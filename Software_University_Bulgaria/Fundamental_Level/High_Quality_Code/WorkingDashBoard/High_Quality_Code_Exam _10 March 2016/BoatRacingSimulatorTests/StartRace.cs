namespace BoatRacingSimulatorTests
{
    using System.Collections.Generic;
    using BoatRacingSimulator.Exceptions;
    using BoatRacingSimulator.Models.Boats;
    using BoatRacingSimulator.Models.Engines;
    using BoatRacingSimulator.Controllers;
    using BoatRacingSimulator.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StartRace
    {
        private IBoatSimulatorController Controller { get; set; }

        private List<IBoat> TestBoats { get; set; }

        private List<IBoatEngine> TestEngines { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            var engine1 = new JetEngine("engine1", 10, 100);
            var engine2 = new SterndriveEngine("engine2", 10, 100);
            var boat1 = new RowBoat("Rowboat1", 50, 1);
            var boat2 = new SailBoat("Sailboat1", 100, 1);
            var boat3 = new PowerBoat("Powerboat1", 20, engine1, engine2);   
            var boat4 = new Yacht("Yacht1", 10, engine2, 10);
            var boat5 = new PowerBoat("Powerboat2", 20, engine1, engine2);
            var boat6 = new SailBoat("Sailboat2", 100, 1);
            var boat7 = new SailBoat("Sailboat3", 100, 1);

            this.Controller = new BoatSimulatorController();
            this.TestEngines = new List<IBoatEngine>() { engine1, engine2 };
            this.TestBoats = new List<IBoat>() {boat1,boat2,boat3,boat4,boat5,boat6,boat7};
        }

        [ExpectedException(typeof(NoSetRaceException))]
        [TestMethod]
        public void StartRace_WithoutASetupRace_ShouldThrowCorrectException()
        {
            try
            {
                this.Controller.StartRace();
            }
            catch (NoSetRaceException ex)
            {
                Assert.AreEqual("There is currently no race set.", ex.Message, "Expected messages did not match!");
                throw;
            }
        }

        [ExpectedException(typeof(InsufficientContestantsException))]
        [TestMethod]
        public void StartRace_WithLessThan3Contestants_ShouldThrowCorrectException()
        {
            this.Controller.OpenRace(1, 1, 1, true);
            try
            {
                this.Controller.StartRace();
            }
            catch (InsufficientContestantsException ex)
            {
                Assert.AreEqual("Not enough contestants for the race.",ex.Message,"Expected messages did not match!");
                throw;
            }
        }

        [TestMethod]
        public void StartRace_WithABoatThatCannotFinish_ShouldPrintCorrectMessage()
        {
            this.Controller.OpenRace(1, 1, 1, true);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[1]);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[5]);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[6]);
            var result = this.Controller.StartRace();

            Assert.AreEqual(
                "First place: SailBoat Model: Sailboat1 Time: Did not finish!\r\n" +
                "Second place: SailBoat Model: Sailboat2 Time: Did not finish!\r\n" +
                "Third place: SailBoat Model: Sailboat3 Time: Did not finish!",
                result,
                "Expected messages did not match!");
        }

        [TestMethod]
        public void StartRace_WithABoatThatFinishes_ShouldPrintTimeInCorrectFormat()
        {
            this.Controller.OpenRace(300, 0, 0, true);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[0]);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[2]);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[3]);
            var result = this.Controller.StartRace();

            Assert.AreEqual(
                "First place: PowerBoat Model: Powerboat1 Time: 1.00 sec\r\n" +
                "Second place: Yacht Model: Yacht1 Time: 2.00 sec\r\n" +
                "Third place: RowBoat Model: Rowboat1 Time: 6.00 sec",
                result,
                "Expected messages did not match!");
        }

        [TestMethod]
        public void StartRace_WithBothFinishedAndUnfinishedBoats_ShouldPrintUnfinishedBehindFinishedBoats()
        {
            this.Controller.OpenRace(300, 0, 0, true);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[1]);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[2]);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[3]);
            var result = this.Controller.StartRace();

            Assert.AreEqual(
                "First place: PowerBoat Model: Powerboat1 Time: 1.00 sec\r\n" +
                "Second place: Yacht Model: Yacht1 Time: 2.00 sec\r\n" +
                "Third place: SailBoat Model: Sailboat1 Time: Did not finish!",
                result,
                "Expected messages did not match!");
        }

        [TestMethod]
        public void StartRace_WithBoatsWithSameTime_ShouldPrintThemInOrderOfAdding()
        {
            this.Controller.OpenRace(300, 0, 0, true);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[1]);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[4]);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[2]);          
            var result = this.Controller.StartRace();

            Assert.AreEqual(
                "First place: PowerBoat Model: Powerboat2 Time: 1.00 sec\r\n" +
                "Second place: PowerBoat Model: Powerboat1 Time: 1.00 sec\r\n" +
                "Third place: SailBoat Model: Sailboat1 Time: Did not finish!",
                result,
                "Expected messages did not match!");
        }

        [TestMethod]
        public void StartRace_WithMultipleBoats_ShouldPrintCorrectlyRankedResults()
        {
            this.Controller.OpenRace(300, 0, 0, true);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[0]);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[1]);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[2]);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[3]);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[4]);
            var result = this.Controller.StartRace();

            Assert.AreEqual(
                "First place: PowerBoat Model: Powerboat1 Time: 1.00 sec\r\n" +
                "Second place: PowerBoat Model: Powerboat2 Time: 1.00 sec\r\n" +
                "Third place: Yacht Model: Yacht1 Time: 2.00 sec",
                result,
                "Expected messages did not match!");
        }

        [TestMethod]
        public void StartRace_InCaseOfNoExceptions_ShouldClearCurrentRace()
        {
            this.Controller.OpenRace(300, 0, 0, true);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[0]);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[1]);
            this.Controller.CurrentRace.AddParticipant(this.TestBoats[2]);

            this.Controller.StartRace();
            Assert.AreEqual(this.Controller.CurrentRace,null,"Current Race was not cleared!");
        }
    }
}

namespace BoatRacingSimulatorTests
{
    using System;
    using System.Collections.Generic;
    using BoatRacingSimulator.Controllers;
    using BoatRacingSimulator.Exceptions;
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Models.Boats;
    using BoatRacingSimulator.Models.Engines;
    using Moq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SignUpBoat
    {
        private IBoatSimulatorController Controller { get; set; }

        private Mock<IBoatSimulatorDatabase> FakeDb { get; set; }

        private Mock<IRace> FakeRace { get; set; }

        private List<IBoat> FakeBoats { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            var engine = new SterndriveEngine("engine", 10, 100);
            var boat1 = new RowBoat("Rowboat1", 50, 1);
            var boat2 = new Yacht("Yacht1", 10, engine, 10);

            this.FakeBoats = new List<IBoat>() {boat1,boat2};

            Mock<IBoatSimulatorDatabase> fakeDb = new Mock<IBoatSimulatorDatabase>();
            fakeDb.Setup(x => x.Boats.GetItem("Test1")).Returns(boat1);
            fakeDb.Setup(x => x.Boats.GetItem("Test2")).Returns(boat2);

            Mock<IRace> fakeRace = new Mock<IRace>();
            fakeRace.Setup(x => x.AllowsMotorboats).Returns(false);

            this.FakeDb = fakeDb;
            this.FakeRace = fakeRace;
        }

        [TestMethod]
        public void SignUpBoat_ShouldCallDatabaseBoatsGetMethodWithCorrectModel()
        {
            this.Controller = new BoatSimulatorController(this.FakeDb.Object, this.FakeRace.Object);
            this.Controller.SignUpBoat("Test1");
            this.FakeDb.Verify(x=>x.Boats.GetItem("Test1"),Times.Exactly(1));
        }

        [TestMethod]
        public void SignUpBoat_WithValidInput_ShouldCallRaceAllowMotorboatsField()
        {
            this.Controller = new BoatSimulatorController(this.FakeDb.Object, this.FakeRace.Object);
            this.Controller.SignUpBoat("Test1");
            this.FakeRace.Verify(x => x.AllowsMotorboats, Times.Exactly(1));
        }

        [ExpectedException(typeof(NoSetRaceException))]
        [TestMethod]
        public void SignUpBoat_WithoutASetRace_ShouldThrowCorrectException()
        {
            this.Controller = new BoatSimulatorController(this.FakeDb.Object,null);
            try
            {
                this.Controller.SignUpBoat("test");
            }
            catch (NoSetRaceException ex)
            {
                Assert.AreEqual("There is currently no race set.",ex.Message,"Expected message did not match!");
                throw;
            }
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void SignUpBoat_WithAMotorboatInANonMotorboatRace_ShouldThrowCorrectException()
        {
            this.Controller = new BoatSimulatorController(this.FakeDb.Object, this.FakeRace.Object);

            try
            {
                this.Controller.SignUpBoat("Test2");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("The specified boat does not meet the race constraints.", ex.Message, "Expected message did not match!");
                throw;
            }
        }

        [TestMethod]
        public void SignUpBoat_WithASetRace_ShouldAddBoatToRaceParticipantsCollection()
        {
            this.Controller = new BoatSimulatorController(this.FakeDb.Object, this.FakeRace.Object);
            this.Controller.SignUpBoat("Test1");
            this.FakeRace.Verify(x=>x.AddParticipant(It.IsAny<IBoat>()),Times.Exactly(1));
        }

        [TestMethod]
        public void SignUpBoat_WithASetRace_ShouldAddCorrectBoat()
        {
            this.Controller = new BoatSimulatorController(this.FakeDb.Object, this.FakeRace.Object);
            this.Controller.SignUpBoat("Test1");
            this.FakeRace.Verify(x => x.AddParticipant(this.FakeBoats[0]), Times.Exactly(1));
        }

        [TestMethod]
        public void SignUpBoat_WithValidInput_ShouldReturnCorrectSuccessMessage()
        {
            this.Controller = new BoatSimulatorController(this.FakeDb.Object, this.FakeRace.Object);
            var result = this.Controller.SignUpBoat("Test1");
            Assert.AreEqual("Boat with model Test1 has signed up for the current Race.",result,"Expected message did not match!");
        }
    }
}

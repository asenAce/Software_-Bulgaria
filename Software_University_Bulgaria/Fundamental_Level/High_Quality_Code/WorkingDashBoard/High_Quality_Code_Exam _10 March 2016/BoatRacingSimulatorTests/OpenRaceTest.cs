namespace BoatRacingSimulatorTests
{
    using System.Collections.Generic;
    using System.Linq;
    using BoatRacingSimulator.Controllers;
    using BoatRacingSimulator.Exceptions;
    using BoatRacingSimulator.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OpenRaceTest
    {
        public IBoatSimulatorController Controller { get; private set; }

        [TestInitialize]
        public void Initialize()
        {
            this.Controller = new BoatSimulatorController();
        }

        [ExpectedException(typeof(RaceAlreadyExistsException))]
        [TestMethod]
        public void OpenRace_WithAnAlreadySetRace_ShouldThrowCorrectException()
        {
            this.Controller.OpenRace(1, 1, 1, true);

            try
            {
                this.Controller.OpenRace(2, 2, 2, false);
            }
            catch (RaceAlreadyExistsException ex)
            {
                Assert.AreEqual("The current race has already been set.", ex.Message,"The expected messages did not match!");
                throw;
            }
        }

        [TestMethod]
        public void OpenRace_WithValidInput_ShouldSetCurrentRace()
        {
            Assert.AreEqual(this.Controller.CurrentRace,null);
            this.Controller.OpenRace(1, 1, 1, true);
            Assert.AreNotEqual(this.Controller.CurrentRace,null);
        }

        [TestMethod]
        public void OpenRace_WithValidInput_ShouldSetCurrentRaceWithCorrectParameters()
        {
            this.Controller.OpenRace(1, 2, 3, true);
            Assert.AreEqual(1,this.Controller.CurrentRace.Distance);
            Assert.AreEqual(2, this.Controller.CurrentRace.WindSpeed);
            Assert.AreEqual(3, this.Controller.CurrentRace.OceanCurrentSpeed);
            Assert.AreEqual(true, this.Controller.CurrentRace.AllowsMotorboats);
            CollectionAssert.AreEqual(new List<IBoat>(),this.Controller.CurrentRace.GetParticipants().ToList());
        }

        [TestMethod]
        public void OpenRace_WithValidInput_ShouldReturnSuccesMessage()
        {
            var message = this.Controller.OpenRace(1, 2, 3, true);
            Assert.AreEqual("A new race with distance 1 meters, wind speed 2 m/s and ocean current speed 3 m/s has been set.",message, "The expected messages did not match!");
        }
    }
}

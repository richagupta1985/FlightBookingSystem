using FlightBooking.Core;
using FlightBooking.Core.BusinessLogic;
using FlightBooking.Core.Model;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace FlightBookingSystem.Test
{
    [TestFixture]
    public class ScheduledFlightTests
    {
        ScheduledFlight scheduledFlight;
        [SetUp]
        public void Setup()
        {
            if (scheduledFlight == null)
            {
                IEnumerable testData = FlightBookingTestData.TestCases;
                List<Passenger> passengers = new List<Passenger>();
                FlightBookingViewModel flightBookingViewModel = new FlightBookingViewModel();
                scheduledFlight = flightBookingViewModel.ScheduledFlight;
                foreach (var data in testData)
                {
                    flightBookingViewModel.AnalysePassengerInput(((TestCaseData)data).Arguments[0].ToString());
                }
            }
        }

        [Test]
        public void CheckIfLoadFlightRouteDetailIsNotNull()
        {
            Assert.That(scheduledFlight.FlightRoute, Is.Not.Null);
        }
        [Test]
        public void CheckIfPlaneDetailIsNotNull()
        {
            Assert.That(scheduledFlight.Aircraft, Is.Not.Null);
        }
        [Test]
        public void CheckIfPassengersIsNotNull()
        {
            Assert.That(scheduledFlight.Passengers, Is.Not.Null);
        }
    }
}

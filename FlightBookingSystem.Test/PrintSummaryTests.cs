using FlightBooking.Core;
using FlightBooking.Core.BusinessLogic;
using FlightBooking.Core.Model;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem.Test
{
    [TestFixture]
    public  class PrintSummaryTests
    {
        PrintSummary printSummary;
        [SetUp]
        public void Setup()
        {
            if (printSummary == null)
            {
                IEnumerable testData = FlightBookingTestData.TestCases;
                List<Passenger> passengers = new List<Passenger>();
                FlightBookingViewModel flightBookingViewModel = new FlightBookingViewModel();
              
                foreach (var data in testData)
                {
                    flightBookingViewModel.AnalysePassengerInput(((TestCaseData)data).Arguments[0].ToString());
                }
                printSummary = new PrintSummary(flightBookingViewModel.ScheduledFlight);
            }
        }
        [Test]
        public void CheckIfCanFlightProceedReturnsCorrectResult()
        {
            Assert.That(printSummary.CanFlightProceed(), Is.EqualTo(true));
        }
    }
}

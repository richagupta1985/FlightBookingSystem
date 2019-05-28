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
    public class FlightCostingTests
    {
        FlightBookingViewModel flightBookingViewModel;
        [SetUp]
        public void Setup()
        {
            if (flightBookingViewModel == null)
            {
                IEnumerable testData = FlightBookingTestData.TestCases;
                List<Passenger> passengers = new List<Passenger>();
                flightBookingViewModel = new FlightBookingViewModel();
                foreach (var data in testData)
                {
                    flightBookingViewModel.AnalysePassengerInput(((TestCaseData)data).Arguments[0].ToString());
                }
            }
        }

        [Test]
        [TestCase(ExpectedResult = 500)]
        public double? CheckTotalCostOfFlight()
        {
            //Setup();
            return flightBookingViewModel.ScheduledFlight.FlightCosting.CostOfFlight;
        }
        [Test]
        [TestCase(ExpectedResult = 13)]
        public int CheckTotalExpectedBaggage()
        {
            return flightBookingViewModel.ScheduledFlight.FlightCosting.TotalExpectedBaggage;
        }
        [Test]
        [TestCase(ExpectedResult = 800)]
        public double? CheckProfitFromFlight()
        {
            return flightBookingViewModel.ScheduledFlight.FlightCosting.ProfitFromFlight;
        }
        [Test]
        [TestCase(ExpectedResult = 100)]
        public int CheckTotalLoyaltyPointsRedeemed()
        {
            return flightBookingViewModel.ScheduledFlight.FlightCosting.TotalLoyaltyPointsRedeemed;
        }
        [Test]
        [TestCase(ExpectedResult = 10)]
        public int CheckTotalLoyaltyPointsAccrued()
        {
            return flightBookingViewModel.ScheduledFlight.FlightCosting.TotalLoyaltyPointsAccrued;
        }
        [Test]
        [TestCase(ExpectedResult = 10)]
        public int CheckTotalSeatTaken()
        {
            return flightBookingViewModel.ScheduledFlight.FlightCosting.SeatsTaken;
        }
        [Test]
        [TestCase(ExpectedResult = 1)]
        public int CheckTotalAirlineEmployeesPassengers()
        {
            return flightBookingViewModel.ScheduledFlight.FlightCosting.AirlineEmployeePassengers.Count();
        }
        [Test]
        [TestCase(ExpectedResult = 6)]
        public int CheckTotalGeneralPassengers()
        {
            return flightBookingViewModel.ScheduledFlight.FlightCosting.GeneralPassengers.Count();
        }
        [Test]
        [TestCase(ExpectedResult = 3)]
        public int CheckTotalLoyaltyPassengers()
        {
            return flightBookingViewModel.ScheduledFlight.FlightCosting.LoyaltyPassengers.Count();
        }
        [Test]
        [TestCase(ExpectedResult = 0)]
        public int CheckTotalDiscountedPassengers()
        {
            return flightBookingViewModel.ScheduledFlight.FlightCosting.DiscountedPassengers.Count();
        }
    }
}

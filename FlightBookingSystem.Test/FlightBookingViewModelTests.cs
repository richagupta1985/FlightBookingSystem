using FlightBooking.Core;
using FlightBooking.Core.BusinessLogic;
using FlightBooking.Core.Model;
using NUnit.Framework;
using System;

namespace FlightBookingSystem.Test
{
    [TestFixture]
    public class FlightBookingViewModelTests
    {
        [Test]
        [TestCaseSource(typeof(FlightBookingTestData), "TestCases")]
        public void TestToCheckIfUserInputValid(string passengerData)
        {
            var sut = new FlightBookingViewModel();
            sut.AnalysePassengerInput(passengerData);
            Assert.That(sut.Passenger.IsUserInputValid, Is.EqualTo(true));
        }
        [Test]
        [TestCase(EPassengerSelection.AirlineEmployeePassenger,"Sam 67")]
        public void TestToCheckIfCorrectPassengerClassIsInvokedForAirlinePAssenger(EPassengerSelection passengerSelection, string passengerData)
        {
            var sut = new FlightBookingViewModel();
            object passengerInstance = sut.GetPassengerClassBasedOnPassengerType(passengerSelection, passengerData);
            Assert.IsInstanceOf <AirlineEmployeePassenger> (passengerInstance);
        }
        [Test]

        [TestCase(EPassengerSelection.LoyaltyMemberPassenger, "Sam 67 888 True")]
        [TestCase(EPassengerSelection.LoyaltyMemberPassenger, "Sam 67 888 False")]
        public void TestToCheckIfCorrectPassengerClassIsInvokedForLoyaltyMemPassengers(EPassengerSelection passengerSelection, string passengerData)
        {
            var sut = new FlightBookingViewModel();
            object passengerInstance = sut.GetPassengerClassBasedOnPassengerType(passengerSelection, passengerData);
            Assert.IsInstanceOf<LoyaltyMemberPassenger>(passengerInstance);
        }
        [Test]
        [TestCase(EPassengerSelection.GeneralPassenger, "Sam 67")]
        public void TestToCheckIfCorrectPassengerClassIsInvokedForGeneralPassenger(EPassengerSelection passengerSelection, string passengerData)
        {
            var sut = new FlightBookingViewModel();
            object passengerInstance = sut.GetPassengerClassBasedOnPassengerType(passengerSelection, passengerData);
            Assert.IsInstanceOf<GeneralPassenger>(passengerInstance);
        }
        [Test]
        [TestCase(EPassengerSelection.DiscountedPassenger, "Sam 67")]
        public void TestToCheckIfCorrectPassengerClassIsInvokedForDiscountedPassenger(EPassengerSelection passengerSelection, string passengerData)
        {
            var sut = new FlightBookingViewModel();
            object passengerInstance = sut.GetPassengerClassBasedOnPassengerType(passengerSelection, passengerData);
            Assert.IsInstanceOf<DiscountedPassenger>(passengerInstance);
        }
    }
}

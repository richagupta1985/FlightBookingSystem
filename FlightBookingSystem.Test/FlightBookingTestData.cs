using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem.Test
{
  public  class FlightBookingTestData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("add general  Steve 30 ");
                yield return new TestCaseData("add general Mark 12");
                yield return new TestCaseData("add general James 36");
                yield return new TestCaseData("add general Jane 32");
                yield return new TestCaseData("add loyalty John 29 1000 true");
                yield return new TestCaseData("add loyalty Sarah 45 1250 false");
                yield return new TestCaseData("add loyalty Jack 60 50 false");
                yield return new TestCaseData("add airline Trevor 47");
                yield return new TestCaseData("add general Alan 34");
                yield return new TestCaseData("add general Suzy 21");
            }
        }
    }
}

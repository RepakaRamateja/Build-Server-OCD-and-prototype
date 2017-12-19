/////////////////////////////////////////////////////////////////////
// Tester.cs - demonstration Tester                                //
//                                                                 //
// Jim Fawcett, CSE681 - Software Modeling and Analysis, Fall 2017 //
/////////////////////////////////////////////////////////////////////
/*
 *  - This Tester makes a reference to a known library.
 *  - Your Mock TestHarness will have to load arbitrary libraries
 *    and test to see if they implement the ITest interface.
 *  - We'll discuss how to do that in a couple of weeks.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSTestDemo;

namespace Tester
{
  public class Tester
  {
    public bool doTest()
    {
      TestDriver td = new TestDriver();
      return td.test();
    }
    static void Main(string[] args)
    {
      Console.Write("\n  Demonstrate Testing ");
      Console.Write("\n =====================");

      Tester tester = new Tester();
      if (tester.doTest())
        Console.Write("\n  test passed");
      else
        Console.Write("\n  test failed");

      Console.Write("\n\n");
    }
  }
}

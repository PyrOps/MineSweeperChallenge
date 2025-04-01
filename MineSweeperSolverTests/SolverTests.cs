using Microsoft.VisualStudio.TestTools.UnitTesting;
using MineSweeperSolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperSolver.Tests {
  /*
   *  input   |   expected output
   *  .*      |   1*
   *  ..      |   11
   * 
   *  input   |   expected output
   *  .*      |   2*
   *  .*      |   2*
   *  
   *  input   |   expected output
   *  .*.**.  |   1*2**1
   *  ....*.  |   1234*2
   *  ..*...  |   01*211
   */
  [TestClass()]
  public class SolverTests {
    [TestMethod()]
    public void TwoByTwoGridOneMineSolveTest() {
      Solver solver = new();
      string input = ".*\n..";
      string expectedOutput = "1*\n11";
      Assert.AreEqual(expectedOutput, solver.Solve(input));
    }

    [TestMethod()]
    public void TwoByTwoGridTwoMinesSolveTest() {
      Solver solver = new();
      string input = ".*\n.*";
      string expectedOutput = "2*\n2*";
      Assert.AreEqual(expectedOutput, solver.Solve(input));
    }

    [TestMethod()]
    public void ExampleGridSolveTest() {
      Solver solver = new();
      string input = ".*.**.\n....*.\n..*...";
      string expectedOutput = "1*2**1\n1234*2\n01*211";
      Assert.AreEqual(expectedOutput, solver.Solve(input));
    }

    [TestMethod()]
    public void CharIsDotTest() {
      Solver solver = new();
      string input = ".*.**.\n....*.\n..*...";
      bool expectedOutput = true;
      Assert.AreEqual(expectedOutput, solver.CharIsDot(input[0]));
    }

    [TestMethod()]
    public void CountNbLinesTest() {
      Solver solver = new();
      string input = ".*.**.\n....*.\n..*...";
      int expectedOutput = 3;
      Assert.AreEqual(expectedOutput, solver.CountNbLines(input));
    }
  }
}
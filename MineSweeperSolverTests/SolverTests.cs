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
      string input = ".*\r\n..";
      string expectedOutput = "1*\r\n11";
      Assert.AreEqual(expectedOutput, solver.Solve(input));
    }

    [TestMethod()]
    public void TwoByTwoGridTwoMinesSolveTest() {
      Solver solver = new();
      string input = ".*\r\n.*";
      string expectedOutput = "2*\r\n2*";
      Assert.AreEqual(expectedOutput, solver.Solve(input));
    }
  }
}
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
    [DataTestMethod]
    [DataRow(".*\n..", "1*\n11")]
    [DataRow(".*\n.*", "2*\n2*")]
    [DataRow(".*.**.\n....*.\n..*...", "1*2**1\n1234*2\n01*211")]
    public void SolveTest(string grid, string expectedOutput) {
      Solver solver = new();
      Assert.AreEqual(expectedOutput, solver.Solve(grid));
    }

    [DataTestMethod]
    [DataRow(".*\n..", true)]
    [DataRow("*.\n.*", false)]
    [DataRow(".*.**.\n....*.\n..*...", true)]
    public void CharIsDotTest(string grid, bool expectedResult) {
      Solver solver = new();
      Assert.AreEqual(expectedResult, solver.CharIsDot(grid[0]));
    }
  }
}
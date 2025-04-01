using Microsoft.VisualStudio.TestTools.UnitTesting;
using MineSweeperSolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperSolver.Tests {
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
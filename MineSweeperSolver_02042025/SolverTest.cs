﻿/********************************************/
/* Mine Sweeper Challenge                   */
/*                                          */
/* Auteur :     Pierre-Yves Ravoire         */
/* Date :       02/04/2025                  */
/* Iteration :  2                           */
/*                                          */
/********************************************/

namespace MineSweeperSolver_02042025 {
  /*
   * Examples :
   * in : "."           | out : "0"
   * in : "*"           | out : "*"
   * in : ".."          | out : ".."
   * in : ".*"          | out : "1*"
   * in : "**"          | out : "**"
   * in : "*."          | out : "*1"
   * in : "..."         | out : "000"
   * in : "..*"         | out : "01*"
   * in : ".*."         | out : "1*1"
   * in : ".**"         | out : "1**"
   * in : "*.."         | out : "*10"
   * in : "*.*"         | out : "*2*"
   * in : "**."         | out : "**1"
   * in : "***"         | out : "***"
   */
  public class Solver {
    public string Solve(string input) {
      return "0";
    }
  }

  [TestClass]
  public sealed class SolverTest {
    [DataTestMethod]
    [DataRow(".", "0")]
    public void SolveTest(string input, string expectedOutput) {
      Solver solver = new Solver();
      Assert.AreEqual(expectedOutput, solver.Solve(input));
    }
  }
}

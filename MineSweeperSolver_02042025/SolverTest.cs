/********************************************/
/* Mine Sweeper Challenge                   */
/*                                          */
/* Auteur :     Pierre-Yves Ravoire         */
/* Date :       02/04/2025                  */
/* Iteration :  2                           */
/*                                          */
/********************************************/

using System.Text;

namespace MineSweeperSolver_02042025 {
  /*
   * Examples :
   * in : "."           | out : "0"
   * in : "*"           | out : "*"
   * in : ".."          | out : "00"
   * in : ".*"          | out : "1*"
   * in : "*."          | out : "*1"
   * in : "**"          | out : "**"
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
      StringBuilder sb = new();
      for (int i = 0; i < input.Length; i++) {
        if (input[i] == '*')
          sb.Append('*');
        else {
          if ((i + 1) < input.Length && NextCharIsBomb(input[i + 1]))
            sb.Append('1');
          else if ((i - 1) >= 0 && PreviousCharIsBomb(input[i - 1]))
            sb.Append('1');
          else
            sb.Append('0');
        }
      }
      return sb.ToString();
    }

    private bool NextCharIsBomb(char c) {
      return c == '*';
    }

    private bool PreviousCharIsBomb(char c) {
      return c == '*';
    }
  }

  [TestClass]
  public sealed class SolverTest {
    [DataTestMethod]
    [DataRow(".", "0")]
    [DataRow("*", "*")]
    [DataRow("..", "00")]
    [DataRow(".*", "1*")]
    [DataRow("*.", "*1")]
    public void SolveTest(string input, string expectedOutput) {
      Solver solver = new Solver();
      Assert.AreEqual(expectedOutput, solver.Solve(input));
    }
  }
}

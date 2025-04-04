/********************************************/
/* Mine Sweeper Challenge                   */
/*                                          */
/* Auteur :     Pierre-Yves Ravoire         */
/* Date :       04/04/2025                  */
/* Iteration :  4                           */
/*                                          */
/********************************************/

/*
 * Examples :
 * 1) One line
 * in : "."             | out : "0"
 * in : "*"             | out : "*"
 * in : ".."            | out : "00"
 * in : ".*"            | out : "1*"
 * in : "*."            | out : "*1"
 * in : "**"            | out : "**"
 * in : "..."           | out : "000"
 * in : "..*"           | out : "01*"
 * in : ".*."           | out : "1*1"
 * in : ".**"           | out : "1**"
 * in : "*.."           | out : "*10"
 * in : "*.*"           | out : "*2*"
 * in : "**."           | out : "**1"
 * in : "***"           | out : "***"
 * 2) Two lines
 * in : ".\n."          | out : "0\n0"
 * in : ".\n*"          | out : "1\n*"
 * in : "*\n."          | out : "*\n0"
 * in : "*\n*"          | out : "*\n*"
 * in : "..\n.."        | out : "00\n00"
 * in : "..\n.*"        | out : "11\n1*"
 * in : "..\n*."        | out : "11\n*1"
 * in : "..\n**"        | out : "22\n**"
 * in : ".*\n.."        | out : "1*\n11"
 * in : ".*\n.*"        | out : "2*\n2*"
 * in : ".*\n*."        | out : "2*\n*2"
 * in : ".*\n**"        | out : "3*\n**"
 * in : "*.\n.."        | out : "*1\n11"
 * in : "*.\n.*"        | out : "*2\n2*"
 * in : "*.\n*."        | out : "*2\n*2"
 * in : "*.\n**"        | out : "*3\n**"
 * in : "**\n.."        | out : "**\n22"
 * in : "**\n.*"        | out : "**\n3*"
 * in : "**\n*."        | out : "**\n*3"
 * in : "**\n**"        | out : "**\n**"
 * in : "...\n..."      | out : "000\n000"
 * in : "...\n..*"      | out : "011\n01*"
 * in : "...\n.*."      | out : "111\n1*1"
 * in : "...\n.**"      | out : "122\n1**"
 * in : "...\n*.."      | out : "110\n*10"
 * in : "...\n*.*"      | out : "121\n*2*"
 * in : "...\n**."      | out : "221\n**1"
 * in : "...\n***"      | out : "232\n***"
 * in : "..*\n..."      | out : "01*\n011"
 * in : "..*\n..*"      | out : "02*\n02*"
 * in : "..*\n.*."      | out : "12*\n1*2"
 * in : "..*\n.**"      | out : "13*\n1**"
 * in : "..*\n*.."      | out : "12*\n*21"
 * in : "..*\n*.*"      | out : "12*\n*3*"
 * in : "..*\n**."      | out : "23*\n**2"
 * in : "..*\n***"      | out : "24*\n***"
 * in : ".*.\n..."      | out : "1*1\n111"
 * in : ".*.\n..*"      | out : "1*2\n12*"
 * in : ".*.\n.*."      | out : "2*2\n2*2"
 * in : ".*.\n.**"      | out : "2*3\n2**"
 * in : ".*.\n*.."      | out : "2*1\n*21"
 * in : ".*.\n*.*"      | out : "2*2\n*3*"
 * in : ".*.\n**."      | out : "3*2\n**2"
 * in : ".*.\n***"      | out : "3*3\n***"
 * in : ".**\n..."      | out : "1**\n122"
 * in : ".**\n..*"      | out : "1**\n13*"
 * in : ".**\n.*."      | out : "2**\n2*3"
 * in : ".**\n.**"      | out : "2**\n2**"
 * in : ".**\n*.."      | out : "2**\n*32"
 * in : ".**\n*.*"      | out : "2**\n*4*"
 * in : ".**\n**."      | out : "3**\n**3"
 * in : ".**\n***"      | out : "3**\n***"
 * in : "*..\n..."      | out : "*10\n110"
 * in : "*..\n..*"      | out : "*21\n12*"
 * in : "*..\n.*."      | out : "*21\n2*1"
 * in : "*..\n.**"      | out : "*32\n2**"
 * in : "*..\n*.."      | out : "*20\n*20"
 * in : "*..\n*.*"      | out : "*31\n*3*"
 * in : "*..\n**."      | out : "*31\n**1"
 * in : "*..\n***"      | out : "*42\n***"
 * in : "*.*\n..."      | out : "*2*\n121"
 * in : "*.*\n..*"      | out : "*3*\n12*"
 * in : "*.*\n.*."      | out : "*3*\n2*2"
 * in : "*.*\n.**"      | out : "*4*\n2**"
 * in : "*.*\n*.."      | out : "*3*\n*31"
 * in : "*.*\n*.*"      | out : "*4*\n*4*"
 * in : "*.*\n**."      | out : "*4*\n**2"
 * in : "*.*\n***"      | out : "*5*\n***"
 * in : "**.\n..."      | out : "**1\n221"
 * in : "**.\n..*"      | out : "**2\n23*"
 * in : "**.\n.*."      | out : "**2\n3*2"
 * in : "**.\n.**"      | out : "**3\n3**"
 * in : "**.\n*.."      | out : "**1\n*31"
 * in : "**.\n*.*"      | out : "**2\n*4*"
 * in : "**.\n**."      | out : "**2\n**2"
 * in : "**.\n***"      | out : "**3\n***"
 * in : "***\n..."      | out : "***\n232"
 * in : "***\n..*"      | out : "***\n24*"
 * in : "***\n.*."      | out : "***\n3*3"
 * in : "***\n.**"      | out : "***\n3**"
 * in : "***\n*.."      | out : "***\n*42"
 * in : "***\n*.*"      | out : "***\n*5*"
 * in : "***\n**."      | out : "***\n**3"
 * in : "***\n***"      | out : "***\n***"
*/

using System.Text;
using System.Threading.Tasks.Dataflow;

namespace MineSweeperSolverTest_20250404 {
  [TestClass]
  public sealed class SolverTest {
    [DataTestMethod]
    [DataRow(".", "0")]
    [DataRow("*", "*")]
    [DataRow("..", "00")]
    [DataRow(".*", "1*")]
    [DataRow("*.", "*1")]
    [DataRow("**", "**")]
    [DataRow("...", "000")]
    [DataRow("..*", "01*")]
    [DataRow(".*.", "1*1")]
    [DataRow(".**", "1**")]
    [DataRow("*..", "*10")]
    [DataRow("*.*", "*2*")]
    [DataRow("**.", "**1")]
    [DataRow("***", "***")]
    [DataRow(".\n.", "0\n0")]
    [DataRow(".\n*", "1\n*")]
    [DataRow("*\n.", "*\n1")]
    [DataRow("*\n*", "*\n*")]
    [DataRow("..\n..", "00\n00")]
    [DataRow("..\n.*", "11\n1*")]
    [DataRow("..\n*.", "11\n*1")]
    public void SolveTest(string input, string expectedOutput) {
      Solver solver = new();
      Assert.AreEqual(expectedOutput, solver.Solve(input));
    }
  }

  public class Solver {
    public string Solve(string input) {
      Grid grid = new(input);
      int i = -1;
      while (++i < grid.Cells.Length) {
        if (grid.Cells[i].IsBomb()) {
          if (i > grid.LineLength) {
            int j = i - grid.LineLength - 1;
            if (j > 0) {
              if (!grid.Cells[j - 1].IsBomb())
                grid.Cells[j - 1].IncreaseValue();
            }
            if (!grid.Cells[j].IsBomb())
              grid.Cells[j].IncreaseValue();
          }
          if (i < (grid.Cells.Length - grid.LineLength - 1)) {
            int j = i + grid.LineLength + 1;
            if (!grid.Cells[j].IsBomb())
              grid.Cells[j].IncreaseValue();
          }
          if (i > 0) {
            if (!grid.Cells[i - 1].IsBomb() && !grid.Cells[i - 1].IsNewLine())
              grid.Cells[i - 1].IncreaseValue();
          }
          if (i < grid.Cells.Length - 1) {
            if (!grid.Cells[i + 1].IsBomb() && !grid.Cells[i + 1].IsNewLine())
              grid.Cells[i + 1].IncreaseValue();
          }
        }
      }
      return grid.FormatOutput();
    }
  }

  public class Grid {
    public Cell[] Cells { get; }
    public int LineLength { get; }

    public Grid(string input) {
      Cells = new Cell[input.Length];
      int i = -1;
      while (++i < input.Length) {
        Cells[i] = new Cell(input[i].Equals('.') ? '0' : input[i]);
      }
      LineLength = input.Split('\n')[0].Length;
    }

    public string FormatOutput() {
      StringBuilder sb = new();
      foreach (Cell cell in Cells)
        sb.Append(cell.GetValue());
      return sb.ToString();
    }
  }

  public class Cell(char value) {
    private char value = value;

    public bool IsBomb() {
      return value.Equals('*');
    }

    public bool IsNewLine() {
      return value.Equals('\n');
    }

    public void IncreaseValue() {
      value++;
    }

    public char GetValue() {
      return value;
    }
  }
}

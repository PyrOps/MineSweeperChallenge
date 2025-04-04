﻿/********************************************/
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

namespace MineSweeperSolverTest_20250404 {
  [TestClass]
  public sealed class SolverTest {
    [DataTestMethod]
    [DataRow(".", "0")]
    [DataRow("*", "*")]
    public void SolveTest(string input, string expectedOutput) {
      Solver solver = new();
      Assert.AreEqual(expectedOutput, solver.Solve(input));
    }
  }

  public class Solver {
    public string Solve(string input) {
      return "0";
    }
  }
}

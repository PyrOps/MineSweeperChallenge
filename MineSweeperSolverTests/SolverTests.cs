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
    [DataRow(".*.**.\n....*.\n..*...", "1*2**2\n1234*2\n01*211")]
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

    [DataTestMethod]
    [DataRow("01*10", -1, 2, "02*20")]
    [DataRow("01**4", 0, 0, "02**4")]
    [DataRow("01**4", 1, 1, "12**4")]
    public void UpdateRow(string row, int rowOffset, int colIndex, string expectedResult) {
      Solver solver = new();
      Assert.AreEqual(expectedResult, solver.UpdateRow(row, rowOffset, colIndex));
    }
  }
}
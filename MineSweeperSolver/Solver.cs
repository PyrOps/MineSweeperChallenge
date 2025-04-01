using System.Text;

namespace MineSweeperSolver {
  public class Solver {
    public string Solve(string grid) {
      string[] input = grid.Split(['\n'], StringSplitOptions.RemoveEmptyEntries);
      string[] output = new string[input.Length];
      for (int row = 0; row < input.Length; row++)
        for (int col = 0; col < input[row].Length; col++)
          output[row] += CharIsDot(input[row][col]) ? "0" : "*";
      for (int row = 0; row < input.Length; row++)
        for (int col = 0; col < input[row].Length; col++)
          if (CharIsDot(input[row][col]))
            continue;
          else {
            if ((row - 1) >= 0)
              output[row - 1] = UpdateRow(output[row - 1], -1, col);
            output[row] = UpdateRow(output[row], 0, col);
            if ((row + 1) < input.Length)
              output[row + 1] = UpdateRow(output[row + 1], 1, col);
          }
      return string.Join("\n", output);
    }

    public bool CharIsDot(char c) {
      return c == '.';
    }

    public string UpdateRow(string row, int rowOffset, int colIndex) {
      StringBuilder stringBuilder = new();
      for (int i = 0; i < row.Length; i++)
        if (rowOffset == 0) {
          if (row[i] != '*' && (i == colIndex - 1 || i == colIndex + 1))
            stringBuilder.Append((char)(row[i] + 1));
          else
            stringBuilder.Append(row[i]);
        } else {
          if (row[i] != '*' && (i == colIndex - 1 || i == colIndex || i == colIndex + 1))
            stringBuilder.Append((char)(row[i] + 1));
          else
            stringBuilder.Append(row[i]);
        }
      return stringBuilder.ToString();
    }
  }
}

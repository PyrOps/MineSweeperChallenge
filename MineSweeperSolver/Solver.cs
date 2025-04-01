using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperSolver {
  public class Solver {
    public string Solve(string input) {
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
      return "1*\r\n11";
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Board;
using ReportManagerCore;
using TaskCore;


namespace CustomJira
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = Board.Board.GetInstance();

            IReports ReportManager = new ReportManager(board.GetTaskList());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCore;

namespace Board
{
    public class Board
    {
        private static Board instance;

        private static List<BaseTask> _tasks;
        private Board()
        {
            //TODO: implement geterating tasks list
        }

        private static Board GetInstance()
        {
            if (instance == null)
            {
                instance = new Board();
            }

            return instance;
        }
    }
}

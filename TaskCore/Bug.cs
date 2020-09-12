using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCore.Enums;
using UserCore;

namespace TaskCore
{
    public class Bug : BaseTask
    {
        public Bug(double estimation, TaskEnums type, string title, string discription, User creator, Statuses status = Statuses.BackLog) 
           : base(estimation, type, title, discription, creator, status)
        {

        }
        public override void GetInfo()
        {
            Console.WriteLine("Bug");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCore;
using TaskCore;
using TaskCore.Enums;

namespace ReportManagerCore
{
    public interface IReports
    {

        List<TaskCore.Task> GetAll();
        List<TaskCore.Task> GetFromEstimateRange(double startEstimation, double finishEstimation);


    }
}

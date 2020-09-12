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
    public class ReportManager : IReports
    {
        private List<TaskCore.Task> _tasksList;
        public ReportManager(List <TaskCore.Task> tasksList)
        {
            _tasksList = tasksList;
        }

        public List<TaskCore.Task> GetAll()
        {
            return _tasksList;
        }

        public List<TaskCore.Task> GetFromEstimateRange(double startEstimation, double finishEstimation)
        {
           return _tasksList.Where(task => task.Estimation >= startEstimation && task.Estimation <= finishEstimation).ToList();
        }
    }
}

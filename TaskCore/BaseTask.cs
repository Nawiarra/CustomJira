using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCore.Enums;
using UserCore;

namespace TaskCore
{
    public abstract class BaseTask
    {
        private readonly DateTime _createdDate;

        public readonly User taskCreator; 
        public double Estimation { get; set; }

        public TaskEnums Type { get; set; }

        public string Title { get; set; }

        public string Discription { get; set; }

        public string Id { get; set; }

        public Statuses Status { get; set; }

        public DateTime UpdatedDate { get; set; }

        public User TaskOwner { get; set; }

        public BaseTask(double estimation, TaskEnums type, string title, string discription, User creator, Statuses status = Statuses.BackLog)
        {
            Estimation = estimation;

            Type = type;

            Title = title;

            Discription = discription;

            Id = Guid.NewGuid().ToString();

            taskCreator = creator;

            _createdDate = DateTime.Now;

            UpdatedDate = DateTime.Now;

            Status = status;
        }

        public BaseTask()
        {

        }

        public abstract void GetInfo();

    }
}

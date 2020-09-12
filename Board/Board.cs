using Bogus;
using static Bogus.Faker;
using System;
using System.Collections.Generic;
using TaskCore;
using TaskCore.Enums;
using UserCore;
using ReportManagerCore;

namespace Board
{
    public class Board
    {
        public IReports ReportManager { get; set; }

        private static Board instance;

        private List<TaskCore.Task> _tasks;
        private Board()
        {

            var faker = new Bogus.Faker();

            var baseTaskBogus = new Faker<TaskCore.Task>()
                    .RuleFor(r => r.Discription, f => f.Lorem.Paragraph())
                    .RuleFor(r => r.Estimation, f => f.Random.Double(0, 7))
                    .RuleFor(r => r.Id, f => Guid.NewGuid().ToString())
                    .RuleFor(r => r.TaskOwner, f => new User(f.Person.FirstName, f.Person.LastName, f.Person.Avatar))
                    .RuleFor(r => r.taskCreator, f => new User(f.Person.FirstName, f.Person.LastName, f.Person.Avatar))
                    .RuleFor(r => r.Title, f => f.Lorem.Word())
                    .RuleFor(r => r.Status, f => (Statuses)f.Random.Int(1,6))
                    .RuleFor(r => r.Type, f => (TaskEnums)f.Random.Int(1, 4))
                    .RuleFor(r => r.UpdatedDate, f => f.Date.Past(8));


            var tasks = baseTaskBogus.Generate(faker.Random.Number(50, 100));
            _tasks = tasks;

        }

        public static Board GetInstance()
        {
            if (instance == null)
            {
                instance = new Board();
            }

            return instance;
        }

        public List<TaskCore.Task> GetTaskList()
        {
            return _tasks;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attachment
{
    public class Attachment
    {
        private readonly DateTime _createdDate;

        public readonly string userId;

        public readonly string taskId;
        public string Name { get; set; }

        public string Link { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string Id { get; set; }

        public Attachment(string name, string link, string custUserId, string custTaskId)
        {
            Name = name;

            Link = link;

            userId = custUserId;

            taskId = custTaskId;

            Id = Guid.NewGuid().ToString();

            _createdDate = DateTime.Now;

            UpdatedDate = DateTime.Now;
        }

    }

}
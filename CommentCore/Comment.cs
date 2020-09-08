using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentCore
{
    public class Comment
    {
        private readonly DateTime _createdDate;
        public string Id { get; set; }

        public readonly string autorId;

        public readonly string taskId;

        public string CommentText { get; set; }

        public DateTime UpdatedDate { get; set; }

        public Comment(string custAutorId, string custTaskId, string commentText)
        {
            autorId = custAutorId;

            taskId = custTaskId;

            CommentText = commentText;

            Id = Guid.NewGuid().ToString();

            _createdDate = DateTime.Now;

            UpdatedDate = DateTime.Now;
        }

    }
}

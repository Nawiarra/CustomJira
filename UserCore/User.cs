using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCore
{
    public class User
    {
        private readonly DateTime _createdDate;
        public string FirstName { get; set; }

        public string LasttName { get; set; }

        public string Image { get; set; }

        public string Id { get; set; }

        public DateTime UpdatedDate { get; set; }

        public User(string firstName, string lasttName, string image)
        {
            FirstName = firstName;

            LasttName = lasttName;

            Image = image;

            Id = Guid.NewGuid().ToString();

            _createdDate = DateTime.Now;

            UpdatedDate = DateTime.Now;
        }

    }
}

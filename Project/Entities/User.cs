using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    public enum UserType
    {
        Student,
        Employee
    }
    public class User
    {
        private static int next_id = 1;
        public int id { get; }
        public string fname { get; }
        public string lname { get; }

        public UserType type { get; }

        public User(string fname, string lname, UserType type)
        {
            this.id = next_id++;
            this.fname = fname;
            this.lname = lname;
            this.type = type;
        }
    }
}

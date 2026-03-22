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
        public int Id { get; }
        public string FName { get; }
        public string LName { get; }

        public UserType Type { get; }

        public User(string fname, string lname, UserType type)
        {
            this.Id = next_id++;
            this.FName = fname;
            this.LName = lname;
            this.Type = type;
        }
    }
}

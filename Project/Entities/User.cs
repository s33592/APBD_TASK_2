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
        public int Id { get; }
        public string FName { get; }
        public string LName { get; }

        public UserType Type { get; }

        public User(int id, string fname, string lname, UserType type)
        {
            Id = id;
            FName = fname;
            LName = lname;
            Type = type;
        }
    }
}

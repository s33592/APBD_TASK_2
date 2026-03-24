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

        public int MaxActiveRentals
        {
            get 
            {
                return Type switch
                {
                    UserType.Student => 2,
                    UserType.Employee => 5,
                    _ => throw new Exception("Unknown Type")
                };
            }
        }
        public User(int id, string fname, string lname, UserType type)
        {
            Id = id;
            FName = fname;
            LName = lname;
            Type = type;
        }

        public override string ToString() {
            return $"User {Id} {FName} {LName}";
        }
    }
}

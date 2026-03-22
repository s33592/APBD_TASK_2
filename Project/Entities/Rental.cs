using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    public class Rental
    {
        public int Id { get;}
        public User User { get; }
        public Equipment Equipment { get; }
        public DateTime RentDate { get; }
        public DateTime DueDate { get; }

        public DateTime? ReturnDate { get;  }

        public bool isActive() { return ReturnDate != null; }
        public bool isOverdue() { return ReturnDate != null && ReturnDate > DueDate; }
        Rental(int id,User user,Equipment equipment,DateTime rentDate,DateTime dueDate)
        {
            Id = id;
            User = user;
            Equipment = equipment;
            RentDate = rentDate;
            DueDate = dueDate;
            ReturnDate = null;
        }


    }
}

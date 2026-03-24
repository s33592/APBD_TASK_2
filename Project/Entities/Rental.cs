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

        public DateTime? ReturnDate { get; set; }

        public decimal Penalty { get; set; }
        public bool isActive() { return ReturnDate != null; }
        public bool isOverdue() { return ReturnDate != null && ReturnDate > DueDate; }
        public Rental(int id,User user,Equipment equipment,DateTime rentDate,DateTime dueDate)
        {
            Id = id;
            User = user;
            Equipment = equipment;
            RentDate = rentDate;
            DueDate = dueDate;
            ReturnDate = null;
            Penalty = 0;
        }

        public override string ToString() {
            return $"ID: {Id} | User: {User} | Equipment: {Equipment} | Rent Date: {RentDate} | Due Date: {DueDate}";
        }


    }
}

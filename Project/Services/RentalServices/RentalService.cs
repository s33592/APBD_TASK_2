using Project.Entities;
using Project.Exceptions;
namespace Project.Services.RentalServices
{
    public class RentalService : IRentalService
    {
        private readonly List<Rental> rentals = []; 

        public Rental RentEquipment(User user, Equipment equipment, DateTime rentDate, DateTime dueDate) {
            
            if (!equipment.IsAvailable)
                throw new EquipmentNotAvailableException(equipment);

            if (GetActiveRentals(user).Count >= user.MaxActiveRentals)
                throw new MaxActiveRentalsReachedException(user);

            Rental rental = new Rental(rentals.Count+1, user, equipment, rentDate, dueDate);
            equipment.IsAvailable = false;

            rentals.Add(rental);

            return rental;
        }

        public void ReturnEquipment(Rental rental,DateTime returnDate) {
            if (!GetActiveRentals(rental.User).Contains(rental))
                throw new RentalReturnedException(rental);

            if (returnDate < rental.RentDate)
                throw new ReturnBeforeRentException(rental);

            rental.ReturnDate = returnDate;
            rental.Equipment.IsAvailable = true;
        }
        public List<Rental> GetActiveRentals(User user) {
            return rentals.Where(rental => rental.User == user && rental.ReturnDate == null).ToList();
        }

        public List<Rental> GetOverdueRentals() {
            return rentals.Where(rental => rental.ReturnDate > rental.DueDate).ToList();
        }
    }
}

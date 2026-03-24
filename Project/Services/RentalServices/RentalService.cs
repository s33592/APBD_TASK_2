using Project.Entities;
using Project.Exceptions;
namespace Project.Services.RentalServices
{
    public class RentalService
    {
        private readonly List<Rental> rentals = []; 

        public void RentEquipment(int id,User user, Equipment equipment, DateTime rentDate, DateTime dueDate) {
            
            if (!equipment.IsAvailable)
                throw new EquipmentNotAvailableException(equipment);

            if (GetActiveRentals(user).Count >= user.MaxActiveRentals)
                throw new MaxActiveRentalsReachedException(user);
                
        
            Rental rental = new Rental(id,user, equipment, rentDate, dueDate);
            equipment.IsAvailable = false;

            rentals.Add(rental);
        }

        public void ReturnEquipment(int rentalId,DateTime returnDate) {
            var rental = rentals.FirstOrDefault(rental => rental.Id == rentalId);

            if (rental == null)
                throw new RentalReturnedException(rentalId);

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

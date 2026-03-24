using Project.Entities;
namespace Project.Services.RentalServices
{
    public interface IRentalService
    {
        public void RentEquipment(User user, Equipment equipment, DateTime rentDate, DateTime dueDate);

        public void ReturnEquipment(int rentalId,DateTime returnDate);
        public List<Rental> GetActiveRentals(User user);

        public List<Rental> GetOverdueRentals();

    }
}

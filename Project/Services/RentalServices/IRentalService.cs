using Project.Entities;
namespace Project.Services.RentalServices
{
    public interface IRentalService
    {
        public Rental RentEquipment(User user, Equipment equipment, DateTime rentDate, DateTime dueDate);

        public void ReturnEquipment(Rental rental,DateTime returnDate);
        public List<Rental> GetActiveRentals(User user);

        public List<Rental> GetOverdueRentals();

    }
}

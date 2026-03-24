
using Project.Entities;
namespace Project.Exceptions
{
    public class RentalReturnedException(int rentalId) : RentalException($"Rental with id = {rentalId} is not from the list of active rentals");
}

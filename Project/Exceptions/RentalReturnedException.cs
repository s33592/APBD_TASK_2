
using Project.Entities;
namespace Project.Exceptions
{
    public class RentalReturnedException(Rental rental) : RentalException($"Rental with id = {rental.Id} is not from the list of active rentals");
}

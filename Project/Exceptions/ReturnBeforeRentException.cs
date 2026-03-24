using Project.Entities;

namespace Project.Exceptions
{
    public class ReturnBeforeRentException(Rental rental) : RentalException($"Return date cannot be earlier than rent date for rental id = {rental.Id}");
}

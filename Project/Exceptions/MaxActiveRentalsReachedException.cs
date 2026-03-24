using Project.Entities;

namespace Project.Exceptions
{
    public class MaxActiveRentalsReachedException(User user) : RentalException($"{user} has reached his maximum number of active rentals");
   
}

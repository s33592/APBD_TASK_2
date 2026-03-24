using Project.Entities;

namespace Project.Services.PenaltyServices
{
    public class PenaltyService : IPenaltyService
    {
        public readonly decimal dailyPenaltyrate = 5.00m;

        public decimal CalculatePenalty(Rental rental) { 
             if(rental.ReturnDate <= rental.DueDate)
                return 0;

             int daysLate = (rental.ReturnDate.Value - rental.DueDate).Days;
            return daysLate * dailyPenaltyrate;
        }
        
        public void ApplyPenalty(Rental rental) {
            rental.Penalty = CalculatePenalty(rental);
        }
    }
}

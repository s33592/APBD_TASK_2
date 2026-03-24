using Project.Entities;

namespace Project.Services.PenaltyServices
{
    public interface IPenaltyService
    {
        public decimal CalculatePenalty(Rental rental);
        public void ApplyPenalty(Rental rental);

    }
}

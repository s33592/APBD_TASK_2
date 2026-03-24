using Project.Entities;
namespace Project.Exceptions
{
    public class EquipmentNotAvailableException(Equipment equipment) : RentalException($"{equipment} is not available currently");
}

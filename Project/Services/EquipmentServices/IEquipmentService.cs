using Project.Entities;

namespace Project.Services.EquipmentServices
{
    public interface IEquipmentService
    {
        public void AddEquipment(Equipment equipment);
        public void ReturnEquipment(int equipmentId);

        public void MarkEquipmentUnavailable(int equipmentId);
        public List<Equipment> GetEquipments();

        public List<Equipment> GetAvailableEquipments();

    }
}
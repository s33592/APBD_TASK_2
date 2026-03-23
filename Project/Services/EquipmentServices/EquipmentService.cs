using Project.Entities;
using Project.Exceptions;

namespace Project.Services.EquipmentServices
{
    public class EquipmentService: IEquipmentService
    {
        private readonly List<Equipment> equipments = [];

        public void AddEquipment(Equipment equipment) {
            equipments.Add(equipment);
        }
        public void ReturnEquipment(int equipmentId) {
            var equipment = equipments.FirstOrDefault(equipment => equipment.Id == equipmentId)
                      ?? throw new EquipmentNotFoundException(equipmentId);
            equipment.IsAvailable = true;
        }

        public void MarkEquipmentUnavailable(int equipmentId) {
            var equipment = equipments.FirstOrDefault(equipment => equipment.Id == equipmentId)
                     ?? throw new EquipmentNotFoundException(equipmentId);
            equipment.IsAvailable = false;
        }
        public List<Equipment> GetEquipments() {
            return equipments;
        }

        public List<Equipment> GetAvailableEquipments() {
            return equipments.Where(equipment => equipment.IsAvailable).ToList();
        }


    }
}

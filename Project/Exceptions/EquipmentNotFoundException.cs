namespace Project.Exceptions
{ 
    public class EquipmentNotFoundException(int equipmentId) : Exception($"Equipment with id = {equipmentId} not found");
}


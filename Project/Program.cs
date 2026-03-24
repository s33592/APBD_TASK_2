using Project.Entities;
using Project.Exceptions;
using Project.RentalSystem;

Database db = Database.Instance;

User user1 = new User(1,"Jan","Kowalski",UserType.Student);
User user2 = new User(2, "Michael", "Doe", UserType.Employee);
User user3 = new User(2, "John", "Doe", UserType.Employee);

db.UService.AddUser(user1);
db.UService.AddUser(user2);

Equipment laptop = new Laptop(1,"Lenovo ThinkPad X1 Carbon",16,512,StorageMedium.SATA_SSD,3.5,Architecture.X64,OS.Windows);
Equipment camera = new Camera(2,"Canon EOS R50",24,LensType.Zoom);
Equipment projector = new Projector(3,"Epson EB-L200F",4000,true);

db.EService.AddEquipment(laptop);
db.EService.AddEquipment(camera);
db.EService.AddEquipment(projector);


Rental rental1 = db.RService.RentEquipment(user1, laptop, DateTime.Parse("2026-03-01"), DateTime.Parse("2026-03-12"));

// Attempt to rent an equipment that is not available
try {
    db.RService.RentEquipment(user2,laptop, DateTime.Parse("2026-03-13"), DateTime.Parse("2026-03-15"));
}catch(RentalException e)
{
    Console.WriteLine(e.Message);
}

//Return completed on time
{
    db.RService.ReturnEquipment(rental1, DateTime.Parse("2026-03-10"));
    db.PService.ApplyPenalty(rental1);

    if (rental1.Penalty != 0)
        Console.WriteLine($"Penlaty of {rental1.Penalty} applied");
}

//Delayed return that leads to a penalty
{
    Rental rental2 = db.RService.RentEquipment(user2, laptop, DateTime.Parse("2026-03-13"), DateTime.Parse("2026-03-15"));
    db.RService.ReturnEquipment(rental2, DateTime.Parse("2026-03-17"));
    db.PService.ApplyPenalty(rental2);

    if (rental2.Penalty != 0)
        Console.WriteLine($"Penlaty of {rental2.Penalty} applied");
}

//Rent more than limit
{
    try
    {
        db.RService.RentEquipment(user1, laptop,    DateTime.Parse("2026-03-18"), DateTime.Parse("2026-03-20"));
        db.RService.RentEquipment(user1, camera,    DateTime.Parse("2026-03-18"), DateTime.Parse("2026-03-20"));
        db.RService.RentEquipment(user1, projector, DateTime.Parse("2026-03-18"), DateTime.Parse("2026-03-20"));
    }
    catch (MaxActiveRentalsReachedException e) {
        Console.WriteLine(e.Message);
    }
}


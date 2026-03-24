using Project.Services.UserServices;
using Project.Services.EquipmentServices;
using Project.Services.RentalServices;
using Project.Services.PenaltyServices;

namespace Project.RentalSystem
{
    public class Database
    {
        private static Database? instance;

        public IUserService UService { get; private set; }
        public IEquipmentService EService { get; private set; }

        public IRentalService RService { get; private set; }

        public IPenaltyService PService { get; private set; }
        public static Database Instance
        {
            get
            {
                instance ??= new Database();
                return instance;
            }
        }

        private Database() {
            UService = new UserService();
            EService = new EquipmentService();
            RService = new RentalService();
            PService = new PenaltyService();
        
        }
    }
}

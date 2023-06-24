using TeamManagement.Shared;

namespace TeamManagementSystem.Services
{
    public class PlayerService : ServiceBase<Player>
    {
        public PlayerService(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}

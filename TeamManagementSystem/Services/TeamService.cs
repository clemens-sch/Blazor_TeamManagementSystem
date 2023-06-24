using TeamManagement.Shared;

namespace TeamManagementSystem.Services
{
    public class TeamService : ServiceBase<Team>
    {
        public TeamService(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}

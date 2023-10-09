using System.Threading.Tasks;
using Abp.Application.Services;
using Employee.Sessions.Dto;

namespace Employee.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

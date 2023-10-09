using System.Threading.Tasks;
using Abp.Application.Services;
using Employee.Authorization.Accounts.Dto;

namespace Employee.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

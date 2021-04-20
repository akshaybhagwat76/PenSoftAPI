using System.Threading.Tasks;
using Abp.Application.Services;
using PenSoftAPI.Sessions.Dto;

namespace PenSoftAPI.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

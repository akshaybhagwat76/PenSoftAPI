using Abp.Application.Services;
using PenSoftAPI.MultiTenancy.Dto;

namespace PenSoftAPI.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


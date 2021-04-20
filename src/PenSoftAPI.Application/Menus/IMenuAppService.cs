using Abp.Application.Services;
using Abp.Application.Services.Dto;

using PenSoftAPI.Menus.Dtos;
using System.Threading.Tasks;

namespace PenSoftAPI.Menus
{
    public interface IMenuAppService : IApplicationService
    {
        Task<PagedResultDto<GetMenuForViewDto>> GetAll(GetAllForLookupTableInput input);

        Task<GetMenuForViewDto> GetMenuForView(int id);

        Task<GetMenuForEditOutput> GetMenuForEdit(EntityDto input);

        Task CreateOrEdit(CreateOrEditMenuDto input);

        Task Delete(EntityDto input);

        //Task<FileDto> GetMenusToExcel(GetAllMenusForExcelInput input);

    }
}

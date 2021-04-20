using Abp.Application.Services.Dto;
using PenSoftAPI.MenuPermission.Dtos;
using System.Threading.Tasks;

namespace PenSoftAPI.MenuPermission
{
  public  interface IMenuPermissionAppService 
    {
        Task CreateOrEdit(CreateOrEditMenuPermissionDto input);
    }
}

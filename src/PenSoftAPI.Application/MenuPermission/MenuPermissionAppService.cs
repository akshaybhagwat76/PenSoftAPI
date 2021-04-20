using Abp.Domain.Repositories;
using PenSoftAPI.MenuPermission.Dtos;
using PenSoftAPI.MenusPermission;
using System;
using System.Threading.Tasks;

namespace PenSoftAPI.MenuPermission
{
    public class MenuPermissionAppService : PenSoftAPIAppServiceBase, IMenuPermissionAppService
    {
        private readonly IRepository<Menu_permission> _menupermissionRepository;
             public MenuPermissionAppService(IRepository<Menu_permission> menupermissionRepository)
        {
            _menupermissionRepository = menupermissionRepository;
        }
        public async Task CreateOrEdit(CreateOrEditMenuPermissionDto input)
        {
           
            
                if (input.Id == null || input.Id == 0)
                {
                    await Create(input);
                }
                else
                {
                    await Update(input);

                }
        }
        protected virtual async Task Create(CreateOrEditMenuPermissionDto input)
        {
            {

                var menu = ObjectMapper.Map<Menu_permission>(input);
                await _menupermissionRepository.InsertAsync(menu);
            }
            
        }

        protected virtual async Task Update(CreateOrEditMenuPermissionDto input)
        {


            var menu = await _menupermissionRepository.FirstOrDefaultAsync((int)input.Id);

            ObjectMapper.Map(input, menu);
            await _menupermissionRepository.UpdateAsync(menu);
        }

       
    }
}

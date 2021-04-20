using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using PenSoftAPI.Menus.Dtos;
using System.Linq;
using System.Linq.Dynamic.Core;
using Abp.Linq.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PenSoftAPI.Menus
{
    public class MenuAppService : PenSoftAPIAppServiceBase, IMenuAppService
    {
        private readonly IRepository<Menu> _menuRepository;
        //private readonly IMasterAmenitiesesExcelExporter _masterAmenitiesesExcelExporter;

        public MenuAppService(IRepository<Menu> menuRepository)
        {
            _menuRepository = menuRepository;
        }
        public async Task<PagedResultDto<GetMenuForViewDto>> GetAll(GetAllForLookupTableInput input)
        {

            var filteredMasterAmenitieses = _menuRepository.GetAll()
                        .WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false || e.MenuDescription.Contains(input.Filter) ||e.MenuName.Contains(input.Filter))
                        .WhereIf(!string.IsNullOrWhiteSpace(input.MenuDescriptionFilter), e => e.MenuDescription == input.MenuDescriptionFilter)
                        .WhereIf(!string.IsNullOrWhiteSpace(input.MenuNameFilter), e => e.MenuName == input.MenuNameFilter);

            var pagedAndFilteredMasterAmenitieses = filteredMasterAmenitieses
                .OrderBy(input.Sorting ?? "id asc")
                .PageBy(input);

            var masterAmenitieses = from o in pagedAndFilteredMasterAmenitieses
                                    select new GetMenuForViewDto()
                                    {
                                        Menu = new MenuDto
                                        {
                                            MenuDescription = o.MenuDescription,
                                            MenuName= o.MenuName,
                                            IsPerent = o.IsPerent,
                                            ParentId = o.ParentId,
                                            Id = o.Id
                                        }
                                    };

            var totalCount = await filteredMasterAmenitieses.CountAsync();

            return new PagedResultDto<GetMenuForViewDto>(
                totalCount,
                await masterAmenitieses.ToListAsync()
            );
        }

        public async Task<GetMenuForViewDto> GetMenuForView(int id)
        {
            var menu = await _menuRepository.GetAsync(id);

            var output = new GetMenuForViewDto { Menu = ObjectMapper.Map<MenuDto>(menu) };

            return output;
        }
        public async Task<GetMenuForEditOutput> GetMenuForEdit(EntityDto input)
        {
            var menu = await _menuRepository.FirstOrDefaultAsync(input.Id);

            var output = new GetMenuForEditOutput { Menu = ObjectMapper.Map<CreateOrEditMenuDto>(menu) };

            return output;
        }

        public async Task CreateOrEdit(CreateOrEditMenuDto input)
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


        protected virtual async Task Create(CreateOrEditMenuDto input)
        {
            var menu = ObjectMapper.Map<Menu>(input);
            await _menuRepository.InsertAsync(menu);
        }

        protected virtual async Task Update(CreateOrEditMenuDto input)
        {
           

            var menu = await _menuRepository.FirstOrDefaultAsync((int)input.Id);

            ObjectMapper.Map(input, menu);
            await _menuRepository.UpdateAsync(menu);
        }

        public async Task Delete(EntityDto input)
        {
            await _menuRepository.DeleteAsync(input.Id);
        }

    }
}

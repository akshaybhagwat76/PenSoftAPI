using Abp.Application.Services.Dto;
namespace PenSoftAPI.Menus.Dtos
{
    public class GetAllMenusInput: PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }


    }
}

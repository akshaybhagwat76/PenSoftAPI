using Abp.Application.Services.Dto;
namespace PenSoftAPI.Menus.Dtos
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
        public string MenuNameFilter { get; set; }
        public bool IsPerent { get; set; }
        public string MenuDescriptionFilter { get; set; }
        public int? ParentId { get; set; }
    }
}

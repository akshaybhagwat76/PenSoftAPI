using Abp.Application.Services.Dto;
namespace PenSoftAPI.Menus.Dtos
{
    public class MenuDto: EntityDto
    {
        public string MenuName { get; set; }

        public bool IsPerent { get; set; }

        public string MenuDescription { get; set; }
        public int? ParentId { get; set; }
    }
}


namespace PenSoftAPI.Menus.Dtos
{
    public class GetAllMenusForExcelInput
    {
        public string Filter { get; set; }

        public string MenuName { get; set; }

        public bool IsPerent { get; set; }
        public string MenuDescription { get; set; }
        public int? ParentId { get; set; }
    }
}

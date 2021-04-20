

using Abp.Application.Services.Dto;

namespace PenSoftAPI.MenuPermission.Dtos 
{
   public class CreateOrEditMenuPermissionDto : EntityDto<int?>
    {
        public int RoleId { get; set; }
        public int MenuId { get; set; }
        public bool IsEdited { get; set; }
        public bool IsView { get; set; }
        public bool Isdeleted { get; set; }
        public bool IsCreated { get; set; }

    }
}

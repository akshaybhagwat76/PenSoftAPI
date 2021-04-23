using Abp.Auditing;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace PenSoftAPI.Menus
{
    [Table("Menus")]
    [Audited]
    public class Menu : AuditedEntity
    {
        public virtual string MenuName { get; set; }

        public virtual bool IsPerent { get; set; }

        public virtual string MenuDescription { get; set; }
        public int? ParentId { get; set; }
        [NotMapped]
        public bool isView { get; set; }
        [NotMapped]
        public bool isEdit { get; set; }
    }
}

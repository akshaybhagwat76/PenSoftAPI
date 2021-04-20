using Abp.Auditing;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenSoftAPI.MenusPermission
{
    [Table("MenuPermission")]
    [Audited]
    public class Menu_permission : AuditedEntity
    {
        public virtual int RoleId { get; set; }

        public virtual int MenuId { get; set; }
        public virtual bool IsEdited { get; set; }
        public virtual bool IsView { get; set; }
        public virtual bool Isdeleted { get; set; }
        public virtual bool IsCreated { get; set; }
    }
}

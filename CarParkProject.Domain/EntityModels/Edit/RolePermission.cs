using CarParkProject.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Domain.EntityModels
{
    [Table("RolePermission")]
    public class RolePermission : BaseEntity
    {
        public string Description { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
    }
}

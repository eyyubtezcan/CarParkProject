using CarParkProject.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Domain.EntityModels
{
    [Table("Permission")]
    public class Permission : BaseEntity
    {
        public string Description { get; set; }
    }
}

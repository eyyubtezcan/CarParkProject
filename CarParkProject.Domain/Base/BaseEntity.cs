using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarParkProject.Domain.Base
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now; //override CreatedDate 
        public DateTime LastModifiedDate { get; set; } = DateTime.Now; //override CreatedDate 
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public int CreatedById { get; set; }
        public int ModifiedById { get; set; }
    }
}

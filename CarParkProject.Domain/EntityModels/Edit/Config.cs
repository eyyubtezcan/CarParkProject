using CarParkProject.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarParkProject.Domain.EntityModels
{
    [Table("Config")]
    public class Config : BaseEntity
    {       
        public string Description { get; set; }
        public string Detail { get; set; }
        public string Value { get; set; }
      

    }
}

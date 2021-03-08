using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DemoApp.Repository.EntityModels
{
    public class User
    {
        [Key]
        public int Id { get; set; }
  
        public string Name { get; set; }
        public string Role { get; set; }
    }
}

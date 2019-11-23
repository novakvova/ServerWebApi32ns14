using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiServer.Data
{
    [Table("tblAnimals")]
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [Required, StringLength(255)]
        public string Bread { get; set; }
        [StringLength(128)]
        public string Image { get; set; }
        public DateTime DateBirdth { get; set; }
    }
}

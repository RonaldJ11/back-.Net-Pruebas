using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace UsuariosBackend.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(2)]
        public string TypeDoc { get; set; }

        [Required]
        public char State { get; set; }

        [Required]
        [StringLength(25)]
        public string NumberDoc { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreationDate { get; set; }


    }
}

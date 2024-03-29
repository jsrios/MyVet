﻿
namespace MyVet.Web.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class PetType
    {
        public int Id { get; set; }

        [Display(Name = "Pet Type")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }// Es como el tippo de mascota

        public ICollection<Pet> Pets { get; set; }
    }
}

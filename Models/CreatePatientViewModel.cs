using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.ViewModels
{
    public class CreatePatientViewModel
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

 

        public string MedicalHistory { get; set; }
    }

   
}

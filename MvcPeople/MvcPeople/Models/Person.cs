using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace MvcPeople.Models
{
    public class Person
    {
        [Key] public int id { get; set; }
        [Display(Name = "DUI")]
        public int dui { get; set; }
        [Display(Name = "Nombre")]
        public string name { get; set; }
        [Display(Name = "Apellido")]
        public string surname { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateBirthday { get; set; }
        [Display(Name = "Dirección")]
        public string address { get; set; }
        [Display(Name = "Correo Electrónico")]
        public string email { get; set; }
    }
    public class PersonDBContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}
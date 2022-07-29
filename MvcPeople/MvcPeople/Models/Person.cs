using System;


namespace MvcPeople.Models
{
    public class Person
    {
        public int dui { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime dateBirthday { get; set; }
        public string address { get; set; }
        public string email { get; set; }
    }
}
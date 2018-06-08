using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kontakt.Models
{
    public class Person : BindableBase
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Github { get; set; }
        public string Birthday { get; set; }
        public string Company {get;set;}
        public Person()
        {

        }
        public Person Clone()
        {
            Person person =new Person();
            person.Name = Name;
            person.Number = Number;
            person.Email = Email;
            person.Facebook = Facebook;
            person.Instagram= Instagram;
            person.Github = Github;
            person.Birthday = Birthday;
            person.Company = Company;
            return person;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

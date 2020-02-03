using System;
using System.Collections.Generic;
using System.Text;

namespace oblig1
{
    public class Person
    {
        private static int Antall = 0;


        private int _id;
        private string _firstName;
        private string _lastName;
        private int? _birthYear;
        private int? _deathYear;

        private Person _mother;
        private Person _father;


        public Person(string firstName = "____", string lastName = "____", int? birthYear = null, int? deathYear = null)
        {
            this._id = Person.Antall;
            this._firstName = firstName;
            this._lastName = lastName;
            this._birthYear = birthYear;
            this._deathYear = deathYear;
            Antall++;
        }

        public string Show()
        {
            //Vis info om personen, samt barn og foreldre?



            var birthyear = _birthYear == null ? "" : $"Born: {_birthYear.ToString()}";

            var mother = _mother == default(Person) ? "" : $"Mor: {_mother.Name()} (ID: {_mother.Id().ToString()})";
            var father = _father == default(Person) ? "" : $"Far: {_father.Name()} (ID: {_father.Id().ToString()})";


            return $"Name: {_firstName} {_lastName} (ID: {_id})\n" +
                   $"{birthyear}\n" +
                   $"{mother}\n" +
                   $"{father}";
        }

        public string Name()
        {
            return $"{_firstName} {_lastName}";
        }

        public int Id()
        {
            return this._id;
        }

        public void Mother(Person mother)
        {
            this._mother = mother;
        }

        public void Father(Person father)
        {
            this._father = father;
        }


    }
}

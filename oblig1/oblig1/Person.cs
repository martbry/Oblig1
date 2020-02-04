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

        public Person MotherOf;
        public Person FatherOf;


        public Person(string firstName = "____", string lastName = "____", int? birthYear = null, int? deathYear = null)
        {

            if (firstName == "____" && lastName == "____" && birthYear == null && deathYear == null)
            {
                throw new System.ArgumentException("Du må spesifisere minst én av følgende: fornavn, etternavn, fødselsår eller dødsår");
            }

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

            var mother = this.MotherOf == default(Person) ? "" : $"Mother: {this.MotherOf.Name()} (ID: {this.MotherOf.Id().ToString()})\n";
            var father = this.FatherOf == default(Person) ? "" : $"Father: {this.FatherOf.Name()} (ID: {this.FatherOf.Id().ToString()})\n";


            return $"Name: {_firstName} {_lastName} (ID: {_id})\n" +
                   $"{birthyear}\n" +
                   $"{mother}" +
                   $"{father}";
        }

        public string ShowThisPerson()
        {
            var birthyear = _birthYear == null ? "" : $"Born: {_birthYear.ToString()}";

            return $"Name: {_firstName} {_lastName} (ID: {_id}) {birthyear}";
        }

        public int Id()
        {
            return this._id;
        }

        public string Name()
        {
            return $"{_firstName} {_lastName}";
        }

        public string FirstName()
        {
            return this._firstName;
        }

        public string LastName()
        {
            return this._lastName;
        }

        public int? BirthYear()
        {
            return this._birthYear;
        }

        public void Mother(Person mother)
        {
            this.MotherOf = mother;
        }

        public void Father(Person father)
        {
            this.FatherOf = father;
        }

        public bool Dead()
        {
            return this._deathYear != null;
        }

        public string DeathYear()
        {
            return this.Dead() ? this.DeathYear() : "";
        }

    }
}

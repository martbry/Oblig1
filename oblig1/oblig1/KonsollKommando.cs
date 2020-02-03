using System;
using System.Collections.Generic;
using System.Text;

namespace oblig1
{
    static class KonsollKommando
    {
        static public void hjelp()
        {
            //viser en hjelpetekst som forklarer alle kommandoene
        }

        static public void Liste(List<Person> personer)
        {
            //Lister alle personer med id, fornavn, fødselsår, dødsår og navn og id på mor og far om det finnes registrert.

            foreach (var person in personer)
            {
                var dead = person.Dead() ? $", død: {person.DeathYear()}" : "";
                var mother = person.MotherOf == default(Person) ? "" : $"Mor: {person.MotherOf.FirstName()} (ID: {person.MotherOf.Id().ToString()}). ";
                var father = person.FatherOf == default(Person) ? "" : $"Far: {person.FatherOf.FirstName()} (ID: {person.FatherOf.Id().ToString()}). ";
                Console.WriteLine($"{person.Id()} {person.FirstName()}, født {person.BirthYear()}{dead}. {mother}{father}");
            }


        }


        static public void vis(int id)
        {
            //Viser en bestemt person med mor, far og barn (og id for disse, slik at man lett kan vise en av dem)
        }


    }
}

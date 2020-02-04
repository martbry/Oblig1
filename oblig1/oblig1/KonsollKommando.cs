using System;
using System.Collections.Generic;
using System.Text;

namespace oblig1
{
    static class KonsollKommando
    {
        static public void Hjelp()
        {
            //viser en hjelpetekst som forklarer alle kommandoene
            Console.WriteLine($"\"Stopp\" avslutter programmet\n" +
                              $"\"Hjelp\" viser denne menyen\n" +
                              $"\"Liste\" viser en liste alle registrerte personer og litt informasjon om dem\n" +
                              $"\"Vis\" gir deg muligheten til å skrive inn en id og viser informasjon om personen med den IDen\n\n");

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


        static public void Vis(int id, List<Person> personer)
        {
            //Viser en bestemt person med mor, far og barn (og id for disse, slik at man lett kan vise en av dem)

            List<Person> barn = new List<Person>();
            foreach (var person in personer)
            {
                if (person.FatherOf == personer[id] || person.MotherOf == personer[id])
                {
                    barn.Add(person);
                }
            }

            Console.WriteLine(personer[id].Show());

            if (barn.Count > 0)
            {
                Console.WriteLine("Kids:");
                foreach (var barnIListe in barn)
                {
                    Console.WriteLine(barnIListe.ShowThisPerson());
                }
                Console.WriteLine("");
            }

        }


    }
}

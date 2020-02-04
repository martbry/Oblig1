using System;
using System.Collections.Generic;
using System.Reflection;

namespace oblig1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> personer = new List<Person>();

            try
            {
                personer.Add(new Person(firstName: "Sverre Magnus", birthYear: 2005));
                personer.Add(new Person(firstName: "Ingrid Alexandra", birthYear: 2004));
                personer.Add(new Person(firstName: "Haakon Magnus", birthYear: 1973));
                personer.Add(new Person(firstName: "Mette-Marit", birthYear: 1973));
                personer.Add(new Person(firstName: "Marius", lastName: "Borg Høiby", birthYear: 1997));
                personer.Add(new Person(firstName: "Harald", birthYear: 1937));
                personer.Add(new Person(firstName: "Sonja", birthYear: 1937));
                personer.Add(new Person(firstName: "Olav", birthYear: 1903));
            }
            catch(System.ArgumentException e)
            {
                Console.WriteLine(e + "\n\n");
            }
            

            personer[0].Father(personer[2]);
            personer[0].Mother(personer[3]);
            personer[1].Father(personer[2]);
            personer[1].Mother(personer[3]);
            personer[4].Mother(personer[3]);
            personer[2].Father(personer[5]);
            personer[2].Mother(personer[6]);
            personer[5].Father(personer[7]);


            var input = "";
            var konsoll = typeof(KonsollKommando);
            //MethodInfo metode;


            Console.WriteLine("Skriv \"Hjelp\" for å vise kommandoer (Case sensitive)\n\n");

            while (input != "stopp")
            {
                input = Console.ReadLine();

                if (input == "stopp" || input == "Stopp") {break;}
                
                if (konsoll.GetMethod(input) == null) {Console.WriteLine("Dette støttes ikke. Prøv igjen \n\n"); continue;}

                if (input == "Vis")
                {
                    Console.WriteLine("Skriv inn IDen på personen du ønsker å vise informasjonen til");
                    var argumentId = Console.ReadLine();
                    konsoll.GetMethod(input).Invoke(null, new object[]{Convert.ToInt32(argumentId), personer});
                    input = "";
                    continue;
                }

                if (input == "Liste")
                {
                    konsoll.GetMethod(input).Invoke(null, new object[] { personer });
                    input = "";
                    continue;
                }

                konsoll.GetMethod(input).Invoke(null, null);


            }

        }
    }
}



//var sverreMagnus = new Person(firstName: "Sverre Magnus", birthYear: 2005);
//var ingridAlexandra = new Person(firstName: "Ingrid Alexandra", birthYear: 2004);
//var haakon = new Person(firstName: "Haakon Magnus", birthYear: 1973);
//var metteMarit = new Person(firstName: "Mette-Marit", birthYear: 1973);
//var marius = new Person(firstName: "Marius", lastName: "Borg Høiby", birthYear: 1997);
//var harald = new Person(firstName: "Harald", birthYear: 1937);
//var sonja = new Person(firstName: "Sonja", birthYear: 1937);
//var olav = new Person(firstName: "Olav", birthYear: 1903);


//sverreMagnus.Father(haakon);
//sverreMagnus.Mother(metteMarit);
//ingridAlexandra.Father(haakon);
//ingridAlexandra.Mother(metteMarit);
//marius.Mother(metteMarit);
//haakon.Father(harald);
//haakon.Mother(sonja);
//harald.Father(olav);
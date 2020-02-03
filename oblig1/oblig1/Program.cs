using System;
using System.Collections.Generic;

namespace oblig1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> personer = new List<Person>();


            personer.Add(new Person(firstName: "Sverre Magnus", birthYear: 2005));
            personer.Add(new Person(firstName: "Ingrid Alexandra", birthYear: 2004));
            personer.Add(new Person(firstName: "Haakon Magnus", birthYear: 1973));
            personer.Add(new Person(firstName: "Mette-Marit", birthYear: 1973));
            personer.Add(new Person(firstName: "Marius", lastName: "Borg Høiby", birthYear: 1997));
            personer.Add(new Person(firstName: "Harald", birthYear: 1937));
            personer.Add(new Person(firstName: "Sonja", birthYear: 1937));
            personer.Add(new Person(firstName: "Olav", birthYear: 1903));

            personer[0].Father(personer[2]);
            personer[0].Mother(personer[3]);
            personer[1].Father(personer[2]);
            personer[1].Mother(personer[3]);
            personer[4].Mother(personer[3]);
            personer[2].Father(personer[5]);
            personer[2].Mother(personer[6]);
            personer[5].Father(personer[7]);


           

            //foreach (var person in personer)
            //{
            //    Console.WriteLine($"{person.Id()} {person.Name()}");
            //}


            //Console.WriteLine(personer[0].Dead());

            KonsollKommando.Liste(personer);

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
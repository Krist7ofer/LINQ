using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");

            WhereLINQ();
            ThenByLINQ();
            ThenByDescendingLINQ();
            JoinLINQ();
            GroupJoinLINQ();
            SelectLINQ();
            AllAndAnyLINQ();
            ContainsLINQ();
            AggregateLINQ();
            AverageLINQ();
        }
        public static void WhereLINQ()
        {
            var peopleAge = PeopleList.peoples
                .Where(x => x.Age > 20 && x.Age < 23);

            foreach (var item in peopleAge)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static void ThenByLINQ()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("\n");
            Console.WriteLine("ThenBy järgi reastamine:");
            Console.WriteLine("\n");

            var thenByResult = PeopleList.peoples
                //järjestab nimede järgi ja siis vanuse järgi
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Age);

            foreach (var people in thenByResult)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }
        public static void ThenByDescendingLINQ()
        {
            Console.WriteLine("\n");
            Console.WriteLine("ThenbyDescending:");
            Console.WriteLine("\n");
            var thenByDescending = PeopleList.peoples
                .OrderBy(x => x.Name)
                .ThenByDescending(x=>x.Age);
            foreach (var people in thenByDescending)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }
        public static void JoinLINQ()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("InnerJoin in LINQ");

            var innerJoin = PeopleList.peoples
                .Join(GenderList.genderList,
                humans => humans.GenderId,
                gender => gender.Id,
                (humans, gender) => new
                {
                    Name = humans.Name,
                    Sex = gender.Sex
                });

            foreach (var people in innerJoin)
            {
                Console.WriteLine(people.Name + " " + people.Sex);
            }
        }
        public static void GroupJoinLINQ()
        {
            Console.BackgroundColor = ConsoleColor.Red;

            var groupJoin = GenderList.genderList
                .GroupJoin(PeopleList.peoples,
                p => p.Id,
                g => g.GenderId,
                (p, peopleGroup) => new
                {
                    Humans = peopleGroup,
                    GenderFullName = p.Sex
                });

            foreach (var people in groupJoin)
            {
                Console.WriteLine(people.GenderFullName);

                foreach (var name in people.Humans)
                {
                    Console.WriteLine(name.Name);
                }
            }
        }
        public static void SelectLINQ()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n");
            Console.WriteLine("Select in LINQ");
            Console.WriteLine("\n");
            var selectLINQ = PeopleList.peoples
                .Select(x => new
                { 
                    name = x.Name,
                    age = x.Age,                
                });
            foreach (var peopleName in selectLINQ)
            {
                Console.WriteLine(peopleName.name + ": " + peopleName.age);
            }
        }
        public static void AllAndAnyLINQ()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            Console.WriteLine("All LINQ");
            Console.WriteLine("\n");

            bool areAllPeopleTeenagers = PeopleList.peoples
                .All(x => x.Age < 18);
            //Kõik PeopleList-i all olevad isikud peaved olema alla 18 a vanused
            Console.WriteLine(areAllPeopleTeenagers);

            Console.BackgroundColor = ConsoleColor.Cyan;           
            Console.WriteLine("\n");
            Console.WriteLine("Any LINQ");
            Console.WriteLine("\n");
            
            bool isAnyPersonTeenager = PeopleList.peoples
                .Any(x => x.Age > 18);
            //Kasvõi üks andmerida vastab tingimusele, siis tuleb vastus
            Console.WriteLine(isAnyPersonTeenager);
        }
        public static void ContainsLINQ()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n");
            Console.WriteLine("Contains LINQ");
            Console.WriteLine("\n");

            //Pärib, kas number 10 on numbrite seas
            //niimoodi saab iga numbriga teha
            //kui paneme nr 5, siis tuleb vastuseks true
            bool result = NumberList.numberList.Contains(5);

            Console.WriteLine(result);
        }
        public static void AggregateLINQ()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            string commaSeparatedPersonNames = PeopleList.peoples
                .Aggregate<People, string>(
                "People names: ",
                (str, x) => str += x.Name + ", "
                );
            Console.WriteLine(commaSeparatedPersonNames);
        }
        public static void AverageLINQ()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Average LINQ");
            var averageResult = PeopleList.peoples
                .Average(x => x.Age);

                Console.WriteLine(averageResult);
        }
    }
}
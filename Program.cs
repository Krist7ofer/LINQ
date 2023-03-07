using System.Runtime.InteropServices;

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
    }
}
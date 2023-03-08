namespace LINQ
{
    public class PeopleList
    {
        public static readonly List<People> peoples = new List<People>
        {
            new People()
            {
                    Id = 1,
                    Name = "Moona",
                    Age = 31,
                    GenderId = Guid.Parse("dccb9000-020f-495e-9996-0431b2c695cf")
            },
            new People()
            {
                    Id = 2,
                    Name = "Poona",
                    Age = 21,
                    GenderId = Guid.Parse("ba855880-dd18-49bc-938b-0175dd041372")
            },
            new People()
            {
                    Id = 3,
                    Name = "Ron",
                    Age = 26,
                    GenderId = Guid.Parse("020f4a6a-247d-4d6f-93db-d12857f44070")
            },
            new People()
            {
                    Id = 4,
                    Name = "Anna",
                    Age = 20,
                    GenderId = Guid.Parse("bde1bee2-862b-41ad-9110-681a413329ed")
            },
            new People()
            {
                    Id = 5,
                    Name = "Mari",
                    Age = 19,
                    GenderId = Guid.Parse("266ecb6f-8069-45c7-9267-7d8c7928d12b")
            },
            new People()
            {
                    Id = 6,
                    Name = "Mari",
                    Age = 21,
                    GenderId = Guid.Parse("8e58f7c9-cf55-4d45-b393-9fa724509b26")
            },
                        new People()
            {
                Id = 7,
                Name = "Bill",
                Age = 21,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            }
        };
    }
}

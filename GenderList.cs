namespace LINQ
{
    public class GenderList
    {
        public static readonly List<Gender> genderList = new List<Gender>
        {
            new Gender()
            {
                Id = Guid.Parse("1b760ddc-6b1d-45fe-8392-e1510cc6b5ab"),
                Sex = "male"
            },
            new Gender()
            {
                Id = Guid.Parse("d3d078bd-5b09-4a0e-a6c0-0afc0b745735"),
                Sex = "female"
            },
        };
    }
}

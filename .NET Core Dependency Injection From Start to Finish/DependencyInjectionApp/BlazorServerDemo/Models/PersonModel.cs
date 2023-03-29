namespace BlazorServerDemo.Models
{
    public interface IPersonModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    public class PersonModel : IPersonModel
    {
        // "First Name"
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class MockPersonModel : IPersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

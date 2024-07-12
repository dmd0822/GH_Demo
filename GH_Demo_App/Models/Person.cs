namespace GH_Demo_App.Models
{
    //Create a person class with first name last name and date of birth

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        //Create a method that returns the full name of the person
        public string GetFullName()
        {
            return $"{LastName}, {FirstName}";
        }

        //create methods to create update and delete a person
        public void CreatePerson(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public void UpdatePerson(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public void DeletePerson() {
            FirstName = null;
            LastName = null;
        }
    }
   
}

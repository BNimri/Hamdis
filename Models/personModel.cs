namespace Hamdi.Models
{
    public class personModel
    {
        int id;
        DateOnly birthDate;
        int? yearInCollege;
        int age;

        string nationalId;
        string surname;
        string firstName, secondName, thirdName, lastName;
        string gender;
        string location;
        string occupation;
        string jobTitle;
        string phoneNumber;
        string email;

        public personModel()
        {
        }

        public personModel(DateOnly birthDate, int age, int yearInCollege, string nationalId, string firstName, string secondName, string thirdName, string lastName, string surname, string gender, string location, string occupation, string jobTitle, string phoneNumber, string email)
        {
            this.surname = surname;
            this.birthDate = birthDate;
            this.age = age;
            this.yearInCollege = yearInCollege;
            this.nationalId = nationalId;
            this.firstName = firstName;
            this.secondName = secondName;
            this.thirdName = thirdName;
            this.lastName = lastName;
            this.gender = gender;
            this.location = location;
            this.occupation = occupation;
            this.jobTitle = jobTitle;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }



        public int Id { get { return id; } set { id = value; } }
        public DateOnly BirthDate { get { return birthDate; } set { birthDate = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int? YearInCollege { get { return yearInCollege; } set { yearInCollege = value; } }

        public string NationalId { get { return nationalId; } set { nationalId = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string SecondName { get { return secondName; } set { secondName = value; } }
        public string ThirdName { get { return thirdName; } set { thirdName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string Location { get { return location; } set { location = value; } }
        public string Occupation { get { return occupation; } set { occupation = value; } }
        public string JobTitle { get { return jobTitle; } set { jobTitle = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Surname { get { return surname; } set { surname = value; } }

    }
}
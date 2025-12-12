namespace UsingProperties;

public class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    private DateTime _birthDate;

    public DateTime BirthDate
    {
        get => _birthDate;
        set
        {
            if (value > DateTime.Today)
            {
                _birthDate = DateTime.Today;
            }
            else
            {
                _birthDate = value;
            }
        }
    }

    public string NameLastFirst
    {
        get => $"{LastName} {FirstName}";
    }

    public int AgeYears
    {
        get
        {
            int age = DateTime.Today.Year - BirthDate.Year;
            
            // account for whether the birthdate happened this year yet
            if (BirthDate.AddYears(age) > DateTime.Today)
            {
                age--;
            }
            return age;
        }
        
    }
    
}
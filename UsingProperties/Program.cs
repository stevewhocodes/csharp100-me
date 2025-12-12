using UsingProperties;

Contact c1 = new();

c1.FirstName = "Joe";
c1.LastName = "Schmoe";
c1.BirthDate = new DateTime(1997, 2, 15);

Console.WriteLine($"{c1.NameLastFirst} | Age: {c1.AgeYears}");

Contact c2 = new()
{
    FirstName = "Sue",
    LastName = "Miller",
    BirthDate = new DateTime(1998, 6, 15)
};

Console.WriteLine($"{c2.NameLastFirst} | Age: {c2.AgeYears}");


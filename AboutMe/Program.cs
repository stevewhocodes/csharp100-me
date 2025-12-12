using AboutMe.Prompter;
using AboutMe.Printer;

string fName = Prompter.GetRequiredString("Enter First Name: ");
string lName = Prompter.GetRequiredString("Enter Last Name: ");
DateTime dob = Prompter.GetPastDate("Enter Date of Birth (MM/DD/YYYY): ");
int age = Prompter.GetIntInRange("Enter Age (1-120): ", 1, 120);
string status = Prompter.GetMaritalStatus("Marital Status (S)ingle, (M)arried: ");

Printer.PrintHeader();
Printer.PrintAboutMe(fName, lName, dob, age, status);
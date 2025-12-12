using PromptMethods.UI;

string firstName = Prompter.GetPrompt("Please enter your first name: ");
string lastName = Prompter.GetPrompt("Please enter your last name: ");

Console.WriteLine($"\nHello, {lastName}, {firstName}.");


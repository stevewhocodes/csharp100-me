// prompt user for HTTP status code
Console.Write("Enter a Response Code: ");
int input = int.Parse(Console.ReadLine());

// Check response and print our response type
// switch (input)
// {
//     case >= 100 and <= 199:
//         Console.WriteLine($"{input} is a Informational response.");
//         break;
//     case > 199 and <= 299:
//         Console.WriteLine($"{input} is a Successful response.");
//         break;
//     case > 299 and <= 399:
//         Console.WriteLine($"{input} is a Redirection response.");
//         break;
//     case > 399 and <= 499:
//         Console.WriteLine($"{input} is a Client error response.");
//         break;
//     case > 499 and <= 599:
//         Console.WriteLine($"{input} is a Server error response.");
//         break;
//     default:
//         Console.WriteLine($"{input} is not a valid response.");
//         break;
// }

string result = input switch
{
    >= 100 and <= 199 => $"{input} is a Informational response.",
    > 199 and <= 299 => $"{input} is a Successful response.",
    > 299 and <= 399 => $"{input} is a Redirection response.",
    > 399 and <= 499 => $"{input} is a Client error response.",
    > 499 and <= 599 => $"{input} is a Server error response.",
    _ => $"{input} is not a valid response."
    
};
Console.WriteLine(result);
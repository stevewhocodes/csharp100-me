namespace PromptMethods.UI;

/// <summary>
/// Class returns a prompt
/// </summary>
public static class Prompter
{
    /// <summary>
    /// Receives a prompt and prints it
    /// </summary>
    /// <param name="prompt">This is a cool prompt</param>
    /// <returns>returns a non-zero string</returns>
    
    public static string GetPrompt(string prompt)
    {
        string input;
        
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("You must enter in a character.");
            }
            
        } while (true);
    }
}



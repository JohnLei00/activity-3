internal class Program
{
    private static void Main(string[] args)
    {
        List<string> usernames = new List<string> { "john", "susan", "alex", "michael", "jenny" };
        Console.WriteLine("Enter a character to search for:");

        string searchChar = Console.ReadLine().ToLower();

        // Filter usernames based on character
        var filteredUsernames = new List<string>();
        foreach (var username in usernames)
        {
            if (username.ToLower().Contains(searchChar))
            {
                filteredUsernames.Add(username);
            }
        }

        // Display filtered usernames
        Console.WriteLine("\nFiltered Usernames:");
        if (filteredUsernames.Count > 0)
        {
            foreach (var username in filteredUsernames)
            {
                Console.WriteLine(username);
            }
        }
        else
        {
            Console.WriteLine("No usernames found containing that character.");
        }
    }
}
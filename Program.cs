namespace wk5ex3_Review;
class Program
{
    static Stack<string> BrowserHistory = new Stack<string>();

    static void Main(string[] args)
    {
        int menuOption = 0;

        Console.WriteLine("Welcome to Web Browser Back Button Application");

        do
        {
            Console.WriteLine("1. Visit\n2. Go Back\n3. View Browsing History\n4. Exit");
            Console.Write("Enter your choice: ");
            menuOption = Convert.ToInt32(Console.ReadLine());

            switch (menuOption)
            {
                case 1:
                    VisitNewPage(BrowserHistory);
                    break;
                case 2:
                    GoBack(BrowserHistory);
                    break;
                case 3:
                    ViewHistory(BrowserHistory);
                    break;
                case 4:
                    break;
            }

        } while (menuOption != 4);

        Console.WriteLine("Thank you for using this App. Bye!");
        Console.Read();
    }
    static void VisitNewPage(Stack<string> BrowserHistory)
    {
        string newPage = "";
        Console.Write("Enter Webpage URL: ");
        newPage = Console.ReadLine();

        BrowserHistory.Push(newPage);
        Console.WriteLine("Page visited successfully!");
    }
    static void GoBack(Stack<string> BrowserHistory)
    {
        if (BrowserHistory.Count == 0)
        {
            Console.WriteLine("Browser History is Empty!");
        }
        else
        {
            Console.WriteLine($"\nGoing back to: {(BrowserHistory.Pop())}\n");
        }
    }
    static void ViewHistory(Stack<string> BrowserHistory)
    {
        if (BrowserHistory.Count == 0)
        {
            Console.WriteLine("Browser History is Empty!");
        }
        else
        {
            Console.WriteLine("Paged Visited:");
            foreach (var page in BrowserHistory)
            {
                Console.WriteLine(page);
            }
        }
    }
   
}


namespace wk5ex3_Review;
class Program
{
    //Stack Collection to store the browser history
    static Stack<string> BrowserHistory = new Stack<string>();

    static void Main(string[] args)
    {
        //Declaration of variable to store the menu option
        int menuOption = 0;
        //Program title
        Console.WriteLine("Welcome to Web Browser Back Button Application");
        //Menu do while loop
        do
        {
            //Menu option
            Console.WriteLine("1. Visit\n2. Go Back\n3. View Browsing History\n4. Exit");
            //Prompt the user for choice
            Console.Write("Enter your choice: ");
            //Stores the menu option
            menuOption = Convert.ToInt32(Console.ReadLine());
            //Swith to call method from menu
            switch (menuOption)
            {
                case 1:
                    //Call visit new page method
                    VisitNewPage(BrowserHistory);
                    //Exit the loop
                    break;
                case 2:
                    //Call go back method
                    GoBack(BrowserHistory);
                    //Exit the loop
                    break;
                case 3:
                    //Call view history method
                    ViewHistory(BrowserHistory);
                    //Exit the loop
                    break;
                case 4:
                    //Exit the loop
                    break;
            }
        //Stops the loop when user select 4
        } while (menuOption != 4);
        //End of the program message
        Console.WriteLine("Thank you for using this App. Bye!\n ");
        //Stop the program to allow user to read the message
        Console.Read();
    }
    //Visit new page method
    static void VisitNewPage(Stack<string> BrowserHistory)
    {
        //Declaration of variable to store the new page  value
        string newPage = "";
        //Prompt the user for the URL
        Console.Write("Enter Webpage URL: ");
        //Store the URL value
        newPage = Console.ReadLine();
        //Push value to the stack collection
        BrowserHistory.Push(newPage);
        //Confirmation message after contact added
        Console.WriteLine("Page visited successfully!");
    }
    //Go back method
    static void GoBack(Stack<string> BrowserHistory)
    {
        //Condition to check the stack count
        if (BrowserHistory.Count == 0)
        {
            //Show a message if the stack is empty
            Console.WriteLine("Browser History is Empty!");
        }
        //Otherwise
        else
        {
            //Display previous element on the stack
            Console.WriteLine($"\nGoing back to: {(BrowserHistory.Pop())}\n");
        }
    }
    //Method to view history
    static void ViewHistory(Stack<string> BrowserHistory)
    {
        //Condition to check the stack count
        if (BrowserHistory.Count == 0)
        {
            //Show a message if the stack is empty
            Console.WriteLine("Browser History is Empty!");
        }
        else
        {
            //Section title
            Console.WriteLine("Paged Visited:");
            //Loop to iterate through the collection
            foreach (var page in BrowserHistory)
            {
                //Display element in the collection
                Console.WriteLine(page);
            }
        }
    }
   
}


namespace Infostructure;
public class Tools
{
    public void CountWords(string text)
    {
        string[] words = text.Split(separator:new []{' ', '!'});
        Dictionary<string, int> counter = new Dictionary<string, int>();
        foreach (var item in words)
        {
            string cleanWord = item.ToLower();
            if(cleanWord != "")
            {
                if(counter.ContainsKey(cleanWord))
                {
                    counter[cleanWord]++;
                }
                else
                {
                    counter.Add(cleanWord, 1);
                }
            }
        }
        System.Console.WriteLine("Results: ");
        int number = 1;
        foreach (var item in counter)
        {
            System.Console.WriteLine($"{number}. {item.Key} - {item.Value} times");
            number++;
        }
    }

    public void PhoneBook()
    {
        Dictionary<string, string> Book = new Dictionary<string, string>();
        Book.Add("Alex", "+7-999-123-45-67");
        Book.Add("Andrew", "+7-999-765-43-21");
        for (;;)
        {
            System.Console.WriteLine();
            System.Console.Write("Press 'D' to delete a contact, 'A' to add a contact, 'S' to search contact by name, or 0 to exit: ");
            char action = char.Parse(Console.ReadLine());
            if (action == 'D')
            {
                System.Console.Write("Name of the contact you want to delete: ");
                string Name = Console.ReadLine();
                if (Book.ContainsKey(Name))
                {
                    Book.Remove(Name);
                    System.Console.WriteLine("Contact has been deleted successefully!");
                    System.Console.WriteLine("Remaining contacts: ");
                    foreach (var item in Book)
                    {
                        System.Console.WriteLine(item.Key + " " + item.Value);
                    }
                }
                else
                {
                    System.Console.WriteLine("Contact not found");
                }
            }
            if (action == 'A')
            {
                System.Console.Write("Name: ");
                string Name = Console.ReadLine();
                System.Console.Write("Phone number: ");
                string Phone = Console.ReadLine();
                Book.Add(Name, Phone);
                System.Console.WriteLine("Contact has been added successefully!");
                System.Console.WriteLine("Remaining contacts: ");
                    foreach (var item in Book)
                    {
                        System.Console.WriteLine(item.Key + " " + item.Value);
                    }
            }
            if (action == '0')
            {
                System.Console.WriteLine("Exiting, bye!");
                break;
            }
            if (action == 'S')
            {
                System.Console.Write("Name of the contact you want to search: ");
                string Name = Console.ReadLine();
                if (Book.ContainsKey(Name))
                {
                    var contactValue = Book[Name];
                    System.Console.WriteLine("Found contact: " + Name + " " + contactValue);
                }
                else
                {
                    System.Console.WriteLine("No contact with such name.");
                }
            }
            else
            {
                System.Console.WriteLine("Error. Something went wrong!");
            }
        }
    }

    public void GradeSystem(){
        Dictionary<string, List<int>> Grades = new Dictionary<string, List<int>>();
        Grades.Add("Ivan", new List<int> {5, 4, 5});
        Grades.Add("Anton", new List<int> {4, 3, 4});
        Grades.Add("Maria", new List<int> {5, 5, 5});

        for (;;)
        {
            System.Console.WriteLine();
            System.Console.Write("Press 'S' to see all of the students, 'A' to add a point to a Student, or 0 to exit: ");
            char symbol = char.Parse(Console.ReadLine());
            if (symbol == 'S')
            {
                System.Console.WriteLine("All students: ");
                foreach (var item in Grades)
                {
                    float sum = 0;
                    foreach (var grades in item.Value)
                    {
                        sum += grades;
                    }
                    sum = sum / item.Value.Count();
                    System.Console.WriteLine(item.Key + ": Average grade: " + sum);
                }
            }
            if (symbol == 'A')
            {
                System.Console.WriteLine("You want to add a point to a student.");
                System.Console.Write("Name: ");
                string Name = Console.ReadLine();
                if (Grades.ContainsKey(Name))
                {
                    System.Console.Write("Enter a grade you want to add: ");
                    int point = int.Parse(Console.ReadLine());
                    Grades[Name].Add(point);
                    var value = Grades[Name];
                    System.Console.WriteLine("Point has been added successefully!");
                    System.Console.Write(Name + ": Grades: ");
                    foreach (var item in value)
                    {
                        System.Console.Write(item + " ");
                    }
                }
            }
            if (symbol == '0')
            {
                System.Console.WriteLine("Exiting, bye!");
                break;
            }
        }
    }

    public void Inventory(){
        Dictionary<string, int> inventory = new Dictionary<string, int>();

        for (;;)
        {
            System.Console.WriteLine();
            System.Console.Write("Press 'A' if you want to add an inventory, 'D' to delete, 'C' to check, or 0 to exit: ");
            char choice = char.Parse(Console.ReadLine());
            if (choice == 'A')
            {
                System.Console.WriteLine("Adding to an inventory...");
                System.Console.Write("Name of an item: ");
                string item = Console.ReadLine();
                System.Console.Write("Amount: ");
                int amount = int.Parse(Console.ReadLine());
                inventory.Add(item, amount);
                System.Console.WriteLine($"{item} in amount of {amount} has been successefully added to inventory!");
                System.Console.WriteLine("Inventory: ");
                
                int sum = 0;
                foreach (var show in inventory)
                {
                    System.Console.WriteLine(show.Key + ": " + show.Value + " pieces");
                    sum += show.Value;
                }
                System.Console.WriteLine($"Sum of items: {sum}");   
            }
            if (choice == 'D')
            {
                if (inventory.Count() == 0)
                {
                    System.Console.WriteLine("Can't delete. Inventory is empty.");
                }
                else
                {
                    System.Console.WriteLine("Deleting from an inventory...");
                    System.Console.Write("Name of an item to delete: ");
                    string item = Console.ReadLine();
                    if (inventory.ContainsKey(item))
                    {
                        inventory.Remove(item);
                        System.Console.WriteLine("Item has been deleted successefully!");
                        System.Console.WriteLine("Inventory: ");
                        int sum = 0;
                        foreach (var show in inventory)
                        {
                            System.Console.WriteLine(show.Key + ": " + show.Value + " pieces");
                            sum += show.Value;
                        }
                        System.Console.WriteLine($"Sum of items: {sum}");  
                    }
                    else
                    {
                        System.Console.WriteLine("Item is not fount.");
                    }
                }
            }
            if (choice == 'C')
            {
                System.Console.WriteLine("Checking inventory...");
                System.Console.WriteLine("Inventory: ");
                int sum = 0;
                foreach (var show in inventory)
                {
                    System.Console.WriteLine(show.Key + ": " + show.Value + " pieces");
                    sum += show.Value;
                }
                System.Console.WriteLine($"Sum of items: {sum}");   
            }
            if (choice == '0')
            {
                System.Console.WriteLine("Exiting, bye!");
                break;
            }
        }
    }
}
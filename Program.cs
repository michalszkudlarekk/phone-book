namespace PhoneBook
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello from the other sideeeee");

            Console.WriteLine("1 Add Contact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 Display all contacts");
            Console.WriteLine("4 Search contacts");

            var userInput = Console.ReadLine();


            var phoneBook = new PhoneBook();    
            switch (userInput)
            {
                case "1":

                    Console.WriteLine("Insert number");
                    var number = Console.ReadLine();
                    Console.WriteLine("Insert name");
                    var fullName = Console.ReadLine();

                    var newContact = new Contact(fullName, number);
                    phoneBook.AddContact(newContact);
                    break;

                case "2":
                    Console.WriteLine("Insert number");
                    var numbertoSearch = Console.ReadLine();

                    phoneBook.DisplayContact(numbertoSearch);
                    break;

                case "3":
                    break;

                case "4":
                    break;

                default:
                    Console.Write("Invalid operation");
                    break;
            }
        }
    }
}
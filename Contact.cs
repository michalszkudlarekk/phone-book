namespace PhoneBook
{
    public class Contact
    {
        public Contact(string fullName, string number)
        {
            FullName = fullName;
            Number = number;
        }

        public string FullName { get; set; }
        public string Number { get; set; }
        public object Name { get; internal set; }

    }
}
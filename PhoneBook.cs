namespace PhoneBook
{
    public class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public void RemoveContact(Contact contact)
        { 
            Contacts.Remove(contact); 
        }

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact : {contact.FullName}, {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
                DisplayContactDetails(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayAllContacts()
        {
            DisplayContactsDetails(Contacts);
        }

        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = Contacts.Where(c => c.FullName.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }

        public void RemoveNumber(string numberToDelete)
        {
            var toDelete = Contacts.FirstOrDefault(c => c.Number.Contains(numberToDelete));
        }
    }
}
namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book!");
            List<Contacts> ContactsList = new List<Contacts>();
            ContactsList.Add(new Contacts("Mohan", "sharma", "Nehru Nagar", "Indore", "Madhya Pradesh", 246413165, "mohan@gmail.com"));
        }
    }
}
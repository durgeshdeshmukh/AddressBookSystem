using AddressBookSystem;

Console.WriteLine("Welcome to Address Book!");
//List<Contacts> ContactsList = new List<Contacts>();
//ContactsList.Add(new Contacts("Mohan", "sharma", "Nehru Nagar", "Indore", "Madhya Pradesh", 246413165, "mohan@gmail.com"));
//foreach (Contacts item in ContactsList)
//    Console.WriteLine(item);

Console.WriteLine("FirstName:");
string FirstName = Console.ReadLine();
Console.WriteLine("LastName:");
string LastName = Console.ReadLine();
Console.WriteLine("Address:");
string Address = Console.ReadLine();
Console.WriteLine("City:");
string City = Console.ReadLine();
Console.WriteLine("State:");
string State = Console.ReadLine();
Console.WriteLine("PhoneNumber:");
string PhoneNumber = Console.ReadLine();
Console.WriteLine("Email:");
string Email = Console.ReadLine();

List<Contacts> ContactsList = new List<Contacts>();
ContactsList.Add(new Contacts(FirstName, LastName, Address, City, State, PhoneNumber, Email));
foreach (var contact in ContactsList)
{
    Console.WriteLine(contact);
}

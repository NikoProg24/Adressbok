namespace Inlämningsuppgift1._1.Classes
{
    public class Contact
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Contact(string name, string address, string zipCode, string city, string phone, string email)
        {
            Name = name;
            Address = address;
            ZipCode = zipCode;
            City = city;
            Phone = phone;
            Email = email;
        }

        //Anropar denna metod i buttonCreate.
        public void Save()
        {
            FileHandler filehandler = new FileHandler(@"C:\Users\niko\Documents\Textfiler\Kontakter.txt");
            string text = $"{Name}, {Address}, {ZipCode}, {City}, {Phone}, {Email}";
            filehandler.WriteToFile(text);
        }
    }
}

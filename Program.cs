namespace PersonalInformationForm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name:");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string Lastname = Console.ReadLine();
            Console.WriteLine("Please enter your phone number:");
            string Phonenum = Console.ReadLine();
            int phonenumber = Int32.Parse(Phonenum);
            Console.WriteLine("Please enter your national code:");
            string Ncode = Console.ReadLine();
            int ncode = Int32.Parse(Ncode);
            Console.WriteLine("Please enter your gender:");
            string Gender = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            string Age = Console.ReadLine();
            int age = Int32.Parse(Age);
            Console.WriteLine("Thanks, Here is your information:");
            Console.WriteLine("First name: " + Firstname);
            Console.WriteLine("Last name: " + Lastname);
            Console.WriteLine("Phone nember: " + phonenumber);
            Console.WriteLine("National code: " + ncode);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Age: " + age);
        }
    }
}

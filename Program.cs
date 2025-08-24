using System.Security.Cryptography.X509Certificates;

namespace PersonalInformationForm
{
    enum Gender
    {
        Male,
        Female
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name:");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string Lastname = Console.ReadLine();
            string Phonenum = phoneNumber();
            static string phoneNumber()
            {
                    Console.WriteLine("Please enter your phone number:");
                    string Phonenum = Console.ReadLine();
                while (Phonenum.All(char.IsDigit))
                {
                    if (Phonenum.Length == 11 && Phonenum.StartsWith("09")) ;
                    else if (Phonenum.Length == 10 && Phonenum.StartsWith("9"))
                    {
                        Phonenum = "0" + Phonenum;
                    }
                    else if (Phonenum.Length == 13 && Phonenum.StartsWith("+98"))
                    {
                        Phonenum = Phonenum.Replace("+98","0");
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid phone number!");
                        phoneNumber();
                    }

                    return Phonenum;
                }
                return null;
            }
            Console.WriteLine("Please enter your national code:");
            int Ncode = int.Parse(Console.ReadLine());
            Gender gender = GetGenderFromUser();
            static Gender GetGenderFromUser()
            {
                while (true)
                {
                    Console.WriteLine("Please enter your gender: M->male , F->female");
                    string GenderIn = Console.ReadLine().ToLower();
                    if (GenderIn == "m")
                        return Gender.Male;
                    else if (GenderIn == "f")
                        return Gender.Female;
                    else
                        Console.WriteLine("Please enter valid Gender!");
                }
            }
            Console.WriteLine("Please enter your year of birth:");
            string birth = (Console.ReadLine());
            DateTime birthDate = DateTime.Parse(birth);
            int age = CalculateAge(birthDate);
            static int CalculateAge(DateTime birthDate)
            {
                DateTime today = DateTime.Today;
                int age = today.Year - birthDate.Year;
                return age;
            }
            Console.WriteLine("Please enter your city:");
            string city = Console.ReadLine();

            Console.WriteLine("Thanks, Here is your information:");
            Console.WriteLine("First name: " + Firstname);
            Console.WriteLine("Last name: " + Lastname);
            Console.WriteLine("Phone nember: " + Phonenum);
            Console.WriteLine("National code: " + Ncode);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("your uniqe code: " + Guid.NewGuid().ToString());
        }


    }
}

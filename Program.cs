using System.Security.Cryptography.X509Certificates;

namespace PersonalInformationForm
{
    enum Gender
    {
        Male = 0,
        Female = 1
    }
    internal class Program
    {
        public static bool IsValidPhoneNumber(string Phonenum)
        {

            while (Phonenum.All(char.IsDigit))
            {
                if (Phonenum.Length == 11 && Phonenum.StartsWith("09"))
                {
                    return true;
                }
                else if (Phonenum.Length == 10 && Phonenum.StartsWith("9"))
                {
                    Phonenum = "0" + Phonenum;
                    return true;
                }
                else if (Phonenum.Length == 13 && Phonenum.StartsWith("+98"))
                {
                    Phonenum = Phonenum.Replace("+98", "0");
                    return true;
                }
                else
                {
                    Console.WriteLine("Please enter valid phone number!");
                    return false;
                }
            }

            return true;
        }
       public static Gender GetGenderFromUser(string GenderIn)
        {
            while (true)
            { 

                if (GenderIn == "m")
                    return Gender.Male;
                else if (GenderIn == "f")
                    return Gender.Female;
                else
                    Console.WriteLine("Please enter valid Gender!");
            }
        }
        public static bool CheckGender(string genderstr)
        {
            if (Enum.TryParse(typeof(Gender), genderstr, true, out var gender))
            {
                return (Gender)gender == Gender.Male || (Gender)gender == Gender.Female;
            }
            else
                return false;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name:");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string Lastname = Console.ReadLine();
            Console.WriteLine("enter phone number");
            string phonenumber;
            for (; ; )
            {
                try
                {
                    phonenumber = Console.ReadLine() ?? throw new Exception("invalid phonenumber!");

                    if (IsValidPhoneNumber(phonenumber))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("you entered invalid phone number");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("you entered invalid phone number");
                    continue;
                }

            }
            Console.WriteLine("Please enter your national code:");
            int Ncode = int.Parse(Console.ReadLine());
            string GenderIn;
            Console.WriteLine("Please enter your gender: M->male , F->female");
            GenderIn = Console.ReadLine().ToLower() ?? string.Empty;
            Gender x = GetGenderFromUser(GenderIn);
            for (; ; )
            {
                if (x is not (Gender)0 or not (Gender)1)
                {
                    Console.WriteLine("Please enter your gender: M->male , F->female");
                    GenderIn = Console.ReadLine().ToLower() ?? string.Empty;
                    x = GetGenderFromUser(GenderIn);
                }
                else
                    break;
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
            Console.WriteLine("Phone nember: " + phonenumber);
            Console.WriteLine("National code: " + Ncode);
            Console.WriteLine("Gender: " + GenderIn);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("your uniqe code: " + Guid.NewGuid().ToString());
        }
 

}
}

namespace TypyDanychZadania_week2_exercise1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Typy danych week2, lesson 4, exercise 1- 5
            // zadanie 1
            string name;
            string fullName;
            int age;
            char sex;
            string pesel;
            int number;

            Console.WriteLine("Program ten zbiera następujące dane o pracownikach: imię, nazwisko, wiek, płeć, PESEL, numer pracownika");
            Console.ReadKey();

            // zadanie 2 
            char first = 'A';
            char second = 'B';
            char third = 'C';

            Console.WriteLine($"{third}, {second}, {first}");
            Console.ReadKey();

            // zadanie 3
            double a = 2;       //width 
            double b = 4;      //length
            double c;           // diagonal

            c = Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));

            Console.WriteLine($"Diagonal is: {c}");
            Console.ReadKey();

            // zadanie 4
            int number1;
            double number2;
            string text;

            number1 = 10;
            text = "Szkoła Dotneta";
            number2 = 12.5;

            Console.WriteLine("Do zmiennych przypisano następujące wartości:");
            Console.WriteLine("number1: {0}, number2: {1}, text: {2}", number1, number2, text);
            Console.ReadKey();

            // zadanie 5
            string yourName;
            string yourFullName;
            string phoneNumber;
            string mail;
            int height;
            double weight;
            string color;
            double seniority;

            Console.WriteLine("\nDzień dobry Nowy użytkowniku, podaj następujące dane:");
            Console.Write("imię: ");
            yourName = Console.ReadLine();

            Console.Write("nazwisko: ");
            yourFullName = Console.ReadLine();

            Console.Write("numer telefonu: ");
            phoneNumber = Console.ReadLine();

            Console.Write("mail (nazwa@nazwa.pl): ");
            mail = Console.ReadLine();

            Console.Write("wzrost (cm): ");
            height = int.Parse(Console.ReadLine());

            Console.Write("waga (kg): ");
            weight = double.Parse(Console.ReadLine());

            Console.Write("kolor oczu: ");
            color = Console.ReadLine();

            Console.Write("staż pracy (rok): ");
            seniority = double.Parse(Console.ReadLine());

            Console.WriteLine("\nPodałeś następujące dane: \nimię: {0}, \nnazwisko: {1}, \nnumer telefonu: {2}, \nmail: {3}, \nwzrost: {4}, \nwaga: {5}, \nkolor oczu: {6}, \nstaż pracy: {7}", yourName, yourFullName, phoneNumber, mail, height, weight, color, seniority);
            Console.ReadKey();

        }
    }
}
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            // Faça uma validação para que o usuário não consiga digitar um valor maior que 5 antes
            Console.Clear();
            Console.WriteLine("Calculator");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("-------------");
            Console.WriteLine("Enter the option:");
            string input = Console.ReadLine();
            short option;
            Console.WriteLine();

            if (!short.TryParse(input, out option) || option > 5 || option < 1)
            {
                Console.Clear();
                Console.WriteLine("Invalid option, please enter a number between 1 and 5.");
                Menu();
            }

            switch (option)
            {
                case 1:
                    Sum();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    Console.WriteLine("Thank you for using our services!");
                    Exit();
                    break;
                default:
                    Menu(); break;
            }
        }

        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = num1 + num2;
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            double result = num1 - num2;
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            double result = num1 * num2;
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            double result = num1 / num2;
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Exit()
        {
            Environment.Exit(0);
        }
    }
}

namespace lox;

class Program
{
    static void Main(string[] args)
    {
        while (true) {
           double firstvalue, secondvalue;
        string symbol;

        Console.WriteLine("Введите первое число:");
        firstvalue = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите действие:");
        symbol = Console.ReadLine();

        Console.WriteLine("Введите второе число:");
        secondvalue = double.Parse(Console.ReadLine());

        if (symbol == "+") {
            Console.WriteLine(firstvalue + secondvalue);
        }
        else if (symbol == "-") {
            Console.WriteLine(firstvalue - secondvalue);
        }
        else if (symbol == "*") {
            Console.WriteLine(firstvalue * secondvalue);
        }
        else if (symbol == "/") {
            if (firstvalue == 0 || secondvalue == 0) {
                Console.WriteLine("Неправильно");
            }
            else {
                Console.WriteLine(firstvalue / secondvalue);
            }
        }
        Console.ReadLine();
        Console.Clear(); 
        }
    }
}

int input = 0;
string variable = " ";
Console.WriteLine("Enter number between 1 and 1000:");
input = Console.Read();
if (1 >= input || input >= 1000)
    Console.WriteLine("Wrong input");
else
{
    variable = Fibonacci(input);
    Console.WriteLine(variable);
}
static string Fibonacci(int input)
{
    string result = "";
    int number1 = 0;
    int number2 = 1;
    int number3 = 0;

    while (number3 < input)
    {
        if (number3 < input)
        {
            number3 = number1 + number2;
            if (number3 <= input)
            {
                result += number3 + ";";
            }
            number1 = number2;
            number2 = number3;
        }
        else
        {
            continue;
        }
    }
    return result;
}
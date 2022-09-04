// Показать натуральные числа от M до N, N и M заданы

Console.Write("Введите первое число: ");
bool firstCheck = int.TryParse(Console.ReadLine(), out int firstNumber);

Console.Write("Введите второе число: ");
bool secondCheck = int.TryParse(Console.ReadLine(), out int secondNumber);

if(firstNumber < secondNumber && firstCheck && secondCheck) PrintNumber(firstNumber, secondNumber);
else if(firstNumber > secondNumber && firstCheck && secondCheck) PrintNumber(secondNumber, firstNumber);
else if (!firstCheck || !secondCheck) Console.WriteLine("Введено не число");
else Console.WriteLine("Числа равны");

void PrintNumber(int m, int n)
{
    Console.WriteLine(m);
    if (m < n) PrintNumber(++m, n);
}
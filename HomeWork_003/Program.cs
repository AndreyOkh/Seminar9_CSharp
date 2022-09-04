// Найти сумму элементов от M до N, N и M заданы

Console.Write("Введите первое число: ");
bool firstCheck = int.TryParse(Console.ReadLine(), out int firstNumber);

Console.Write("Введите второе число: ");
bool secondCheck = int.TryParse(Console.ReadLine(), out int secondNumber);

int sum = 0;
if(firstNumber < secondNumber && firstCheck && secondCheck) sum = SumNumber(firstNumber, secondNumber);
else if(firstNumber > secondNumber && firstCheck && secondCheck) sum = SumNumber(secondNumber, firstNumber);
else if (!firstCheck || !secondCheck) Console.WriteLine("Введено не число");
else Console.WriteLine("Числа равны");

Console.WriteLine(sum);

int SumNumber(int m, int n)
{
    if (m < n) m += SumNumber(++m, n);
    return m;
}
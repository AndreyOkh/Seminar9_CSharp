// Показать натуральные числа от N до 1, N задано

Console.Write("Введите число: ");
bool check = int.TryParse(Console.ReadLine(), out int n);
if(check) PrintNumber(n);
else Console.WriteLine("Введено не число");

void PrintNumber(int number)
{
    Console.WriteLine(number);
    if (number != 1) PrintNumber(--number);
}
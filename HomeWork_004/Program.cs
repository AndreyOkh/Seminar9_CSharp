// Написать программу вычисления функции Аккермана

int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");

Console.WriteLine(Akkerman(m, n));

int Akkerman(int m, int n)
{
    int result = 0;
    if(m == 0) return result = n + 1;
    if(m > 0 && n == 0) result = Akkerman(m - 1, 1);
    if (m > 0 && n > 0) result = Akkerman(m - 1, Akkerman(m, n - 1));
    return result;
}

int ReadInt(string message)
{
    Console.Write(message);
    int.TryParse(Console.ReadLine(), out int num);
    return num;
}
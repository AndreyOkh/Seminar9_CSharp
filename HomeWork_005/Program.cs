// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

int firstNumber = ReadInt("Введите первое число: ");
int secondNumber = ReadInt("Введите второе число: ");
int nNumber = ReadInt("Введите число N: ");

int[] array = new int[nNumber + 2];
array[0] = firstNumber;
array[1] = secondNumber;
FillArray(array);
Console.WriteLine(String.Join(" ", array));

void FillArray(int[] array, int position = 2)
{
    if(position < array.Length)
    {
        array[position] = array[position - 1] + array[position - 2];
        FillArray(array, ++position);
    }
    else return;
}

int ReadInt(string message)
{
    Console.Write(message);
    int.TryParse(Console.ReadLine(), out int num);
    return num;
}
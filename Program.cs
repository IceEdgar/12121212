Console.Clear();
int length1 = InputLengthArray("Введите длинну массива строк ", "Ошибка ввода данных!");
string[] array1 = new string[length1];
FillArray(array1, length1);
int length2 = SecondArrayLenght(array1);
string[] array2 = new string[length2];
SecondArray(array1, array2);
Console.WriteLine("__________________________________________________________________________________________________________________________________________");
if (array2.Length == 0) Console.WriteLine($"Изначальный массив строк [{String.Join(",", array1)}] не имеет строк, длина которых меньше, либо равна 3 символам");
else Console.WriteLine($"Изначальный массив = [{String.Join(",", array1)}] => [{String.Join(",", array2)}]");

static int InputLengthArray(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errormessage);
    }
}


void FillArray(string?[] array, int i)
{
    int index = 0;
    while (index < i)
    {
        Console.Write("Введите новую строку - ");
        array[index] = Console.ReadLine();
        index++;
    }
}

static int SecondArrayLenght(string[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3) count++;
    }
    return count;
}


void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
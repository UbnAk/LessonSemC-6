// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] CreatArray (int Length)
{
int [] array = new int [Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = ReadInt($"Введите {Length} чисел/числа: ");
}
    return array;
}

int ReadInt(string arg)
{
    System.Console.Write(arg);
    return int.Parse(Console.ReadLine());
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine(array[array.Length-1]+"]");
}

int SearchNumber(int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            count+=1;
        }
    }
    return count;
}

int Length = ReadInt("Сколько чисел вы собираетесь ввести?:");
int [] array = CreatArray(Length);
PrintArray(array);
System.Console.WriteLine($"Из {Length} введенных вами чисел/числа, вы ввели {SearchNumber(array)} чисел/числа больше 0:)");

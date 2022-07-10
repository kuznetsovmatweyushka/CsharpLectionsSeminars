/* Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
 */

/* Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество чисел: ");
int end = int.Parse(Console.ReadLine());
int Fibonacci(int m, int n, int end)
{
    if (end <= 1) return 0;
    if (end == 1) return m;
    if (end == 2) return n;
    return Fibonacci(m, n, end - 1) + Fibonacci(m, n, end - 2);
}
for (int i = 1; i <= end; i++)
{
    Console.Write(Fibonacci(3, n, i) + " ");
} */

/* Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с»
и «в». Покажите все слова, состоящие из n букв, которые можно построить из
букв этого алфавита. */

/* Console.WriteLine("Введите количество букв: ");
int n = int.Parse(Console.ReadLine());
string alphabet = "аисв";
string[] word;
string[] Words(string alphabet, int length)
{
    string[] result;
    if (length <= 0)
    {
        result = new string[1];
        result[0] = string.Empty;
        return result;
    }
    string[] resultOld = Words(alphabet, length - 1);

    result = new string[resultOld.Length * alphabet.Length];
    int z = 0;
    for (int i = 0; i < resultOld.Length; i++)
    {
        for (int j = 0; j < alphabet.Length; j++)
        {
            result[z] = resultOld[i] + alphabet[j];
            z++;
        }
    }
    return result;
}
word = Words(alphabet, n);
for (int i = 0; i < word.Length; i++)
{
    Console.Write(word[i] + " ");
} */

/* Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные
представления нескольких чисел (без разделителя). В массиве data хранится
информация о количестве бит, которые занимают числа из массива info.
Напишите программу, которая составит массив десятичных представлений чисел
массива data с учётом информации из массива info. */

/* int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int count = 0;
int mult;
for (int i = 0; i < info.Length; i++)
{
    mult = 0;
    for (int j = count; j < count + info[i]; j++)
    {
        mult += data[j] * (int)Math.Pow(2, info[i] - j + count - 1);
    }
    count += info[i];
    Console.WriteLine(mult);
} */

/* Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех
чисел на группы, так чтобы в одной группе все числа были взаимно просты (все
числа в группе друг на друга не делятся)? Найдите M при заданном N и получите
одно из разбиений на группы N ≤ 10²⁰. */

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

int[] tempArray = CreateArray(n);


void CreateRows(int[] tempArray)
{
    int[] arrayTemp = new int[tempArray.Length];
    int m = 1;
    int count = 0;
    int tempNumber = 0;
    int tempNumber2 = 0;
    int tempSwitch = 0;

    for (int i = 0; i < tempArray.Length; i++)
    {
        Array.Clear(arrayTemp);
        count = 0;
        if (tempArray[i] != 0)
        {
            arrayTemp[count] = tempArray[i];
            tempNumber2 = tempArray[i];

            for (int j = i; j < tempArray.Length; j++)
            {
                if (tempArray[j] % tempNumber2 != 0 || tempArray[j] / tempNumber2 == 1)
                {
                    tempSwitch = 0;
                    tempNumber = tempArray[j];
                    for (int k = 0; k < count; k++)
                    {
                        if (tempNumber % arrayTemp[k] == 0) tempSwitch++;
                    }
                    if (tempSwitch == 0)
                    {
                        arrayTemp[count] = tempArray[j];
                        count++;
                        tempArray[j] = 0;
                    }
                }
            }
            Console.WriteLine($"Группа {m++}: {PrintIntArray(arrayTemp)}");
        }
    }
}

int[] CreateArray(int n)
{
    int[] temp = new int[n];
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = i + 1;
    }
    return temp;
}

string PrintIntArray(int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0) result += $"{array[i],1} ";
    }
    return result;
}

CreateRows(tempArray);
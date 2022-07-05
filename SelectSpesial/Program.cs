Console.WriteLine("Введите слова/числа: ");
string input = Console.ReadLine();
string[] array = input.Split('.', ' ', ',');
void SelectStrings(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    Console.WriteLine("Ваш массив состоящий из элементов <= 3 символов: ");
    string[] selectedarr = new string[count];
    for (int k = 0; k < array.Length; k++)
    {
        int n = 0;
        if (array[k].Length <= 3)
        {
            selectedarr[n] = array[k];
            Console.Write($"{selectedarr[n]}" + " ");
        }
    }
}
SelectStrings(array);
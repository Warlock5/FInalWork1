string[] array1 = new string[] {"Так", "то", "оно", "так", "так", "то", "оно",
                                "конечно", "верно", ",а", "вот", "коснись", "чего,",
                                "так", "вот", "тебе", "и", "пожалуйста"};
string[] array2 = new string[array1.Length];

void SortArray(string[] array1, string[] array2)
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

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SortArray(array1, array2);
ShowArray(array2);


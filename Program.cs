void ShowOldArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] +" ");
    Console.WriteLine();
}

void FindThree(string[] array, string[] newarray)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        newarray[count] = array[i];
        count++;
    }
}
void ShowNewArray(string[] newarray)
{
    for(int i = 0; i < newarray.Length; i++)
        Console.Write(newarray[i] +" ");
}

string[] array = new string[] { "Sun", "Paris", "22", "0", "Hello", "++", "world" };
ShowOldArray(array);
string[] newArray = new string[array.Length];
FindThree(array, newArray);
ShowNewArray(newArray);
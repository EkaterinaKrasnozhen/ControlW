//Формируем массив строк, который меньше или равен 3 символам
string[] arrString = { "Имя", "Номер", "^)", "45" };
string[] CutStringNumElement(string[] s)
{
    int count = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i].Length <= 3)
            count++;
    }
    string[] s2 = new string[count];
    int index = 0;
    int j = 0;
    while (j < s2.Length)
    {
        if (s[j].Length <= 3)
        {
            s2[index] = s[j];
            index++;
            j++;
        }
        else j++;
    }
    return s2;
}
void PrintArray(string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < str.Length - 1) Console.Write(str[i] + ", ");
        else Console.Write(str[i] + "]");
    }
}
string[] result = CutStringNumElement(arrString);
PrintArray(arrString);
Console.Write(" -> ");
PrintArray(result);
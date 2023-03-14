// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинная которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
// 

string[] TextInput(string messege)
{
    Console.WriteLine(messege);
    string text = Console.ReadLine()!.Replace(" ", "").Replace("\"", "");
    
    return text.Split(",");
}

void ArrayStr(string[] array)
{
    int sizeArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
        sizeArray++;
        }
    }

    string[] arrayNew = new string[sizeArray];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayNew[j] = array[i];
            j++;         
        }
    }
    Console.Write("[" + string.Join(", ", arrayNew) + "]");
}
    

string[] strArr = TextInput("Введите массив из строк через запятую");
ArrayStr(strArr);



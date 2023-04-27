// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

HomeWork();

void HomeWork()
{
    string[] array = GetRandomStringArray(arrLength());
    PrintArray(array);
    System.Console.WriteLine("В массиве имеются следующие строки, длиною менее 3");
    PrintArray(NewStringArray(array));
}

int arrLength()
{
    int length;
    while (true)
    {
        Console.Write("Введите длину массива: ");
        bool isNumber = int.TryParse(Console.ReadLine(), out length);
        if (isNumber && length > 0)
        {
            Console.WriteLine("Принято!");
            break;
        }
        else
        {
            Console.WriteLine("Необходимо указать число больше 0.");
            continue;
        }
    }
    return length;

}

string[] GetRandomStringArray(int arrayLength)
{
    char[] symbol = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
    Random rand = new Random();
    string[] wordsArray = new string[arrayLength];
    string word = "";

    for (int i = 0; i < arrayLength; i++)
    {
        for (int j = 0; j < rand.Next(1, 10); j++)
        {
            word += symbol[rand.Next(0, arrayLength)];

        }
        wordsArray[i] = word;
        word = "";
    }
    return wordsArray;
}

void PrintArray(string[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

string[] NewStringArray(string[] arr)
{
    string[] result = new string[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = arr[i];
        }
    }
    return result;
}




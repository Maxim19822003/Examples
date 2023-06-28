// Вид 1
/*
void Method1()
{
Console.WriteLine("Author ...");
}
Method1();
*/
// Вид 2
//void Method2(string msg)//где void ключевое слово, 
//дальше идентификатор, в скобках
//указаны какие-то аргументы.
{
    {

    }
}
//Method2("Text msg");

/*void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
    Console.WriteLine(msg);
    i++;
    }
}
*/
//Method21("Text", 4);//- метод вызывает Текст, после запятой 
//указано количество
//вызовов, в нашем случае 4
//Method21(count: 4, msg: "new text");

//Вид 3
/*
int Method3()//- не принимает никакие аргументы
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/

//Вид 4
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "shalom");
Console.WriteLine(res);
*/
/*
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
//Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
*/

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

/*string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
*/
// string = "qwerty"
//           012345
// s[3] // r
/*
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result +
        $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'с', 'С');
Console.WriteLine(newText);
*/
/*
int[] arr = {8,7,4,3,6,5,3,9,2};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i=0;i<count;i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void selectionSort(int[] array)
{
    for (int i = 0;i < array.Length-1;i++)
    {
        int minPosition = i;
        for (int j=i+1;j<array.Length;j++)
        {
            if(array[j]<array[minPosition]) minPosition=j;
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
selectionSort(arr);
PrintArray(arr);
*/

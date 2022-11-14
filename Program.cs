/* программа, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами. */

Console.Clear();
string[] a = new string[6] {"1234", "1567", "-2", "Russia", "Kazan", ":-)"}; 
string[] b = new string[a.Length];     

void collection(string[] a, string[] b)
{
    int n = 0;
    for (int i = 0; i < a.Length; i++)
    {
    if(a[i].Length <= 3)
        {
        b[n] = a[i];
        n++;
        }
    }
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
collection(a, b);
PrintArray(b);
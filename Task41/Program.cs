// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateArray(){
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array){

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Clear();

int [] MyArray = CreateArray();
int chislo = 0;

for (int i = 0; i < MyArray.Length; i++)
{
    if (MyArray[i] > 0) chislo = chislo + 1;
}

ShowArray(MyArray);
if (chislo == 0) Console.WriteLine($"в указанном массиве нет чисел больше нуля");
else
Console.WriteLine($"в указанном массиве {chislo} чисел большое нуля");

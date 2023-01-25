string[] arrayInitial = { "Russia", "Denmark", "UAE", "Germany", "USA", "UK" };

//Метод определения размера результирующего массива
int GetResultedArraySize(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            size++;
        }
    };
    return size;
}

//Метод копирования необходимых элементов из заданного массива в  результирующий
string[] GetResultedArray(string[] arrayInit, string[] arrayRes)
{
    int j = 0;
    for (int i = 0; i < arrayInit.Length; i++)
    {
        if (arrayInit[i].Length <= 3)
        {
            arrayRes[j] = arrayInit[i];
            j++;
        }
    };
    return arrayRes;
};

//Метод вывода результирующего массива в консоль
void PrintArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");

}
Console.WriteLine();
}

int arrResSize = GetResultedArraySize(arrayInitial);
string[] arrayResulted = new string[arrResSize];
arrayResulted = GetResultedArray(arrayInitial, arrayResulted);
PrintArray(arrayResulted);

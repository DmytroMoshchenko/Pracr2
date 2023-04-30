// Приклад масиву 
int[] arr = { 5, 0, -2, 7, -9, 0, 4, 3 };

// Добуток елементів масиву з парними номерами 
int product = 1;
for (int i = 0; i < arr.Length; i += 2)
{
    product *= arr[i];
}
Console.WriteLine("Добуток елементів масиву з парними номерами: {0}", product);

// Сума елементів масиву, розташованих між першим і останнім нульовим елементами
int sum = 0;
int firstZeroIndex = -1;
int lastZeroIndex = -1;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == 0 && firstZeroIndex == -1)
    {
        firstZeroIndex = i;
    }
    else if (arr[i] == 0 && firstZeroIndex != -1)
    {
        lastZeroIndex = i;
    }
}
for (int i = firstZeroIndex + 1; i < lastZeroIndex; i++)
{
    sum += arr[i];
}
Console.WriteLine("Сума елементів масиву, розташованих між першим і останнім нульовим елементами: {0}", sum);

// Перетворення масиву таким чином, щоб спочатку розташовувалися всі додатні елементи, а потім − усі від’ємні (елементи, рівні 0, вважати додатними)
int[] transformedArr = new int[arr.Length];
int index = 0;

// Додатні елементи 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >= 0)
    {
        transformedArr[index] = arr[i];
        index++;
    }
}

// Від'ємні елементи 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        transformedArr[index] = arr[i];
        index++;
    }
}

Console.WriteLine("Перетворений масив:");
foreach (int item in transformedArr)
{
    Console.Write("{0} ", item);
}
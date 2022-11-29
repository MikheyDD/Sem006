// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// 5 => 0 1 1 2 3 
PrintFnibancciNum(10);
void PrintFnibancciNum(int count)
{
    int currentNum = 0;
    int currentCount = 2;
    int firstNum = 0;
    int secondNum = 1;
    Console.Write("0, 1, ");
    while (currentCount != count)
    {
        currentNum = firstNum + secondNum;
        firstNum = secondNum;
        secondNum = currentNum;
        Console.Write($"{currentNum}, ");
        currentCount++;

    }
}
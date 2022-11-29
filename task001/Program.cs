// Метод вывода двух чисел, пример
(int,int) GetTwoNums(params int[] array)
{
    int max = array[0];
    int min = array[0];
    for(int i = 1; i<array.Length;i++)
    {
        if(array[i]>max)
        {
            max = array[i];
        }
        if(array[i]<min)
        {
            min = array[i];
        }
    }
    return(min,max);
}
var result = GetTwoNums(1,2,3,4,5,6);
System.Console.WriteLine(result.Item1); // вывод одной переменной
Console.WriteLine(result); // вывод обеих
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
/*double formula(int A, int B)
{
    int  result=1;
    for(int i = 0; i < B; i++)
{
     result *= A;
}
return result;
}
Console.WriteLine("Enter A: ");
int A1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter B: ");
int B1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A в степени В равно{formula(A1,B1)}");
*/
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*int Number(int num)
{
int count=0;
int sum=0;
    while(num!=0)
    {
        sum=sum+num%10;
        num=num/10;
        count++;
    }
    return  sum;
}
Console.Write("Введите число ");
int a=Convert.ToInt32(Console.ReadLine());
int result=Number(a);
Console.WriteLine($"Сумма цифр числа равна {Number(a)}");
*/
//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*int [] CreateArray(int size)
{
    int[] array=new int [size];
    for(int i=0; i<size;i++)
    {
       Console.Write("Введите элемент массива {0}: ", i);
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int n=0;n<array.Length;n++)
    {
        Console.Write(array[n]+" ");
        Console.WriteLine();
    }
}
Console.WriteLine("Введите колличество эллементов массива: ");
int  Length = Convert.ToInt32(Console.ReadLine());
int [] newArray=CreateArray( Length);
ShowArray(CreateArray( Length));
*/

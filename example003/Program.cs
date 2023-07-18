Console.Clear();
int[] array = new int[8];
Random myRandom = new Random();
 Console.WriteLine("Введите число 1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int x2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3:");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 4:");
int x4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 5:");
int x5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 6:");
int x6 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 7:");
int x7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 8:");
int x8 = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 8);
Console.Write("{0} ", array[i]);
            }

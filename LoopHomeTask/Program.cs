﻿// Task1
//1.Verilmish ededin 2 quvveti olub olmadigini tapan alqoritm
//(Meselen 8 , 4, 16 ve s. 2-nin quvvetidir amma 12  2-nin quvveti deyil) 


//int num = int.Parse(Console.ReadLine());

//while (true)
//{
//    if (num % 2 == 0 && num / 2 >= 2)num /= 2;


//    else if(num % 2 == 1)
//    {
//        Console.WriteLine("2 quvveti deyil");
//        break;
//    }


//    if (num / 2 == 1)
//    {
//        Console.WriteLine("2 quvvetidir");
//        break;

//    }

//}








//Task2
//1-dən N-ə qədər ədədlər arasında neçə digit rəqəmi var?


int N=int.Parse(Console.ReadLine());
int digit=int.Parse(Console.ReadLine());
int count = 1;
int num;

for(int i = 10; i <= N; i++)
{
    num = i;
    while (num / 10 > 0)
    {
        if (num% 10 == digit)
        {
            count++;
        }
        num = (num - num % 10) / 10;

    }
    if (num == digit) count++;
}
Console.WriteLine(count);





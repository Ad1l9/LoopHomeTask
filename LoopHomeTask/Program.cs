// Task1
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


//int N=int.Parse(Console.ReadLine());
//int digit=int.Parse(Console.ReadLine());
//int count = 1;
//int num;

//for(int i = 10; i <= N; i++)
//{
//    num = i;
//    while (num / 10 > 0)
//    {
//        if (num% 10 == digit)
//        {
//            count++;
//        }
//        num = (num - num % 10) / 10;

//    }
//    if (num == digit) count++;
//}
//Console.WriteLine(count);







//Task3

//Ədədin mükəmməl olub-olmamasını yoxlayan proqram yazın.
//Əgər mükəmməldirsə ekrana true, əks halda false çıxsın.

//int num=int.Parse(Console.ReadLine());
//int sum = 0;

//for(int i=1; i<num; i++)
//{
//    if (num % i == 0) sum += i;
//}
//if(sum == num) Console.WriteLine(true);
//else Console.WriteLine(false);






//Task4

//Daxil edilən N ədədinin 2-lik say sistemindəki qarşılığını göstərən proqram yazın.


//int N = int.Parse(Console.ReadLine());
//string binaryVersion = "";

//while (N/2!=0)
//{
//    binaryVersion = N % 2 + binaryVersion;
//    N = (N - N % 2) / 2;
//}
//Console.WriteLine("1"+binaryVersion);








//Task5

//Daxil edilən N ədədinin ən böyük və ən kiçik rəqəmlərinin hasilini ekrana çıxaran proqram yazın.


int N = int.Parse(Console.ReadLine());

int less=N%10, greater=N%10;

while(N > 9)
{
    N-=N%10;
    N /= 10;
    if(N%10 > greater) greater = N % 10;
    if(N%10 < less) less = N % 10;
}
Console.WriteLine($"greater({greater})+less({less})={greater+less}");



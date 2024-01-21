int n = int.Parse(Console.ReadLine());  
int m = int.Parse(Console.ReadLine());  
int y = int.Parse(Console.ReadLine());

int count = 0;
double percent = n * 0.50d;

while (n >= m)
{
    count++;
    n -= m;
    if (n == percent && y != 0)
    {
        n /= y; 
    }

}
Console.WriteLine(n);
Console.WriteLine(count);

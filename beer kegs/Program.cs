int kegsCount = int.Parse(Console.ReadLine());
string biggestKegModel = "";
double biggestKeg = 0;

for (int i = 0; i < kegsCount; i++)
{ 
string kegModel = Console.ReadLine();
double kegRadius = double.Parse(Console.ReadLine());
int kegHeight = int.Parse(Console.ReadLine());

    double volume = Math.PI * (kegRadius * kegRadius) * kegHeight;

    if (volume > biggestKeg)
    { 
      biggestKeg = volume;
        biggestKegModel = kegModel;
    }
}
Console.WriteLine(biggestKegModel);
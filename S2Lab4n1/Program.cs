using S2Lab4n1;

Car lightweightCar = new Car(220, 135, "GTR", "green");

lightweightCar.Write();

Console.WriteLine("бажаєте змінити колір yes=1 no=0");
int x;
x = int.Parse(Console.ReadLine());

if (x == 1)
{
    Console.WriteLine("яка нова колір");
    string color = Console.ReadLine();
    lightweightCar.ChangeColor(lightweightCar, color);
}

Console.WriteLine("бажаєте змінити марку yes=1 no=0");
int y;
y = int.Parse(Console.ReadLine());

if (y == 1)
{
    Console.WriteLine("яка нова марка");
    string marka = Console.ReadLine();
    lightweightCar.ChangeBrend(lightweightCar, marka);
}

Console.WriteLine("бажаєте додати грузопідйомність yes=1 no=0");
int z;
z = int.Parse(Console.ReadLine());
if(z == 1)
{
    Console.WriteLine("скільки додати?");
    int plusLoadCapacity;
    plusLoadCapacity = int.Parse(Console.ReadLine());
    lightweightCar.ChangeLoadCapacity(lightweightCar, plusLoadCapacity);
}
Console.WriteLine("бажаєте змінити вагу?");
int c;
c = int.Parse(Console.ReadLine());
if (c == 1)
{
    Console.WriteLine("як змынити вагу");
    int newweight;
    newweight = int.Parse(Console.ReadLine());
    lightweightCar.ChangeWeight(lightweightCar, newweight);
}
lightweightCar.Write();
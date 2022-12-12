/*
int FindQuandrant(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input the first coordinate : x = ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the first coordinate : y = ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadNum = FindQuandrant(xA, yA);

Console.WriteLine($"The point A ({xA},{yA}) is on the {quadNum} quadrant.");
*/

// Задача: Программа которая выведет значения x и y, если укажут четверть.
/*
void Range(int quadrant)
{
    if(quadrant == 1) 
    Console.Write("Первая четверть, значит кординаты x > 0 и координаты y > 0 ");
    if(quadrant == 2) 
    Console.Write("Вторая четверть, значит кординаты x < 0 и координаты y > 0 ");
    if(quadrant == 3) 
    Console.Write("Третья четверть, значит кординаты x < 0 и координаты y < 0 ");
    if(quadrant == 4) 
    Console.Write("Четвертая четверть, значит кординаты x > 0 и координаты y < 0 ");
}

Console.Write("Введите номер четверти : ");
int result = Convert.ToInt32(Console.ReadLine());
Range(result);
*/

// Задача: Программа, которая на вход принимает координаты двух точек и находит
// расстояние между ними.
/*

double Length(double coorPoint1x, double coorPoint1y, double coorPoint2x, double coorPoint2y)
{
    double coorPoint3x = coorPoint2x;
    double coorPoint3y = coorPoint1y;
    double lenAC = coorPoint1x - coorPoint3x;
    double lenAB = coorPoint2y - coorPoint3y;
    double quad1 = Math.Pow(lenAC, 2);
    double quad2 = Math.Pow(lenAB, 2);
    double result = Math.Sqrt(quad1 + quad2);
    return result;
}

Console.Write("Введите координаты Точки A по оси абцисс  : ");
double point1X = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Точки A по оси ординат  : ");
double point1Y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Точки B по оси абцисс  : ");
double point2X = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Точки B по оси ординат  : ");
double point2Y = Convert.ToDouble(Console.ReadLine());

double len = Length(point1X, point1Y, point2X, point2Y);
Console.WriteLine($"Расстояние между задаными точками равно : {len} ");

*/

// Задача :  Программа принимает на вход число (N) и выдает ряд квадратов чисел от 1 до N
/*

void Quad(double N)
{
    double count = 1;
    while(count <= N)
    {
    double result = Math.Pow(count, 2);
    Console.Write(result + " ");
    count++;
    }
}

Console.Write("Input a number : ");
double num = Convert.ToDouble(Console.ReadLine());

Quad(num);
*/

// Задача Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.


//bool Pal(int num)

/*
int num = 678678787;
int count = 0;
while(num > 0)
{
    num = num / 10;
    count++;
}
Console.WriteLine(count);
*/
int number = 123211;
int num = number;
string result = "";
while(num > 0)
{
    int a = num % 10; 
    num = num / 10;   
    result = result + a;
}

int y = int.Parse(result);

if(y == number)
Console.WriteLine("паландрий");
else
Console.WriteLine("не паландрий");




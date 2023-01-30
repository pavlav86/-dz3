/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
double GetLength(double[] pointA, double[] pointB)
{
  double result = Math.Sqrt((pointA[0] - pointB[0]) * (pointA[0] - pointB[0]) 
 + (pointA[1] - pointB[1]) * (pointA[1] - pointB[1]) 
 + (pointA[2] - pointB[2]) * (pointA[2] - pointB[2]));
  return result;
}

double[] GetPoint()
{
  double[] point = new double[3];

  point[0] = GetNumber("Enter point X");
  point[1] = GetNumber("Enter point Y");
  point[2] = GetNumber("Enter point Z");
  return point;
}

int GetNumber(string text)
{
  Console.WriteLine(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

Console. WriteLine("Enter point A: ");
double[] pointA = GetPoint();
Console. WriteLine("Enter point B: ");
double[] pointB = GetPoint();

double length = GetLength(pointA, pointB);

Console.WriteLine($"Расстояние между точками: {Math.Round(length,2)}");

///Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void GetCube(int n)
{
  int i = 1;
  int num = 0;
  
  while (i < n)
  {
    num = (int) Math.Pow(i, 3);
    Console.Write(num + ", ");
    i++;
  }
  Console.WriteLine(Math.Pow(i, 3));
}

int GetNumber(string text)
{
  Console.WriteLine(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int N = GetNumber("Введите число N");

GetCube(N);

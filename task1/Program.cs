// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
string IsPalindrome(int number)
{
  int i = 0;
  char[] arr = number.ToString().ToCharArray();
  while (i < arr.Length/2)
  {
    if ( arr[i] != arr[arr.Length - 1 - i])
    {
      return "NO";
    }
    i++;
  }
  return "YES";
}

int GetNumber(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int num = GetNumber("Enter your number: ");

Console.Write("Is it Palindrome?  " + IsPalindrome(num));

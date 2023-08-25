// See https://aka.ms/new-console-template for more information
char[] ünlü = new char[] {'e','E','u','U','i','I','o','O','a','A'};
Console.WriteLine("Please enter a word/words: ");
string s = Console.ReadLine();
string[] arr = s.Split(" ");
foreach (string str in arr)
{
    int i = 0;
    for (int j = 0; j < str.Length-1; j++)
    {
        if (!ünlü.Contains(str[j])&& !ünlü.Contains(str[j+1]))
        {
            i += 1;
        }

    }
    if (i>0)
    {
        Console.Write("False ");
    }
    else
    {
        Console.Write("True ");
    }
}
Console.WriteLine("Введите строку: ");
string s = Console.ReadLine();
bool Reverse(string str)
{
    bool result = true;
    str = str.ToLower();
    str = str.Replace(" ", "");
    char[] charArray = str.ToCharArray();
    string reverseStr = String.Empty;
    for (int i = charArray.Length-1; i>-1; i--)
    {
        reverseStr += charArray[i];
    }
    if (reverseStr == str)
    {
        result = true;
    }
    else
        result = false;
    return result;
}
bool result = Reverse(s);
if (result)
    Console.WriteLine($"{s} - палиндром");
else
    Console.WriteLine($"{s} - не палиндром");

Console.WriteLine("Введите числа: ");
Console.WriteLine("пример: 1,2,3,4");
string sNumbers = Console.ReadLine();
string[] arNumbers = sNumbers.Split(',');
List<int> nums = new List<int>();
int oneNum;
foreach (string s in arNumbers)
{
    if (Int32.TryParse(s, out oneNum))
        nums.Add(oneNum);
}
int[] numbers = nums.ToArray();
int flag = 1;
int Plus(int[] numbers)
{
    int[] odd = new int[numbers.Length];
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if ((numbers[i] % 2) != 0)
        {
            if ((flag % 2) == 0)
            {
                odd[i] = numbers[i];
                flag++;
            }
            else
                flag++;
            continue;
        }
    }
    foreach (var item in odd)
    {
        result += Math.Abs(item);
    }
    return result;
}
int result = Plus(numbers);
Console.WriteLine(result.ToString());


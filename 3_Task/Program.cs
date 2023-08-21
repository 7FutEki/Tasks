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

int[] x = new int[numbers.Length];
x = BubbleSort(numbers);
foreach (var item in x)
{
    Console.WriteLine(item);
}
static int[] BubbleSort(int[] mas)
{
    int temp;
    for (int i = 0; i < mas.Length; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] > mas[j])
            {
                temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
            }
        }
    }
    return mas;
}
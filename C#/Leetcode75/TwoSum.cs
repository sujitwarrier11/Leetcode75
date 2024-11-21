namespace Leetcode75;

public class TwoSum : ILeetcode
{
    public int[] Numbers { get; set; }
    public int Sum { get; set; }
    public TwoSum(int[] numbers, int sum)
    {
        Numbers = numbers;
        Sum = sum;
    }

    private void TwoSumWithDuplicateEntries()
    {
        var numberMap = Numbers.ToDictionary(x => x, x => x);
        for (var i = 0; i< Numbers.Length; i++)
        {
            var diff = Sum - Numbers[i];
            if (numberMap.ContainsKey(diff))
            {
                Console.WriteLine($"Numbers found: {Numbers[i]} & {diff}.");
                break;
            }
        }
    }

    private void TwoSumWithDuplicates()
    {
        int i = 0;
        int j = Numbers.Length -1;
        Numbers = Numbers.OrderBy(x => i).ToArray();
        while (i < j)
        {
            var currSum = Numbers[i] + Numbers[j];
            if (currSum == Sum)
            {
                Console.WriteLine($"Numbers found: {Numbers[i]} & {Numbers[j]}");
                break;
            }
            if (currSum > Sum){
                j--;
                continue;
            }
            i++;
        }
    }
    
    public void RunSolution()
    {
        TwoSumWithDuplicates();
    }
}
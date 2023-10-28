CyclicRotation cyclicRotation = new CyclicRotation();
OddOccurrencesInArray oddOccurrencesInArray = new OddOccurrencesInArray();
int[] arr = { 3, 8, 9, 7, 6 };
int[] arr2 = { 9, 3, 9, 3, 9, 7, 9 };


var test1 = cyclicRotation.Solution(arr, 3);
foreach (var number in test1)
{
    Console.WriteLine($"{number},");
}

var test2 = oddOccurrencesInArray.DictSolution(arr2);
var test3 = oddOccurrencesInArray.XORSolution(arr2);
Console.WriteLine($"\n {test2}");
Console.WriteLine($"\n {test3}");

class CyclicRotation
{
    public int[] Solution(int[] A, int K)
    {
        Array.Reverse(A);
        Array.Reverse(A, 0, K);
        Array.Reverse(A, K, A.Length - K);

        return A;
    }
}

class OddOccurrencesInArray
{
    public int DictSolution(int[] A)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach (var value in A)
        {
            if (counts.ContainsKey(value))
            {
                counts[value]++;
            }
            else
            {
                counts[value] = 1;
            }
        }

        foreach (var pair in counts)
        {
            if (pair.Value == 1)
            {
                return pair.Key;
            }
        }

        return 0;
    }
    //Faster than the dicts Solution
    public int XORSolution(int[] A)
    {
        int result = 0;

        foreach (var value in A)
        {
            result ^= value;
        }

        return result;
    }
}
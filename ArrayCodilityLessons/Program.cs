CyclicRotation test = new CyclicRotation();
int[] arr = { 3, 8, 9, 7, 6 };
var test2 = test.Solution(arr, 3);
foreach (var number in test2)
{
    Console.Write(number);
}
class CyclicRotation { 
    public int[] Solution(int[] A, int K)
    { 
        Array.Reverse(A);
        Array.Reverse(A, 0, K);
        Array.Reverse(A, K, A.Length - K);

        return A;
    }
}
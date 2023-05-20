using System.Runtime.CompilerServices;

namespace CodilityTasks.Problems
{
    public class TapeEquilibrium
    {
        public static int Solution(int[] A)
        {
            var diffSet = false;
            var lowestDiff = 0;
            var leftPart = 0;
            var sum = A.Aggregate((t, n) => t + n);

            for (int i = 0; i < A.Length - 1; i++)
            {
                leftPart += A[i];
                var rightPart = sum - leftPart;

                var diff = Math.Abs(leftPart - rightPart);

                if (diffSet == false || diff < lowestDiff)
                {
                    lowestDiff = diff;
                    diffSet = true;
                }
            }

            return lowestDiff;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTasks.Problems
{
    public class BinaryGap
    {
        public static int Solution(int N)
        {
            var binary = Convert.ToString(N, 2);

            var slices = new HashSet<string>();

            for (int i = 0; i < binary.Length; i++)
            {
                var number = binary[i];

                var slice = new StringBuilder();

                if (number == '1')
                {
                    var innerIndex = i + 1;

                    // Start a slice
                    while (innerIndex < binary.Length && binary[innerIndex] == '0')
                    {
                        slice.Append('0');

                        innerIndex++;
                    }

                    // Close a slice
                    if (slice.Length > 0 && innerIndex < binary.Length && binary[innerIndex] == '1')
                    {
                        slices.Add(slice.ToString());

                        i = innerIndex - 1;
                    }
                }
            }

            return slices.Max()?.Length ?? 0;
        }
    }
}

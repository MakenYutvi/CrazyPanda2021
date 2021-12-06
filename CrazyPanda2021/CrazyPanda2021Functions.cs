using System.Collections.Generic;

namespace CrazyPanda2021
{
    public class CrazyPanda2021Functions
    {
        public void FindElementsForSum(List<uint> list, ulong sum, out int start, out int end)
        {
            int countOfElement = list.Count;
            start = 0;
            end = 0;
            ulong currentSum = 0;
            bool IsMatch = false;
            for (int i = 0; i < countOfElement; i++)
            {
                currentSum = 0;
                for (int j = i; j < countOfElement; j++)
                {
                    currentSum += list[j];
                    if (currentSum >= sum)
                    {
                        end = j + 1;
                        break;
                    }
                }
                if (currentSum == sum)
                {
                    start = i;
                    IsMatch = true;
                    break;
                }               
            }
            if (!IsMatch)
            {
                start = 0;
                end = 0;
            }

        }
    }
}

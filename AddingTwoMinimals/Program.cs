using System;
using System.Linq;

namespace AddingTwoMinimals
{
    public class Program
    {
        const int MaxArrayLen = 10000;
        static void Main(string[] args)
        {
        }

        public static int GetMinimalsSum(int[] array)
        {
            try
            {
                if (array.Length > MaxArrayLen)
                {
                    throw new ArgumentOutOfRangeException("array", $"Array length is too long. It can't be bigger than {MaxArrayLen}");
                }

                int min = array.Min();
                if (array.Where(x => x == min).ToArray().Length > 1)
                {
                    return min * 2;
                }
                else
                {
                    return min + array.Where(x => x != min).Min();
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Array is null. {ex.Message}");
                throw;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Array length is too long. {ex.Message}");
                throw;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Array is empty or it length is 1. {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class cache
    {
        public int value;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, cache> dic = new Dictionary<int, cache>();



            if(dic.ContainsKey(1))
            {
                Console.WriteLine("i m in 1");
            }
            Console.WriteLine("Hello World!");
            int[] nums = { 1, 11, 2, 3, 15 };
            List<int> ls = new List<int>();
            ls.Add(5);
            ls.Add(8);
            ls.Remove(5);

            foreach(var a in ls)
            {
                Console.WriteLine(a);
            }
            Program p = new Program();
          //  p.SubArrays(nums, 10);
            Console.ReadLine();
        }

        public int SubArrays(int[] nums,int k)
        {
            int subArr = 0;
            for(int i=0;i<nums.Length;i++)
            {
                int sum = 0;
                if(nums[i]<k)
                {
                    sum = nums[i];
                    Console.WriteLine(sum);
                    subArr++;
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if(sum+nums[j]<k)
                        {
                            Console.WriteLine("{0} {1}", sum, nums[j]);
                            sum = sum + nums[j];
                           
                            subArr++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

               
            }

            return subArr;
        }
    }
}

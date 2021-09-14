using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp565
{
    public class Palindrome
    {
        public Palindrome()
        {

        }

        public bool IsPalindrome(string str)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            for(int i=0;i<str.Length;i++)
            {
                if(!map.ContainsKey(str[i]))
                {
                    map.Add(str[i], 1);
                }
                else
                {
                    map[str[i]]++;
                }
            }

            int count = 0;
            foreach(KeyValuePair<char,int> key in map)
            {
                count += key.Value%2;

            }

            if(count>1)
            {
                return false;

            }
            else
            {
                return true;
            }
        }
    }
}

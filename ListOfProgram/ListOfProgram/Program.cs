namespace ListOfProgram
{


    public class Solution
    {

        static void Main(string[] args)
        {
            SayHello("Ajay");
            //int res = LengthOfLongestSubstring("pwwkew");
            int res = LengthOfLongestSubstring("12345");
            Console.WriteLine(res);
            Console.ReadKey();


            int LengthOfLongestSubstring(string s)
            {
                int lenth = 0;
                int i = 0; //left pointer
                Dictionary<char, int> seen = new();
                int stringMaxLenth = s.Length;
                for (int j = i; j < stringMaxLenth; j++)
                {
                    char c = s[j];
                    if (seen.ContainsKey(c) && seen[c] >= i)
                    {
                        i = seen[c] + 1;
                    }
                    else
                    {
                        lenth = Math.Max(lenth, j - i + 1);
                    }
                    if (!seen.ContainsKey(c))
                    {
                        seen.Add(c, j);
                    }
                    else
                        seen[c] = j;
                }
                return lenth;
            }
        }
        public static void SayHello(string str)
        {
            Console.WriteLine("Hello how are you {0}",str);
        }

    }
}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //     int res=   LengthOfLongestSubstring("pwwkew");
    //        Console.WriteLine(res);
    //        Console.ReadKey();
    //    }

    //        //public static int LengthOfLongestSubstring(string s)
    //        //{
    //        //    string result = string.Empty;

    //        //        if (!result.Contains(s))
    //        //        {
    //        //            result += s;
    //        //        }

    //        //    return result.Length;
    //        //}



    //}

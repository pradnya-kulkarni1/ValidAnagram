namespace ValidAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter first string");
            String firstOne = Console.ReadLine();
            Console.WriteLine("Enter second string to check same letters as the first one!");
            String secondOne = Console.ReadLine();
            Boolean YesItsAnagram = IsAnagram(firstOne, secondOne);
            Console.WriteLine("Output:" + YesItsAnagram);
        }
        static Boolean IsAnagram(String s, String t)
        {

            Boolean result = false;
            if (!(s.Length == t.Length)) return false;
            String tcheck = t;
            for(int i=0; i < s.Length; i++)
            {
                for(int j=0; j < tcheck.Length; j++)
                {
                    String sChar = s[i].ToString();
                    String tChar = tcheck[j].ToString();
                    
                    
                        if (sChar.Equals(tChar))
                        {
                        try
                        {
                            tcheck = tcheck.Remove(j, 1);
                            break;
                        }catch(ArgumentOutOfRangeException e)
                            {
                            Console.WriteLine("i and j are " + i + " " + j + " not in limit");
                            }
                        }
                    
                }
            }
            Console.WriteLine("tcheck " + tcheck);
            if(tcheck.Length == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}

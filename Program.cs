using System;
using System.Collections.Generic;

namespace test_supriyanto
{
    class Program
    {
        static void Main(string[] args)
        {
             
        Console.WriteLine("Hello World!");
        //answer number 01
         Console.WriteLine("<<<<<<<answer number 01>>>>>>>>>>>");
        GetMyName getMyName= new GetMyName();
        Console.WriteLine($"Hello my name is {getMyName.readMyname()}");  
        //answer number 02
        Console.WriteLine("<<<<<<answer number 02>>>>>>>>>>");
        MyNextBirthday myNextBirthday = new MyNextBirthday();
        Console.WriteLine($"{myNextBirthday.nextBirthday()} days remaining to my next birthday");

        //answer number 03
        Console.WriteLine("<<<<<<<<answer number 03>>>>>>>>>");
          CountString countString = new CountString();
          Console.Write("input String = ");
          string inputString = Console.ReadLine();
          Console.WriteLine($"Input String = {inputString}, length = {countString.CoutString(inputString)} character");
        
        //answer number 04
        Console.WriteLine("<<<<<<answer number 04>>>>>>>>>");
        ReplaceStar replaceStar = new ReplaceStar();
        replaceStar.replace();

        //answer number 05
        Console.WriteLine("<<<<<<answer number 05>>>>>>>>>");
        OddOrEven oddOrEven = new OddOrEven();
        Console.WriteLine(oddOrEven.checkNumber(6));

        //answer number 06
        Console.WriteLine("<<<<<<answer number 06>>>>>>>>>");
        }
    }
    //class number 01
    class GetMyName
    {
        public string readMyname()
        {
            Console.Write("What's your name ? = ");
            string name =Console.ReadLine();
            return name;

        }
    }

    //class number 02
    class MyNextBirthday
    {
        public  double nextBirthday()
        {
            DateTime myBirthday = DateTime.Parse("09/25/1994");
            DateTime dateTimeNow = DateTime.Parse(DateTime.Now.ToString());
            DateTime nextMoth = DateTime.Parse($"{myBirthday.Month}/{myBirthday.Day}/{dateTimeNow.Year}"); 
            double nextBirthday = (nextMoth -dateTimeNow).Days;
            return  nextBirthday;
        }
    }

    //class number 03
    class CountString
    {
        public int  CoutString(string countString)
        {
            int length = countString.Length;   
            return length;
        }
    }

    //class number 04
    class ReplaceStar
    {
        
         public void replace()
         {
               // Create a list of 2 strings.
         var censoredWords = new List<string>(){"imperdiet","dolor","duo"};
         var paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";
         string[] split =paragraph.Split();
         //split paragraph 
         for(int i = 0; i<=split.Length-1;i++)
         {   
                foreach(string c in censoredWords)
                {
                    if(split[i]==c)
                    {  
                        //create star go to createStar() 
                     split[i]=createStar(split[i].Length);
                   }
                }  
            }
            string result = ConvertStringArrayToStringJoin(split);
            Console.WriteLine(result);
            
         }

       public string createStar(int star)
       {
           char[] chars = new char[star];
            for(int i=0;i<=star-1;i++)
            {     
            chars[i]='*';                 
            }    
            string charToString = new string(chars);
            //Console.WriteLine(charToString);   
            return charToString;                
       }

        static string ConvertStringArrayToStringJoin(string[] array)
        {
            // Use string Join to concatenate the string elements.
            string result = string.Join(" ", array);
            return result;
        }

      
    }

    //class number 05
    class OddOrEven
    {
        public bool checkNumber(int number)
        {
            if(number % 2==0)
            {
                Console.WriteLine($"enter number is even number = {number}");
                return true;
            }
            else
            {
             Console.WriteLine($"enter number is odd number = {number}");
             return false;
            }

            
        }
    }
    
}

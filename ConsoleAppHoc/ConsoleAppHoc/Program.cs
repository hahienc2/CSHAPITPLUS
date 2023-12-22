using System.Collections;
using System.Collections.Generic;
namespace ConsoleAppHoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "Hello X Y Z";
            //s = s.Replace(" ", "_"); -> Hello_X_Y_Z

            // Array
            string[] BArr = new string[10];

            BArr = s.Split(' ');
           // Console.WriteLine(BArr.Length); // = 4

            for (int i = 0; i < BArr.Length; i++)
            {
               // Console.WriteLine(BArr[i]);

            }

            string[] BArr2 = new string[3] { "3", "3", "5" };
            //BArr2.Count;
            //Console.WriteLine("Count",BArr2.Length);
            string[,] Arr2_2 = new string[2,2];

            // List
            List<string> Blist = new List<string>();
            List<string> Blist2 = new List<string>() { "3", "3", "5" };
            Blist2.Add("100");
            Blist2.Remove("5");
            Blist2.RemoveAt(0);
            for (int i = 0; i < Blist2.Count; i++)
            {
             //   Console.WriteLine(Blist2[i]);

            }
            //Dictionary
            Dictionary<string,int> Dict = new Dictionary<string,int>();
            Dict.Add("test1", 134);
            int abzs = Dict["test1"]; // lay gia tri theo key
            foreach (KeyValuePair<string,int> element in Dict)
            {
                Console.WriteLine(element.Key +"|"+ element.Value+"|"+element.ToString);
            }



            Console.WriteLine(abzs);
            // Ngoai Le
            int numnl = 0;
            bool isSuccess = int.TryParse(BArr[0], out numnl);
            if (isSuccess)
            {
                
            }




        }
        static void ad()
        {

        }
    }

}

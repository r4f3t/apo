using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HACKERRANNK
{
    class Program
    {

        // Complete the rotLeft function below.
   
     
   
        public class FreqModel
        {
            public int sayi { get; set; }
            public int freq { get; set; }
        }
        public static void customSort(List<int> arr)
        {
            //List<int> oneFreq = new List<int>();
            List<FreqModel> moreFreq = new List<FreqModel>();
            //find frequecy ones
            foreach (var item in arr)
            {
                // sayısını bul
                int sayi = arr.Where(x => x == item).Count();
                if (moreFreq.Where(x => x.sayi == item).Count() == 0)
                {
                    moreFreq.Add(new FreqModel() { sayi = item, freq = sayi });
                }
            }
            moreFreq.Sort((x, y) => x.sayi.CompareTo(y.sayi));
            moreFreq.Sort((x, y) => x.freq.CompareTo(y.freq));
            //moreFreq = moreFreq.OrderBy(x => x.sayi).OrderBy(x=>x.freq).ToList();
            foreach (var item in moreFreq)
            {
                for (int i = 0; i < item.freq; i++)
                {
                    Console.WriteLine(item.sayi.ToString());
                }

            }

        }

        public static List<string> missingWords(string s, string t)
        {
            string[] _s = s.Split(' ');
            string[] _t = t.Split(' ');
            List<string> _listt = _t.ToList();
            List<string> result =new List<string>();
            for (int i = 0; i < _s.Length; i++)
            { 
                int isVar=0;
                for (int j = 0; j < _t.Length; j++)
                {
                    if (_s[i] == _t[j])
                    {
                        isVar = 1;
                    }
                }
                if (isVar == 0) { result.Add(_s[i]); }
                
            }

            //for (int i = 0; i < _s.Length; i++)
            //{
            //    int sayi = _listt.BinarySearch(_s[i]);
            //    if (sayi<0)
            //    {
            //        result.Add(_s[i]);
            //    }
            //}
            return result;
        }
        class Demo
    {
        int i;
        float j;
        public void SetData(int i, float j)
        {
            i = i;
            j = j;
        }
        public void Display()
        {
            Console.WriteLine(i + " " + j);
        }
    }
  static void funcinconly(int num)
        {
            num = num + 10; Console.Write(num + ", ");
        }
        static void funcincref (ref int num)
        {
            num = num + 10; Console.Write(num + ", ");
        }

        static void Main(string[] args)
        {
          Demo s1 = new Demo();
            s1.SetData(10, 5.4f);
            s1.Display();
            Console.ReadKey();
        }
    }
}

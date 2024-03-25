using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _0325
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String English;
            Console.WriteLine("請輸入英文字串");
            English = Console.ReadLine();
            Console.WriteLine("您輸入資料為:" + English.ToString());
            String code1 = English.Substring(0, 1);
            Console.WriteLine("code1資料為:" + code1.ToString());
            {
                string[] strs = new string[] { "a", "e", "i", "o" ,"u"};
                switch(English)
                {
                    case string a;
                    string Upper = English.ToUpper();
                }
                Console.WriteLine("请输入一个带大写字符和小写字符的字符串");
                string str = Console.ReadLine();
               //全部转大写
                Console.WriteLine("转换成大写的字符串：" + Upper);
                string Lower = str.ToLower();//全部转小写
                Console.WriteLine("转换成小写写的字符串：" + Lower);
                Console.ReadKey();//等待用户按任意键结束程序
            }
        }
        }

            }

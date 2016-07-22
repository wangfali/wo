using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPlatProject
{
    class Computer
    {
        private int one = 0;
        private int two = 0;


        public Computer() { }

        public Computer(int a, int b)
        {
            one = a;
            two = b;
        }
        public int add()
        {
            return one + two;
        }
        /// <summary>
        /// 实现两个整数相加，返回相加结果
        /// </summary>
        /// <param name="a">第一个运算整数</param>
        /// <param name="b">第二个运算整数</param>
        /// <returns>获得运算结果</returns>
        public int add(int a, int b)
        {
            int sum=a + b;
            return sum;
        }

        public float add(float a, float b)
        {
            return a + b;
        }

        public String add(String a, String b)
        {
            return a + b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public static int JianFa(int one, int two)
        {
            return one - two;
        }
    }
}

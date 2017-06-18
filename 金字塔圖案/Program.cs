using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 金字塔圖案
{
    class Program
    {
        static void Main(string[] args)
        {
            ////假設有一 3x2 陣列，(三層樓，每一層樓有2戶)
            //int[,] arr1 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };


            ///*方法1*/
            ////直接存取陣列元素

            //Response.Write(arr1[0, 0]);

            ///*方法2*/
            ////GetUpperBound方法--取得陣列中某一維度上限
            ///*註：第一維是3(樓層高度)，
            //  因arr1[0,1]、arr1[1,1]、arr1[2,1]，故第一維的上限是2*/

            //for (int i = 0; i <= arr1.GetUpperBound(0); i++)
            //{
            //    /*註：第二維是2(有幾「戶」)，因arr1[1,0],arr1[1,1]，故第二維上限是1*/
            //    for (int j = 0; j <= arr1.GetUpperBound(1); j++)
            //    {
            //        Response.Write(arr1[i, j].ToString());
            //    }
            //}


            ///*方法3*/
            ////GetLength方法--取得某一維度的長度(即元素個數)
            ////GetLength(0)->得到第1維長度，是3(列數、樓層數)
            ////GetLength(1)->得到第2維長度，是2(行數、戶數)

            //for (int i = 0; i <= arr1.GetLength(0) - 1; i++)
            //{
            //    for (int j = 0; j <= arr1.GetLength(1) - 1; j++)
            //    {
            //        Response.Write(arr1[i, j].ToString());
            //    }
            //}


            ///*方法4*/
            ////用foreach迴圈

            //foreach (int i in arr1)
            //{
            //    Response.Write(i);
            //}

            ////金字塔
            //for (int i = 1; i <= 5; i++) 
            //{
            //    for (int j = 1; j <= 5 - i; j++) 
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i * 2 - 1; k++) 
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}
            //Console.Write("\n");
            //反金字塔

            // { i=0  j=1   1<=0}  ,
            // { i=1  j=1   1<=1}, 
            // { i=2  j=1   1<=2 , i=2  j=2  2<=2 } ,
            // { i=3  j=1   1<=3 , i=3  j=2  2<=3, i=3 j=3  3<=3}
            // { i=4  j=1   1<=4 , i=4  j=2  2<=4, i=4 j=3  3<=4,  i=4 j=4 4<=4}


            // k=9,k=8,k=7,k=6,k=5,k=4,k=3,k=2,k=1
            // k=7,k=6,k=5,k=4,k=3,k=2,k=1
            // k=5,k=4,k=3,k=2,k=1
            // k=3,k=2,k=1
            // k=1
                //for (int i = 0; i <= 4; i++) 
                //{
              
                //    for (int j = 1; j <= i; j++) 
                //    {
                //        Console.Write(" ");
                //    }
           
                //    for (int k = 9 - (i * 2); k >= 1; k--) 
                //    {
                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}


                ////三角形
                //for (int i = 1; i <= 6; i++)
                //{                   1    5
                //    for (int j = 1; j <= 6 - i; j++)
                //    {
                //        Console.Write("*");
                //    }
                //    Console.Write("\n");
                //}

            //for (int i = 1; i < 10; i++) 
            //{
            //    for (int j = 1; j <= i; j++) 
            //    {
            //        Console.Write(" " + i + "*" + j + "=" + (i * j));
            //    }
            //}
            //Console.Write("\n");
            int[,] ary = getTriangle(8);
            print(ary);
           Console.Read();
        }
        private static int[,] getTriangle(int num)
        {
           int[,]ary = new int[num,num];
           for (int i = 0; i < ary.GetUpperBound(0); i++) 
           {
               ary[i,0] = 1;
               ary[i,i] = 1;
           }
           for (int i = 1; i < ary.GetUpperBound(0); i++) 
           {
               for (int j = 1; j <= i; j++) 
               {
                   ary[i, j] = ary[i - 1, j - 1] + ary[i-1,j];
               }
             
           }
           return ary;
        }
        private static void print(int[,] ary) 
        {
            for (int i = 0; i < ary.GetUpperBound(0); i++) 
            {
                for (int j = 0; j <= i; j++) 
                {
                    Console.Write(" {0,-3:D}", ary[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}

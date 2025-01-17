﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace c_ch5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //例題5.1-利用一維陣列求10個數字的計算平均值。
            //int[] numbers = new int[10];
            //int sum = 0;
            //Console.WriteLine("輸入10個數");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += numbers[i];
            //}
            //double a =(double)sum/ numbers.Length;
            //Console.WriteLine("平均值為:" + a);
            //Console.ReadKey();

            //例題5.2-利用一維陣列求10個數字的最大值。
            //int[] numbers = new int[10];
            //Console.WriteLine("輸入10個數");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int max = numbers[0];
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}
            //Console.WriteLine("最大值為:" + max);
            //Console.ReadKey();

            //例題5.3-搜尋問題：輸入10個數字至A[ ]，再輸入x，
            //判斷x是否存在於A陣列中，如果存在，輸出所在的註標(索引)值，
            //若不存在，則告知不存在。
            //int[] A = new int[10];
            //Console.WriteLine("請輸入 10 個數字：");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    A[i] = Convert.ToInt16(Console.ReadLine());
            //}
            //Console.WriteLine("請輸入收尋數字:");
            //int x = Convert.ToInt16(Console.ReadLine());
            //bool found = false;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i] == x)
            //    {
            //        Console.WriteLine($" {x} 在 A 陣列中，為第{i + 1}個數");
            //        found = true;
            //        break;
            //    }
            //}
            //if (!found)
            //{
            //    Console.WriteLine("不存在陣列中");
            //}
            //Console.ReadKey();

            //5.4流程圖
            //int w = 3;//寬度-列
            //int h = 2;//高度-行
            //int[,] a = new int[h, w];
            //int[,] b = new int[h, w];
            //int[,] c = new int[h, w];
            //Console.WriteLine("輸入a值:");
            //for (int i = 0; i < h; i++)
            //{
            //    for (int j = 0; j < w; j++)
            //    {
            //        Console.Write($"a[{i},{j}]=");
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("輸入b值:");
            //for (int i = 0; i < h; i++)
            //{
            //    for (int j = 0; j < w; j++)
            //    {
            //        Console.Write($"b[{i},{j}]=");
            //        b[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("矩陣c:");
            //for (int i = 0; i < h; i++)
            //{
            //    for (int j = 0; j < w; j++)
            //    {
            //        c[i, j] = a[i, j] + b[i, j];
            //        Console.Write($"{c[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //例題5.5-求a=2*3矩陣b=3*1矩陣，結果存入c=2*1矩陣，
            //最後將C矩陣的內容顯示出來。
            //int[,] a = new int[2, 3];
            //int[,] b = new int[3, 1];
            //int[,] c = new int[2, 1];
            //Console.WriteLine("請輸入a矩陣的值");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"a[{i},{j}]=");
            //        a[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("請輸入b矩陣的值");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"b[{i},0]=");
            //    b[i, 0] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    c[i, 0] = 0;
            //    for (int j = 0; j < 3; j++)
            //    {
            //        c[i, 0] += a[i, j] * b[j, 0];
            //    }
            //}
            //Console.WriteLine("c=(a+b),c巨陣為;");
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine($"c[{i},0]={c[i, 0]}");
            //}
            //Console.ReadKey();

            //-------------------------------------------------------------

            //5-1將10個數字讀入A陣列，然後逐一檢查此陣列，
            //如A[i]>5，則令A[i]=A[i]-5，否則A[i]=A[i]+5。
            //int[] a = new int[10];
            //Console.WriteLine("請輸入10個數字:");
            //for (int i=0;i<10; i++) 
            //{
            //    a[i]=int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("大於5會減5,否則會加5");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (a[i] > 5) { Console.WriteLine(a[i] -= 5); }
            //    else { Console.WriteLine(a[i] += 5); }
            //}
            //Console.ReadKey();

            //5-2將10個數字讀入A陣列，對每一個數字，令A[i] = A[i] + i。
            //int[] a = new int[10];
            //Console.WriteLine("請輸入10個數字");
            //for (int i = 0; i < 10; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("加5");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(a[i] + i);
            //}
            //Console.ReadKey();

            //5-3將10個數字讀入A陣列，並建立一個B陣列，
            //如A[i]≥0，令B[i] = 1，否則令B[i] = 0。
            //int[] a = new int[10];
            //int[] b = new int[10];
            //Console.WriteLine("請輸入10個數字");
            //for (int i = 0; i < 10; i++) 
            //{
            //    a[i]=int.Parse(Console.ReadLine());
            //    if (a[i]>= 0)
            //    {
            //        b[i] = 1;
            //    }
            //    else
            //    {
            //        b[i] = 0;
            //    }
            //}
            //Console.WriteLine(">=0為1否則為0,結果如下:");
            //for (int i = 0;i < 10; i++)
            //{
            //    Console.WriteLine($"b[{a[i]}] = {b[i]}");
            //}
            //Console.ReadKey();

            //5-4將15數字存入3×5的二維陣列A中，求每一行及每一列數字的和。
            //int[,] a = new int[4, 6];
            //Console.WriteLine("請輸入15個數字");
            //for (int i = 0; i < 3; i++)//前3行
            //{
            //    for (int j = 0; j < 5; j++)//前5列
            //    {
            //        Console.Write($"A[{i},{j}] = ");
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            ////計算每行的和
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        a[i, 5] += a[i, j]; // 每行的和儲存在第 5 列
            //    }
            //}
            //for (int j = 0; j < 5; j++)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        a[3, j] += a[i, j];
            //    }
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    a[3, 5] += a[i, 5];
            //}
            //Console.WriteLine("\n陣列a的結果如下:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        Console.Write($"{a[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //5-5將15數字存入3×5的二維陣列A中，求每一行及每一列數字的最小值。
            //int[,] a = new int[3, 5];
            //Console.WriteLine("請輸入15個數字");
            //for (int i = 0; i < 3; i++)//前3行
            //{
            //    for (int j = 0; j < 5; j++)//前5列
            //    {
            //        Console.Write($"A[{i},{j}] = ");
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("\n您輸入的3x5陣列是：");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write($"{a[i, j]}\t");
            //    }
            //    Console.WriteLine();//換行
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    int min = a[i, 0];
            //    for (int j = 1; j < 5; j++)
            //    {
            //        if (a[i, j] < min)
            //        {
            //            min = a[i, j];
            //        }
            //    }Console.WriteLine($"第{i + 1}行的最小值是:{min}");
            //}
            //for(int j=0;j<5;j++)
            //{
            //    int mine = a[0, j];
            //    for(int i=1;i<3;i++)
            //    {
            //        if (a[i, j] < mine);
            //    }Console.WriteLine($"第{j + 1}列的最小值:{mine}");
            //}
            //        Console.ReadKey();

            //5-6輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。求ai + bi，i = 1到i = 5。
            //int[] a = new int[5]; // 儲存 a1 到 a5
            //int[] b = new int[5]; // 儲存 b1 到 b5
            //int[] sum = new int[5]; // 儲存 ai + bi 的結果
            //Console.WriteLine("請輸入第一組數字 a1 到 a5：");// 輸入第一組數字 a1 到 a5
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"a[{i + 1}] = ");
            //    a[i] = int.Parse(Console.ReadLine());
            //}//\n是斷行
            //Console.WriteLine("\n請輸入第二組數字 b1 到 b5：");// 輸入第二組數字 b1 到 b5
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"b[{i + 1}] = ");
            //    b[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < 5; i++)// 計算 ai + bi
            //{
            //    sum[i] = a[i] + b[i];
            //}
            //Console.WriteLine("\n每組數字相加的結果是：");// 輸出結果
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"a[{i + 1}] + b[{i + 1}] = {a[i]} + {b[i]} = {sum[i]}");
            //}
            //Console.ReadKey(); // 等待按鍵結束程式

            //5-7輸入兩組數字： a1,a2,…,a5和b1,b2,…,b5。
            //令x為a中的最大值，令y為b中的最大值，求x與y中較小者。
            //int[] a = new int[5];
            //int[] b = new int[5];
            //Console.WriteLine("請輸入a1-a5:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"a[{i + 1}] = ");
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("請輸入b1-b5:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"b[{i + 1}] = ");
            //    b[i] = int.Parse(Console.ReadLine());
            //}
            //int x = a[0];// 找出 a 陣列中的最大值 x
            //for (int i = 1; i < 5; i++)
            //{
            //    if (a[i] > x)
            //    {
            //        x = a[i];
            //    }
            //}
            //int y = b[0];// 找出 b 陣列中的最大值 y
            //for (int i = 1; i < 5; i++)
            //{
            //    if (b[i] > y)
            //    {
            //        y = b[i];
            //    }
            //}
            //// 比較 x 和 y，找出較小者
            //int smaller = (x < y) ? x : y;
            //Console.WriteLine($"\n第一組的最大值 x = {x}");
            //Console.WriteLine($"第二組的最大值 y = {y}");
            //Console.WriteLine($"x 與 y 中較小者是：{smaller}");
            //Console.ReadKey();

        }
    }
}

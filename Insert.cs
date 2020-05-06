using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;//滙入靜態類別

/// 插入排序法（Insert Sorting）
/// 最壞及平均比較為n(n-1)/2，時間複雜度為O(n^2)，最好情況時間複雜度為O(n)
/// 插入排序法是穩定排序法
/// 只需一個額外空間，所以空間複雜度為最佳
/// 插入排序法會造成大量資料搬移，所以建議在鏈結串列上使用
namespace Sorting
{
    class Insert
    {
        static int[] data = new int[6];
        static int size = 6;

        static void Main(string[] args)
        {
            Inputarr();
            Write("您輸入的原始陣列是：");
            Showdata();
            Insert();
            ReadKey();
        }
        static void Inputarr()
        {
            int i;
            for (i = 0; i < size; i++)      //利用迴圈輸入陣列資料
            {
                try
                {
                    Write("請輸入第" + (i + 1) + "個元素：");
                    data[i] = int.Parse(ReadLine());
                }
                catch (Exception e) { }
            }
        }

        static void Showdata()
        {
            int i;
            for (i = 0; i < size; i++)
            {
                Write(data[i] + " ");   //列印陣列資料
            }
            WriteLine();
        }

        static void Insert()
        {
            int i;     //i為掃描次數
            int j;     //以j來定位比較的元素
            int tmp;   //tmp用來暫存資料
            for (i = 1; i < size; i++)  //掃描迴圈次數為SIZE-1
            {
                tmp = data[i];
                j = i - 1;
                while (j >= 0 && tmp < data[j])  //如果第二元素小於第一元素
                {
                    data[j + 1] = data[j]; //就把所有元素往後推一個位置
                    j--;
                }
                data[j + 1] = tmp;       //最小的元素放到第一個元素
                Write("第" + i + "次掃瞄：");
                Showdata();
            }
        }
    }
}
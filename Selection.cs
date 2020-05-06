using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;//滙入靜態類別


/// 選蓻排序法（Selection Sorting）
/// 無論是最壞、最佳或平均情況都需要找到最大值（或最小），所以比較次數為n(n-1)/2，時間複雜度為O(n^2)
/// 由於選擇排序是以最大或最小直接與最前方外排序的鍵值交換，資料排序很有可能被改變，故為不穩定排序法。
/// 只需一個額外空間，所以空間複雜度為最佳。
/// 此排序法用於資料量小或有部分資料已經過排序
namespace Sorting
{
    class Selection
    {
        public static int[] data = new int[] { 9, 7, 5, 3, 4, 6 };
        static void Main(string[] args)
        {
            Write("原始資料為：");
            Showdata();
            Select();
            ReadKey();
        }

        static void Showdata()
        {
            int i;
            for (i = 0; i < data.Length; i++)
            {
                Write(data[i] + " ");
            }
            WriteLine();
        }

        static void Select()
        {
            int i, j, tmp, k;
            for (i = 0; i < 5; i++)         //掃描5次
            {
                for (j = i + 1; j < 6; j++)  //由i+1比較起，比較5次
                {
                    if (data[i] > data[j])  //比較第i及第j個元素
                    {
                        tmp = data[i];
                        data[i] = data[j];
                        data[j] = tmp;
                    }
                }
                Write("第" + (i + 1) + "次排序結果：");
                for (k = 0; k < 6; k++)
                {
                    Write(data[k] + " ");  //列印排序結果
                }
                WriteLine();
            }
        }
    }
}

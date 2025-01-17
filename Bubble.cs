using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;//滙入靜態類別

/// 氣泡演算法（Bubble Sorting）
/// 最換情況與平均情況均須比較：n(n+1)/2，時間複雜度為O(n^2)，最好情況為Ｏ(n)。
/// 氣泡排序法為相鄰兩者互相比較對調，並不會更改其原本排序的順序，所以是穩定排序法。
/// 只需一個額外的空間，所以空間複雜度為最佳。
/// 氣泡排序法適用於資料量小或有部分資料已經過排序。
namespace Sorting
{
    class Bubble
    {
        static Bubble(string[] args)
        {
            int i, j, tmp;
            int[] data = { 6, 5, 9, 7, 2, 8 };  //原始資料

            WriteLine("氣泡排序法：");
            Write("原始資料為：");
            for (i = 0; i < data.Length; i++)
            {
                Write(data[i] + " ");
            }
            WriteLine();

            for (i = data.Length - 1; i > 0; i--)     //掃瞄次數
            {
                for (j = 0; j < i; j++)     //比較、交換次數
                {
                    // 比較相鄰兩數，如第一數較大則交換
                    if (data[j] > data[j + 1])
                    {
                        tmp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = tmp;
                    }
                }

                //把各次掃描後的結果印出
                Write("第" + (data.Length - i) + "次排序後的結果是：");
                for (j = 0; j < data.Length; j++)
                {
                    Write(data[j] + " ");
                }
                WriteLine();
            }

            Write("排序後結果為：");
            for (i = 0; i < data.Length; i++)
            {
                Write(data[i] + " ");
            }
            WriteLine();
            ReadKey();
        }
    }
}
namespace Algorithm
{
    class Recursion
    {
        /// 遞迴演算法
        /// 在實作遞迴時會用到堆疊（Stack）的資料結構概念。，具後進先出的特性（First In,Fist Out:FIFO）。
        static int fac(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * fac(n - 1);
            }
        }

        /// 費氏數列（Fibonacci Polynomial）
        static int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return (Fib(n - 1) + Fib(n - 2));
            }
        }

        /// 動態規劃演算法（Dynamic Programming Algorithm,DPA）
        /// 類似分治法，其中最大的不同就是可以讓每一個子問題的答案被儲存起來，以供下次求解時使用。
        static int[] output = new int[1000];
        static int FibDPA(int n)
        {
            int result;
            result = output[n];
            if (result == 0)
            {
                if (n == 0)
                {
                    return 0;
                }
                else if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return (FibDPA(n - 1) + FibDPA(n - 2));
                }
            }
            output[n] = result;
            return result;
        }

        /// 疊代法（iterative methon）
        /// 只無法使用公式一次求解，而需反覆運算。
        /// 用for-loop設計一個計算1!~n!的遞迴公式
        static int Iterative(int n)
        {
            int sum = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    sum *= j;
                    sum = 1;
                }
            }
            return sum;

        }

        /// 求Ｎ是否為質數
        static bool IsPrimeNumber(int n)
        {
            int i = 2;
            while (i <= n)
            {
                if ((n % i) == 0)
                {
                    return false;
                }
                i++;
                return true;
            }
            return true;
        }

    }
}
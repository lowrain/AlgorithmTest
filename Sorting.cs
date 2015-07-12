using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    public static class Sorting
    {
        public static void BubbleSort(int[] a)
        {
            int flag = a.Length;

            while (flag > 0)
            {
                int j = flag;
                flag = 0;

                for (int i = 1; i < j; i++)
                {
                    if (a[i - 1] > a[i])
                    {
                        Swap(ref a[i - 1], ref a[i]);
                        flag = i;
                    }
                }
            }
        }

        public static void DirectInsertionSort(int[] a)
        {
            int n = a.Length;
            for (int i = 1; i < n; i++)
            {
                for (int j = i - 1; j >= 0 && a[j] > a[j + 1]; j--)
                {
                    Swap(ref a[j], ref a[j + 1]);
                }
            }
        }

        public static void StraightSelectSort(int[] a)
        {
            int n = a.Length;

            for (int i = 0; i < n; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(ref a[i], ref a[minIndex]);
            }
        }

        public static void MergeSort(int[] a, int first, int last, int[] temp)
        {
            int n = a.Length;
            if (first < last)
            {
                int mid = (first + last)/2;
                MergeSort(a, first, mid, temp);
                MergeSort(a, mid + 1, last, temp);


                int i = first, j = mid + 1, k = 0;
                while (i <= mid && j <= last)
                {
                    if (a[i] < a[j])
                    {
                        temp[k++] = a[i++];
                    }
                    else
                    {
                        temp[k++] = a[j++];
                    }
                }

                while (i <= mid)
                {
                    temp[k++] = a[i++];
                }

                while (j <= last)
                {
                    temp[k++] = a[j++];
                }

                for (int o=0; o < k; o++)
                {
                    a[first + o] = temp[o];
                }
            }
        }

        public static void QuickSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int l = left, r = right, x = a[l];

                while (l < r)
                {
                    while (l < r && a[r] > x)
                    {
                        r--;
                    }
                    if (l < r)
                    {
                        a[l++] = a[r];
                    }

                    while (l < r && a[l] < x)
                    {
                        l++;
                    }
                    if (l < r)
                    {
                        a[r--] = a[l];
                    }
                }
                a[l] = x;
                QuickSort(a, left, l - 1);
                QuickSort(a, l + 1, right);
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            if (a != b)
            {
                a ^= b;//a=10100,b=0010,两者相异或的结果是10110,并保存在a中。
                b ^= a;//a=10110,b=0010,两者相异或的结果是10100，并保存在b中，换成二进制是20
                a ^= b;//a=10110,b=10100,两者相异或的结果是00010，保存在a中，换成十进制是2
            }
        }
    }
}

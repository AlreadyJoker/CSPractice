using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arithmetic
{
    /// <summary>
    /// 排序算法
    /// </summary>
    public static class Sort
    {
        //插入排序
        public static void InsertSort(int[] arr)
        {
            if(arr.Length <= 1)
                return; 
            for(int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j --;
                }
                arr[j + 1] = key;
            }
        }
        //冒泡排序 升序
        public static void BubbleSortUp(int[] arr)
        {
            if(arr.Length <= 1)
                return;
            for(int i = 0; i < arr.Length; i++)
            {
                bool flag = false;
                for(int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flag = true;
                    }
                }
                if(!flag)
                    break;
            }
        }
        //冒泡排序 降序
        public static void BubbleSortDown(int[] arr)
        {
            if (arr.Length <= 1)
                return;
            for (int i = 0; i < arr.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flag = true;
                    }
                }
                if (!flag)
                    break;
            }
        }
        //选择排序 升序
        public static void SelectSortUp(int[] arr)
        {
            if (arr.Length <= 1)
                return;
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }

        //选择排序 降序
        public static void SelectSortDown(int[] arr)
        {
            if(arr.Length <= 1)
                return;
            for(int i = 0; i < arr.Length; i++)
            {
                int maxIndex = i;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[maxIndex];
                arr[maxIndex] = temp;
            }
        }
    }
}

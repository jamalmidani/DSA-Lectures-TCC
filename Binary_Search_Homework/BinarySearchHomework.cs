using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            int midl = start + (end - start) / 3;
            int midr = end - (end - start) / 3;

            if (start >= end)
                return -1;
            if (arr[midl] == key)
                return midl;
            if (arr[midr] == key)
                return midr;

            if (arr[midl] > key)
                return TernarySearch(arr, key, start, midl - 1);
            if (arr[midl] < key && arr[midr] > key)
                return TernarySearch(arr, key, midl + 1, midr - 1);
            if (arr[midr] < key)
                return TernarySearch(arr, key, midr + 1, end);

            return -1;
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance
            int result = -1;
            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (arr[mid] == key)
                {
                    result = mid;
                    if (is_first)
                        end = mid - 1;
                    else
                        start = mid + 1;
                }
                else if (arr[mid] < key)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return result;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
            int first = BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length - 1);
            int last = BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length - 1);

            if (first != -1)
                return last - first + 1;

            return -1;
        }
    }
}

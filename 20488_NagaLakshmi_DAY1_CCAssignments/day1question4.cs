using System;

namespace quesyion_4
{
	class GFG
	{
		static int binarySearch(int[] arr, int l,
								int r, int x)
		{
			if (r >= l)
			{
				int mid = l + (r - l) / 2;
				if (arr[mid] == x)
					return mid;
				if (arr[mid] > x)
					return binarySearch(arr, l, mid - 1, x);
				return binarySearch(arr, mid + 1, r, x);
			}

			return -1;
		}
		public static void Main()
		{

			int[] arr = new int[5];
			int n = arr.Length;
			int x,i;

			Console.Write("Enter array elements:");
			for (i = 0; i < arr.Length; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.Write("Enter search elements:");
			x = Convert.ToInt32(Console.ReadLine());
			int result = binarySearch(arr, 0, n - 1, x);

			if (result == -1)
				Console.WriteLine("Element not present");
			else
				Console.WriteLine("Element found at index "
								+ result);
		}
	}
}
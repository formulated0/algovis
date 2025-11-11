using ColoredConsole;
using Microsoft.VisualBasic;
using static Menus;

class Sorting
{
	public static bool RUNNING;

	public static void Quit(Action method)
	{
		var key = Console.ReadKey(true);
		while (RUNNING)
		{
			if (key.Key == ConsoleKey.Q)
			{
				RUNNING = false;
			}
		}
		method();
	}

	// where n is the arrayLength
	public static void BubbleSort(int[] arr, int n)
	{
		int i, j, temp;
		bool swapped;
		for (i = 0; i < n - 1; i++)
		{
			swapped = false;
			for (j = 0; j < n - i - 1; j++)
			{
				// if the jth element is larger than the next element
				if (arr[j] > arr[j + 1])
				{
					Console.WriteLine($"swapping {arr[j]} and {arr[j + 1]}");
					// then swap them
					temp = arr[j];
					arr[j] = arr[j + 1];
					arr[j + 1] = temp;
					swapped = true;
				}
			}

			// if no two elements were swapped by inner loop then break
			if (swapped == false)
				break;
		}

		static void printArray(int[] arr)
		{
			Console.WriteLine($"sorted array: [{string.Join(", ", arr)}]");
		}

		printArray(arr);
		Console.WriteLine($"press q to go back");
		Quit(SortMenu);
	}

	public static void InsertionSort()
	{
		return;
	}

	public static void SelectionSort()
	{
		return;
	}

	public static void MergeSort()
	{
		return;
	}

	public static void QuickSort()
	{
		return;
	}

}
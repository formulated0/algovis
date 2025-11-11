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
		int passes = 0;
		int swaps = 0;
		int comparisons = 0;
		var stopwatch = System.Diagnostics.Stopwatch.StartNew();
		for (i = 0; i < n - 1; i++)
		{
			swapped = false;
			passes++;
			for (j = 0; j < n - i - 1; j++)
			{
				// visualise the array here so that we get the sickass red moving up per pass not per swap
				DrawArray(arr, j, j + 1);

				comparisons++;
				if (arr[j] > arr[j + 1])
				{
					// swap
					temp = arr[j];
					arr[j] = arr[j + 1];
					arr[j + 1] = temp;
					swaps++;
					swapped = true;
				}
			}
			
			if (!swapped)
				break;
		}

		// have to draw another one to get rid of the red
		DrawArray(arr, -1, -1, 0);

		stopwatch.Stop();

		TimeSpan ts = stopwatch.Elapsed;
		string elapsedTime = string.Format("{0:00}.{1:00}", ts.Microseconds, ts.Nanoseconds);

		Console.WriteLine("-----------------------------");
		Console.WriteLine("sorting complete!");
		Console.WriteLine("algorithm: bubble sort");
		Console.WriteLine($"passes: {passes}");
		Console.WriteLine($"swaps: {swaps}");
		Console.WriteLine($"comparisons: {comparisons}");
		Console.WriteLine($"real time taken: {elapsedTime + " microseconds"}");
		Console.WriteLine("-----------------------------");
		Console.WriteLine("sorted array:");
		Console.WriteLine($"[{string.Join(", ", arr)}]");
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

	public static void DrawArray(int[] arr, int highlightA = -1, int highlightB = -1, int delay = 50, ConsoleColor color = ConsoleColor.Red)
	{
		Console.SetCursorPosition(0, 0);

		int max = arr.Max();
		int width = 50;

		Console.WriteLine("-----------------------------");
		Console.WriteLine("sorting visualisation:");
		Console.WriteLine("-----------------------------");

		for (int i = 0; i < arr.Length; i++)
		{
			int barLength = (int)(arr[i] / (double)max * width);

			if (i == highlightA || i == highlightB)
				Console.ForegroundColor = color;
			else
				Console.ForegroundColor = ConsoleColor.Gray;

			Console.Write($"{arr[i],3} | {new string('█', barLength)}");
			Console.Write(new string(' ', Console.WindowWidth - barLength - 6));
			Console.WriteLine();
		}

		Console.ResetColor();
		Thread.Sleep(delay);
	}
}
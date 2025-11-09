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
	public static void BubbleSort()
	{
		ColorConsole.WriteLine("bubblesort");
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
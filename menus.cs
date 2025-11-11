using System.Security.Cryptography.X509Certificates;
using ColoredConsole;
using static Sorting;
using System.Text;

class Menus
{
	public static void MainMenu()
	{
		Console.WriteLine("=============================");
		Console.WriteLine("ALGOVIS v1");
		Console.WriteLine("=============================");
		Console.WriteLine("1. sorting algorithms");
		Console.WriteLine("2. pathfinding algorithms (todo)");
		Console.WriteLine("3. data structures (todo)");
		Console.WriteLine("4. exit");
		Console.Write("-----------------------------\nselect an option: ");
		var input = Console.ReadLine();
		if (!int.TryParse(input, out int choice) || choice < 1 || choice > 4)
		{
			ColorConsole.WriteLine("\ninvalid choice buddy try again".Red());
			Console.ResetColor();
			MainMenu();
			return;
		}

		switch (choice)
		{
			case 1:
				SortMenu();
				break;
			case 2:
				PathMenu();
				break;
			case 3:
				DataMenu();
				break;
			case 4:
				Environment.Exit(0);
				break;
			default:
				ColorConsole.WriteLine("\ninvalid choice buddy try again".Red());
				Console.ResetColor();
				MainMenu();
				return;
		}
	}

	public static void SortMenu()
	{
		Console.WriteLine("-----------------------------");
		Console.WriteLine("SORTING ALGORITHMS");
		ColorConsole.WriteLine("1. ".Red(), "bubble sort");
		ColorConsole.WriteLine("2. ".Red(), "insertion sort");
		ColorConsole.WriteLine("3. ".Red(), "selection sort");
		ColorConsole.WriteLine("4. ".Red(), "merge sort");
		ColorConsole.WriteLine("5. ".Red(), "quick sort");
		Console.WriteLine("6. back");
		Console.Write("-----------------------------\nselect an algorithm: ");

		var input = Console.ReadLine();
		if (!int.TryParse(input, out int choice) || choice < 1 || choice > 6)
		{
			ColorConsole.WriteLine("\ninvalid choice buddy try again".Red());
			SortMenu();
			return;
		}

		switch (choice)
		{
			case 1:
				SortMenus.BubblesortMenu();
				break;
			case 2:
				// TODO INSERTION SORT
				break;
			case 3:
				// TODO SELECTIONSORT
				break;
			case 4:
				// TODO MERGESORT
				break;
			case 5:
				// TODO QUICKSORT
				break;
			default:
				ColorConsole.WriteLine("\ninvalid choice buddy try again".Red());
				SortMenu();
				return;
		}
	}

	public static void PathMenu()
	{
		ColorConsole.WriteLine("\npathmenu".Blue());
	}

	public static void DataMenu()
	{
		ColorConsole.WriteLine("\ndatamenu".Yellow());
	}
}

class ArrayMenus
{
	public static (int[] arr, int size)? ArrayMenu()
	{
		Console.Write($"enter array size (10-50): ");
		var input = Console.ReadLine();
		if (!int.TryParse(input, out int arraySize) || arraySize < 10 || arraySize > 50)
		{
			ColorConsole.WriteLine("enter an integer between 10 and 50".Red());
			return ArrayMenu();
		}

		Console.WriteLine("data type:");
		ColorConsole.WriteLine("1. ".Red(), "random numbers");
		ColorConsole.WriteLine("2. ".Red(), "reverse sorted");
		ColorConsole.WriteLine("3. ".Red(), "almost sorted");
		ColorConsole.WriteLine("4. ".Red(), "custom input");
		Console.WriteLine("5. back");
		Console.WriteLine("-----------------------------\nselect an option: ");

		var input1 = Console.ReadLine();
		if (!int.TryParse(input1, out int arrayMenuSelection) || arrayMenuSelection < 1 || arrayMenuSelection > 5)
		{
			ColorConsole.WriteLine("invalid choice buddy try again".Red());
			return ArrayMenu();
		}

		switch (arrayMenuSelection)
		{
			case 1:
				return GenerateRandArray(arraySize);
			case 2:
				break;
			case 3:
				break;
			case 4:
				break;
			case 5:
				Menus.SortMenu();
				return null;
			default:
				ColorConsole.WriteLine("\ninvalid choice buddy try again".Red());
				return ArrayMenu();
		}
		return null;
	}

	public static (int[] arr, int size) GenerateRandArray(int arraySize)
	{
		Random rand = new();

		int[] randArray = new int[arraySize];

		for (int i = 0; i < arraySize; i++)
		{
			randArray[i] = rand.Next(1, 101);
		}

		Console.WriteLine($"your array: [{string.Join(", ", randArray)}]");
		Console.WriteLine("press enter to continue");
		Console.ReadLine();
		return (randArray, arraySize);
	}
}

class SortMenus
{
	public static void BubblesortMenu()
	{
		ColorConsole.WriteLine("bubblesort");
		var result = ArrayMenus.ArrayMenu();
		if (result.HasValue)
		{
			BubbleSort(result.Value.arr, result.Value.size);
		}
	}
}
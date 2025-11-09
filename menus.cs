using ColoredConsole;

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
		Console.WriteLine("-----------------------------\nselect an algorithm: ");

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
				Sorting.BubbleSort();
				break;
			case 2:
				break;
			case 3:
				break;
			case 4:
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
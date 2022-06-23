using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

class Menu
{
	public static void Main() //starting point for the code.
	{
		string[,] table = new string[1400,7];// array for holding the raw weather station data.
		string file; // holds the filepath for the text files.
		file = System.IO.Path.GetFullPath(@"Texts\"); // finds the directory for the texts folder no matter where the project folder is. 
		Console.WriteLine("Would you like to query ws1 or ws2? (Type don't, no or quit to exit program)"); //prompts user to enter station name.
		string station = Console.ReadLine(); // takes the users response.
		string method; //case string
		int total; // number of entries
		string mval; //case string
		int column; //column being sorted
		string aval; //case string
		
		switch (station) // takes the users choice of station
		{
			case "ws1":
				total = readIn.Tws1(file, table);
				Console.WriteLine("Search by: year, month, find the minimum, maximum or average values on record (enter min, max or average)");
				Console.WriteLine(@"or enter 'whole' to display entire record");
				method = Console.ReadLine();
				
				switch(method) // after station is taken asks what user wishes to query.
				{
					case "year":
						sort.shift(table, total);
						display.year(table, total);
						break;
						
					case "month":
						sort.shift(table, total);						
						display.month(table, total);
						break;
						
					case "min":
						sort.shift(table, total);
						Console.WriteLine("what column do you want the minimum value for?(TMax, TMin, AF, Rain or Sun)");
						mval = Console.ReadLine();
						switch(mval) //asks what column query is for
						{
							case "TMax":
							case "Tmax":
							case "tmax":
								column = 2;
								display.min(table, total, column);
								break;
							case "TMin":
							case "Tmin":
							case "tmin":
								column = 3;
								display.min(table, total, column);
								break;
							case "AF":
							case "Af":
							case "af":
								column = 4;
								display.min(table, total, column);
								break;
							case "Rain":
							case "rain":
								column = 5;
								display.min(table, total, column);
								break;
							case "Sun":
							case "sun":
								column = 6;
								display.min(table, total, column);
								break;
							default:
								Console.WriteLine("min can't be displayed for this field");
								Console.WriteLine("");
								Menu.Main();
								break;
						}
						break;
						
					case "max":
						sort.shift(table, total);
						Console.WriteLine("what column do you want the maximum value for?(TMax, TMin, AF, Rain or Sun)");
						mval = Console.ReadLine();
						switch(mval) //asks what column query is for
						{
							case "TMax":
							case "Tmax":
							case "tmax":
								column = 2;
								display.max(table, total, column); //calls to display max value
								break;
							case "TMin":
							case "Tmin":
							case "tmin":
								column = 3;
								display.max(table, total, column);
								break;
							case "AF":
							case "Af":
							case "af":
								column = 4;
								display.max(table, total, column);
								break;
							case "Rain":
							case "rain":
								column = 5;
								display.max(table, total, column);
								break;
							case "Sun":
							case "sun":
								column = 6;
								display.max(table, total, column);
								break;
							default:
								Console.WriteLine("max can't be displayed for this field");
								Console.WriteLine("");
								Menu.Main();
								break;
						}
						break;
						
					case "whole": // just displays entire table
						sort.shift(table, total);
						Console.WriteLine();
						display.whole(table, total);
						break;
					
					case "average":
						sort.shift(table, total);
						Console.WriteLine("what column do you want the mean and median value for?(TMax, TMin, AF, Rain or Sun)");
						aval = Console.ReadLine();
						switch(aval) //asks what column query is for
						{
							case "TMax":
							case "Tmax":
							case "tmax":
								column = 2;
								sort.descendingNo(table, 0, total - 1, column, total, 0); //calls to sort column before median is found
								display.ave(table, total, column);
								break;
							case "TMin":
							case "Tmin":
							case "tmin":
								column = 3;
								sort.descendingNo(table, 0, total - 1, column, total, 0);
								display.ave(table, total, column);
								break;
							case "AF":
							case "Af":
							case "af":
								column = 4;
								sort.descendingNo(table, 0, total - 1, column, total, 0);
								display.ave(table, total, column);
								break;
							case "Rain":
							case "rain":
								column = 5;
								sort.descendingNo(table, 0, total - 1, column, total, 0);
								display.ave(table, total, column);
								break;
							case "Sun":
							case "sun":
								column = 6;
								sort.descendingNo(table, 0, total - 1, column, total, 0);
								display.ave(table, total, column);
								break;
							default:
								Console.WriteLine("averages can't be displayed for this field");
								Console.WriteLine("");
								Menu.Main();
								break;
						}
						break;
						
					default:
						Console.WriteLine("please enter a valid term");
						Console.WriteLine("");
						Menu.Main();
						break;
				}
				break;
				
				
						
			case "ws2":
				total = readIn.Tws2(file, table);
				Console.WriteLine("Search by: year, month, find the minimum, maximum or average values on record (enter min, max or average)");
				Console.WriteLine(@"or enter 'whole' to display entire record");
				method = Console.ReadLine();
				
				switch(method) // after station is taken asks what user wishes to query.
				{
					case "year":
						sort.shift(table, total);						
						display.year(table, total);
						break;
						
					case "month":
						sort.shift(table, total);						
						display.month(table, total);
						break;
						
					case "min":
						sort.shift(table, total);
						Console.WriteLine("what column do you want the minimum value for?(TMax, TMin, AF, Rain or Sun)");
						mval = Console.ReadLine();
						switch(mval) //asks what column query is for
						{
							case "TMax":
							case "Tmax":
							case "tmax":
								column = 2;
								display.min(table, total, column);
								break;
								
							case "TMin":
							case "Tmin":
							case "tmin":
								column = 3;
								display.min(table, total, column);
								break;
								
							case "AF":
							case "Af":
							case "af":
								column = 4;
								display.min(table, total, column);
								break;
								
							case "Rain":
							case "rain":
								column = 5;
								display.min(table, total, column);
								break;
								
							case "Sun":
							case "sun":
								column = 6;
								display.min(table, total, column);
								break;
								
							default:
								Console.WriteLine("min can't be displayed for this field");
								Console.WriteLine("");
								Menu.Main();
								break;
						}
						break;
						
					case "max":
						sort.shift(table, total);
						Console.WriteLine("what column do you want the maximum value for?(TMax, TMin, AF, Rain or Sun)");
						mval = Console.ReadLine();
						switch(mval) //asks what column query is for
						{
							case "TMax":
							case "Tmax":
							case "tmax":
								column = 2;
								display.max(table, total, column);
								break;
								
							case "TMin":
							case "Tmin":
							case "tmin":
								column = 3;
								display.max(table, total, column);
								break;
								
							case "AF":
							case "Af":
							case "af":
								column = 4;
								display.max(table, total, column);
								break;
								
							case "Rain":
							case "rain":
								column = 5;
								display.max(table, total, column);
								break;
								
							case "Sun":
							case "sun":
								column = 6;
								display.max(table, total, column);
								break;
								
							default:
								Console.WriteLine("max can't be displayed for this field");
								Console.WriteLine("");
								Menu.Main();
								break;
						}
						break;
						
					case "average":
						sort.shift(table, total);
						Console.WriteLine("what column do you want the mean and median value for?(TMax, TMin, AF, Rain or Sun)");
						aval = Console.ReadLine();
						switch(aval) //asks what column query is for, passes relevant column
						{
							case "TMax":
							case "Tmax":
							case "tmax":
								column = 2;
								sort.descendingNo(table, 0, total - 1, column, total, 0);
								display.ave(table, total, column); 
								break;
								
							case "TMin":
							case "Tmin":
							case "tmin":
								column = 3;
								sort.descendingNo(table, 0, total - 1, column, total, 0);
								display.ave(table, total, column);
								break;
								
							case "AF":
							case "Af":
							case "af":
								column = 4;
								sort.descendingNo(table, 0, total - 1, column, total, 0);
								display.ave(table, total, column);
								break;
								
							case "Rain":
							case "rain":
								column = 5;
								sort.descendingNo(table, 0, total - 1, column, total, 0);
								display.ave(table, total, column);
								break;
								
							case "Sun":
							case "sun":
								column = 6;
								sort.descendingNo(table, 0, total - 1, column, total, 0);
								display.ave(table, total, column);
								break;
								
							default:
								Console.WriteLine("invalid search field");
								Console.WriteLine("");
								Menu.Main();
								break;
						}
						break;
						
					case "whole":
						sort.shift(table, total);
						Console.WriteLine();
						display.whole(table, total);
						break;
						
					default:
						Console.WriteLine("please enter a valid term");
						Console.WriteLine("");
						Menu.Main();
						break;
				}
				break;
			case "quit":
			case "Quit":
			case "no":
			case "No":
			case "Don't":
			case "don't":
				return;
			default:
				Console.WriteLine("please enter a valid station");
				Console.WriteLine("");
				Menu.Main();
				break;
		}
		
	}	
}

class sort
{
	public static void shift(string[,] table, int total)
	{
		Console.WriteLine("what do you want your results sorted by?(Date, TMax, TMin, AF, Rain or Sun)");
		string sval = Console.ReadLine();
		Console.WriteLine("sorted by ascending or descending order?");
		string order = Console.ReadLine();
		int column;
		Stopwatch sw = new Stopwatch();//stopwatch for sorts
		//branches for various columns and order of sorting
		switch(order)
		{	
			case "asc":
				switch(sval)
				{
					case "DATE":
					case "date":
					case "Date":
						sw.Start();
						sort.ascendingDate(table, 0, total - 1);
						sw.Stop();
						Console.WriteLine("Time to sort = {0}", sw.Elapsed);
						break;
					case "TMax":
					case "Tmax":
					case "tmax":
						column = 2;
						sw.Start();
						sort.ascendingNo(table, 0, total - 1, column, total, 0);
						sw.Stop();
						Console.WriteLine("Time to sort = {0}", sw.Elapsed);
						break;
					case "TMin":
					case "Tmin":
					case "tmin":
						column = 3;
						sw.Start();
						sort.ascendingNo(table, 0, total - 1, column, total, 0);
						sw.Stop();
						Console.WriteLine("Time to sort = {0}", sw.Elapsed);
						break;
					case "AF":
					case "Af":
					case "af":
						column = 4;
						sw.Start();
						sort.ascendingNo(table, 0, total - 1, column, total, 0);
						sw.Stop();
						Console.WriteLine("Time to sort = {0}", sw.Elapsed);
						break;
					case "Rain":
					case "rain":
						column = 5;
						sw.Start();
						sort.ascendingNo(table, 0, total - 1, column, total, 0);
						sw.Stop();
						Console.WriteLine("Time to sort = {0}", sw.Elapsed);
						break;
					case "Sun":
					case "sun":
						column = 6;
						sw.Start();
						sort.ascendingNo(table, 0, total - 1, column, total, 0);
						sw.Stop();
						Console.WriteLine("Time to sort = {0}", sw.Elapsed);
						break;
					default:
						Console.WriteLine("invalid field to sort");
						sort.shift(table, total);
						break;
				}
				
				break;
			case "des":
				switch(sval)
				{
					case "DATE":
					case "date":
					case "Date":
						sw.Start();
						sort.descendingDate(table, 0, total - 1);
						sw.Stop();
						Console.WriteLine("Time to sort = {0}", sw.Elapsed);
						break;
					case "TMax":
					case "Tmax":
					case "tmax":
						column = 2;
						sw.Start();
						sort.descendingNo(table, 0, total - 1, column, total, 0);
						sw.Stop();
						Console.WriteLine("Time to sort = {0}", sw.Elapsed);
						break;
					case "TMin":
					case "Tmin":
					case "tmin":
						column = 3;
						sw.Start();
						sort.descendingNo(table, 0, total - 1, column, total, 0);
						sw.Stop();
						Console.WriteLine("Time to sort = {0}", sw.Elapsed);
						break;
					case "AF":
					case "Af":
					case "af":
						column = 4;
						sw.Start();
						sort.descendingNo(table, 0, total - 1, column, total, 0);
						sw.Stop();
						Console.WriteLine("Time to sort = {0}", sw.Elapsed);
						break;
					case "Rain":
					case "rain":
						column = 5;
						sw.Start();
						sort.descendingNo(table, 0, total - 1, column, total, 0);
						sw.Stop();
						Console.WriteLine("Time to sort = {0}", sw.Elapsed);
						break;
					case "Sun":
					case "sun":
						column = 6;
						sw.Start();
						sort.descendingNo(table, 0, total - 1, column, total, 0);
						sw.Stop();
						Console.WriteLine("Time to sort = {0}", sw.Elapsed);
						break;
					default:
						Console.WriteLine("invalid field to sort");
						sort.shift(table, total);
						break;
				}
				
				break;
				
			case "don't":
				break;
				
			default:
				Console.WriteLine("invalid");
				sort.shift(table, total);
				break;
		}
	}
	
	private static void descendingDate(string[,] table, int left, int right)//descending sort for numbers
	{
		int i = left, j = right; //temporary left and right values for the evaluations
        int pivot = Convert.ToInt32(table[(left + right) / 2,0]); //pulls year value as integer and assigns to temp
		string[] temp = new string[7];
        while (i <= j)
        {
			while (Convert.ToInt32(table[i,0]) >= pivot) // increments temporary left
            {
                i++;			
            }
 
            while (Convert.ToInt32(table[j,0]) <= pivot)// decrements temporary right
            {
                j--;
            }
 
            if (i <= j)
            {
                // Swap
                temp[0] = table[i,0];
				temp[1] = table[i,1];
				temp[2] = table[i,2];
				temp[3] = table[i,3];
				temp[4] = table[i,4];
				temp[5] = table[i,5];
				temp[6] = table[i,6];
                table[i,0] = table[j,0];
				table[i,1] = table[j,1];
				table[i,2] = table[j,2];
				table[i,3] = table[j,3];
				table[i,4] = table[j,4];
				table[i,5] = table[j,5];
				table[i,6] = table[j,6];
                table[j,0] = temp[0];
				table[j,1] = temp[1];
				table[j,2] = temp[2];
				table[j,3] = temp[3];
				table[j,4] = temp[4];
				table[j,5] = temp[5];
				table[j,6] = temp[6];
 
                i++;
                j--;
				
            }
        }
 
        // Recursive calls
        if (left < j)
        {
            sort.descendingDate(table, left, j);
        }
 
        if (i < right)
        {
            sort.descendingDate(table, i, right);
        }   
	}
		
	public static void descendingNo(string[,] table, int left, int right,int column, int total,int count)
	{
		int i = left, j = right; //temporary left and right values for the evaluations
        double pivot = Convert.ToDouble(table[left + (right-left) / 2,column]);
		string[] temp = new string[7];
        while (i <= j)
        {
			while (Convert.ToDouble(table[i,column]) > pivot)// increments temporary left
            {
                i++;			
            }
 
            while (Convert.ToDouble(table[j,column]) < pivot)// decrements temporary right
            {
                j--;
            }
 
            if (i <= j)
            {
                // Swap
                temp[0] = table[i,0];
				temp[1] = table[i,1];
				temp[2] = table[i,2];
				temp[3] = table[i,3];
				temp[4] = table[i,4];
				temp[5] = table[i,5];
				temp[6] = table[i,6];
                table[i,0] = table[j,0];
				table[i,1] = table[j,1];
				table[i,2] = table[j,2];
				table[i,3] = table[j,3];
				table[i,4] = table[j,4];
				table[i,5] = table[j,5];
				table[i,6] = table[j,6];
                table[j,0] = temp[0];
				table[j,1] = temp[1];
				table[j,2] = temp[2];
				table[j,3] = temp[3];
				table[j,4] = temp[4];
				table[j,5] = temp[5];
				table[j,6] = temp[6];
 
                i++;
                j--;
				
            }
        } 
		// iterative calls.
		if(count < total)
		{
			if (left < j)
			{
				sort.descendingNo(table, left, j, column, total, count+1);
			}
 
			if (i < right)
			{
				sort.descendingNo(table, i, right, column, total, count+1);
			} 
		}			   
	}
	
	private static void ascendingDate(string[,] table, int left, int right)
	{
		int i = left, j = right; //temporary left and right values for the evaluations
        int pivot = Convert.ToInt32(table[(left + right) / 2,0]);
		string[] temp = new string[7];
        while (i <= j)
        {
			while (Convert.ToInt32(table[i,0]) <= pivot)// increments temporary left
            {
                i++;			
            }
 
            while (Convert.ToInt32(table[j,0]) >= pivot)// decrements temporary right
            {
                j--;
            }
 
            if (i <= j)
            {
                // Swap
                temp[0] = table[i,0];
				temp[1] = table[i,1];
				temp[2] = table[i,2];
				temp[3] = table[i,3];
				temp[4] = table[i,4];
				temp[5] = table[i,5];
				temp[6] = table[i,6];
                table[i,0] = table[j,0];
				table[i,1] = table[j,1];
				table[i,2] = table[j,2];
				table[i,3] = table[j,3];
				table[i,4] = table[j,4];
				table[i,5] = table[j,5];
				table[i,6] = table[j,6];
                table[j,0] = temp[0];
				table[j,1] = temp[1];
				table[j,2] = temp[2];
				table[j,3] = temp[3];
				table[j,4] = temp[4];
				table[j,5] = temp[5];
				table[j,6] = temp[6];
 
                i++;
                j--;
				
            }
        }
 
        // Recursive calls
        if (left < j)
        {
            sort.ascendingDate(table, left, j);
        }
 
        if (i < right)
        {
            sort.ascendingDate(table, i, right);
        }
	}
	
	private static void ascendingNo(string[,] table, int left, int right,int column, int total,int count)
	{
		int i = left, j = right; //temporary left and right values for the evaluations
        double pivot = Convert.ToDouble(table[left + (right-left) / 2,column]);
		string[] temp = new string[7];
        while (i <= j)
        {
			while (Convert.ToDouble(table[i,column]) < pivot) //increments temporary left
            {
                i++;			
            }
 
            while (Convert.ToDouble(table[j,column]) > pivot)// decrements temporary right
            {
                j--;
            }
 
            if (i <= j)
            {
                // Swap
                temp[0] = table[i,0];
				temp[1] = table[i,1];
				temp[2] = table[i,2];
				temp[3] = table[i,3];
				temp[4] = table[i,4];
				temp[5] = table[i,5];
				temp[6] = table[i,6];
                table[i,0] = table[j,0];
				table[i,1] = table[j,1];
				table[i,2] = table[j,2];
				table[i,3] = table[j,3];
				table[i,4] = table[j,4];
				table[i,5] = table[j,5];
				table[i,6] = table[j,6];
                table[j,0] = temp[0];
				table[j,1] = temp[1];
				table[j,2] = temp[2];
				table[j,3] = temp[3];
				table[j,4] = temp[4];
				table[j,5] = temp[5];
				table[j,6] = temp[6];
 
                i++;
                j--;
				
            }
        } 
		// iterative calls.
		if(count < total)
		{
			if (left < j)
			{
				sort.ascendingNo(table, left, j, column, total, count+1);
			}
 
			if (i < right)
			{
				sort.ascendingNo(table, i, right, column, total, count+1);
			} 
		}			   
	}
}

class display
{
	public static void whole(string[,] table, int total) //displays entire table
	{
		Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", "Year", "Month", "TMax", "TMin", "AF", "Rain", "Sun");
		for(int j = 0; j <= total - 1; j++)
		{
			for(int i = 0; i <= 6; i++)
			{
				Console.Write("{0,10}|", table[j,i]);
			}
			Console.Write("\n");
		}
		Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", "Year", "Month", "TMax", "TMin", "AF", "Rain", "Sun");
		Console.WriteLine("");
		Menu.Main();
	}
	
	public static void year(string[,] table, int total) //method for finding year
	{
		Console.WriteLine("what year do you want the results for?");
		string yval = Console.ReadLine();
		Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", "Year", "Month", "TMax", "TMin", "AF", "Rain", "Sun");
		bool exists = false;
		for(int j = 0; j <= total - 1; j++)
		{
			if(table[j,0] == yval) //if year equals current row, displays row
			{
				for(int i = 0; i <= 6; i++)
				{
						Console.Write("{0,10}|", table[j,i]);
				}
				exists = true;			
				Console.Write("\n");
			}
		}
		if(exists == false) //provides error message if year isn't found
		{
			Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", "-", "-", "-", "-", "-", "-", "-");
			Console.WriteLine("invalid input or year doesn't exist in chosen station");
			Menu.Main();
		}
		Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", "Year", "Month", "TMax", "TMin", "AF", "Rain", "Sun");
		Console.WriteLine("");
		Menu.Main();
	}
	
	public static void month(string[,] table, int total) //method for finding month
	{
		Console.WriteLine("what month do you want the results for? (case sensitive)");
		string mval = Console.ReadLine();
		Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", "Year", "Month", "TMax", "TMin", "AF", "Rain", "Sun");
		bool exists = false;
		for(int j = 0; j <= total - 1; j++)
		{
			if(table[j,1] == mval) //if month equals current row, displays row
			{
				for(int i = 0; i <= 6; i++)
				{
						Console.Write("{0,10}|", table[j,i]);
				}
				exists = true;				
				Console.Write("\n");
			}
		}
		if(exists == false) //provides error message if month isn't found
		{
			Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", "-", "-", "-", "-", "-", "-", "-");
			Console.WriteLine("invalid input or year doesn't exist in chosen station");
			Menu.Main();
		}
		Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", "Year", "Month", "TMax", "TMin", "AF", "Rain", "Sun");
		Console.WriteLine("");
		Menu.Main();
	}
	
	public static void min(string[,] table, int total, int column)
	{
		string[,] temp = new string[20,7];
		temp[0,0] = table[0,0];
		temp[0,1] = table[0,1];
		temp[0,2] = table[0,2];
		temp[0,3] = table[0,3];
		temp[0,4] = table[0,4];
		temp[0,5] = table[0,5];
		temp[0,6] = table[0,6];
		int count = 0;
		for(int j = 0; j <= total - 1; j++)
		{
			
			
			if(Convert.ToDouble(table[j,column]) == Convert.ToDouble(temp[0,column])) // appends value if its equal to max
			{
				if(count <= 18)
				{
					temp[count,0] = table[j,0];	
					temp[count,1] = table[j,1];	
					temp[count,2] = table[j,2];	
					temp[count,3] = table[j,3];	
					temp[count,4] = table[j,4];	
					temp[count,5] = table[j,5];	
					temp[count,6] = table[j,6];	
					count++; //increments counter
				}
			}
			
			if(Convert.ToDouble(table[j,column]) < Convert.ToDouble(temp[0,column])) //evaluates current row with temp
			{
				Array.Clear(temp, 0, temp.Length); //clears the array 
				for(int i = 0; i <= 6; i++)
				{
					temp[0,i] = table[j,i];	//assigns new min
				}	
				count=1; //sets counter
			}
		}
		Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", "Year", "Month", "TMax", "TMin", "AF", "Rain", "Sun");
		//displays min value using for loop
		for(int k = 0; k <= count - 1; k++)
		{
			Console.Write("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", temp[k,0], temp[k,1], temp[k,2], temp[k,3], temp[k,4], temp[k,5], temp[k,6]);
			Console.Write("\n");
		}
		Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", "Year", "Month", "TMax", "TMin", "AF", "Rain", "Sun");
		Console.WriteLine("");
		Menu.Main();
	}
	
	public static void max(string[,] table, int total, int column) //method for max value
	{
		string[,] temp = new string[20,7];
		temp[0,0] = table[0,0];
		temp[0,1] = table[0,1];
		temp[0,2] = table[0,2];
		temp[0,3] = table[0,3];
		temp[0,4] = table[0,4];
		temp[0,5] = table[0,5];
		temp[0,6] = table[0,6];
		int count = 0;
		for(int j = 0; j <= total - 1; j++)
		{
			
			
			if(Convert.ToDouble(table[j,column]) == Convert.ToDouble(temp[0,column])) // appends value if its equal to max
			{
				if(count <= 18)
				{
					temp[count,0] = table[j,0];	
					temp[count,1] = table[j,1];	
					temp[count,2] = table[j,2];	
					temp[count,3] = table[j,3];	
					temp[count,4] = table[j,4];	
					temp[count,5] = table[j,5];	
					temp[count,6] = table[j,6];	
					count++;
				}
					
			}
			
			if(Convert.ToDouble(table[j,column]) > Convert.ToDouble(temp[0,column])) //evaluates current row with temp
			{
				Console.WriteLine("{0}", column);
				Array.Clear(temp, 0, temp.Length);//clears the array 
				for(int i = 0; i <= 6; i++)
				{
					temp[0,i] = table[j,i];	
				}	
				count=1;
			}
		}
		Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", "Year", "Month", "TMax", "TMin", "AF", "Rain", "Sun");
		//displays max value using for loop
		for(int k = 0; k <= count - 1; k++)
		{
			Console.Write("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", temp[k,0], temp[k,1], temp[k,2], temp[k,3], temp[k,4], temp[k,5], temp[k,6]);
			Console.Write("\n");
		}
		Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", "Year", "Month", "TMax", "TMin", "AF", "Rain", "Sun");
		Console.WriteLine("");
		Menu.Main(); //returns to menu
	}
	
	public static void ave(string[,] table, int total, int column) //method for displaying averages
	{
		double mean = 0; 
		
		for(int j = 0; j <= total - 1; j++)
		{
			mean += Convert.ToDouble(table[j,column]);
		}
		
		mean = mean/total;
		
		switch(column) // different outputs for different columns
		{
			case 2:
				Console.WriteLine("mean Maximum Temperature (celsius) = {0}", mean);
				break;
			case 3:
				Console.WriteLine("mean Minimum Temperature (celsius) = {0}", mean);
				break;
			case 4:
				Console.WriteLine("mean Air Frost (days) = {0}", mean);
				break;
			case 5:
				Console.WriteLine("mean Rainfall (mm) = {0}", mean);
				break;
			case 6:
				Console.WriteLine("mean Sunlight (hours) = {0}", mean);
				break;
		}
		
		int median = total/2;
		
		if(IsOdd(total)) // displays middle value if odd number of total entries
		{
			Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", "Year", "Month", "TMax", "TMin", "AF", "Rain", "Sun");
			Console.Write("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", table[median,0], table[median,1], table[median,2], table[median,3], table[median,4], table[median,5], table[median,6]);
			Console.Write("\n");
			Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", "Year", "Month", "TMax", "TMin", "AF", "Rain", "Sun");
		}
		
		if(IsEven(total)) //displays the two middle values if there are an even number of total entries
		{
			Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", "Year", "Month", "TMax", "TMin", "AF", "Rain", "Sun");
			Console.Write("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", table[median,0], table[median,1], table[median,2], table[median,3], table[median,4], table[median,5], table[median,6]);
			Console.Write("\n");
			Console.Write("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", table[median - 1,0], table[median - 1,1], table[median - 1,2], table[median - 1,3], table[median - 1,4], table[median - 1,5], table[median - 1,6]);
			Console.Write("\n");
			Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|", "Year", "Month", "TMax", "TMin", "AF", "Rain", "Sun");
			Console.WriteLine("");
		}
		
		else
		{
			Console.WriteLine("cannot find median");
		}
		Menu.Main(); //returns to menu
		
	}
	
	public static bool IsOdd(int value) //sees if value is odd
    {
		return value % 2 != 0;
    }
	
	public static bool IsEven(int value) //sees if value is even
    {
		return value % 2 == 0;
    }
}

class readIn
{
	public static int Tws1(string file, string[,] table) //performs read in for weather station 1
	{	
		int count; // counter to increment through array.
		int total = 0;
		
		try //tries the streamreader with the entered file name.
		{
			using (StreamReader sr = new StreamReader(file + "Year.txt")) //opens year text file.				
			{
				count = 0; // sets the counter to 0 for the current column.
				while (sr.Peek() > -1) 
				{					
					string line = sr.ReadLine();
					table[count,0] = line;
					count++;
				}
			}
			
			using (StreamReader sr = new StreamReader(file + "Month.txt")) // opens month text file.
			{
				count = 0; // sets the counter to 0 for the current column.
				while (sr.Peek() > -1) 
				{
					string line = sr.ReadLine();
					table[count,1] = line;
					count++;
				}
			}
			
			using (StreamReader sr = new StreamReader(file + "WS1_TMax.txt")) 
			{
				count = 0; // sets the counter to 0 for the current column.
				while (sr.Peek() > -1) 
				{
					string line = sr.ReadLine();
					table[count,2] = line;
					count++;
				}
			}
			
			using (StreamReader sr = new StreamReader(file + "WS1_TMin.txt")) //
			{
				count = 0; // sets the counter to 0 for the current column.
				while (sr.Peek() > -1) 
				{
					string line = sr.ReadLine();
					table[count,3] = line;
					count++;
				}
			}
			
			using (StreamReader sr = new StreamReader(file + "WS1_AF.txt")) //opens average rainfall text file.
			{
				count = 0; // sets the counter to 0 for the current column.
				while (sr.Peek() > -1) 
				{
					string line = sr.ReadLine();
					table[count,4] = line;
					count++;
				}
			}
			
			using (StreamReader sr = new StreamReader(file + "WS1_Rain.txt")) //opens rainfall text file.
			{
				count = 0; // sets the counter to 0 for the current column.
				while (sr.Peek() > -1) 
				{
					string line = sr.ReadLine();
					table[count,5] = line;
					count++;
				}
			}
			
			using (StreamReader sr = new StreamReader(file + "WS1_Sun.txt")) //opens sunlight text file.
			{
				count = 0; // sets the counter to 0 for the current column.
				while (sr.Peek() > -1) 
				{
					string line = sr.ReadLine();
					table[count,6] = line;
					count++;
					if(line != "")
					{
						total++;
					}
					
				}
			}
		}
		
		
		
		catch (Exception e) //returns shortened error message if unable to read in text.
		{				
			Console.WriteLine("{0}",e.ToString()); 			
		}
		
		return(total);
	}
	
	public static int Tws2(string file, string[,] table) //performs read in for weather station 2
	{	
		int count; // counter to increment through array.
		int total = 0;
		
		try //tries the streamreader with the entered file name.
		{
			using (StreamReader sr = new StreamReader(file + "Year.txt")) //opens year text file.				
			{
				count = 0; // sets the counter to 0 for the current column.
				while (sr.Peek() > -1) 
				{					
					string line = sr.ReadLine();
					table[count,0] = line;
					count++;
				}
			}
			
			using (StreamReader sr = new StreamReader(file + "Month.txt")) // opens month text file.
			{
				count = 0; // sets the counter to 0 for the current column.
				while (sr.Peek() > -1) 
				{
					string line = sr.ReadLine();
					table[count,1] = line;
					count++;
				}
			}
			
			using (StreamReader sr = new StreamReader(file + "WS2_TMax.txt")) 
			{
				count = 0; // sets the counter to 0 for the current column.
				while (sr.Peek() > -1) 
				{
					string line = sr.ReadLine();
					table[count,2] = line;
					count++;
				}
			}
			
			using (StreamReader sr = new StreamReader(file + "WS2_TMin.txt")) //
			{
				count = 0; // sets the counter to 0 for the current column.
				while (sr.Peek() > -1) 
				{
					string line = sr.ReadLine();
					table[count,3] = line;
					count++;
				}
			}
			
			using (StreamReader sr = new StreamReader(file + "WS2_AF.txt")) //opens average rainfall text file.
			{
				count = 0; // sets the counter to 0 for the current column.
				while (sr.Peek() > -1) 
				{
					string line = sr.ReadLine();
					table[count,4] = line;
					count++;
				}
			}
			
			using (StreamReader sr = new StreamReader(file + "WS2_Rain.txt")) //opens rainfall text file.
			{
				count = 0; // sets the counter to 0 for the current column.
				while (sr.Peek() > -1) 
				{
					string line = sr.ReadLine();
					table[count,5] = line;
					count++;
				}
			}
			
			using (StreamReader sr = new StreamReader(file + "WS2_Sun.txt")) //opens sunlight text file.
			{
				count = 0; // sets the counter to 0 for the current column.
				while (sr.Peek() > -1) 
				{
					string line = sr.ReadLine();
					table[count,6] = line;
					count++;
					if(line != "")
					{
						total++;
					}
					
				}
			}
		}
		
		
		
		catch (Exception e) //returns shortened error message if unable to read in text.
		{				
			Console.WriteLine("{0}",e.ToString()); 			
		}
		
		return(total);
	}
}

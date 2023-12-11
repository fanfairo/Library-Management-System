/*******************************************************************
* Name: Osha Fanfair
* Date:12/ 10/23
* Assignment: CIS317 Week 5 Final Exam
*
* Main application class.
*/

class Program
{
    private static List<Building> buildingList = new List<Building>();
    private static StreamWriter logFile;

    static void Main()
    {
        // Initialize log file
        logFile = new StreamWriter("OshaFanfair_log.txt");

        // Print header
        PrintLog("Osha Fanfair - Week 5 Final Practical Exam");

        // Create and add buildings to the list
        buildingList.Add(new House(4, new Door(32, "Red"), new Kitchen("Modern", "BrandA")));
        buildingList.Add(new House(3, new Door(30, "Blue"), new Kitchen("Contemporary", "BrandB")));
        buildingList.Add(new House(5, new Door(36, "Green"), new Kitchen("Country", "BrandC")));
        buildingList.Add(new House(6, new Door(34, "Yellow"), new Kitchen("Chef's", "BrandD")));
        buildingList.Add(new House(4, new Door(32, "White"), new Kitchen("Modern", "BrandE")));

        // Print the list of buildings iteratively
        PrintLog("Printing buildings iteratively:");
        PrintBuildingListIteratively();

        // Print the list of buildings recursively
        PrintLog("Printing buildings recursively:");
        PrintBuildingListRecursively(buildingList.Count - 1);

        // Close log file
        logFile.Close();
    }

    private static void PrintBuildingListIteratively()
    {
        foreach (var building in buildingList)
        {
            PrintLog(building.ToString());
        }
    }

    private static void PrintBuildingListRecursively(int index)
    {
        if (index >= 0)
        {
            PrintBuildingListRecursively(index - 1);
            PrintLog(buildingList[index].ToString());
        }
    }

    private static void PrintLog(string message)
    {
        
        Console.WriteLine(message);
      
        logFile.WriteLine(message);
    }
}
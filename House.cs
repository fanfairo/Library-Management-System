/*******************************************************************
* Name: Osha Fanfair
* Date:12/ 10/23
* Assignment: CIS317 Week 5 Final Exam
*
* Door class.
*/

public class House : Building
{
    // Properties
    private int NumRooms { get; set; }
    private Door FrontDoor { get; set; }
    private Kitchen MainKitchen { get; set; }

    // Constructors
    public House(int numRooms, Door frontDoor, Kitchen mainKitchen) : base("House")
    {
        NumRooms = numRooms;
        FrontDoor = frontDoor;
        MainKitchen = mainKitchen;
    }

    // Methods
    public override int GetRooms()
    {
        return NumRooms;
    }

    public override string ToString()
    {
        return $"{base.ToString()} - {NumRooms} rooms, {FrontDoor}, {MainKitchen}";
    }
}
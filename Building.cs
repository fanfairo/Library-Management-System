/*******************************************************************
* Name: Osha Fanfair
* Date:12/ 10/23
* Assignment: CIS317 Week 5 Final Exam
*
* Building class.
*/

public abstract class Building
{
    // Properties
    private string BuildingType { get; set; }

    // Constructors
    protected Building(string buildingType)
    {
        BuildingType = buildingType;
    }

    // Methods
    public abstract int GetRooms();
    
    public override string ToString()
    {
        return $"{BuildingType} Building";
    }
}
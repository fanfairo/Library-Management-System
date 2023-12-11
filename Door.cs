/*******************************************************************
* Name: Osha Fanfair
* Date:12/ 10/23
* Assignment: CIS317 Week 5 Final Exam
*
* Door class.
*/

public class Door
{
    // Properties
    private int Width { get; set; }
    private string Color { get; set; }

    // Constructors
    public Door(int width, string color)
    {
        Width = width;
        Color = color;
    }

    // Methods
    public override string ToString()
    {
        return $"Door - Width: {Width}, Color: {Color}";
    }
}
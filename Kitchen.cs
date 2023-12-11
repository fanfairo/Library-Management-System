/*******************************************************************
* Name: Osha Fanfair
* Date:12/ 10/23
* Assignment: CIS317 Week 5 Final Exam
*
* Kitchen class.
*/

public class Kitchen
{
    // Properties
    private string Style { get; set; }
    private string ApplianceBrand { get; set; }

    // Constructors
    public Kitchen(string style, string applianceBrand)
    {
        Style = style;
        ApplianceBrand = applianceBrand;
    }

    // Methods
    public override string ToString()
    {
        return $"Kitchen - Style: {Style}, Appliance Brand: {ApplianceBrand}";
    }
}
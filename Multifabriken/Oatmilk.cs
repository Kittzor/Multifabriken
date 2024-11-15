//Creates the class oatmilk with two properties: fatcontent and literamount
class Oatmilk
{
    public int fatContent { get; set; }
    public int literAmount { get; set; }

    //Constructor to create a oatmilk object
    public Oatmilk(int fatContent, int literAmount)
    {
        this.fatContent = fatContent;
        this.literAmount = literAmount;
    }

    //overrides the ToString method to return a text of the oatmilk object
    public override string ToString()
    {
        return $"Havremjölk - fetthalt: {fatContent}%, litermängd: {literAmount} liter";
    }
}
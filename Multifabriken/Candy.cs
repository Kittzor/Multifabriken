//Creates the class candy with two properties: flavour and quantity
class Candy
{
    public string flavour { get; set; }
    public int quantity { get; set; }

    //Constructor to create a candy object
    public Candy(string flavour, int quantity)
    {
        this.flavour = flavour;
        this.quantity = quantity;
    }

    //overrides the ToString method to return a text of the candy object
    public override string ToString()
    {
        return $"Godis - Smak: {flavour}, Antal: {quantity}";
    }
}
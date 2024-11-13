class Candy
{
    public string flavour { get; set; }
    public string quantity { get; set; }

    public Candy(string flavour, string quantity)
    {
        this.flavour = flavour;
        this.quantity = quantity;
    }

    public override string ToString()
    {
        return $"Godis - Smak: {flavour}, Antal: {quantity}";
    }
}
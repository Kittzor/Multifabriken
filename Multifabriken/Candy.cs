class Candy
{
    public string flavour { get; set; }
    public int quantity { get; set; }

    public Candy(string flavour, int quantity)
    {
        this.flavour = flavour;
        this.quantity = quantity;
    }

    public override string ToString()
    {
        return $"Godis - Smak: {flavour}, Antal: {quantity}";
    }
}
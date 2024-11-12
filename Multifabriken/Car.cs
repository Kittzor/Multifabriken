class Car
{
    public string regNumber { get; set; }
    public string color { get; set; }
    public string brand { get; set; }

    public Car(string regNumber, string color, string brand)
    {
        this.regNumber = regNumber;
        this.color = color;
        this.brand = brand;
    }

    public override string ToString()
    {
        return $"Bil - Registreringsnummer: {regNumber}, Färg: {color}, Märke: {brand}";
    }
}
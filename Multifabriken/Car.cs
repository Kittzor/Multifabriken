//Create the class car with three properties: regnumber, color and brand
class Car
{
    public string regNumber { get; set; }
    public string color { get; set; }
    public string brand { get; set; }

    //Constructor to create a car object
    public Car(string regNumber, string color, string brand)
    {
        this.regNumber = regNumber;
        this.color = color;
        this.brand = brand;
    }

    //overrides the ToString method to return a text of the car object
    public override string ToString()
    {
        return $"Bil - Registreringsnummer: {regNumber}, Färg: {color}, Märke: {brand}";
    }
}
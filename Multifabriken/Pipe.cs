//Create the class pipe with two properties, diameter and length
class Pipe
{
    public int diameter { get; set; }
    public int length { get; set; }

    //constructor to create a pipe object
    public Pipe(int diameter, int length)
    {
        this.diameter = diameter;
        this.length = length;
    }

    //overrides the ToString method to return a text of the pipe object
    public override string ToString()
    {
        return $"Rör - diameter: {diameter}cm, längd: {length}cm ";
    }
}
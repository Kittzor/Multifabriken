class Pipe
{
    public int diameter { get; set; }
    public int length { get; set; }

    public Pipe(int diameter, int length)
    {
        this.diameter = diameter;
        this.length = length;
    }

    public override string ToString()
    {
        return $"R�r - diameter: {diameter}cm, l�ngd: {length}cm ";
    }
}
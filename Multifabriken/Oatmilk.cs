class Oatmilk
{
    public int fatContent { get; set; }
    public int literAmount { get; set; }

    public Oatmilk(int fatContent, int literAmount)
    {
        this.fatContent = fatContent;
        this.literAmount = literAmount;
    }

    public override string ToString()
    {
        return $"Havremj�lk - fetthalt: {fatContent}%, literm�ngd: {literAmount} liter";
    }
}
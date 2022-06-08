class Food
{
    public string Name;
    public int Calories;
    public bool IsSpicy;
    public bool IsSweet;

    public Food (string name, int cal, bool Sp, bool Sw)
    {
        Name = name;
        Calories = cal;
        IsSpicy = Sp;
        IsSweet = Sw;
    }
}
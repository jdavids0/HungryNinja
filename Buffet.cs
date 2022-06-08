class Buffet
{
    public List<Food> Menu;

    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Chana Masala", 1000, false, false),
            new Food("Yogurt", 350, false, false),
            new Food("Chicken Haryali", 800, true, false),
            new Food("Gobi Manchurian", 500, false, true),
            new Food("Jasmine Rice", 500, false, false),
            new Food("Samosa", 300, false, false),
            new Food("Naan", 200, false, false)


        };
    }

    public Food Serve()
    {
        Random rand = new Random();
        int randInt = rand.Next(Menu.Count);
        return Menu[randInt];

    }
}


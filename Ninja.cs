class Ninja
{
    public string Name;
    private int calorieIntake;
    public List<Food> FoodHistory;

    public Ninja (string name)
    {
        Name = name;
        calorieIntake = 0;
        FoodHistory = new List<Food>();

    }

    public int CalorieProp
    {
        get
        {
            return calorieIntake;
        }
    }

    // add a public "getter" property called "IsFull"
    public bool IsFull
    {
        get
        {
            if(calorieIntake > 1200){
                Console.WriteLine("is full");
                return true;
            }
            Console.WriteLine("is still hungry");
            return false;
        }
    }

    // build out the Eat method
    public void Eat(Food item)
    {
        calorieIntake += item.Calories;
        FoodHistory.Add(item);
        Console.WriteLine($"Food: {item.Name}, Spicy: {item.IsSpicy}, Sweet: {item.IsSweet}");
    }
}


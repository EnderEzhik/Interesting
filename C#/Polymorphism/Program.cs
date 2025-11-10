class Program
{
    static void Main(string[] args)
    {
        var potions = new IPotion[3]
        {
            new WaterPotion(),
            new HealthPotion(),
            new PoisonPotion()
        };

        foreach (IPotion potion in potions)
        {
            potion.Drink();
        }
    }
}

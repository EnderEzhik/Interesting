public class WaterPotion : IPotion
{
    public void Drink()
    {
        Console.WriteLine("Это зелье из воды и оно ничего не делает");
    }
}

public class HealthPotion : IPotion
{
    public void Drink()
    {
        Console.WriteLine("Это зелье здоровья и оно восстанавливает здоровье");
    }
}

public class PoisonPotion : IPotion
{
    public void Drink()
    {
        Console.WriteLine("Это зелье не надо было пить");
    }
}

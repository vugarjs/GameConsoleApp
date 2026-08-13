namespace Game.Main;

internal class GameCharacter
{
    private decimal health { get; set; } = 100;
    private int level { get; set; } = 1;
    public string Name { get; set; }
    public string Gun { get; set; }
    public bool IsAlive { get; set; } = true;

    public void TakeDamage(decimal damage)
    {
        if (damage > 0)
            health -= damage;
        if (health <= 0)
        {
            health = 0;
            IsAlive = false;
            Console.WriteLine("Character died!");
        }
    }
    public void Heal(decimal heal)
    {
        if (IsAlive)
        {
            if (heal > 0)
            {
                health += heal;
                if (health > 100)
                    health = 100;
            }
        }
    }
    public void Attack()    
    {
        if (IsAlive)
        {
            Console.WriteLine($"{Name} attacks with {Gun}");
        }
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Weapon : {Gun}");
        Console.WriteLine($"Level : {level}");
        Console.WriteLine($"Health : {health}");
        if (IsAlive)
        {
            Console.WriteLine($"Status : Alive ");
        }
        else
        {
            Console.WriteLine($"Status : Die ");
        }
    }
    public void LevelUp()
    {
        level += 1;
    }
    public void Respawn()
    {
        if(IsAlive == false)
        {
            health = 100;
            IsAlive  = true;
            Console.WriteLine("You Respawned.");
        }
    }
    public GameCharacter(string name, string weapon)
    {
        Name = name;
        Gun = weapon;
    }
}

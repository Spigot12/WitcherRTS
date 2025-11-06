namespace WitcherRTS.Core.Models;

public class Unit
{
    private string name;
    private int health;
    private int attackPower;
    private int defence;
    private string faction;
    public Unit(string name, int health, int attackPower, int defence, string faction)
    {
        this.name = name;
        this.health = health;
        this.attackPower = attackPower;
        this.defence = defence;
        this.faction = faction;
        
        
    }

    void Attack(Unit target)
    {
        int damage = this.attackPower - target.defence;

        if (damage < 1)
        {
            damage = 1;
        }
        
        target.TakeDamage(damage);
    }
    
    void TakeDamage(int damage)
    {
        health -= damage;
        
        if (health < 0)
        {
            health = 0;
            Console.WriteLine("Du bist gestorben.");
        }
        
        Console.WriteLine($"{name} erleidet {damage} Schaden. HP = {health}");
        
        
    }

    public bool isAlive()
    {
        return health > 0;
    }
    
}
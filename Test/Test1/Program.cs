using System;

public class AutoBattleGame
{
    private int playerHealth = 100;
    private int enemyHealth = 50;
    private bool isAutoBattleActive = false;

    public void Start()
    {
        StartAutoBattle();
    }

    public void Update()
    {
        if (isAutoBattleActive)
        {
 
            if (enemyHealth > 0)
            {
                AttackEnemy();
            }
            else
            {
                EndAutoBattle();
            }
        }
    }

    private void StartAutoBattle()
    {
        isAutoBattleActive = true;
        Console.WriteLine("Auto Battle started!");
    }

    private void EndAutoBattle()
    {
        isAutoBattleActive = false;
        Console.WriteLine("Auto Battle ended!");
    }

    private void AttackEnemy()
    {

        enemyHealth -= 10;
        Console.WriteLine("Enemy health: " + enemyHealth);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        AutoBattleGame game = new AutoBattleGame();
        game.Start();

        while (true)
        {
            game.Update();
        }
    }
}
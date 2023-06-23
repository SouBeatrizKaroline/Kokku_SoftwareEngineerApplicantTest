using System;
using System.Threading;

public class AutoBattleGame
{
    private bool isAutoBattleActive = false;

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("===== AUTO BATTLE GAME =====");
        Console.WriteLine("Pressione qualquer tecla para iniciar a batalha automática...");
        Console.ReadKey();
        Console.Clear();

        isAutoBattleActive = true;
        Console.WriteLine("Batalha automática iniciada!");

        while (isAutoBattleActive)
        {

            Console.WriteLine("Ataque realizado!");

            Thread.Sleep(1000);
        }

        Console.WriteLine("Batalha automática encerrada!");
    }

    public void Stop()
    {
        isAutoBattleActive = false;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        AutoBattleGame game = new AutoBattleGame();
        game.Start();

        Console.WriteLine("Pressione qualquer tecla para encerrar a aplicação...");
        Console.ReadKey();

        game.Stop();
    }
}

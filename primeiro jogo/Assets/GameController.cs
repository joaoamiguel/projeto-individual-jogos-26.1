using UnityEngine;

public static class GameController
{
    public static int score;
    public static bool gameOver
    {
        get { return PlayerMovement.player_health <= 0; }
    }
    
    public static void Init()
    {
        PlayerMovement.player_health = 1;
        score = 0;
    }

    public static void Collect()
    {
        score += 10;
    }

    public static void TakeDamage()
    {
        PlayerMovement.player_health--;
    }
}

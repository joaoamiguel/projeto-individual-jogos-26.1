using UnityEngine;

public static class GameController
{
    public static int score;
    public static float time;
    public static bool gameOver
    {
        get { return PlayerMovement.player_health <= 0; }
    }
    
    public static void Init()
    {
        PlayerMovement.player_health = 1;
        score = 0;
        time = 0;
        UIController.startTimer = true;
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

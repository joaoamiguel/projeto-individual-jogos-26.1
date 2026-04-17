using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] TextMeshProUGUI totalScore;
    public static bool startTimer = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Init()
    {
        GameController.time = 0;
    }

    public static void StopTimer()
    {
        startTimer = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (startTimer)
        {
            GameController.time += Time.deltaTime;
        }
        
        timer.text = GameController.time.ToString("F2");
        
        totalScore.text = GameController.score.ToString();
    }
}

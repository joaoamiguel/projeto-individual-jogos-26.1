using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    private float time = 0;
    
    [SerializeField] TextMeshProUGUI timer;

    [SerializeField] private TextMeshProUGUI totalScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Init()
    {
        time = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timer.text = time.ToString("F2");
        
        totalScore.text = GameController.score.ToString();
    }
}

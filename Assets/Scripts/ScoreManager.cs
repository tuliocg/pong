using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text playerScoreText;
    public Text opponentScoreText;

    private int playerScore = 0;
    private int opponentScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerScoreText.text = playerScore.ToString() + "point(s)";
        opponentScoreText.text = opponentScore.ToString() + "point(s)";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TMP_Text playerScoreText;
    [SerializeField] private TMP_Text opponentScoreText;

    private int playerScore = 0;
    private int opponentScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void addPlayerScore()
    {
        playerScore++;
        playerScoreText.SetText(playerScore.ToString());
    }

    public void addOpponentScore()
    {
        opponentScore++;
        opponentScoreText.SetText(opponentScore.ToString());
    }
}

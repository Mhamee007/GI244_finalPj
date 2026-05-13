using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIcanvas : MonoBehaviour
{
    public PlayerController player;
    public TMP_Text speedText;
    public TMP_Text hpText;

    public TMP_Text finalScoreText;
    int HightfinalScore;

    public float score = 0f;
    public TMP_Text scoreText;
    public Button restart;
    public Button quit;

    public GameObject gameOverPanel;
    void Start()
    {
        Time.timeScale = 1f;

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
            finalScoreText.gameObject.SetActive(false);
            restart.gameObject.SetActive(false);
            quit.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        speedText.text = "Speed : " + player.speed.ToString("F1");
        hpText.text = "HP : " + player.hp.ToString();

        score += Time.deltaTime * 10f;

        scoreText.text = "Score : " + Mathf.FloorToInt(score);

        if (player.hp <= 0)
        {
            GameOver();
        }

        HightfinalScore = PlayerPrefs.GetInt("HighScore", 0);
        finalScoreText.text = "GAME OVER Score : " + HightfinalScore;
    }

    void GameOver()
    {
        int currentScore = Mathf.FloorToInt(score);
        if (currentScore > HightfinalScore)
        {
            HightfinalScore = currentScore;
            PlayerPrefs.SetInt("HighScore", HightfinalScore);

            PlayerPrefs.Save();
        }
        finalScoreText.text = "High Score : " + HightfinalScore;

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
            finalScoreText.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
            quit.gameObject.SetActive(true);

            scoreText.gameObject.SetActive(false);
            speedText.gameObject.SetActive(false);
            hpText.gameObject.SetActive(false);

        }
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitsGame()
    {
       
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}

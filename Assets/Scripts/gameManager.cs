using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject gameOverPanel;

    void Start()
    {
        Time.timeScale = 1f;
    }


    void Update()
    {
        
        
    }

   /* public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }*/
}

using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class meneUI : MonoBehaviour
{

    public TMP_Text name;
    

    public Button startGame;
    public Button quit;

    public GameObject gameOverPanel;
  
    void Update()
    {
       
    }


    public void PlayGame()
    {
        SceneManager.LoadScene("playScene");
    }



    public void ExitsGame()
    {

        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}

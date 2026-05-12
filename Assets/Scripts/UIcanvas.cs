using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UIcanvas : MonoBehaviour
{
    public PlayerController player;
    public TMP_Text speedText;
    public TMP_Text hpText;

    public float score = 0f;
    public TMP_Text scoreText;

    
    void Update()
    {
        speedText.text = "Speed : " + player.speed.ToString("F1");
        hpText.text = "HP : " + player.hp.ToString();

        score += Time.deltaTime * 10f;
        scoreText.text = "Score : " + Mathf.FloorToInt(score);
    }
}

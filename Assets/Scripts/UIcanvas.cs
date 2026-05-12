using TMPro;
using UnityEngine;

public class UIcanvas : MonoBehaviour
{
    public PlayerController player;
    public TMP_Text speedText;
    public TMP_Text hpText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speedText.text = "Speed : " + player.speed.ToString("F1");
        hpText.text = "HP : " + player.hp.ToString();
    }
}

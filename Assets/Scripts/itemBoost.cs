using UnityEngine;
using UnityEngine.InputSystem;

public class itemBoost : MonoBehaviour
{
    public float boostMultiplier = 2f;
    public float boostDuration = 3f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();

            if (player != null)
            {
                player.ActivateBoost(boostMultiplier, boostDuration);
            }

            gameObject.SetActive(false);
        }
    }
}

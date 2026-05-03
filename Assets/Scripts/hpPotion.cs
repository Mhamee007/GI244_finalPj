using UnityEngine;

public class hpPotion : MonoBehaviour
{
    public float hpUp= 1f;
  

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();

            if (player != null)
            {
                player.hp = hpUp + player.hp;
            }

            gameObject.SetActive(false);
        }
    }
}

using UnityEngine;

public class obstacles : MonoBehaviour
{
    public float speedMin = 5;
    public float speedMax= 15;
    [SerializeField] float moveSpeed;

    private void OnEnable()
    {
        moveSpeed = Random.Range(speedMin, speedMax);
    }
    private void Update()
    {
        
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        if (transform.position.z < -10f)
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {           
            gameObject.SetActive(false);

        }
    }
}

using UnityEngine;

public class roadMove : MonoBehaviour
{
    public float speed = 10.0f;
    public float posZ = 150;
    public float posZreset = 100;
   
    void Update()
    {
        Transform t = gameObject.GetComponent<Transform>();
        t.Translate(Vector3.right * speed * Time.deltaTime);

        if (transform.position.z <= posZreset)
        {
            Vector3 newPos = transform.position;
            newPos.z = posZ;
            transform.position = newPos;
        }

    }
}

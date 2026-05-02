using UnityEngine;

public class roadMove : MonoBehaviour
{
    public float speed = 10.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform t = gameObject.GetComponent<Transform>();
        t.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

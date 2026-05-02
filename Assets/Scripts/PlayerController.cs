// Lecture Note
// [1] New Input System in Unity: https://learn.unity.com/tutorial/getting-started-with-the-new-input-system

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 0f;
    float horizontalInput = 0;
    float forwardInput = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // hello classroom
        Debug.Log("Hello GI244");
    }

    // Update is called once per frame
    void Update()
    {
        // [1] manage input using Keyboard
        // if (Input.GetKey(KeyCode.RightArrow))
        // {
        //     horizontalInput = 1;
        // }
        // else if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     horizontalInput = -1;
        // }w

        // [2] manage input using Input System
        // horizontalInput = Input.GetAxis("Horizontal");

        // [3] manage input using Input System (newest solution from Unity)
        InputAction moveAction = InputSystem.actions.FindAction("Move");
        horizontalInput = moveAction.ReadValue<Vector2>().x;
        forwardInput = moveAction.ReadValue<Vector2>().y;

        // transform.Translate(speed * Time.deltaTime * Vector3.forward);
        transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);
        // transform.Translate(turnSpeed * Time.deltaTime * Vector3.right);
        // transform.Translate(horizontalInput * turnSpeed * Time.deltaTime * Vector3.right);
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);
    }
}

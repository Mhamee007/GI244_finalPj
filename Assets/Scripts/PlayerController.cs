using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    float normalSpeed;

    void Start()
    {
        normalSpeed = speed;
    }
    void Update()
    {
        InputAction moveAction = InputSystem.actions.FindAction("Move");
        Vector2 input = moveAction.ReadValue<Vector2>();

        float forwardInput = input.y;
        float horizontalInput = input.x;

        transform.Translate(Vector3.right * forwardInput * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * horizontalInput * speed * Time.deltaTime);
    }

    public void ActivateBoost(float multiplier, float duration)
    {
        StopAllCoroutines();
        StartCoroutine(BoostRoutine(multiplier, duration));
    }
    IEnumerator BoostRoutine(float multiplier, float duration)
    {
        speed = normalSpeed * multiplier;
        yield return new WaitForSeconds(duration);
        speed = normalSpeed;
    }

}

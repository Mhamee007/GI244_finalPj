using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    float normalSpeed;

   public float hp = 2;

    void Start()
    {
        normalSpeed = speed;
    }
    void Update()
    {
        InputAction moveAction = InputSystem.actions.FindAction("Move");
        Vector2 input = moveAction.ReadValue<Vector2>();

        float forwardInput = input.x;
        float horizontalInput = input.y;

        transform.Translate(Vector3.forward * forwardInput * speed * Time.deltaTime);
        transform.Translate(Vector3.left * horizontalInput * speed * Time.deltaTime);



        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -10f, 6f);
        pos.z = Mathf.Clamp(pos.z, 70f, 160f);
        transform.position = pos;
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

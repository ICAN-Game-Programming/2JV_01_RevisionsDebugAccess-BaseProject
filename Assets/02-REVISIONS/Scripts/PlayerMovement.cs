using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    void FixedUpdate()
    {
        Vector3 inputVector = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        inputVector = Vector3.ClampMagnitude(inputVector, 1f);
        rb.linearVelocity = (inputVector * speed) + new Vector3(0f, rb.linearVelocity.y, 0f);
    }
}

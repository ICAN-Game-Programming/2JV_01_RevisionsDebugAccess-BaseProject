using UnityEngine;

public class PhysicsTargeting : MonoBehaviour
{
    public Transform target;
    public float speed = 10f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        transform.LookAt(target);
        Vector3 direction = target.position - transform.position;
        rb.linearVelocity = direction.normalized * speed;
    }
}
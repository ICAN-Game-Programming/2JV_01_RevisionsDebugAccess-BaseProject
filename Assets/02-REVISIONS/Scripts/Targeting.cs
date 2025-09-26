using UnityEngine;

public class Targeting : MonoBehaviour
{
    
    public Transform target;
    public float speed = 5f;
    
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
}

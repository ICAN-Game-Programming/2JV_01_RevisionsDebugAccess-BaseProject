using UnityEngine;

public class FreezeRotation : MonoBehaviour
{
    private Quaternion startRotation;
    
    void Start()
    {
        startRotation = transform.rotation;
    }

    void LateUpdate()
    {
        transform.rotation = startRotation;
    }
}

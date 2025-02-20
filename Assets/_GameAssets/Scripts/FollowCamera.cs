using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    Vector3 offset;
    void Start()
    {
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        if (target!=null)
        {
            transform.position = target.position + offset;
        }
    }
}

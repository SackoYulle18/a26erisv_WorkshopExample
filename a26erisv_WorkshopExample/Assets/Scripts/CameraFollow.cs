using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    public bool active;
    void Update()
    {
        if (active)
        {
            transform.position += target.position;
        }
    }
}

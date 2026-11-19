using System;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float MaxDistance;
    public float Speed;
    public bool MovingDown;
    
    [SerializeField] private Vector2 originalPos;

    private void Start()
    {
        originalPos = transform.position;
    }

    void Update()
    {
        float movementSpeed = Speed * Time.deltaTime;
        
        if (MovingDown)
        {
            if (originalPos.y - transform.position.y < MaxDistance)
                transform.position -= new Vector3(0, movementSpeed);
        }
        else
        {
            if (originalPos.y - transform.position.y > 0.01f)
                transform.position += new Vector3(0, movementSpeed);
        }
    }

    public void GoDown(bool value) => MovingDown = value;


}

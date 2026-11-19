using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class UnityEventOnCollision : MonoBehaviour
{
    public List<string> tagsToActivate;
    public UnityEvent onCollisionEnter, onCollisionStay, onCollisionExit;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log($"Colliding with other by tag: {other.gameObject.tag}");
        if (tagsToActivate != null)
        {
            if (!tagsToActivate.Contains(other.gameObject.tag))
                return;
        }
        Debug.Log("Colliding");
        
        onCollisionEnter?.Invoke();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (tagsToActivate != null)
        {
            if (!tagsToActivate.Contains(other.gameObject.tag))
                return;
        }
        
        onCollisionEnter?.Invoke();
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (tagsToActivate != null)
        {
            if (!tagsToActivate.Contains(other.gameObject.tag))
                return;
        }
        
        onCollisionStay?.Invoke();
    }
    private void OnCollisionStay(Collision other)
    {
        if (tagsToActivate != null)
        {
            if (!tagsToActivate.Contains(other.gameObject.tag))
                return;
        }
        
        onCollisionStay?.Invoke();
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (tagsToActivate != null)
        {
            if (!tagsToActivate.Contains(other.gameObject.tag))
                return;
        }
        Debug.Log("Left collision");
        
        onCollisionExit?.Invoke();
    }
    private void OnCollisionExit(Collision other)
    {
        if (tagsToActivate != null)
        {
            if (!tagsToActivate.Contains(other.gameObject.tag))
                return;
        }
        
        onCollisionExit?.Invoke();
    }
}

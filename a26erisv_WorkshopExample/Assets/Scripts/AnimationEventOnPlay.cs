using UnityEngine;
using UnityEngine.Events;

public class AnimationEventOnPlay : MonoBehaviour
{
    public UnityEvent OnAnimationStart, OnAnimationEnd;
    public void AnimationStart() => OnAnimationStart?.Invoke();
    public void AnimationEnd() => OnAnimationEnd?.Invoke();
}

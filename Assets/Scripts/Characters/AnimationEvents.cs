using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationEvents : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _animationStart;
    [SerializeField]
    private UnityEvent _animationEnd;
    [SerializeField]
    private UnityEvent _projectileShoot;
    [SerializeField]
    private UnityEvent _dieEvent;
    [SerializeField]
    private UnityEvent _stepEvent;

    public void AnimationStarted()
    {
        _animationStart.Invoke();
    }

    public void AnimationEnded()
    {
        _animationEnd.Invoke();
    }

    public void ProjectileShoot()
    {
        _projectileShoot.Invoke();
    }

    public void DieEvent()
    {
        _dieEvent.Invoke();
    }

    public void Step()
    {
        _stepEvent.Invoke();
    }
}

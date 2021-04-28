using System;
using UnityEngine;

public abstract class ScriptableEvent<T> : ScriptableObject
{
    public event Action<T> Event = delegate { };
    public void Raise(T obj)
    {
        Event(obj);
    }
}

[CreateAssetMenu(fileName = "NewScriptableEvent",menuName = "NewScriptableEvent")]
public class ScriptableEvent : ScriptableObject
{
    public event Action Event = delegate { };
    public void Raise()
    {
        Event();
    }
}

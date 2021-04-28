using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="NewFloatObject",menuName = "CreateNewFloatObject")]
public class ScriptableFloatObject : ScriptableObject
{
    private float _value;

    public float Value { get => _value; set => _value = value; }
}

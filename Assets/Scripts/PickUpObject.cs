using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickUpObject : MonoBehaviour
{
    public abstract void PickUp(Collider2D collider2D);

    public abstract void DestroyPickUp();

}

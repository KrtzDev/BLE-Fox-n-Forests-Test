using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : PickUpObject
{

    [SerializeField]
    private float _healAmount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PickUp(collision);
        }
    }

    public override void PickUp(Collider2D collider2D)
    {
        collider2D.GetComponent<HealthComponent>().HealDamage(_healAmount);
        DestroyPickUp();
    }

    public override void DestroyPickUp()
    {
        Destroy(this.gameObject);
    }
}

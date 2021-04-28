using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : PickUpObject
{
    [SerializeField]
    private float _coinAmount;
    [SerializeField]
    private float _deSpawnTime;

    private void Awake()
    {
        if (_deSpawnTime > 0)
        {
            StartCoroutine(DestroyAfterTime());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PickUp(collision);
        }    
    }

    public override void PickUp(Collider2D collider2D)
    {
        collider2D.GetComponent<FoxCurrency>().AddToCoinsOwned(_coinAmount);
        DestroyPickUp();
    }

    public override void DestroyPickUp()
    {
        Destroy(this.gameObject);
    }

    IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(_deSpawnTime);
        DestroyPickUp();
    }
}

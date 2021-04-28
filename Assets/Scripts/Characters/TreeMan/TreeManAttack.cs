using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManAttack : MonoBehaviour
{
    [SerializeField]
    private float _attackDamage;
    [SerializeField]
    private float _knockBackForce;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<IDamagable<float,GameObject,float>>().TakeDamage(_attackDamage,this.gameObject,_knockBackForce);
        }
    }
}

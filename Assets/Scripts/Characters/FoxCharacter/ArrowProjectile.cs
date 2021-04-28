using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ArrowProjectile : MonoBehaviour
{
    public UnityEvent ArrowDestroyed;

    [SerializeField]
    private BoxCollider2D _arrowCollider;
    [SerializeField]
    private SpriteRenderer _arrowRenderer;
    [SerializeField]
    private Rigidbody2D _arrowRigidbody;
    [SerializeField]
    private float _arrowSpeed;
    [SerializeField]
    private float _arrowDamage;
    [SerializeField]
    private float _knockBackForce;

    private float _lifeTime;

    private void FixedUpdate()
    {
        _arrowRigidbody.velocity = new Vector2(this.transform.forward.z * _arrowSpeed * Time.fixedDeltaTime,0);
        _lifeTime += Time.fixedDeltaTime;
        if (_lifeTime > 1f)
        {
            DestroyArrow();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.collider.CompareTag("Player"))
        {
            HideArrow();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            HideArrow();
            collision.GetComponent<IDamagable<float,GameObject,float>>().TakeDamage(_arrowDamage,this.gameObject,_knockBackForce);          
        }
    }

    private void HideArrow()
    {
        _arrowCollider.enabled = false;
        _arrowRenderer.enabled = false;
    }

    private void DestroyArrow()
    {
        ArrowDestroyed.Invoke();
        Destroy(this.gameObject);
    }
}

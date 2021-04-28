using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using Cinemachine;

public class HealthComponent : MonoBehaviour, IDamagable<float,GameObject,float>
{
    private static string MATERIAL_HITEFFECT_PARAM = "_HitEffectBlendOpacity";

    [SerializeField]
    private float _maxHealth;
    [SerializeField]
    private bool _hasInvulnerabilityFrames;
    [SerializeField]
    private float _invulnerabilityDuration;
    [SerializeField]
    private bool _getsKnockedBack;
    [SerializeField]
    private ScriptableEvent<float> _updateHealthUI;

    [SerializeField]
    private UnityEvent<GameObject,float> _applyKnockBack;
    [SerializeField]
    private UnityEvent _deactivateMovement;
    [SerializeField]
    private UnityEvent _deactivateCollider;
    [SerializeField]
    private UnityEvent _playDeathAnimation;
    [SerializeField]
    private UnityEvent<Transform> _dropLoot;

    private float _health;
    private bool _canTakeDamage = true;
    [SerializeField]
    private CinemachineVirtualCamera _camera;

    private void Awake()
    {
        _health = _maxHealth;
        _camera = FindObjectOfType<CinemachineVirtualCamera>();
    }

    private void Start()
    {
        if (this.CompareTag("Player"))
        {
            _updateHealthUI.Raise(_health);
        }
    }

    public void TakeDamage(float damageamount, GameObject damageDealer, float knockBackForce)
    {
        if (_canTakeDamage)
        {
            _health -= damageamount;
            StartCoroutine(HitEffect());
            StartCoroutine(CameraShake());
        }
        if (_getsKnockedBack && _canTakeDamage)
        {
            CharacterKnockBack(damageDealer, knockBackForce);
        }
        if (_hasInvulnerabilityFrames)
        {
            Invulnerability();
        }
        if (_health <= 0)
        {
            CharacterDie();
        }
        if (this.CompareTag("Player"))
        {
            _updateHealthUI.Raise(_health);
        }
    }

    public void HealDamage(float healAmount)
    {
        _health += healAmount;
        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }
        if (this.CompareTag("Player"))
        {
            _updateHealthUI.Raise(_health);
        }
    }

    //OnEndAnimationEvent
    public void DestroyGameObject()
    {
        if (this.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void CharacterKnockBack(GameObject damageDealer,float knockBackForce)
    {
        _applyKnockBack.Invoke(damageDealer,knockBackForce);
    }

    private void CharacterDie()
    {
        _deactivateMovement.Invoke();
        _deactivateCollider.Invoke();
        _playDeathAnimation.Invoke();
        _dropLoot.Invoke(this.transform);
    }
    private void Invulnerability()
    {
        _canTakeDamage = false;
        StartCoroutine(EndInvulnerability());
    }

    IEnumerator CameraShake()
    {
        _camera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = .7f;
        _camera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = .7f;
        yield return new WaitForSeconds(.2f);
        _camera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0;
        _camera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = 0;
    }

    IEnumerator HitEffect()
    {
        this.GetComponentInChildren<SpriteRenderer>().material.SetFloat(MATERIAL_HITEFFECT_PARAM,1);
        yield return new WaitForSeconds(.1f);
        this.GetComponentInChildren<SpriteRenderer>().material.SetFloat(MATERIAL_HITEFFECT_PARAM,0);
    }

    IEnumerator EndInvulnerability()
    {
        yield return new WaitForSeconds(_invulnerabilityDuration);
        _canTakeDamage = true;
    }
}

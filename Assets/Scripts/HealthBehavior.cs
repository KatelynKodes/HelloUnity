using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehavior : MonoBehaviour
{
    [SerializeField]
    private float _health;
    [SerializeField]
    private bool _isAlive;
    [SerializeField]
    private bool _destroyOnDeath;

    public float Health
    {
        get { return _health; }
    }

    public bool IsAlive
    {
        get { return _isAlive; }
    }

    public float TakeDamage(float dmgAmount)
    {
        _health -= dmgAmount;

        return dmgAmount;
    }

    public virtual void OnDeath() { }

    private void Update()
    {
        if (_health <= 0 && IsAlive)
            OnDeath();


        _isAlive = _health > 0;

        if (!IsAlive && _destroyOnDeath)
        {
            Destroy(gameObject);
        }
    }
}

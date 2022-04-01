using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBehavior : MovementBehavior
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _moveSpeed;
    [SerializeField]
    private float _damage;

    public float Speed
    {
        get { return _moveSpeed; }
        set { _moveSpeed = value; }
    }

    public Transform Target
    {
        get { return _target; }
        set { _target = value; }
    }

    // Update is called once per frame
    public override void Update()
    {
        Vector3 direction = _target.position - transform.position;

        Velocity = direction.normalized * _moveSpeed;

        base.Update();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _target)
        {
            //Increment enemy count on goal
            GoalBehavior goalHealth = other.GetComponent<GoalBehavior>();
            if (goalHealth)
                goalHealth.TakeDamage(_damage);

            //Destroys enemy object
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}

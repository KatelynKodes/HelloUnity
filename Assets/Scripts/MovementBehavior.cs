using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    [SerializeField]
    private Vector3 _velocity;

    public Vector3 Velocity
    {
        get { return _velocity; }
        set { _velocity = value; }
    }

    // Update is called once per frame
    virtual public void Update()
    {
        transform.position += Velocity * Time.deltaTime;
    }
}

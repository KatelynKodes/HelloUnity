using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBehavior : MonoBehaviour
{
    [SerializeField]
    private BulletEmitterBehavior _gun;
    [SerializeField]
    private float _bulletCooldown;
    public float _bulletTimer;
    [SerializeField]
    private int _ammo = 0;
    [SerializeField]
    private bool _infiniteAmmo = true;

    public bool CheckHasAmmo()
    {
        if (_infiniteAmmo) return true;

        return _ammo > 0;
    }

    private void Update()
    {

        //Make the timer count upward
        _bulletTimer += Time.deltaTime;

        //If the bulletTimer is greater than or equal to the bullet cooldown and if the ammo is greater than 0
        if (_bulletTimer >= _bulletCooldown)
        {
            //Fire the gun
            _gun.Fire();

            //Set bullet Timer to 0
            _bulletTimer = 0;

            if (!_infiniteAmmo)
            {
                //Decrease the ammo
                _ammo--;
            }
        }
    }

}

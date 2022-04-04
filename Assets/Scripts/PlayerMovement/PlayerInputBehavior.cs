using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputBehavior : MonoBehaviour
{
    private PlayerMovementBehavior _playerMovement;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovementBehavior>();
    }

    private void Update()
    {
        _playerMovement.MoveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _playerMovement.RotationDirection = new Vector2(Input.GetAxisRaw("MouseX"), Input.GetAxisRaw("MouseY")).normalized;
    }
}

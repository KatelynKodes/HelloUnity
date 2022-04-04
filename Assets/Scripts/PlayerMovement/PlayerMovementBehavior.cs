using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidBody;

    private Vector3 _moveDir;
    private Vector2 _rotationDir;
    private Camera _camera;
    [SerializeField]
    private float _rotationSpeed;

    public Vector3 MoveDirection { get { return _moveDir; } set { _moveDir = value; } }
    public Vector2 RotationDirection { get { return _rotationDir; } set { _rotationDir = value; } }


    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _camera = GetComponentInChildren<Camera>();
    }

    private void FixedUpdate()
    {
        //Camera rotation
        Quaternion playerRotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y + RotationDirection.x * _rotationSpeed * Time.deltaTime, 0);
        float cameraXRotation = Mathf.Clamp(transform.localRotation.eulerAngles.x + RotationDirection.y * _rotationSpeed * Time.deltaTime, -89, 89);
        Quaternion cameraRotation = Quaternion.Euler(cameraXRotation, 0, 0);
        _rigidBody.MoveRotation(playerRotation);
        _camera.transform.Rotate(new Vector3(-cameraXRotation, 0, 0) * Time.deltaTime * _rotationSpeed);

        //Player Movement
        _rigidBody.MovePosition(transform.position + MoveDirection * _speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRoot : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public float speed;
    public float turnSpeed;

    private void Awake()
    {
        CameraController.Instance.SetPivot(transform);
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        var acl = moveInput * speed * Time.fixedDeltaTime;
        /*        transform.Translate(Vector3.forward * acl);

                transform.Rotate(Vector3.up, acl * turnInput * turnSpeed * Time.deltaTime);/**/

        rb.MovePosition(transform.position + transform.forward * acl);

        // Поворачиваем автомобиль
        Quaternion turnRotation = Quaternion.Euler(0f, turnInput * turnSpeed * Time.fixedDeltaTime * (acl > 0 ? acl : acl * 3), 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}

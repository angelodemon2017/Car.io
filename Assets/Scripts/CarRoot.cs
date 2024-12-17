using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRoot : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 100f;

    private void Awake()
    {

    }

    void Update()
    {
        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        var acl = moveInput * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * acl);

        transform.Rotate(Vector3.up, acl * turnInput * turnSpeed * Time.deltaTime);
    }
}

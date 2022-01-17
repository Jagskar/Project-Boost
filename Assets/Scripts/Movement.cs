using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    float thrustValue = 1000f;
    [SerializeField]
    float rotationSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
            rb.AddRelativeForce(Vector3.up * thrustValue * Time.deltaTime);
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
            ApplyRotation(rotationSpeed);
        else if (Input.GetKey(KeyCode.D))
            ApplyRotation(-rotationSpeed);
    }

    void ApplyRotation(float rotationCurrFrame)
    {
        transform.Rotate(Vector3.forward * rotationCurrFrame * Time.deltaTime);
    }
}

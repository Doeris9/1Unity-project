using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 forwardMovement = transform.forward * verticalInput * moveSpeed * Time.deltaTime;

        transform.Translate(forwardMovement, Space.World);

        float horizontalInput = Input.GetAxis("Horizontal");
        float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;

        transform.Rotate(0, rotationAmount, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    Vector2 moveVector;
    float walkSpeed = 10.0f;
    Rigidbody rBody;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * moveVector.x * walkSpeed, Space.Self);
        transform.Translate(Vector3.forward * Time.deltaTime * moveVector.y * walkSpeed, Space.Self);
    }
    public void OnMovement(InputAction.CallbackContext ia)
    {
        moveVector = ia.ReadValue<Vector2>();
    }
}

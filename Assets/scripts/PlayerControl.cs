using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    // ENCAPSULATION
    [SerializeField] private float movementSpeed = 5;
    public float MovementSpeed
    {
        get { return movementSpeed; }
        set
        {
            if (value > 0.0f)
                movementSpeed = value;
            else
                Debug.LogError("Movement Speed values must be positive");
        }
    }

    [SerializeField] private float rotationSpeed = 30;
    public float RotationSpeed
    {
        get { return rotationSpeed; }
        set
        {
            if (value > 0.0f)
                rotationSpeed = value;
            else
                Debug.LogError("Rotation Speed values must be positives");
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }


    // ABSTRACTION
    protected void playerMovement()
    {
        float inputVertical = Input.GetAxis("Vertical");
        float inputHorizontal = Input.GetAxis("Horizontal");

        Vector3 directionVector = movementSpeed * ( (transform.forward * inputVertical) + (transform.right * inputHorizontal) );
        transform.Translate(directionVector * Time.deltaTime);
    }


}

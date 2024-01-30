using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeController : MonoBehaviour
{
    public float rotationSpeed = 15f;
    public float rotationLimit = 45f;
    private float currentXRotation = 0f;
    private float currentZRotation = 0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get keyboard input for maze rotation
        float xInput = Input.GetAxis("Vertical"); //up and down arrow keys
        float zInput = Input.GetAxis("Horizontal"); //left and right keys

        //calculate rotation angles
        currentXRotation += xInput * rotationSpeed * Time.deltaTime;
        currentZRotation += zInput * rotationSpeed * Time.deltaTime;

        //clamp the rotation angles with limits
        currentXRotation = Mathf.Clamp(currentXRotation, -rotationLimit, rotationLimit);
        currentZRotation = Mathf.Clamp(currentZRotation, -rotationLimit, rotationLimit);

        //Apply the updated rotation
        transform.rotation = Quaternion.Euler(currentXRotation, 0f, currentZRotation);
    }
}

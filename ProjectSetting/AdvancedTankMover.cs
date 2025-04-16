using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AdvancedTankMover : MonoBehaviour
{
    private float tankSpeed = 10;
    private float rotationSpeed = 20;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * tankSpeed * Time.deltaTime, Space.World);
            Quaternion vector3Rotation = Quaternion.LookRotation(Vector3.forward);
            transform.rotation = Quaternion.Lerp(transform.rotation, vector3Rotation, rotationSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * tankSpeed * Time.deltaTime, Space.World);
            Quaternion vector3Rotation = Quaternion.LookRotation(Vector3.back);
            transform.rotation = Quaternion.Lerp(transform.rotation, vector3Rotation, rotationSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * tankSpeed * Time.deltaTime, Space.World);
            Quaternion vector3Rotation = Quaternion.LookRotation(Vector3.right);
            transform.rotation = Quaternion.Lerp(transform.rotation, vector3Rotation, rotationSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * tankSpeed * Time.deltaTime, Space.World);
            Quaternion vector3Rotation = Quaternion.LookRotation(Vector3.left);
            transform.rotation = Quaternion.Lerp(transform.rotation, vector3Rotation, rotationSpeed * Time.deltaTime);
        }
    }
}
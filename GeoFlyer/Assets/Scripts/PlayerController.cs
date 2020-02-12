using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    { 
        transform.Translate(new Vector3(
        Input.GetAxis("Horizontal") * speed,
        Input.GetAxis("Vertical") * 0, 0) * Time.deltaTime);
    }
}
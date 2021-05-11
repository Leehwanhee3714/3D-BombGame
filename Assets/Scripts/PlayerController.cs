using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float translation; 
    private float rotation; 
    void Update()
    {
        translation = Input.GetAxis("Vertical") * 10f;
        rotation = Input.GetAxis("Horizontal") * 10f;

        transform.Translate(0, 0, translation * Time.deltaTime);
        transform.Rotate(0, rotation, 0 * Time.deltaTime);
    }
}

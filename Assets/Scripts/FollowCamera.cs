using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public float dist = 4.0f;
    public float height = 2.0f;
    public float smoothRotate = 5.0f;
    void LateUpdate()
    {
        float currYangle = Mathf.LerpAngle(transform.eulerAngles.y,
                                            target.eulerAngles.y,
                                            smoothRotate * Time.deltaTime);
        Quaternion rot = Quaternion.Euler(0, currYangle, 0);
        transform.position = target.position - (rot * Vector3.forward * dist) +
                            (Vector3.up * height);
        transform.LookAt(target);
    }
}

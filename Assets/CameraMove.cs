using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    public void LateUpdate(){
        transform.position = target.position+offset;
    }
}

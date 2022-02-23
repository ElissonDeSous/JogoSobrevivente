using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovimento : MonoBehaviour
{
    public float SpeedRota;

    // Update is called once per frame
    void Update()
    {
        float rotacao = Input.GetAxis("Mouse X")*SpeedRota;
        transform.Rotate(0, rotacao, 0);
    }
}

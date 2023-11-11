using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Transform pos;
    float xAxis;
    float yAxis;

    private void Update()
    {
        pos.position = new Vector3(target.position.x, target.position.y, -10);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEngine;

public class ControlPoint : MonoBehaviour
{
    float xroat, yroat = 0f;
    public Rigidbody Linus;
    public float rotatespeed = 5f;
    public LineRenderer Line;
    public float shootpower = 10f;


    void Update()
    {
        transform.position = Linus.position;
        if(Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            transform.rotation = Quaternion.Euler(mousePos.y, -mousePos.x, 0);
            Line.gameObject.SetActive(true);
            Line.SetPosition(0, transform.position);
            Line.SetPosition(1, transform.position + transform.forward * 4f);
        }
        if(Input.GetMouseButtonUp(0))
        {
            Linus.velocity = transform.forward * shootpower;
            Line.gameObject.SetActive(false);
        }

    }
}

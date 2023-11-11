using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Ignore : MonoBehaviour
{
    public Transform Butterfly;
    // Start is called before the first frame update
    void Start()
    {
        Transform butterfly = Instantiate(Butterfly) as Transform;
        Physics.IgnoreCollision(butterfly.GetComponent<Collider>(), GetComponent<Collider>());
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linwWire : MonoBehaviour
{
    public LineRenderer line;
    public Transform p1;
    public Transform p2;
    public Transform p3;
    public Transform p4;
    public Transform p5;
    public Transform p6;
    public Transform p7;
    void Start()
    {
        line.positionCount = 7;
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0,p1.position);
        line.SetPosition(1,p2.position);
        line.SetPosition(2,p3.position);
        line.SetPosition(3,p4.position);
        line.SetPosition(4, p5.position);
        line.SetPosition(5, p6.position);
        line.SetPosition(6, p7.position);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : StateMachineViz.StateMachine
{
    public LayerMask groundLayer;
    public float fallSpeed = 5f;
    public void Fall()
    {
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;
    }
}

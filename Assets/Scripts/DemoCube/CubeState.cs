using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachineViz;

[CreateAssetMenu(fileName = "CubeState", menuName = "CubeState")]
public class CubeState : StateMachineViz.State
{
    protected new CubeController stateMachine;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace StateMachineViz
{
    public class StateMachine : MonoBehaviour
    {
        public State currentState;

        protected virtual void Update()
        {
            currentState?.FrameUpdate(this);
        }

        protected virtual void FixedUpdate()
        {
            currentState?.PhysicsUpdate(this);
        }

        protected virtual void ChangeState(State _newState)
        {
            currentState?.Exit(this);
            currentState = ScriptableObject.CreateInstance(currentState.name) as State;
            currentState?.Enter(this);
        }
    }
}

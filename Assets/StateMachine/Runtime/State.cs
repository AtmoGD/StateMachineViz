using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

namespace StateMachineViz
{
    // [Serializable]
    // public enum Condition
    // {
    //     EQUAL,
    //     NOT_EQUAL,
    //     GREATER_THAN,
    //     LESS_THAN,
    //     GREATER_THAN_OR_EQUAL,
    //     LESS_THAN_OR_EQUAL
    // }

    // [Serializable]
    // public enum SupportedTypes
    // {
    //     INT = TypeCode.Int32,
    //     FLOAT = TypeCode.Single,
    //     BOOL = TypeCode.Boolean,
    //     STRING = TypeCode.String,
    //     CALLBACK = TypeCode.Object,
    // }

    // [Serializable]
    // public class Rule
    // {
    //     public string name = "New Rule";
    //     public SupportedTypes type = SupportedTypes.INT;
    //     public string firstVariableName = "";
    //     public Condition condition = Condition.EQUAL;
    //     public string secondVariableName = "";
    // }

    [Serializable]
    public class TargetState
    {
        public State state;
        public List<UnityEvent> rules = new List<UnityEvent>();
    }

    [CreateAssetMenu(fileName = "New State", menuName = "State")]
    public class State : ScriptableObject
    {
        protected StateMachine stateMachine;
        public List<string> enterActions = new List<string>();
        public List<UnityEvent> frameUpdateActions = new List<UnityEvent>();
        public List<UnityEvent> physicsUpdateActions = new List<UnityEvent>();
        public List<UnityEvent> exitActions = new List<UnityEvent>();

        public List<TargetState> targetStates = new List<TargetState>();

        public virtual void Enter(StateMachine _stateMachine)
        {
            foreach (var action in enterActions)
            {
                stateMachine.Invoke(action, 0f);
            }
        }
        public virtual void FrameUpdate(StateMachine _stateMachine) { }
        public virtual void PhysicsUpdate(StateMachine _stateMachine) { }
        public virtual void Exit(StateMachine _stateMachine) { }
    }
}
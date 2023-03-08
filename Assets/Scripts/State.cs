using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace StateMachine
{
    [Serializable]
    public class Condition
    {
        public string name;
    }

    [Serializable]
    public class Rule
    {
        public string name;
    }

    [Serializable]
    public class PossibleState
    {
        public State state;
        public List<Rule> rules = new List<Rule>();
    }

    [CreateAssetMenu(fileName = "New State", menuName = "State")]
    public class State : ScriptableObject
    {
        public List<PossibleState> possibleStates = new List<PossibleState>();
    }
}
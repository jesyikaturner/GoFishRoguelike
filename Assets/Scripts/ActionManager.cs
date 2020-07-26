using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class ActionDetails
    {
        // player can move, attack or perform a special action. 
        public enum Action { MOVE, ATTACK, SPECIAL }
        public Action ActionStatus { get; private set; }

    }

    //JSON
#pragma warning disable 0649
    [System.Serializable]
    private class Actions
    {
        public Action[] actions;
    }

    [System.Serializable]
    private class Action
    {
        public string match;
        public string value;
        public string action;
    }
}

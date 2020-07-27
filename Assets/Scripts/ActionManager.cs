using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{

    // Action Queue
    public List<ActorAction> actionList;


    // Actor List
    public List<ControllableActor> actorList;

    // Active Actor
    public ControllableActor activeActor;


    // Start is called before the first frame update
    void Start()
    {
        actionList = new List<ActorAction>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeAction()
    {
        ActorAction currentAction = GetCurrentActorsAction();

        switch (currentAction.actionType)
        {
            case ActorAction.ActionType.MOVEUP:
                activeActor.MoveDirection(ControllableActor.Direction.UP);
                break;
            case ActorAction.ActionType.MOVELEFT:
                activeActor.MoveDirection(ControllableActor.Direction.LEFT);
                break;
            case ActorAction.ActionType.MOVERIGHT:
                activeActor.MoveDirection(ControllableActor.Direction.RIGHT);
                break;
            case ActorAction.ActionType.MOVEDOWN:
                activeActor.MoveDirection(ControllableActor.Direction.DOWN);
                break;

            case ActorAction.ActionType.FACEUP:
                activeActor.FaceDirection(ControllableActor.Direction.UP);
                break;
            case ActorAction.ActionType.FACELEFT:
                activeActor.FaceDirection(ControllableActor.Direction.LEFT);
                break;
            case ActorAction.ActionType.FACERIGHT:
                activeActor.FaceDirection(ControllableActor.Direction.RIGHT);
                break;
            case ActorAction.ActionType.FACEDOWN:
                activeActor.FaceDirection(ControllableActor.Direction.DOWN);
                break;

            case ActorAction.ActionType.MELEEATTACK:
                activeActor.MeleeAttack();
                break;
            case ActorAction.ActionType.RANGEDATTACK:
                activeActor.RangedAttack();
                break;
            case ActorAction.ActionType.USEITEM:
                break;
            case ActorAction.ActionType.USESPELL:
                break;
        }
    }

    private ActorAction GetCurrentActorsAction()
    {
        ActorAction currentAction = null;

        if (actionList[0].actorID != activeActor.actorID)
        {
            int index;
            for (index = 0; index < actionList.Count; index++)
            {
                if (actionList[index].actorID == activeActor.actorID)
                {
                    currentAction = actionList[index];
                    break;
                }
            }
            actionList.RemoveAt(index);
            return currentAction;
        }

        return actionList[0];
    }

    public ActorAction CreateAction(int actorID, ActorAction.ActionType actionType)
    {
        ActorAction action = new ActorAction
        {
            actorID = actorID,
            actionType = actionType
        };

        return action;
    }


    public class ActorAction
    {
        public int actorID;
        public enum ActionType { MOVEUP, MOVELEFT, MOVERIGHT, MOVEDOWN, FACEUP, FACELEFT, FACERIGHT, FACEDOWN, MELEEATTACK, RANGEDATTACK, USEITEM, USESPELL }
        public ActionType actionType;

    }
}

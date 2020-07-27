using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ControllableActor : MonoBehaviour
{
    public enum Direction { UP, LEFT, RIGHT, DOWN }

    public int actorID;
    // move queue?

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveDirection(Direction direction)
    {
        // TODO
        Debug.Log(string.Format("Actor {0} moved {1}.", actorID, direction));
    }

    public void FaceDirection(Direction direction)
    {
        // TODO
        Debug.Log(string.Format("Actor {0} faced {1}.", actorID, direction));
    }

    public void MeleeAttack()
    {
        // TODO
        Debug.Log(string.Format("Actor {0} melee attacked.", actorID));
    }

    public void RangedAttack()
    {
        //TODO
        Debug.Log(string.Format("Actor {0} range attacked.", actorID));
    }

    public void UseItem()
    {
        // TODO
    }
}

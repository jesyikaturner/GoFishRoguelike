using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public enum TileType { GROUND, WALL, WATER, TRAP, DOOR }
    public TileType type;
    public int xPos, yPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPosition(int xPos, int yPos)
    {
        this.xPos = xPos;
        this.yPos = yPos;
    }
}

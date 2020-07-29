using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    private const int TILE_ARRAY_WIDTH = 8, TILE_ARRAY_HEIGHT = 8;
    private const float TILE_OFFSET = 0.889f;
    public Tile[,] tileArray;
    public Tile tile;

    // Start is called before the first frame update
    void Start()
    {
        CreateTileGrid();
    }

    private void CreateTileGrid()
    {
        float startXPos = -3.111f, startYPos = 4.42f;
        tileArray = new Tile[TILE_ARRAY_WIDTH, TILE_ARRAY_HEIGHT];
        for (int y = 0; y < TILE_ARRAY_HEIGHT; y++)
        {
            for (int x = 0; x < TILE_ARRAY_WIDTH; x++)
            {
                tileArray[y, x] = Instantiate(tile, new Vector3(startXPos + (x * TILE_OFFSET), startYPos + (y * -TILE_OFFSET)), Quaternion.identity);
                tileArray[y, x].SetPosition(x, y);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

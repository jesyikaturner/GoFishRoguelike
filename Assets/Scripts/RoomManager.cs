using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{

    // I need to write a level image to text file converter -_- 
    public TextAsset roomText;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(roomText.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}

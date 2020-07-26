using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CardDetails : MonoBehaviour
{
    public string suit;
    public string value;

    public void SetupCard(string suit, string value)
    {
        this.suit = suit;
        this.value = value;
    }
}

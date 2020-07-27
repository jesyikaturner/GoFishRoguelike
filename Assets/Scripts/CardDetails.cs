using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CardDetails : MonoBehaviour
{
    public enum CardPosition { DECK, PLAYERHAND, DISCARD }

    public string suit;
    public string value;

    public void SetupCard(string suit, string value)
    {
        this.suit = suit;
        this.value = value;
    }
}

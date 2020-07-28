using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CardDetails : MonoBehaviour
{
    public enum CardPosition { DECK, PLAYERHAND, DISCARD }
    public enum CardSuit { HEARTS, DIAMONDS, SPADES, CLUBS }

    public CardSuit cardSuit;
    public CardPosition position;


    public int value;
    public string valueName;
    public string cardName;

    public void SetupCard(string suit, string valueName, int value)
    {
        SetCardValue(value);
        SetCardSuit(suit);
        name = valueName + " OF " + suit;
        //gameObject.name = this.name;
    }

    public void SetCardSuit(string suit)
    {
        switch(suit)
        {
            case "HEARTS":
                cardSuit = CardSuit.HEARTS;
                break;
            case "DIAMONDS":
                cardSuit = CardSuit.DIAMONDS;
                break;
            case "SPADES":
                cardSuit = CardSuit.SPADES;
                break;
            case "CLUBS":
                cardSuit = CardSuit.CLUBS;
                break;
        }
    }

    public void SetCardValue(int value)
    {
        this.value = value;

        switch (value)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            case 9:
                break;
            case 10:
                break;
            case 11:
                break;
            case 12:
                break;
            case 13:
                break;
        }
    }
}

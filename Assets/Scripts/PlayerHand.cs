using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public List<CardDetails> cards;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string CheckMatch(CardDetails firstCard, CardDetails secondCard)
    {
        if (firstCard.value != secondCard.value)
            return null;

        if((firstCard.suit == "HEARTS" || firstCard.suit == "DIAMONDS") && (secondCard.suit == "HEARTS" || secondCard.suit == "DIAMONDS"))
        {
            return "red";
        }

        if ((firstCard.suit == "CLUBS" || firstCard.suit == "SPADES") && (secondCard.suit == "CLUBS" || secondCard.suit == "SPADES"))
        {
            return "black";
        }

        return "odd";
    }
}

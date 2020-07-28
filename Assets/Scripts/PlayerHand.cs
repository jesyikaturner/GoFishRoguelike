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

        if((firstCard.cardSuit == CardDetails.CardSuit.HEARTS || firstCard.cardSuit == CardDetails.CardSuit.DIAMONDS) && (secondCard.cardSuit == CardDetails.CardSuit.HEARTS || secondCard.cardSuit == CardDetails.CardSuit.DIAMONDS))
            return "red";

        if ((firstCard.cardSuit == CardDetails.CardSuit.CLUBS || firstCard.cardSuit == CardDetails.CardSuit.SPADES) && (secondCard.cardSuit == CardDetails.CardSuit.CLUBS || secondCard.cardSuit == CardDetails.CardSuit.SPADES))
            return "black";

        return "odd";
    }

    public void PickupCard()
    {

    }

    public void StealCard(IPlayer player, IPlayer target)
    {

    }
}

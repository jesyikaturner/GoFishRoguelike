using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DeckManager : MonoBehaviour
{
    public List<CardDetails> deck;
    public CardDetails cardPrefab;
    public TextAsset json;

    // Start is called before the first frame update
    void Start()
    {
        deck = new List<CardDetails>();
        SetupCardList();
        ShuffleDeck();
    }

    public void DrawCard(List<CardDetails> hand)
    {
        hand.Add(deck[deck.Count - 1]);
        deck.RemoveAt(deck.Count - 1);
    }

    public void ShuffleDeck()
    {
        deck.Shuffle();
    }

    public void ResetDeck()
    {
        deck.Clear();
        SetupCardList();
    }

    public void SetupCardList()
    {
        Cards cardsList = JsonUtility.FromJson<Cards>(json.text);

        foreach(Card card in cardsList.cards)
        {
            CardDetails cardClone = Instantiate(cardPrefab, Vector2.zero,Quaternion.identity);
            cardClone.transform.parent = transform;
            cardClone.SetupCard(card.suit, card.valueName, card.value);
            deck.Add(cardClone);
        }
    }

    //JSON
#pragma warning disable 0649
    [System.Serializable]
    private class Cards
    {
        public Card[] cards;
    }

    [System.Serializable]
    private class Card
    {
        public string suit;
        public string valueName;
        public int value;
    }
}

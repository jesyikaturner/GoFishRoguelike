using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour, IPlayer
{
    public const int MAX_PLAYER_HAND = 5;

    public DeckManager deckManager;
    public PlayerHand playerHand;

    public CardDetails prevSelectedCard, selectedCard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetMouseButtonDown(0))
        {
            deckManager.DrawCard(playerHand);
        }
        */
    }

    public void SelectCards()
    {
        RaycastHit hit;
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        CardDetails temp;

        if(Physics.Raycast(mouseRay, out hit))
        {
            if(hit.collider.gameObject.GetComponent<CardDetails>())
            {
                temp = hit.collider.gameObject.GetComponent<CardDetails>();

                if(selectedCard)
                {
                    selectedCard = prevSelectedCard;
                    selectedCard = temp;
                }
                else if (temp == selectedCard)
                {
                    selectedCard = null;
                }
                else if (!selectedCard)
                {
                    selectedCard = temp;
                }

            }
        }

        if (!selectedCard || !prevSelectedCard)
            return;

        string result = playerHand.CheckMatch(selectedCard, prevSelectedCard);
        if(result == null)
        {
            Debug.Log("Let player know that the cards don't match");
        }
        else
        {
            // Add mana to pool
            selectedCard = null;
            prevSelectedCard = null;
        }
    }
}

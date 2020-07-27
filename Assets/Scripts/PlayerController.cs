using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        RaycastHit hit;
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        Physics.Raycast(mouseRay, out hit);

        Debug.Log(hit.collider);

        if(Input.GetMouseButtonUp(0))
        {
            SelectCards(hit.collider);
        }

    }

    public void SelectCards(Collider collider)
    {
        if (!collider || !collider.gameObject.GetComponent<CardDetails>())
            return;

        CardDetails temp = collider.gameObject.GetComponent<CardDetails>();

        if (selectedCard)
        {
            prevSelectedCard = selectedCard;
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

        /*
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
        }*/
    }
}

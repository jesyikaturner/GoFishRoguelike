using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IPlayer
{
    public const int MAX_PLAYER_HAND = 5;

    public DeckManager deckManager;
    public PlayerHand playerHand;

    public List<Mana> manaPool;

    public CardDetails prevSelectedCard, selectedCard;

    // Start is called before the first frame update
    void Start()
    {
        SetupManaPool();
    }

    // Update is called once per frame
    void Update()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        Physics.Raycast(mouseRay, out RaycastHit hit);

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

        if (temp.position != CardDetails.CardPosition.PLAYERHAND)
            return;

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

        if (selectedCard && prevSelectedCard)
        {
            string result = playerHand.CheckMatch(selectedCard, prevSelectedCard);
            if (result == null)
            {
                Debug.Log("Let player know that the cards don't match");
            }
            else
            {
                AddManaToPool(result, selectedCard.value);
                selectedCard = null;
                prevSelectedCard = null;
            }
        }
    }

    private void AddManaToPool(string result, int value)
    {
        switch(result)
        {
            case "red":
                manaPool[0].value += value;
                break;
            case "black":
                manaPool[1].value += value;
                break;
            case "odd":
                manaPool[2].value += value;
                break;
        }
    }

    private void SetupManaPool()
    {
        manaPool = new List<Mana>();
        manaPool.Add(new Mana { type = Mana.ManaType.RED, value = 0});
        manaPool.Add(new Mana { type = Mana.ManaType.BLACK, value = 0 });
        manaPool.Add(new Mana { type = Mana.ManaType.ODD, value = 0 });
    }

    [System.Serializable]
    public class Mana
    {
        public enum ManaType { RED, BLACK, ODD }
        public ManaType type;
        public int value;
    }
}

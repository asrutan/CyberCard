using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Deck00 : DeckTemplate
{
    public Deck00()
        : base()
    {
        deck = new Card00[10];
        deckID = 0000;

        for (int i = 0; i < deck.Length; i++)
        {
            deck[i] = new Card00("Test Card", "This is a test card! Merely a test!", 0);
        }
    }

    public string GetCardTitle(int index)
    {
        return (deck[index].GetTitle());
    }

    public string GetCardDescription(int index)
    {
        return (deck[index].GetDescription());
    }

    public int GetCardId(int index)
    {
        return (deck[index].GetId());
    }
}

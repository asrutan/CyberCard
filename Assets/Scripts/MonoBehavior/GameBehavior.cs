using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour {

    //prefab GameObjects
    public GameObject[] prefabCombatants = new GameObject[1];
    public GameObject[] prefabDecks = new GameObject[1];
    public GameObject[] prefabCards = new GameObject[1];

    //active GameObjects
    private GameObject[] activeCombatants = new GameObject[1];
    private GameObject[] activeDecks = new GameObject[1];
    private GameObject[] activeCards = new GameObject[20];

    //GameObject Scripts
    private CombatantBehavior[] combatantScripts = new CombatantBehavior[1];
    private DeckBehavior[] deckScripts = new DeckBehavior[1];
    private CardBehavior[] cardScripts = new CardBehavior[1];

    private Combatant00 combatantHolder = new Combatant00();
    private int cardCount = 0;

    //Deck Script (not monobehavior)
    Deck00 m_deck = new Deck00();

    // Use this for initialization
    void Start () {

        //Create instance of each combatant.
        //activeCombatants[0] = Instantiate(prefabCombatants[0]);
        //combatantScripts[0] = activeCombatants[0].GetComponent<CombatantBehavior>();

        //Get Deck information from each combatant.
        //activeDecks[0] = Instantiate(prefabDecks[combatantHolder.getDeckID()]);
        //deckScripts[0] = activeDecks[0].GetComponent<DeckBehavior>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            SpawnCard();
        }
	}

    void SpawnCard()
    {
        //activeCards[cardCount] = Instantiate(deckScripts[0].prefabCards[0]);
        activeCards[cardCount] = Instantiate(prefabCards[0]);
        cardScripts[cardCount] = activeCards[cardCount].GetComponent<CardBehavior>();
        //set Card GameObject information
        cardScripts[cardCount].SetTitle(m_deck.GetCardTitle(cardCount));
        cardScripts[cardCount].SetDescription(m_deck.GetCardDescription(cardCount));
        cardScripts[cardCount].SetId(m_deck.GetCardId(cardCount));
        //Display Title/Description
        cardScripts[cardCount].UpdateTextMeshes();

        cardCount++;
    }
}

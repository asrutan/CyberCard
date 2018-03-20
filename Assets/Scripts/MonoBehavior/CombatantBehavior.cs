using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatantBehavior : MonoBehaviour {

    public string m_name;
    public string m_description;
    public int m_maxhp;
    public int m_currenthp;
    public int m_maxap;
    public int m_currentap;

    public int m_column;
    public int m_deck;

    public Combatant00 combatant00 = new Combatant00();

    // Use this for initialization
    void Start () {
        m_deck = combatant00.getDeckID();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //Set all variables based on ID parameter. 
    //For now, use combatant00 script, change later to get info from a file.
    public void setID(int id)
    {
    }
}

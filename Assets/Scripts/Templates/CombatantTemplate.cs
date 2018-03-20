using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatantTemplate {

    protected string m_name;
    protected string m_description;
    protected int m_maxhp;
    protected int m_currenthp;
    protected int m_maxap;
    protected int m_currentap;

    protected int m_column;
    protected int m_deck;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int getDeckID()
    {
        return m_deck;
    }
}

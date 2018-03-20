using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Card00 : CardTemplate
{
    public Card00(string title, string description, int id)
        : base("NULL", "NULL", -1)
    {
        m_title = title;
        m_description = description;
        m_id = id;
    }

    public string GetTitle()
    {
        return (m_title);
    }

    public string GetDescription()
    {
        return (m_description);
    }

    public int GetId()
    {
        return (m_id);
    }
}
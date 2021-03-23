using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardElement // creates a collection of related constants
{
    Earth,
    Fire,
    Water,
    Mind,
    Matter,
    Soul,
    Light,
    Dark,
    Space,
    Aether,
    Plasma
}

public enum CardType
{
    Ruler,
    Minion,
    Spell
}

[System.Serializable] // Lets Unity know that this class can be serialized
public class Card
{
    public int cardId;
    public string cardName;
    public CardElement cardElement;
    public CardType cardType;
    public int cost;
}

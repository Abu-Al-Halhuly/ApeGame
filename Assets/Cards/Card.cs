using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardElement // creates a collection of related constants
{
    Fire,
    Earth,
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
    Unit,
    Command,
    Structure
}

public enum UnitType
{
    Ruler,
    Infantry,
    Sentry,
    Cavalry,
    Artillary,
    Titan
}

public enum CommandType
{
    Normal,
    Attack,
    Equipment,
    Counter,
    Continuous,
    Weather
}

public enum StructureType
{
    PlaceHolder1,
    PlaceHolder2
}

[System.Serializable] // Lets Unity know that this class can be serialized
public class Card
{
    public int cardId;
    public CardElement cardElement;
    public CardType cardType;
    public UnitType unitType;
    public CommandType commandType;
    public StructureType structureType;
    public string cardName;
    public int cost;
}

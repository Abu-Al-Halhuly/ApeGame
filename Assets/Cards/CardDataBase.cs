using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{

public static List<Card> cardList = new List<Card> ();

void Awake ();
{
    cardList.Add (new Card (0, Fire, Unit, Ruler, "Pyromancer", 0));
    cardList.Add (new Card ());
    cardList.Add (new Card ());
    cardList.Add (new Card ());
    cardList.Add (new Card ());

}
}

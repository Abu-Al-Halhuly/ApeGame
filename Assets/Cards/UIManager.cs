using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public CardManager cardManager;
    public GameObject[] cardSlots;

    private void Start()
    {
        DisplayCards();
    }

    private void DisplayCards()
    {
        for(int i = 0; i < cardManager.cards.Count; i++)
        {
            // Assign the cardManager's card information to the UI
            cardSlots[i].transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = cardManager.cards[i].cardName;

            /*
            switch (cardManager.cards[i].cardElement) // Switch statements provide a way to test equality against a list of values
            {
                case CardElement.Earth:
                    {
                        cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "Earth";
                        break;
                    }
                case CardElement.Fire:
                    {
                        cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "Fire";
                        break;
                    }
                case CardElement.Water:
                    {
                        cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "Water";
                        break;
                    }
                case CardElement.Mind:
                    {
                        cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "Mind";
                        break;
                    }
                case CardElement.Matter:
                    {
                        cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "Matter";
                        break;
                    }
                case CardElement.Soul:
                    {
                        cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "Soul";
                        break;
                    }
                case CardElement.Light:
                    {
                        cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "Light";
                        break;
                    }
                case CardElement.Dark:
                    {
                        cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "Dark";
                        break;
                    }
                case CardElement.Space:
                    {
                        cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "Space";
                        break;
                    }
                case CardElement.Aether:
                    {
                        cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "Aether";
                        break;
                    }
                case CardElement.Plasma:
                    {
                        cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "Plasma";
                        break;
                    }
            }
            */
        }
    }
}

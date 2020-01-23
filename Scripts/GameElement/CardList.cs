using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardList
{
    private string cardListName;
    private List<Card> cards;
    private int capacity;
    private ArrayList specificTypes;

    public List<Card> Cards { get => cards; set => cards = value; }
    public int Capacity { get => capacity; set => capacity = value; }
    public ArrayList SpecificTypes { get => specificTypes; set => specificTypes = value; }
    public string CardListName { get => cardListName; set => cardListName = value; }

    public CardList(string name, int capacity)
    {
        this.cardListName = name;
        this.cards = new List<Card>();
        this.capacity = capacity;
        this.specificTypes = new ArrayList();
    }
    private void PrintOutOfCapacity()
    {
        Debug.Log("CardList '" + CardListName + "' out of capacity");
    }
    private void PrintIncorrectType()
    {
        Debug.Log("CardList '" + CardListName + "' cannot add incorrect type of card");
    }
    private void PrintCannotAddEvoleType()
    {
        Debug.Log("CardList '" + CardListName + "' cannot add incorrect type of card");
    }
    //use to append new type specification
    public void AddSpecifications(GameEnum.CardType type)
    {
        SpecificTypes.Add(type);
    }
    public void AddSpecifications(GameEnum.EvoleType type)
    {
        if (this.specificTypes.Contains(GameEnum.CardType.Evole)) SpecificTypes.Add(type);
        else PrintCannotAddEvoleType();
    }
    //use to add new card member
    public void AddCard(Card card)
    {
        if (cards.Count < this.capacity || this.capacity == -1)
        {
            if(this.specificTypes.Count <= 0) cards.Add(card);
            else
            {
                for(int i = 0; i < this.specificTypes.Count; i++)
                {
                    if(this.specificTypes[i] is GameEnum.CardType)
                    {
                        if (card.CardType != (GameEnum.CardType)this.specificTypes[i])
                        {
                            PrintIncorrectType();
                            return;
                        }
                    }
                    else if(this.specificTypes[i] is GameEnum.EvoleType){
                        //TODO writ this after write EvoleCard class
                        /*if(((EvoleCard)card).EvoleType == (GameEnum.EvoleType)this.specificTypes[i]) {
                         *  PrintIncorrectType();
                            return;
                        }*/
                        return;
                    }
                }
                cards.Add(card);
            }
        }
        else PrintOutOfCapacity();
    }
    public int calculateSumOfEvoleCard()
    {
        int sum = 0;
        for(int i = 0; i < cards.Count; i++)
        {
            //TODO if(cards[i].CardType == GameEnum.CardType.Evole) 
        }
        return sum;
    }
}

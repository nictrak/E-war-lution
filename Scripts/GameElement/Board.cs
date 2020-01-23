using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board
{
    private Player owner;
    private CardList deck;
    private CardList hand;
    private CardList boardHead;
    private CardList boardBody;
    private CardList boardOrgan;
    private CardList boardLimb;
    private CardList boardBehavior;
    private CardList fossil;
    private CardList exiledPile;
    private Card waitPlay;

    const int maxPerEvoledZone = 3;
    const int defaultMaxHandSize = 10;

    public CardList Deck { get => deck; set => deck = value; }
    public CardList Hand { get => hand; set => hand = value; }
    public CardList BoardHead { get => boardHead; set => boardHead = value; }
    public CardList BoardBody { get => boardBody; set => boardBody = value; }
    public CardList BoardOrgan { get => boardOrgan; set => boardOrgan = value; }
    public CardList BoardLimb { get => boardLimb; set => boardLimb = value; }
    public CardList BoardBehavior { get => boardBehavior; set => boardBehavior = value; }
    public CardList Fossil { get => fossil; set => fossil = value; }
    public CardList ExiledPile { get => exiledPile; set => exiledPile = value; }
    public Card WaitPlay { get => waitPlay; set => waitPlay = value; }

    public Board(Player owner)
    {
        this.owner = owner;
        this.Deck = new CardList(NameCardList("Deck"), -1);
        this.Hand = new CardList(NameCardList("Hand"), defaultMaxHandSize);
        this.BoardHead = new CardList(NameCardList("Board Head"), maxPerEvoledZone);
        this.BoardBody = new CardList(NameCardList("Board Body"), maxPerEvoledZone);
        this.BoardLimb = new CardList(NameCardList("Board Limb"), maxPerEvoledZone);
        this.BoardOrgan = new CardList(NameCardList("Board Organ"), maxPerEvoledZone);
        this.BoardBehavior = new CardList(NameCardList("Board Behavior"), maxPerEvoledZone);
        this.BoardBody = new CardList(NameCardList("Fossil"), -1);
        this.BoardBody = new CardList(NameCardList("Exiled Pile"), -1);
    }
    private string NameCardList(string str)
    {
        return str + "-" + this.owner.PlayerName + "-" + this.owner.Id;
    }
}

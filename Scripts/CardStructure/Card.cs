using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private Player Owner;
    private int id;
    private string cardName;
    private GameEnum.CardType cardType;
    private GameEnum.Location location;
    private List<Card> enchantmentCards; 

    public Player Owner1 { get => Owner; set => Owner = value; }
    public int Id { get => id; set => id = value; }
    public string CardName { get => cardName; set => cardName = value; }
    public GameEnum.CardType CardType { get => cardType; set => cardType = value; }
    public GameEnum.Location Location { get => location; set => location = value; }
    public List<Card> EnchantmentCards { get => enchantmentCards; set => enchantmentCards = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

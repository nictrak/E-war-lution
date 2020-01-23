using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnum
{
    public enum Location
    {
        Deck,
        Hand,
        BoardHead,
        BoardBody,
        BoardLimb,
        BoardBehavior,
        BoardOrgan,
        Fossil,
        ExiledPile,
        Wait,
        Terrain,
        Undefine,
        Opponent
    }
    public enum CardType
    {
        Evole,
        GodPower,
        Enchantment,
        Terrain,
        Undefine,
        Opponent
    }
    public enum EvoleType
    {
        Head,
        Body,
        Limb,
        Behavior,
        Organ,
        Undefine
    }
    public enum GameState
    {
        InitGame,
        Upkeep,
        SelectActive,
        Play,
        EndTurn,
        EndGame
    }
    public enum WaitState
    {
        Player,
        Logic
    }
    public enum TriggerType
    {
        Undefine,
        Play
        //TODO add more
    }
}

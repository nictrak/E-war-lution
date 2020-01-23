using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string playerName;
    private int id;
    private Player oppoent;
    private PermissionObserver permissionObserver;
    private Board board;
    private Status status;
    private int victoryPoint;
    private int powerPoint;
    private List<ExtraPoint> extraPoints;

    const int startvictoryPoint = 0;

    public string PlayerName { get => playerName; set => playerName = value; }
    public int Id { get => id; set => id = value; }
    public Player Oppoent { get => oppoent; set => oppoent = value; }
    public PermissionObserver PermissionObserver { get => permissionObserver; set => permissionObserver = value; }
    public Board Board { get => board; set => board = value; }
    public Status Status { get => status; set => status = value; }
    public int VictoryPoint { get => victoryPoint; set => victoryPoint = value; }
    public int PowerPoint { get => powerPoint; set => powerPoint = value; }

    private int calculateVictoryPoint()
    {
        int point = 0;
        for(int i = 0; i < this.extraPoints.Count; i++)
        {
            point += extraPoints[i].Value;  
        }
        //TODO write after evole card
        return point;
    }
    // Start is called before the first frame update
    void Start()
    {
        VictoryPoint = startvictoryPoint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PermissionObserver 
{
    private bool canDraw;
    private bool canPlayEvole;
    private bool canPlayGodPower;
    private bool canPlayGodEnchantment;
    private bool canPlayHead;
    private bool canPlayBody;
    private bool canPlayLimb;
    private bool canPlayOrgan;
    private bool canPlayBehavior;
    private bool canChallenge;

    public bool CanDraw { get => canDraw; set => canDraw = value; }
    public bool CanPlayEvole { get => canPlayEvole; set => canPlayEvole = value; }
    public bool CanPlayGodPower { get => canPlayGodPower; set => canPlayGodPower = value; }
    public bool CanPlayGodEnchantment { get => canPlayGodEnchantment; set => canPlayGodEnchantment = value; }
    public bool CanPlayHead { get => canPlayHead; set => canPlayHead = value; }
    public bool CanPlayBody { get => canPlayBody; set => canPlayBody = value; }
    public bool CanPlayLimb { get => canPlayLimb; set => canPlayLimb = value; }
    public bool CanPlayOrgan { get => canPlayOrgan; set => canPlayOrgan = value; }
    public bool CanPlayBehavior { get => canPlayBehavior; set => canPlayBehavior = value; }
    public bool CanChallenge { get => canChallenge; set => canChallenge = value; }

    public PermissionObserver()
    {
        canDraw = true;
        canPlayEvole = true;
        canPlayGodPower = true;
        canPlayGodEnchantment = true;
        canPlayHead = true;
        canPlayBody = true;
        canPlayLimb = true;
        canPlayOrgan = true;
        canPlayBehavior = true;
        canChallenge = true;
    }

    //TODO write Updater
    public void UpdatePermission()
    {

    }
}

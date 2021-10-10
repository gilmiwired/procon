using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivateManager : MonoBehaviour
{
    public int PlayerTurn = 0;
    //0 = not divate,1 = player1,2 = player2,3 = etcAction
    public int faise = 0;
    //0 = not divate, 1 = thinking time,2 = kouteiOK,3 = kouteiQ
    //4 = hiteiOK,5 = hiteiQ,6 = sakusenkaigi,7 = kouteiNOT,8 = hiteiNOT,9 = hantei

    public GameObject OK;
    public GameObject NOT;
    public GameObject think;

    // Start is called before the first frame update
    void Start()
    {
        PlayerTurn = 0;
        faise = 0;
        
    }

     void Update() 
    {
        if(PlayerTurn == 1)
        {
            OK.SetActive(true);
        }
        else if(PlayerTurn == 2)
        {
            NOT.SetActive(true);
        }
        else if(PlayerTurn == 3)
        {
            think.SetActive(true);
        }
    }


}

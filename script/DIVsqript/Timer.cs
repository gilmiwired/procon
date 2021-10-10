using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float countTime;
    public int count = 0;
    public DivateManager DM;
    public GameObject me;
    public valueManager vm;

    // Update is called once per frame
    void Update()
    {
        // countTimeに、ゲームが開始してからの秒数を減少
        countTime -= Time.deltaTime;

        // 小数を消して表示
        GetComponent<Text>().text = countTime.ToString("F0");


        //時間切れになったら
        if(countTime <= 0)
        {

            DM.faise += 1;
            switch (DM.faise)
            {
                case 0: //NOT divate
                    DM.PlayerTurn = 0;
  
                    break;

                case 1: //シンキングタイム
                    countTime = 10f;
                    DM.PlayerTurn = 3;

                    break;
                case 2: //肯定側弁論
                    countTime =　10f;
                    DM.PlayerTurn = 1;

                    break;
                case 3: //肯定側質問タイム
                    countTime =　10f;

                
                    break;
                case 4: //否定側弁論
                    countTime =　10f;
                    DM.PlayerTurn = 2;

           
                    break;
                case 5: //否定側質問タイム
                    countTime =　10f;

                    break;
                case 6: //作戦会議
                    countTime =　10f;
                    DM.PlayerTurn = 3;

                    break;
                case 7: //肯定反論タイム
                    countTime =　10f;
                    DM.PlayerTurn = 1;

                    break;
                case 8: //否定反論タイム
                    countTime = 10f;
                    DM.PlayerTurn = 2;

                    break;

                case 9: //判定
                    countTime =　10f;
                    DM.PlayerTurn = 4;
                    break;

                case 10:
                    me.SetActive(false);
                    DM.faise = 0;
                    vm.step = 0;
                    break;

                default:
                    Debug.Log("Error.");
                    break;

            }
        }
    }

}
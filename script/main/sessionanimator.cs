using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sessionanimator : MonoBehaviour
{
    //===== 定義領域 =====
    public Animator anim;  //Animatorをanimという変数で定義する
    public valueManager vm;
    [SerializeField] GameObject sessionPanel;
   // var an = anim.GetComponent<Animator>;
    //===== 初期処理 =====
    void Start()
    {
        //変数animに、Animatorコンポーネントを設定する
      //  anim = gameObject.GetComponent<Animator>();
    }

    //===== 主処理 =====
    void Update()
    {
        if (vm.tc == 0)
        {
            sessionPanel.SetActive(false);
            anim.GetComponent<Animator>().SetBool("sessionbool", false);
        } else if (vm.tc==1) {
            anim.GetComponent<Animator>().SetBool("sessionbool", true);
            sessionPanel.SetActive(true);
        }
    }
}

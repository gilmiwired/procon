using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sessionanimator : MonoBehaviour
{
    //===== ��`�̈� =====
    public Animator anim;  //Animator��anim�Ƃ����ϐ��Œ�`����
    public valueManager vm;
    [SerializeField] GameObject sessionPanel;
   // var an = anim.GetComponent<Animator>;
    //===== �������� =====
    void Start()
    {
        //�ϐ�anim�ɁAAnimator�R���|�[�l���g��ݒ肷��
      //  anim = gameObject.GetComponent<Animator>();
    }

    //===== �又�� =====
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

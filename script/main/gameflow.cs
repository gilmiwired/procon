using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using System;
public class gameflow : MonoBehaviour
{
    public valueManager vm;
    public DivateManager dm;
    //�C���X�y�N�^�[�E�B���h�E����Q�[���I�u�W�F�N�g��ݒ肷��
    [SerializeField] GameObject Panel;
    //[SerializeField] GameObject systemPanel;
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject enviromentPanel;
    [SerializeField] GameObject openPanel;

    [SerializeField] GameObject devetePanel;

    public Text steptext;

    // Start is called before the first frame update
    void Start()
    {

    }
    private IEnumerator room_Delay() //�R���[�`���֐��̖��O
    {         //�R���[�`���̓��e]
        yield return new WaitForSeconds(10f);
        vm.delete_rp = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (vm.delete_rp==0) { 
        }
        else if (vm.step == 0 && vm.tileon == 0)
        {
            Panel.SetActive(true);
            devetePanel.SetActive(false);
            steptext.text = "�Q�[��";
        }
        else if (vm.step == 1) {
            steptext.text = "���_";
            devetePanel.SetActive(true);
            Panel.SetActive(false);
        }
    }
}

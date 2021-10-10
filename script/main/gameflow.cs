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
    //インスペクターウィンドウからゲームオブジェクトを設定する
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
    private IEnumerator room_Delay() //コルーチン関数の名前
    {         //コルーチンの内容]
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
            steptext.text = "ゲーム";
        }
        else if (vm.step == 1) {
            steptext.text = "討論";
            devetePanel.SetActive(true);
            Panel.SetActive(false);
        }
    }
}

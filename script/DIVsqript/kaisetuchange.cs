using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kaisetuchange : MonoBehaviour
{
	public Text text;
    public GameObject think;
    public GameObject OK;
    public GameObject NO;
    public GameObject LAST;
    public GameObject HANTEI;

	// Update is called once per frame
	void Update () {

		if(think.activeSelf == true)
        {
			text.text = "自分の意見を考えてまとめよう";
		
	    }
		if(OK.activeSelf == true){

			text.text = "自分の意見を相手に伝えよう";
		
	    }
		if(NO.activeSelf == true){

			text.text = "相手の意見の穴を指摘しよう";
		
	    }
		if(LAST.activeSelf == true){

			text.text = "相手の意見の疑問点を聞こう";
		
	    }
		if(HANTEI.activeSelf == true){

			text.text = "さて、勝敗は・・・？";
		
	    }
    }
}

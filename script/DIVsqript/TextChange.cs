using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour {

	public Text text;
	public DivateManager DM;

	// Update is called once per frame
	void Update () {

		if(DM.faise == 1 || DM.faise == 6)
        {
			text.text = "作戦会議";
		
	    }
		if(DM.faise == 2 || DM.faise == 4){

			text.text = "立論";
		
	    }
		if(DM.faise == 3 || DM.faise == 5){

			text.text = "質問";
		
	    }
		if(DM.faise == 7 || DM.faise == 8){

			text.text = "反論";
		
	    }
		if(DM.faise == 9){

			text.text = "判定";
		
	    }
    }

}
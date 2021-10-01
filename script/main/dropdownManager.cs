using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdownManager : MonoBehaviour
{
    [SerializeField] public Dropdown movedropdown;
    [SerializeField] public Dropdown zoomdropdown;
    public cameramove cm;
    public Sprite reverse;
    public Sprite usual;
    public Image movephoto;
    public Image zoomphoto;

    void start() {
      //  movephoto = GameObject.Find("à⁄ìÆÇÃï˚å¸").GetComponent<Image>();
      //  movephoto.sprite = usual;
      //  zoomphoto = GameObject.Find("ÉYÅ[ÉÄÇÃï˚å¸").GetComponent<Image>();
      //  zoomphoto.sprite = usual;
    }
    // Update is called once per frame
    void Update()
    {
     switch (movedropdown.value)
        {
            case 0:
                cm.movedirection = 1;
                break;
            case 1:
                cm.movedirection = -1;
                break;
     }
        switch (zoomdropdown.value)
        {
            case 0:
                cm.zoomdirection = 1;
                break;
            case 1:
               cm.zoomdirection = -1;
                break;
        }
    }

    public void MoveDropDown() {
        switch (movedropdown.value)
        {
            case 0:
                movephoto.sprite = usual;
                break;
            case 1:
                movephoto.sprite = reverse;
                break;
        }
    }
    public void ZoomDropDown() {
        switch (zoomdropdown.value)
        {
            case 0:
                zoomphoto.sprite = usual;
                break;
            case 1:
                zoomphoto.sprite = reverse;
                break;
        }
    }



}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderManager : MonoBehaviour
{
    public Slider moveslider;
    public Slider zoomslider;
    private float maxmovespeed = 200.0f;
    private float maxzoomspeed = 50.0f;

    public Slider natureslider;
    public Slider cultureslider;
    public Slider wealthslider;
    public cameramove cm;


    // Start is called before the first frame update
    void Start()
    {
        moveslider.maxValue = maxmovespeed;
        moveslider.value = cm.movespeed;
        zoomslider.maxValue = maxzoomspeed;
        zoomslider.value = cm.zoomspeed;

        natureslider.maxValue = 100;
        cultureslider.maxValue = 100;
        wealthslider.maxValue = 100;

        natureslider.value = 90;
        cultureslider.value = 10;
        wealthslider.value = 10;
    }

    // Update is called once per frame
    void Update()
    {
        cm.movespeed = moveslider.value;
        cm.zoomspeed = zoomslider.value;
        natureslider.value = cm.nature;
        cultureslider.value = cm.culture;
        wealthslider.value = cm.wealth;
    }
}

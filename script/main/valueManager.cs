using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valueManager : MonoBehaviour
{
    public cameramove cm;

    void Update() {
            cm.nature = cm.forest_num * 2 + cm.grassland_num - cm.firepower_num;
            cm.culture = cm.mine_num + cm.firepower_num + cm.windpower_num;
            cm.wealth = cm.mine_num + cm.forest_num + cm.grassland_num + cm.firepower_num * 3 + cm.windpower_num;
            cm.population = cm.house + cm.windpower_num - cm.firepower_num + 3;
            cm.house = cm.population / 3 + cm.firepower_num;
        if (cm.wealth > 100)
        {
            cm.wealth = 100;
        }
        else if (cm.wealth < 0)
        {
            cm.wealth = 0;
        }
        if (cm.culture > 100)
        {
            cm.culture = 100;
        }
        else if (cm.culture < 0)
        {
            cm.culture = 0;
        }
        if (cm.nature > 100)
        {
            cm.nature = 100;
        }
        else if (cm.nature < 0)
        {
           cm.nature = 0;
        }
        if (cm.population > 100)
        {
            cm.population = 100;
        }
        else if (cm.population < 0) {
            cm.population = 0;
        }
        if (cm.house > 100)
        {
            cm.house = 100;
        }
        else if (cm.house < 0) {
            cm.house = 0;
        }
    }
}

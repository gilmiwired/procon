using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valueManager : MonoBehaviour
{
    public int ablegame = 1;
    public int select = 0;
    public int forest_num = 25;
    public int mine_num = 0;
    public int grassland_num = 20;
    public int desert = 3;
    public int windpower_num = 0;
    public int firepower_num = 0;
    public int wealth = 10;
    public int culture = 10;
    public int nature = 90;
    public int population = 3;
    public int house = 1;
    public int develop = 0;
    public int tileon = 0;
    public int step = 0;
    public int tc = 0;
    public int delete_rp = 0;
    public int tile_num = 0;
    void start() {
    }

    void Update() {
            nature = forest_num * 2 + grassland_num - firepower_num;
            culture = mine_num + firepower_num + windpower_num;
            wealth = mine_num + forest_num + grassland_num + firepower_num * 3 + windpower_num;
            population = house + windpower_num - firepower_num + 3;
            house = population / 3 + firepower_num;
        if (wealth > 100)
        {
            wealth = 100;
        }
        else if (wealth < 0)
        {
            wealth = 0;
        }
        if (culture > 100)
        {
            culture = 100;
        }
        else if (culture < 0)
        {
            culture = 0;
        }
        if (nature > 100)
        {
            nature = 100;
        }
        else if (nature < 0)
        {
           nature = 0;
        }
        if (population > 100)
        {
            population = 100;
        }
        else if (population < 0) {
            population = 0;
        }
        if (house > 100)
        {
            house = 100;
        }
        else if (house < 0)
        {
            house = 0;
        }
    }
}

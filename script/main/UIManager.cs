using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //Panelを格納する変数
    //インスペクターウィンドウからゲームオブジェクトを設定する
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject systemPanel;
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject enviromentPanel;
    [SerializeField] GameObject openPanel;
    //menu関連
    [SerializeField] GameObject menu_Panel;
    [SerializeField] GameObject menu_iconPanel;
    [SerializeField] GameObject menu_tilePanel;
    [SerializeField] GameObject menu_devPanel;
    [SerializeField] GameObject menu_comuPanel;
    //menu_icon関連
    [SerializeField] GameObject menu_icon_system;
    [SerializeField] GameObject menu_icon_wealth;
    [SerializeField] GameObject menu_icon_culture;
    [SerializeField] GameObject menu_icon_nature;
    [SerializeField] GameObject menu_icon_population;
    [SerializeField] GameObject menu_icon_house;
    //menu_tile関連
    [SerializeField] GameObject menu_tile_forest;
    [SerializeField] GameObject menu_tile_grassland;
    [SerializeField] GameObject menu_tile_river;
    [SerializeField] GameObject menu_tile_mine;
    [SerializeField] GameObject menu_tile_riverf;
    [SerializeField] GameObject menu_tile_firepower;
    [SerializeField] GameObject menu_tile_windpower;
    //menu_dev関連
    [SerializeField] GameObject menu_dev_firepower;
    [SerializeField] GameObject menu_dev_windpower;

    public cameramove cm;

    void Update() {
        switch (cm.select) {
            case 0:
                cm.ablegame = 1;
                Panel.SetActive(false);
                break;
            case 1:
                cm.ablegame = 0;
                Panel.SetActive(true);
                break;
            case 2:
                cm.ablegame = 1;
                Panel.SetActive(false);
             
                break;
            case 3:
                Panel.SetActive(false);
                mainPanel.SetActive(false);
                cm.ablegame = 0;
                systemPanel.SetActive(true);
                break;
            case 4:
                cm.ablegame = 1;
                systemPanel.SetActive(false);
                mainPanel.SetActive(true);
                break;
            case 5:
                enviromentPanel.SetActive(false);
                openPanel.SetActive(true);
                break;
            case 6:
                openPanel.SetActive(false);
                enviromentPanel.SetActive(true);
                break;
            //menu関連
            case 7:
                cm.ablegame = 0;
                menu_Panel.SetActive(true);
                menu_iconPanel.SetActive(true);
                menu_comuPanel.SetActive(false);
                menu_devPanel.SetActive(false);
                menu_tilePanel.SetActive(false);
                menu_icon_system.SetActive(true);
                menu_icon_wealth.SetActive(false);
                menu_icon_culture.SetActive(false);
                menu_icon_nature.SetActive(false);
                menu_icon_population.SetActive(false);
                menu_icon_house.SetActive(false);
                break;
            case 8:
                menu_iconPanel.SetActive(true);
                menu_comuPanel.SetActive(false);
                menu_devPanel.SetActive(false);
                menu_tilePanel.SetActive(false);
                break;
            case 9:
                menu_iconPanel.SetActive(false);
                menu_comuPanel.SetActive(false);
                menu_devPanel.SetActive(false);
                menu_tilePanel.SetActive(true);
                break;
            case 10:
                menu_iconPanel.SetActive(false);
                menu_comuPanel.SetActive(false);
                menu_devPanel.SetActive(true);
                menu_tilePanel.SetActive(false);
                break;
            case 11:
                menu_iconPanel.SetActive(false);
                menu_comuPanel.SetActive(true);
                menu_devPanel.SetActive(false);
                menu_tilePanel.SetActive(false);
                break;
            case 12:
                menu_Panel.SetActive(false);
                cm.ablegame = 1;
                break;
            //menu_icon関連
            case 13:
                menu_icon_system.SetActive(true);
                menu_icon_wealth.SetActive(false);
                menu_icon_culture.SetActive(false);
                menu_icon_nature.SetActive(false);
                menu_icon_population.SetActive(false);
                menu_icon_house.SetActive(false);
                break;
            case 14:
                menu_icon_system.SetActive(false);
                menu_icon_wealth.SetActive(true);
                menu_icon_culture.SetActive(false);
                menu_icon_nature.SetActive(false);
                menu_icon_population.SetActive(false);
                menu_icon_house.SetActive(false);
                break;
            case 15:
                menu_icon_system.SetActive(false);
                menu_icon_wealth.SetActive(false);
                menu_icon_culture.SetActive(true);
                menu_icon_nature.SetActive(false);
                menu_icon_population.SetActive(false);
                menu_icon_house.SetActive(false);
                break;
            case 16:
                menu_icon_system.SetActive(false);
                menu_icon_wealth.SetActive(false);
                menu_icon_culture.SetActive(false);
                menu_icon_nature.SetActive(true);
                menu_icon_population.SetActive(false);
                menu_icon_house.SetActive(false);
                break;
            case 17:
                menu_icon_system.SetActive(false);
                menu_icon_wealth.SetActive(false);
                menu_icon_culture.SetActive(false);
                menu_icon_nature.SetActive(false);
                menu_icon_population.SetActive(true);
                menu_icon_house.SetActive(false);
                break;
            case 18:
                menu_icon_system.SetActive(false);
                menu_icon_wealth.SetActive(false);
                menu_icon_culture.SetActive(false);
                menu_icon_nature.SetActive(false);
                menu_icon_population.SetActive(false);
                menu_icon_house.SetActive(true);
                break;
            //menu_tile
            case 19:
                menu_tile_forest.SetActive(true);
                menu_tile_grassland.SetActive(false);
                menu_tile_mine.SetActive(false);
                menu_tile_river.SetActive(false);
                menu_tile_riverf.SetActive(false);
                menu_tile_firepower.SetActive(false);
                menu_tile_windpower.SetActive(false);
                break;
            case 20:
                menu_tile_forest.SetActive(false);
                menu_tile_grassland.SetActive(true);
                menu_tile_mine.SetActive(false);
                menu_tile_river.SetActive(false);
                menu_tile_riverf.SetActive(false);
                menu_tile_firepower.SetActive(false);
                menu_tile_windpower.SetActive(false);
                break;
            case 21:
                menu_tile_forest.SetActive(false);
                menu_tile_grassland.SetActive(false);
                menu_tile_mine.SetActive(false);
                menu_tile_river.SetActive(true);
                menu_tile_riverf.SetActive(false);
                menu_tile_firepower.SetActive(false);
                menu_tile_windpower.SetActive(false);
                break;
            case 22:
                menu_tile_forest.SetActive(false);
                menu_tile_grassland.SetActive(false);
                menu_tile_mine.SetActive(true);
                menu_tile_river.SetActive(false);
                menu_tile_riverf.SetActive(false);
                menu_tile_firepower.SetActive(false);
                menu_tile_windpower.SetActive(false);
                break;
            case 23:
                menu_tile_forest.SetActive(false);
                menu_tile_grassland.SetActive(false);
                menu_tile_mine.SetActive(false);
                menu_tile_river.SetActive(false);
                menu_tile_riverf.SetActive(true);
                menu_tile_firepower.SetActive(false);
                menu_tile_windpower.SetActive(false);
                break;
            case 24:
                menu_tile_forest.SetActive(false);
                menu_tile_grassland.SetActive(false);
                menu_tile_mine.SetActive(false);
                menu_tile_river.SetActive(false);
                menu_tile_riverf.SetActive(false);
                menu_tile_firepower.SetActive(true);
                menu_tile_windpower.SetActive(false);
                break;
            case 25:
                menu_tile_forest.SetActive(false);
                menu_tile_grassland.SetActive(false);
                menu_tile_mine.SetActive(false);
                menu_tile_river.SetActive(false);
                menu_tile_riverf.SetActive(false);
                menu_tile_firepower.SetActive(false);
                menu_tile_windpower.SetActive(true);
                break;
            //menu_dev
            case 26:
                menu_dev_firepower.SetActive(true);
                menu_dev_windpower.SetActive(false);
                break;
            case 27:
                menu_dev_firepower.SetActive(false);
                menu_dev_windpower.SetActive(true);
                break;
        }
    }

}
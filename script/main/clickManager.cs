using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickManager : MonoBehaviour
{
    //インスペクターウィンドウからゲームオブジェクトを設定する
    [SerializeField] GameObject Panel;
    //[SerializeField] GameObject systemPanel;
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
    //[SerializeField] GameObject menu_icon_system;
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
    //gamepanel
    [SerializeField] GameObject gamepanel;
    [SerializeField] GameObject background_Panel;
    //step
    [SerializeField] GameObject step;

    //room
    [SerializeField] GameObject roomPanel;
    [SerializeField] GameObject makeroom;
    [SerializeField] GameObject enterroom;
    [SerializeField] GameObject waitroom;

    public valueManager vm;

    void Update() {
        if (vm.delete_rp==1) {
            gamepanel.SetActive(true);
            mainPanel.SetActive(true);
            Panel.SetActive(true);
            step.SetActive(true);
            background_Panel.SetActive(true);
            waitroom.SetActive(false);
            makeroom.SetActive(false);
            enterroom.SetActive(false);
            roomPanel.SetActive(false);
            vm.delete_rp = 2;
        }
    }




    //dev
    public void oncilckwindpower() {
        //Panel.SetActive(false);
        vm.develop = 1;
        vm.tileon = 1;
    }
    public void onclickfirepower() {
        //Panel.SetActive(false);
        vm.develop = 2;
        vm.tileon = 1;
    }
 /*   public void onclickno()
    {
        Panel.SetActive(false);
        vm.ablegame = 1;
    }   */
 /*   public void onclicksystem() {
        vm.ablegame = 0;
    }*/
  /*  public void onclickreturn() {
        vm.ablegame = 1;
    }*/
    public void onclickclose() {
        enviromentPanel.SetActive(false);
        openPanel.SetActive(true);
    }
    public void onclickopen() {
        openPanel.SetActive(false);
        enviromentPanel.SetActive(true);
    }
//menu関連
    public void onclickmenu() {
        mainPanel.SetActive(false);
        menu_Panel.SetActive(true);
        menu_iconPanel.SetActive(true);
        menu_tilePanel.SetActive(false);
        menu_devPanel.SetActive(false);
        menu_comuPanel.SetActive(false);

        menu_icon_wealth.SetActive(true);
        menu_icon_culture.SetActive(false);
        menu_icon_nature.SetActive(false);
        menu_icon_population.SetActive(false);
        menu_icon_house.SetActive(false);

        gamepanel.SetActive(false);

        step.SetActive(false);
        vm.ablegame = 0;

    }
    public void onclickmenu_icon() {
        menu_iconPanel.SetActive(true);
        menu_tilePanel.SetActive(false);
        menu_devPanel.SetActive(false);
        menu_comuPanel.SetActive(false);
    }
    public void onclickmenu_tile() {
        menu_iconPanel.SetActive(false);
        menu_tilePanel.SetActive(true);
        menu_devPanel.SetActive(false);
        menu_comuPanel.SetActive(false);
    }
    public void onclickmenu_dev() {
        menu_iconPanel.SetActive(false);
        menu_tilePanel.SetActive(false);
        menu_devPanel.SetActive(true);
        menu_comuPanel.SetActive(false);
    }
    public void onclickmenu_com() {
        menu_iconPanel.SetActive(false);
        menu_tilePanel.SetActive(false);
        menu_devPanel.SetActive(false);
        menu_comuPanel.SetActive(true);
    }
    public void onclickmenu_return() {
        menu_Panel.SetActive(false);
        mainPanel.SetActive(true);
        gamepanel.SetActive(true);

        step.SetActive(true) ;
        vm.ablegame = 1;
    }
    //icon関連
/*    public void menu_icon_systemc() {
        menu_icon_system.SetActive(true);
        menu_icon_wealth.SetActive(false);
        menu_icon_culture.SetActive(false);
        menu_icon_nature.SetActive(false);
        menu_icon_population.SetActive(false);
        menu_icon_house.SetActive(false);
    }*/
    public void menu_icon_wealthc() {
    //    menu_icon_system.SetActive(false);
        menu_icon_wealth.SetActive(true);
        menu_icon_culture.SetActive(false);
        menu_icon_nature.SetActive(false);
        menu_icon_population.SetActive(false);
        menu_icon_house.SetActive(false);
    }
    public void menu_icon_culturec()
    {
      //  menu_icon_system.SetActive(false);
        menu_icon_wealth.SetActive(false);
        menu_icon_culture.SetActive(true);
        menu_icon_nature.SetActive(false);
        menu_icon_population.SetActive(false);
        menu_icon_house.SetActive(false);
    }
    public void menu_icon_naturec()
    {
     //   menu_icon_system.SetActive(false);
        menu_icon_wealth.SetActive(false);
        menu_icon_culture.SetActive(false);
        menu_icon_nature.SetActive(true);
        menu_icon_population.SetActive(false);
        menu_icon_house.SetActive(false);
    }
    public void menu_icon_populationc()
    {
    //    menu_icon_system.SetActive(false);
        menu_icon_wealth.SetActive(false);
        menu_icon_culture.SetActive(false);
        menu_icon_nature.SetActive(false);
        menu_icon_population.SetActive(true);
        menu_icon_house.SetActive(false);
    }
    public void menu_icon_housec()
    {
    //    menu_icon_system.SetActive(false);
        menu_icon_wealth.SetActive(false);
        menu_icon_culture.SetActive(false);
        menu_icon_nature.SetActive(false);
        menu_icon_population.SetActive(false);
        menu_icon_house.SetActive(true);
    }
    //tile関連
    public void menu_tile_forestc() {
        menu_tile_forest.SetActive(true);
        menu_tile_grassland.SetActive(false);
        menu_tile_river.SetActive(false);
        menu_tile_mine.SetActive(false);
        menu_tile_riverf.SetActive(false);
        menu_tile_firepower.SetActive(false);
        menu_tile_windpower.SetActive(false);
    }
    public void menu_tile_grasslandc()
    {
        menu_tile_forest.SetActive(false);
        menu_tile_grassland.SetActive(true);
        menu_tile_river.SetActive(false);
        menu_tile_mine.SetActive(false);
        menu_tile_riverf.SetActive(false);
        menu_tile_firepower.SetActive(false);
        menu_tile_windpower.SetActive(false);
    }
    public void menu_tile_riverc() {
        menu_tile_forest.SetActive(false);
        menu_tile_grassland.SetActive(false);
        menu_tile_river.SetActive(true);
        menu_tile_mine.SetActive(false);
        menu_tile_riverf.SetActive(false);
        menu_tile_firepower.SetActive(false);
        menu_tile_windpower.SetActive(false);
    }
    public void menu_tile_minec() {
        menu_tile_forest.SetActive(false);
        menu_tile_grassland.SetActive(false);
        menu_tile_river.SetActive(false);
        menu_tile_mine.SetActive(true);
        menu_tile_riverf.SetActive(false);
        menu_tile_firepower.SetActive(false);
        menu_tile_windpower.SetActive(false);
    }
    public void menu_tile_riverfc() {
        menu_tile_forest.SetActive(false);
        menu_tile_grassland.SetActive(false);
        menu_tile_river.SetActive(false);
        menu_tile_mine.SetActive(false);
        menu_tile_riverf.SetActive(true);
        menu_tile_firepower.SetActive(false);
        menu_tile_windpower.SetActive(false);
    }
    public void menu_tile_firepowerc() {
        menu_tile_forest.SetActive(false);
        menu_tile_grassland.SetActive(false);
        menu_tile_river.SetActive(false);
        menu_tile_mine.SetActive(false);
        menu_tile_riverf.SetActive(false);
        menu_tile_firepower.SetActive(true);
        menu_tile_windpower.SetActive(false);
    }
    public void menu_tile_windpowerc() {
        menu_tile_forest.SetActive(false);
        menu_tile_grassland.SetActive(false);
        menu_tile_river.SetActive(false);
        menu_tile_mine.SetActive(false);
        menu_tile_riverf.SetActive(false);
        menu_tile_firepower.SetActive(false);
        menu_tile_windpower.SetActive(true);
    }
    //dev関連
    public void menu_dev_firepowerc() {
        menu_dev_firepower.SetActive(true);
        menu_dev_windpower.SetActive(false);
    }
    public void menu_dev_windpowerc() {
        menu_dev_firepower.SetActive(false);
        menu_dev_windpower.SetActive(true);
    }
    //com関連


    //room
    public void enter_room() {
        roomPanel.SetActive(false);
        enterroom.SetActive(true);
        makeroom.SetActive(false);
        waitroom.SetActive(false);
    }
    public void make_room() {
        roomPanel.SetActive(false);
        enterroom.SetActive(false);
        makeroom.SetActive(true);
        waitroom.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickManager : MonoBehaviour
{
    public cameramove cm;
    //dev
    public void onclickde()
    {
        cm.select = 2;
    }
    public void oncilckwindpower() {
        cm.select = 28;
    }
    public void onclickfirepower() {
        cm.select = 29;
    }
    public void onclickno()
    {
        cm.select = 0;
    }
    public void onclicksystem() {
        cm.select = 3;
    }
    public void onclickreturn() {
        cm.select = 4;
    }
    public void onclickclose() {
        cm.select = 5;
    }
    public void onclickopen() {
        cm.select = 6;
    }
//menu関連
    public void onclickmenu() {
        cm.select = 7;
    }
    public void onclickmenu_icon() {
        cm.select = 8;
    }
    public void onclickmenu_tile() {
        cm.select = 9;
    }
    public void onclickmenu_dev() {
        cm.select = 10;
    }
    public void onclickmenu_com() {
        cm.select = 11;
    }
    public void onclickmenu_return() {
        cm.select = 12;
    }
    //icon関連
    public void menu_icon_system() {
        cm.select = 13;
    }
    public void menu_icon_wealth() {
        cm.select = 14;
    }
    public void menu_icon_culture()
    {
        cm.select = 15;
    }
    public void menu_icon_nature()
    {
        cm.select = 16;
    }
    public void menu_icon_population()
    {
        cm.select = 17;
    }
    public void menu_icon_house()
    {
        cm.select = 18;
    }
    //tile関連
    public void menu_tile_forest() {
        cm.select = 19;
    }
    public void menu_tile_grassland()
    {
        cm.select = 20;
    }
    public void menu_tile_river() {
        cm.select = 21;
    }
    public void menu_tile_mine() {
        cm.select = 22;
    }
    public void menu_tile_riverf() {
        cm.select = 23;
    }
    public void menu_tile_firepower() {
        cm.select = 24;
    }
    public void menu_tile_windpower() {
        cm.select = 25;
    }
    //dev関連
    public void menu_dev_firepower() {
        cm.select = 26;
    }
    public void menu_dev_windpower() {
        cm.select = 27;
    }
    //com関連
}

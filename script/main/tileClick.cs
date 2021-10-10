using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class tileClick : MonoBehaviourPun
{
    public Sprite windpower;
    public Sprite firepower;
    public valueManager vm;


    //コルーチン関数を定義
    private IEnumerator Delay() //コルーチン関数の名前
    {         //コルーチンの内容]
        yield return new WaitForSeconds(0.6f);
        vm.tc = 1;
        yield return new WaitForSeconds(1.4f);
        vm.tc = 0;
        yield return new WaitForSeconds(0.3f);
        vm.step = 1;
    }

    public void onforestclick()
    {
        var img = GetComponent<Image>();

        if (vm.tileon==1 && img.sprite != windpower && img.sprite != firepower) {
            vm.tile_num++;
                if (vm.develop == 1)
                {
                    img.sprite = windpower;
                    vm.forest_num--;
                    vm.windpower_num++;
                    vm.develop = 0;
                    vm.ablegame = 1;
                }
                else if (vm.develop == 2)
                {
                    img.sprite = firepower;
                vm.forest_num--;
                    vm.firepower_num++;
                    vm.develop = 0;
                    vm.ablegame = 1;
                }
                else if (vm.develop == 3)
                {
                    img.sprite = firepower;
                vm.forest_num--;
                    vm.develop = 0;
                    vm.ablegame = 1;
                }
            vm.develop = 0;
            vm.tileon = 0;
            if (vm.tile_num==4) {
                vm.tile_num = 0;
                StartCoroutine("Delay");
            }
        }
        
    }
 
    public void ongrasslandclick()
    {
        var img = GetComponent<Image>();

        if (vm.tileon == 1 && img.sprite != windpower && img.sprite != firepower)
        {
            vm.tile_num++;
            if (vm.develop == 1)
            {
                img.sprite = windpower;
                vm.grassland_num--;
                vm.windpower_num++;
                vm.develop = 0;
                vm.ablegame = 1;
            }
            else if (vm.develop == 2)
            {
                img.sprite = firepower;
                vm.grassland_num--;
                vm.firepower_num++;
                vm.develop = 0;
                vm.ablegame = 1;
            }
            else if (vm.develop == 3)
            {
                img.sprite = firepower;
                vm.grassland_num--;
                vm.develop = 0;
                vm.ablegame = 1;
            }
            vm.develop = 0;
            vm.tileon = 0;
            if (vm.tile_num == 4)
            {
                vm.tile_num = 0;
                StartCoroutine("Delay");
            }
        }
    }
}

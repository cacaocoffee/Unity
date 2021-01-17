using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : Singleton<UImanager> 
{

    public GameObject StatMenu;
    public GameObject ShopMenu;
    public GameObject statButton;
    public GameObject shopButton;

    public void ButtonsOpen() // 버튼들을 보여줌
    {
        statButton.gameObject.SetActive(true);
        shopButton.gameObject.SetActive(true);
    }

    public void ButtonsClose() //버튼들을 숨김
    {
        statButton.gameObject.SetActive(false);
        shopButton.gameObject.SetActive(false);
    }
    

    public void StatButton()
    {
        StatMenu.gameObject.SetActive(true);
    }
    public void StatExitButton()
    {
        StatMenu.gameObject.SetActive(false);
    }
    public void ShopButton()
    {
        ShopMenu.gameObject.SetActive(true);
    }
    public void ShopExitButton()
    {
        ShopMenu.gameObject.SetActive(false);
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : Singleton<UImanager> 
{

    public GameObject StatMenu;
    public GameObject ShopMenu;
    public GameObject SkillMenu;
    public GameObject statButton;
    public GameObject shopButton;
    public GameObject skillButton;
    public GameObject Stage1;
    public GameObject Stage2;
    public void ButtonsOpen() // 버튼들을 보여줌
    {
        statButton.gameObject.SetActive(true);
        shopButton.gameObject.SetActive(true);
        skillButton.gameObject.SetActive(true);
    }

    public void ButtonsClose() //버튼들을 숨김
    {
        statButton.gameObject.SetActive(false);
        shopButton.gameObject.SetActive(false);
        skillButton.gameObject.SetActive(false);
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
    public void SkillButton()
    {
        SkillMenu.gameObject.SetActive(true);
    }
    public void SkillExitButton()
    {
        SkillMenu.gameObject.SetActive(false);
    }
    public void ShopExitButton()
    {
        ShopMenu.gameObject.SetActive(false);
    }
    
    public void StageChange() // 스테이지 변경 
    {
        if (DataController.Instance.Stage == 1)
        {
            Stage1.gameObject.SetActive(true);
            Stage2.gameObject.SetActive(false);
        }
        if (DataController.Instance.Stage == 2)
        {
            Stage1.gameObject.SetActive(false);
            Stage2.gameObject.SetActive(true);
        }
    }


    private void Start()
    {
        StageChange();
    }
}

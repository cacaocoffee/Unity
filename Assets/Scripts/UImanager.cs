using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    private static UImanager instance;

    public static UImanager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<UImanager>(); //하이라키에서 데이터컨트롤러를 찾아서 넣음
                if (instance == null) //찾았는데도 생성이 안되서 없을때.
                {
                    GameObject container = new GameObject("UImanager");
                    instance = container.AddComponent<UImanager>();
                }
            }

            return instance;
        } 
    }

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

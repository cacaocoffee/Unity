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
    public void StatButton()
    {
        StatMenu.gameObject.SetActive(true);
    }
    public void StatExitButton()
    {
        StatMenu.gameObject.SetActive(false);
    }

}

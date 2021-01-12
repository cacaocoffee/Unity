using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    private static Shop instance;
    public static Shop Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Shop>(); 
                if (instance == null) 
                {
                    GameObject container = new GameObject("Shop");
                    instance = container.AddComponent<Shop>();
                }
            }

            return instance;
        } 
    }
    public Text Item1_Displayer;
    
    public int Item1 //첫번째 아이템 레벨
    {
        get { return PlayerPrefs.GetInt("Item1",1); }
        set { PlayerPrefs.SetInt("Item1", value); }
    }

    public int Item1_Cost //아이템 가격
    {
        get { return PlayerPrefs.GetInt("Item1_Cost",1); }
        set { PlayerPrefs.SetInt("Item1_Cost", value); }
    }

    public int Item1_DamageUp //업그레이드 해줄 데미지.
    {
        get { return PlayerPrefs.GetInt("Item1_DamageUp",1); }
        set { PlayerPrefs.SetInt("Item1_DamageUp", value); }
    }

    private void Update()
    {
        Item1_Displayer.text = "해골Lv" + Item1 + "\n" + "필요한 돈:" + Item1_Cost + "\n" + "올라갈 데미지" + Item1_DamageUp;
    }

    public void OnClick()
    {
        if (Item1_Cost <= DataController.Instance.Gold)
        {
            DataController.Instance.Damage += Item1_DamageUp;
            DataController.Instance.Gold -= Item1_Cost;
            Item1++;
            Item1_DamageUp = 1*(int) Mathf.Pow(1.6f, Item1);
            Item1_Cost = 1*(int) Mathf.Pow(2f, Item1);
        }
    }
}

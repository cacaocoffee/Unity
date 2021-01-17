using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{
    private static Stat instance;

    public static Stat Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Stat>();
                if (instance == null)
                {
                    GameObject container = new GameObject("Stat");
                    instance = container.AddComponent<Stat>();
                }
            }

            return instance;
        }
    }

    public Text StatDisplay_MaxHp;
    public Text StatDisplay_P;
    public Text StatDisplay_A;
    public Text StatDisplay_Int;
    public Text StatDisplay_Dmg;
    private void Update()
    {
        StatDisplay_MaxHp.text = "체력 : " +DataController.Instance.Hero_hp+" / "+ DataController.Instance.Hero_MaxHp;
        StatDisplay_P.text = "힘 : " +  DataController.Instance.Hero_Power;
        StatDisplay_A.text = "민첩 : " +  DataController.Instance.Hero_Agility;
        StatDisplay_Int.text = "지능 : " +  DataController.Instance.Hero_Intellgence;
        StatDisplay_Dmg.text = "데미지 : " +  DataController.Instance.Damage;
    }
}

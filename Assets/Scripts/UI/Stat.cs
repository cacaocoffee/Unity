using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat :  Singleton<Stat>
{
    private static Stat instance;
    
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

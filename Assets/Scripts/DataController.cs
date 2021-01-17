using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    private static DataController instance;

    public static DataController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<DataController>(); //하이라키에서 데이터컨트롤러를 찾아서 넣음
                if (instance == null) //찾았는데도 생성이 안되서 없을때.
                {
                    GameObject container = new GameObject("DataController");
                    instance = container.AddComponent<DataController>();
                }
            }

            return instance;
        } 
    }

    public void reset()
    {
        PlayerPrefs.DeleteAll();
    }
    
    public int Level //적 캐릭터의 레벨 _ 체력과 연관
    {
        get { return PlayerPrefs.GetInt("Level",1); }
        set { PlayerPrefs.SetInt("Level",value);}
    }
    public int Gold //골드
    {
        get { return PlayerPrefs.GetInt("Gold",0); }
        set { PlayerPrefs.SetInt("Gold",value);}
    }

    public int Enemy_Hp // 적 현재체력
    {
        get { return PlayerPrefs.GetInt("Enemy_Hp",10); }
        set { PlayerPrefs.SetInt("Enemy_Hp",value);}
    }
    public int Enemy_MaxHp // 적 최대체력
    {
        get { return PlayerPrefs.GetInt("Enemy_MaxHp",10); }
        set { PlayerPrefs.SetInt("Enemy_MaxHp",value);}
    }

    //====================캐릭터의 스텟창====================//
    public int Hero_Lv //레벨
    {
        get { return PlayerPrefs.GetInt("Hero_Lv",1); }
        set { PlayerPrefs.SetInt("Hero_Lv",value);}
    }
    public int Hero_MaxHp //체력 힘 비례 
    {
        get { return PlayerPrefs.GetInt("Hero_MaxHp",10); }
        set { PlayerPrefs.SetInt("Hero_MaxHp",value);}
    }
    public int Hero_hp //현재 체력 
    {
        get { return PlayerPrefs.GetInt("Hero_hp",10); }
        set { PlayerPrefs.SetInt("Hero_hp",value);}
    }
    
    public int Hero_Power//힘
    {
        get { return PlayerPrefs.GetInt("Hero_Power",1); }
        set { PlayerPrefs.SetInt("Hero_Power",value);}
    }
    
    public int Hero_Agility//민첩
    {
        get { return PlayerPrefs.GetInt("Hero_Agility",1); }
        set { PlayerPrefs.SetInt("Hero_Agility",value);}
    }
    
    public int Hero_Intellgence//지능
    {
        get { return PlayerPrefs.GetInt("Hero_Intellgence",1); }
        set { PlayerPrefs.SetInt("Hero_Intellgence",value);}
    }
    public int Damage //클릭당 데미지 
    {
        get { return PlayerPrefs.GetInt("Damage",1); }
        set { PlayerPrefs.SetInt("Damage", value); }
    }
    public int CriDamage //치명타 데미지배율
    {
        get { return PlayerPrefs.GetInt("CriDamage",2); }
        set { PlayerPrefs.SetInt("CriDamage", value); }
    }
    public int CriPercent //치명타확률
    {
        get { return PlayerPrefs.GetInt("CriPercent",1); }
        set { PlayerPrefs.SetInt("CriPercent", value); }
    }

    public int Hero_MaxMp
    {
        get { return PlayerPrefs.GetInt("Hero_MaxMp",10); }
        set { PlayerPrefs.SetInt("Hero_MaxMp", value); }
    }
    public int Hero_Mp
    {
        get { return PlayerPrefs.GetInt("Hero_Mp",10); }
        set { PlayerPrefs.SetInt("Hero_Mp", value); }
    }
    //====================캐릭터의 스텟창====================//
}

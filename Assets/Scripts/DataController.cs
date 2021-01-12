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
    
    public int Damage //클릭당 데미지 
    {
        get { return PlayerPrefs.GetInt("Damage",1); }
        set { PlayerPrefs.SetInt("Damage", value); }
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

}

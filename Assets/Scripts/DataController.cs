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

    
    public float Damage //클릭당 데미지 
    {
        get { return PlayerPrefs.GetFloat("Damage",1); }
        set { PlayerPrefs.SetFloat("Damage", value); }
    }

    public float Level //적 캐릭터의 레벨 _ 체력과 연관
    {
        get { return PlayerPrefs.GetFloat("Level",1); }
        set { PlayerPrefs.SetFloat("Level",value);}
    }
    public float Gold //골드
    {
        get { return PlayerPrefs.GetFloat("Gold",0); }
        set { PlayerPrefs.SetFloat("Gold",value);}
    }

    public float Enemy_Hp // 적 현재체력
    {
        get { return PlayerPrefs.GetFloat("Enemy_Hp"); }
        set { PlayerPrefs.SetFloat("Enemy_Hp",value);}
    }
    public float Enemy_MaxHp // 적 최대체력
    {
        get { return PlayerPrefs.GetFloat("Enemy_MaxHp"); }
        set { PlayerPrefs.SetFloat("Enemy_MaxHp",value);}
    }

}

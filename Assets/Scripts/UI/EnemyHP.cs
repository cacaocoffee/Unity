using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    private static EnemyHP instance;
    
    public static EnemyHP Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<EnemyHP>(); //하이라키에서 데이터컨트롤러를 찾아서 넣음
                if (instance == null) //찾았는데도 생성이 안되서 없을때.
                {
                    GameObject container = new GameObject("EnemyHP");
                    instance = container.AddComponent<EnemyHP>();
                }
            }

            return instance;
        } 
    }
    [SerializeField]
    private Slider EnmeyHpBar;
    [SerializeField]
    private Text EnemyHPtext;
    [SerializeField]
    private Slider HpBar;
    [SerializeField]
    private Text HPtext;
    [SerializeField]
    private Slider MPBar;
    [SerializeField]
    private Text Mptext;
    
    void Update()
    {
        EnmeyHpBar.value = Mathf.Lerp(EnmeyHpBar.value, (float)DataController.Instance.Enemy_Hp/(float) DataController.Instance.Enemy_MaxHp, Time.deltaTime * 10);//적체력표시바
        EnemyHPtext.text = (int)DataController.Instance.Enemy_Hp + "/" + (int)DataController.Instance.Enemy_MaxHp; //적 체력 표시 Text
        HpBar.value = Mathf.Lerp(HpBar.value, (float)DataController.Instance.Hero_hp/(float) DataController.Instance.Hero_MaxHp, Time.deltaTime * 10);//체력표시바
        HPtext.text = (int)DataController.Instance.Hero_hp + "/" + (int)DataController.Instance.Hero_MaxHp; //체력 표시 Text
        MPBar.value = Mathf.Lerp(MPBar.value, (float)DataController.Instance.Hero_Mp/(float) DataController.Instance.Hero_MaxMp, Time.deltaTime * 10);//체력표시바
        Mptext.text = (int)DataController.Instance.Hero_Mp + "/" + (int)DataController.Instance.Hero_MaxMp; //체력 표시 Text
    }


}

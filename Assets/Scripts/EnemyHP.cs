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
    void Update()
    {
        EnmeyHpBar.value = Mathf.Lerp(EnmeyHpBar.value, (float)DataController.Instance.Enemy_Hp/(float) DataController.Instance.Enemy_MaxHp, Time.deltaTime * 10);//적체력표시바
        EnemyHPtext.text = (int)DataController.Instance.Enemy_Hp + "/" + (int)DataController.Instance.Enemy_MaxHp; //적 체력 표시 Text
    }


}

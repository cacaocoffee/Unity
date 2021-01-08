using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class DamageEffectCreat : MonoBehaviour
{
    private static DamageEffectCreat instance;

    public static DamageEffectCreat Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<DamageEffectCreat>(); //하이라키에서 데이터컨트롤러를 찾아서 넣음
                if (instance == null) //찾았는데도 생성이 안되서 없을때.
                {
                    GameObject container = new GameObject("DamageEffectCreat");
                    instance = container.AddComponent<DamageEffectCreat>();
                }
            }

            return instance;
        } 
    }
    public GameObject hudDamageText;
    public Transform hudPos;
    public void DamageCreat()
    {
        GameObject hudText = Instantiate(hudDamageText);
        hudText.transform.position = hudPos.position;
        hudText.GetComponent<DamageEffect>().damage = DataController.Instance.Damage;
        
    }
}

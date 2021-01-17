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
                instance = FindObjectOfType<DamageEffectCreat>();
                if (instance == null) 
                {
                    GameObject container = new GameObject("DamageEffectCreat");
                    instance = container.AddComponent<DamageEffectCreat>();
                }
            }

            return instance;
        } 
    }
    public GameObject DamageText;
    public GameObject CriDamageText;
    public GameObject hub;
    public Transform hudPos;
    
    public void DamageCreat()
    {
        GameObject hudText = Instantiate(DamageText, hub.gameObject.transform); ;
        hudText.transform.position = hudPos.position;
    }
    public void CriticalDamageCreat()
    {
        GameObject hudText = Instantiate(CriDamageText, hub.gameObject.transform); ;
        hudText.transform.position = hudPos.position;
    }
    
}

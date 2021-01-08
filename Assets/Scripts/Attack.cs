using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Attack : MonoBehaviour
{

    public void OnClick()
    {

        if (DataController.Instance.Enemy_Hp  > 0)
        {
            DataController.Instance.Enemy_Hp -= DataController.Instance.Damage;
            DamageEffectCreat.Instance.DamageCreat();
        }
        else
        {
            Enemydie();
        }

    }
    
    public void Enemydie()
    {
        DataController.Instance.Level+=1;
        float a = 100 * Mathf.Pow(1.6f, DataController.Instance.Level);
        DataController.Instance.Enemy_MaxHp = (int) a;
        DataController.Instance.Enemy_Hp = DataController.Instance.Enemy_MaxHp;;
        DataController.Instance.Gold += DataController.Instance.Level * 10;
    }
}

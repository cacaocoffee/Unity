using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = System.Random;


public class Attack : MonoBehaviour
{
    public Animator animator;
    public void OnClick()
    {
        Random rand = new Random();
        int a = rand.Next(1,100);
        if (a <= DataController.Instance.CriPercent)
        {
            CriticalAttack();//모션 수정 필요함
        }
        else
        {
            Attack_Enemy();
        }


    }
    public void Enemydie()
    {
        DataController.Instance.Level+=1;
        float a = 10 * Mathf.Pow(1.6f, DataController.Instance.Level);
        DataController.Instance.Enemy_MaxHp = (int) a;
        DataController.Instance.Enemy_Hp = DataController.Instance.Enemy_MaxHp;;
        DataController.Instance.Gold += DataController.Instance.Level * 10;
    }
    public void Attack_Enemy()
    {
        animator.SetTrigger("Attack");
        if (DataController.Instance.Enemy_Hp  > 0)
        {
            DataController.Instance.Enemy_Hp -= DataController.Instance.Damage;
            DamageEffectCreat.Instance.DamageCreat();
            if (DataController.Instance.Enemy_Hp <= 0)
            {
                Enemydie();
            }
        }
    }
    public void CriticalAttack()
    {
        animator.SetTrigger("CriticalAttack");
        if (DataController.Instance.Enemy_Hp  > 0)
        {
            DataController.Instance.Enemy_Hp -= DataController.Instance.Damage*DataController.Instance.CriDamage;
            DamageEffectCreat.Instance.CriticalDamageCreat();
            if (DataController.Instance.Enemy_Hp <= 0)
            {
                Enemydie();
            }
        }
    }
}

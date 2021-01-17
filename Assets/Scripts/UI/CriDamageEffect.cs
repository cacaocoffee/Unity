using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CriDamageEffect : MonoBehaviour
{

    public float MoveSpeed; //텍스트 이동속도
    public float disSpeed; //투명해지는 속도
    public float destroyTime; //사라지는 시간
    public Text Damagetext; // 데미지 플로팅 텍스트
    public Color a; //원래 텍스트 색 
    public int damage;

    private void Start()
    {
        a = Damagetext.color;
        damage = DataController.Instance.Damage* DataController.Instance.CriDamage;
        Damagetext.text = damage.ToString();
        Invoke("DestroyObject", destroyTime);
    }

    private void Update()
    {
        transform.Translate(new Vector3(0, MoveSpeed * Time.deltaTime, 0));//
        a.a = Mathf.Lerp(a.a, 0f,Time.deltaTime * disSpeed); // 텍스트 투명해지기
        Damagetext.color = a;
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}

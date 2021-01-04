using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamageEffect : MonoBehaviour
{

    public float MoveSpeed; //텍스트 이동속도
    public float disSpeed; //투명해지는 속도
    public float destroyTime;
    private TextMeshPro Damagetext; // 데미지 플로팅 텍스트
    private Color alpha; //원래 텍스트 색
 
    private void Start()
    {
        Damagetext = GetComponent<TextMeshPro>();
        //alpha = Damagetext.color;
        Invoke("DestroyObject", destroyTime);
    }

    private void Update()
    {
        transform.Translate(new Vector3(0, MoveSpeed * Time.deltaTime, 0));//
        //alpha.a = Mathf.Lerp(alpha.a, 0f,Time.deltaTime * disSpeed); // 텍스트 투명해지기
        //Damagetext.color = alpha;
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}

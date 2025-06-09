using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetHP : MonoBehaviour
{
    // 시스템 기획 연습한다고 생각하시고
    [SerializeField] TextMeshProUGUI Txt_HP;

    public Image Img_HPbar;

    public int MaxHP;
    float nowHP;
    // 최소체력은 0

    public int Damage;
    public int HealPoint;

    void Awake()
    {
        nowHP = MaxHP;
    }

    public void OnClickDamage() // 데미지
    {
        nowHP -= Damage; // 데미지를 받는다.
        if (nowHP < 0) // 그런데 0보다 낮아지면 0으로 고정한다.
        {
            nowHP = 0;
        }
        RefreshUI();
    }

    public void OnClickHeal() // 회복
    {
        nowHP += HealPoint;
        if (nowHP > MaxHP)
        {
            nowHP = MaxHP;
        }
        RefreshUI();
    }

    void RefreshUI()
    {
        Img_HPbar.fillAmount = nowHP / MaxHP;
        Txt_HP.text = $"{nowHP} / {MaxHP}";
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetHP : MonoBehaviour
{
    // �ý��� ��ȹ �����Ѵٰ� �����Ͻð�
    [SerializeField] TextMeshProUGUI Txt_HP;

    public Image Img_HPbar;

    public int MaxHP;
    float nowHP;
    // �ּ�ü���� 0

    public int Damage;
    public int HealPoint;

    void Awake()
    {
        nowHP = MaxHP;
    }

    public void OnClickDamage() // ������
    {
        nowHP -= Damage; // �������� �޴´�.
        if (nowHP < 0) // �׷��� 0���� �������� 0���� �����Ѵ�.
        {
            nowHP = 0;
        }
        RefreshUI();
    }

    public void OnClickHeal() // ȸ��
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

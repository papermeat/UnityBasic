using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Button Btn_button;
    public TextMeshProUGUI infoText;
    public string text;

    public string Name = "ȫ�浿";
    int age = 99;
    string MBTI = "INTJ";

    int count = 0;

    void Awake()
    {
        UnityEngine.Debug.Log($"���� �̸��� {Name}�Դϴ�.");

        // Btn_button.onClick.AddListener(OnButtonClick);
    }

    public void OnButtonClick()
    {
        // infoText.text = string.Empty;
        // infoText.text = "";
        infoText.text = "���� �̸���" + name + "�Դϴ�.\n";

        infoText.text += "���� �̸���" + name + "�Դϴ�.\n";
        infoText.text += $"���� ���̴� {age} �Դϴ�. \n";
        infoText.text += $"���� MBTI�� {MBTI} �Դϴ�";
    }
}




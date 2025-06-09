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

    public string Name = "홍길동";
    int age = 99;
    string MBTI = "INTJ";

    int count = 0;

    void Awake()
    {
        UnityEngine.Debug.Log($"나의 이름은 {Name}입니다.");

        // Btn_button.onClick.AddListener(OnButtonClick);
    }

    public void OnButtonClick()
    {
        // infoText.text = string.Empty;
        // infoText.text = "";
        infoText.text = "저의 이름은" + name + "입니다.\n";

        infoText.text += "저의 이름은" + name + "입니다.\n";
        infoText.text += $"저의 나이는 {age} 입니다. \n";
        infoText.text += $"저의 MBTI는 {MBTI} 입니다";
    }
}




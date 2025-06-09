using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetTextBox : MonoBehaviour
{
    public TextMeshProUGUI Txt_Text; // 텍스트를 넣을 곳
    [SerializeField] TMP_InputField Input_Text; // 어디 텍스트를 가지고 올지

    public void OnClickButton()
    {
        Txt_Text.text = Input_Text.text;
    }
}

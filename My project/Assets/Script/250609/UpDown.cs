using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpDown : MonoBehaviour
{
    
    public TMP_InputField userInputField;   // 플레이어의 숫자 입력 필드
    public Button submitButton;         // 입력 버튼
    public TextMeshProUGUI resultLogText;          // 결과 로그를 표시할 텍스트
    public TextMeshProUGUI tryCountText;           // 시도 횟수를 표시할 텍스트

    private int randomNumber;           // 게임 시작 시 생성될 랜덤 숫자 (정답)
    private int tryCount;               // 플레이어의 시도 횟수
    private List<string> resultLog;     // 결과 기록을 저장할 리스트

    
    void Start()
    {
        InitializeGame();
    }

    // 게임을 초기화하는 함수
    void InitializeGame()
    {
        randomNumber = Random.Range(1, 101);
        tryCount = 0;
        resultLog = new List<string>();

        // UI 초기화
        resultLogText.text = "1부터 100 사이의 숫자를 맞춰보세요!";
        tryCountText.text = "시도 횟수: 0";
        userInputField.text = ""; // 입력 필드 비우기

      
        userInputField.interactable = true;
        submitButton.interactable = true;

        
        Debug.Log("정답: " + randomNumber);
    }

   
    public void CheckGuess()
    {
       
        string userInput = userInputField.text;

        int guess;
       
        if (!int.TryParse(userInput, out guess))
        {
            
            AddLog("숫자만 입력해주세요!");
            userInputField.text = "";
            return;
        }

       
        tryCount++;
        tryCountText.text = "시도 횟수: " + tryCount;

        
        if (guess > randomNumber)
        {
            AddLog($"입력: {guess}, 결과: 다운(Down)!");
        }
        else if (guess < randomNumber)
        {
            AddLog($"입력: {guess}, 결과: 업(Up)!");
        }
        else // 정답을 맞춘 경우
        {
            AddLog($"입력: {guess}, 결과: 정답!");
            tryCountText.text = $"🎉 총 {tryCount}번 만에 맞췄습니다! 🎉";

           
            userInputField.interactable = false;
            submitButton.interactable = false;
        }

        
        userInputField.text = "";
        userInputField.ActivateInputField();
    }

    
    private void AddLog(string logMessage)
    {
        resultLog.Insert(0, logMessage);

        resultLogText.text = string.Join("\n", resultLog);
    }
}
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    private int count = 0;

    public void Gacha10()
    {
        for (int i = 0; i < 10; i++)
        {
            count++;

            if (count >= 8)
            {
                Debug.Log($"[{i + 1}번째] 확정으로 '각청'을 뽑았다!");
                count = 0;
                continue;
            }

            int randomValue = Random.Range(1, 101);
            Debug.Log($"[{i + 1}번째] 랜덤 값: {randomValue}");

            int group = 0;
            if (randomValue <= 10) group = 1;
            else if (randomValue <= 30) group = 2;
            else if (randomValue <= 60) group = 3;
            else if (randomValue <= 80) group = 4;
            else group = 5;

            switch (group)
            {
                case 1:
                    Debug.Log($"[{i + 1}번째] '각청'을 뽑았다!");
                    break;
                case 2:
                    Debug.Log($"[{i + 1}번째] '모나'를 뽑았다!");
                    break;
                case 3:
                    Debug.Log($"[{i + 1}번째] '세이버'를 뽑았다!");
                    break;
                case 4:
                    Debug.Log($"[{i + 1}번째] '반디'를 뽑았다!, 정실은 역시 반디");
                    break;
                default:
                    Debug.Log($"[{i + 1}번째] '치치'를 뽑아버렸다!");
                    break;
            }
        }
    }
}
/*{
    private int count = 0;

    public void Gacha10()

    {
        for (int i = 0; i < 10; i++)
        {
            count++;

            if (count >= 8)
        {
            Debug.Log("확정으로 '각청'을 뽑았다!");
            count = 0;
            return;
        }

        int randomValue = Random.Range(1, 101); // 1 이상 101 미만의 랜덤한 값을 
        Debug.Log($"랜덤한 값은: {randomValue}입니다.");

        if (randomValue <= 10) // 1 ~ 10
        {
            Debug.Log("'각청'을 뽑았다!");
        }
        else if (randomValue <= 30) // 11 ~ 30
        {
            Debug.Log("'모나'를 뽑았다!");
        }
        else if (randomValue <= 60) // 31 ~ 60
        {
            Debug.Log("'세이버'를 뽑았다!");
        }
        else if (randomValue <= 80) // 61 ~ 80
        {
            Debug.Log("'반디'를 뽑았다!, 정실은 역시 반디");
        }
        else
        {
            Debug.Log("'치치'를 뽑아버렸다!");
        }

        int group = 0;
        if (randomValue <= 10) group = 1;
        else if (randomValue <= 30) group = 2;
        else if (randomValue <= 60) group = 3;
        else if (randomValue <= 80) group = 4;
        else group = 5;

        switch (group)
        {
            case 1:
                Debug.Log($"[{i + 1}번째] '각청'을 뽑았다!");
                break;
            case 2:
                Debug.Log($"[{i + 1}번째] '모나'를 뽑았다!");
                break;
            case 3:
                Debug.Log($"[{i + 1}번째] '세이버'를 뽑았다!");
                break;
            case 4:
                Debug.Log($"[{i + 1}번째] '반디'를 뽑았다!, 정실은 역시 반디");
                break;
            default:
                Debug.Log($"[{i + 1}번째] '치치'를 뽑아버렸다!");
                break;
        }
    }
}
}
*/
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
                Debug.Log($"[{i + 1}��°] Ȯ������ '��û'�� �̾Ҵ�!");
                count = 0;
                continue;
            }

            int randomValue = Random.Range(1, 101);
            Debug.Log($"[{i + 1}��°] ���� ��: {randomValue}");

            int group = 0;
            if (randomValue <= 10) group = 1;
            else if (randomValue <= 30) group = 2;
            else if (randomValue <= 60) group = 3;
            else if (randomValue <= 80) group = 4;
            else group = 5;

            switch (group)
            {
                case 1:
                    Debug.Log($"[{i + 1}��°] '��û'�� �̾Ҵ�!");
                    break;
                case 2:
                    Debug.Log($"[{i + 1}��°] '��'�� �̾Ҵ�!");
                    break;
                case 3:
                    Debug.Log($"[{i + 1}��°] '���̹�'�� �̾Ҵ�!");
                    break;
                case 4:
                    Debug.Log($"[{i + 1}��°] '�ݵ�'�� �̾Ҵ�!, ������ ���� �ݵ�");
                    break;
                default:
                    Debug.Log($"[{i + 1}��°] 'ġġ'�� �̾ƹ��ȴ�!");
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
            Debug.Log("Ȯ������ '��û'�� �̾Ҵ�!");
            count = 0;
            return;
        }

        int randomValue = Random.Range(1, 101); // 1 �̻� 101 �̸��� ������ ���� 
        Debug.Log($"������ ����: {randomValue}�Դϴ�.");

        if (randomValue <= 10) // 1 ~ 10
        {
            Debug.Log("'��û'�� �̾Ҵ�!");
        }
        else if (randomValue <= 30) // 11 ~ 30
        {
            Debug.Log("'��'�� �̾Ҵ�!");
        }
        else if (randomValue <= 60) // 31 ~ 60
        {
            Debug.Log("'���̹�'�� �̾Ҵ�!");
        }
        else if (randomValue <= 80) // 61 ~ 80
        {
            Debug.Log("'�ݵ�'�� �̾Ҵ�!, ������ ���� �ݵ�");
        }
        else
        {
            Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
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
                Debug.Log($"[{i + 1}��°] '��û'�� �̾Ҵ�!");
                break;
            case 2:
                Debug.Log($"[{i + 1}��°] '��'�� �̾Ҵ�!");
                break;
            case 3:
                Debug.Log($"[{i + 1}��°] '���̹�'�� �̾Ҵ�!");
                break;
            case 4:
                Debug.Log($"[{i + 1}��°] '�ݵ�'�� �̾Ҵ�!, ������ ���� �ݵ�");
                break;
            default:
                Debug.Log($"[{i + 1}��°] 'ġġ'�� �̾ƹ��ȴ�!");
                break;
        }
    }
}
}
*/
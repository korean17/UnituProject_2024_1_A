using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenChange : MonoBehaviour
{
    public bool isPunch = false;                //���������� �Է��� �����°��� �������� Flag ��



    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!isPunch)         //��ġ üũ�� false �� ���
            {
                isPunch = true;             //��ġ üũ�� True ������༭ ��� �Է��� ������ ������ ���� ���� ���ϰ� ���´�.
                transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1).OnComplete(EndPuch);    //��Ī ȿ���� ���� ������ EndPucj �Լ�ȣ��
            }
        }
    }

    void EndPuch()
    {
        isPunch = false;
    }
}

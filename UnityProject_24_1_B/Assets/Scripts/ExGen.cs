using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExGen : MonoBehaviour
{
    public GameObject item;         //게임 오브젝트 아이템 정의
    public float checkTime;         //시간값 체크 정의

    // Update is called once per frame
    void Update()
    {
        checkTime += Time.deltaTime;
        if(checkTime > 2.0f)
        {
            GameObject Temp = Instantiate(item);
            Temp.transform.position += new Vector3(0.0f, Random.Range(0.4), 0.0f);
            Destroy(Temp, 20.0f);
            checkTime = 0.0f;
        }
        
    }
}

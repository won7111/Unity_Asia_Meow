
using UnityEngine;
using System.Collections; // 引用系統. 集合 包含偕同程序

public class Learncoroutine : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Test());  //啟動偕同程序(偕同程序))
    }


    //定義偕同程序
    //傳回類型 IEnmerator
    private IEnumerator Test()
    {
        print("這是第一段文字訊息");
        yield return new WaitForSeconds(1);
        print("這是第二段文字訊息");

    }
}

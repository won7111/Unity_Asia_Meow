
using UnityEngine;
using System.Collections; // �ޥΨt��. ���X �]�t���P�{��

public class Learncoroutine : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Test());  //�Ұʰ��P�{��(���P�{��))
    }


    //�w�q���P�{��
    //�Ǧ^���� IEnmerator
    private IEnumerator Test()
    {
        print("�o�O�Ĥ@�q��r�T��");
        yield return new WaitForSeconds(1);
        print("�o�O�ĤG�q��r�T��");

    }
}

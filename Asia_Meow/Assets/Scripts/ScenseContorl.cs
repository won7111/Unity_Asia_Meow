
using UnityEngine;
using UnityEngine.SceneManagement;  //u�ޥγ����޲zapi

public class ScenseContorl : MonoBehaviour
{
    public void LoadScense(string nameScense)
    {
        SceneManager.LoadScene(nameScense);
    }

    public void Quit()
    {
        Application.Quit();
            print("�����C��");
    }
}

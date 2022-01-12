
using UnityEngine;
using UnityEngine.SceneManagement;  //u引用場景管理api

public class ScenseContorl : MonoBehaviour
{
    public void LoadScense(string nameScense)
    {
        SceneManager.LoadScene(nameScense);
    }

    public void Quit()
    {
        Application.Quit();
            print("關閉遊戲");
    }
}

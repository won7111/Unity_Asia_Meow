
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


/// <summary>
/// 對話系統
/// 將需要輸出的文字利用打字系統呈現
/// </summary>
public class DialogueSystem : MonoBehaviour
{
    [Header("對話間隔"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("畫布對話系統")]
    public GameObject goDialogue;
    [Header("對話")]
    public Text textContent;


    private void Start()
    {
        StartCoroutine(TypeEffect());
    }

    private IEnumerator TypeEffect()
    {
        string test = "哈摟喵喵~";

        textContent.text = "";  //清除上次對話
                goDialogue.SetActive(true); //顯示對話物件

        for (int i = 0; i < test.Length; i++)
        {
            textContent.text += test[i];   //疊加對話內容文字介面
            yield return new WaitForSeconds (interval);
        }
    }
}

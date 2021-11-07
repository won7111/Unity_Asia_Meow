using UnityEngine;       //引用 unity 引擎命名空間 : 可以使用此空間 API

// 單行註解
//class 類別:一個物件的藍圖
//語法: 類別 類別名稱 { 類別內容 ( 類別成員 ) }
// 此類別要在Unity 內使用必須繼承 MonBehaviour
public class Cat : MonoBehaviour
{
    #region 欄位語法及四大常用類型
    //欄位 Field :保存各種類型的資料
    //語法: 修飾詞 資料類型 欄位名稱 指定 預設值 結束符號
    // 四大常用類型:
    //整  數: 儲存沒有小數點的正負整數 - int
    //浮點數: 儲存有帶小數點的正負整數 - float
    //字  串: 儲存文字資訊           - string
    //布林值: 是與否 ture or false   - bool
    // 修飾值
    // 私人: 其他類別不能存取 不顯示 (預設值) private 
    // 公開: 其他類別可以存取 顯示 public
    // 欄位屬性 Attritube
    // 語法 : [屬性名稱(值)]
    // 1.標題 Header (字串)
    // 2.提示 Tooltip (字串)
    // 3.範圍 Range (最小值 最大值)
    public int cc = 1000;
    [Range(1, 10)]
    public float weight = 3.5f;
    [Tooltip("這是貓貓的名稱")]
    public string brand = "喵喵";
    [Header("是否有天窗")]
    public bool hasSkywindow = false;
    #endregion

    #region Unity內資料類型
    // 顏色 向量(座標) 按鍵 遊戲物件 元件
    public Color color;
    public Color colorRed = Color.red;
    public Color colorYellow = Color.yellow;
    public Color colorCustom1 = new Color(0, 0, 1);
    public Color colorCustom2 = new Color(1, 0, 1, 0.5f);
    //向量 2-4 Vector
    public Vector2 v2;
    public Vector2 v2one = Vector2.one;
    public Vector2 v2right = Vector2.right;
    public Vector2 v2custom = new Vector2(1, 2);
    //按鍵 Keycode
    public KeyCode keycode;
    public KeyCode keycodeMouseLeft = KeyCode.A;
    public KeyCode keycodeMouseRight = KeyCode.D;
    public KeyCode keycodeJump = KeyCode.Space;
    // 遊戲物件 Gameobject
    public GameObject goCamera;
    public GameObject goCar;
    // 元件
    public Transform tranCamera;
    public Camera cam;
    public SpriteRenderer spr;
    #endregion

    #region 事件 : 程式的入口
    //開始事件 : 遊戲播放時執行一次
    private void Start()
    {
        //呼叫方法 : 方法名稱();
        Test();
        Run5();
        Run10();
        Run(15); //呼叫時填入稱為 : 引數
        float w99 = ConverWeight(9.9f);
        print("9.9 轉換 :" + w99);

        print("重量轉換 :" + ConverWeight(weight));
    }
    #endregion

    #region 方法與語法
    //方法 : 保存程式內容的區塊 演算法 陳述式
    //語法 : 修飾詞 傳回類型 方法名稱 (參數1 參數2 直到無限) {程式內容}
    //void 無傳回 : 使用方法時不會有傳回資料
    private void Test()
    {
        //輸出(訊息) - 將訊息輸出至unity 儀錶板 Console
        print("哈摟，我是喵喵:)");
    }

    private void Run5()
    {
        print("跑步速度 : " + 5);
        print("音效 : 喵喵喵");
    }
    private void Run10()
    {
        print("跑步速度 : " + 10);
        print("音效 : 喵喵喵");
    }

    //參數語法 : 資料類型 參數名稱
    private void Run(int speed)
    {
        print("跑步速度 : " + speed);
        print("音效 : 喵喵喵");
    }

    private float ConverWeight(float setWeight)
    {
        return setWeight * 50;
    }
    #endregion
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 建立專案內的選單(menuName = "選單名稱") 資料夾/子資料
[CreateAssetMenu(menuName = "meow/對話資料")]

/// <summary>
/// 對話資料
/// 保存NPC 要跟玩家說的對話內容
/// </summary>
/// ScriptableObject 腳本化物件 : 交程式資料儲存至 Project內的物件
public class DataDialogue : ScriptableObject
{

    // Text Area (最小行數，最大行數) - 僅限 string
    [Header("對話內容"), TextArea(3, 5)]
    public string[] dialogues;
}
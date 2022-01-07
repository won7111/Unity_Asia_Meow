
using UnityEngine;
/// <summary>
/// 控制器 : 2D橫向卷軸版本
/// </summary>

public class Controller2D : MonoBehaviour
{
    #region 欄位 : 公開
    [Header("移動速度"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("跳躍高度"), Range(0, 15000)]
    public float jump = 300;

    #endregion

}


using UnityEngine;
/// <summary>
/// ��� : 2D��V���b����
/// </summary>

public class Controller2D : MonoBehaviour
{
    #region ��� : ���}
    [Header("���ʳt��"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("���D����"), Range(0, 15000)]
    public float jump = 300;

    #endregion

}

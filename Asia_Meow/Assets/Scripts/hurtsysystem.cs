using UnityEngine;
using UnityEngine.UI;  //引用介面API
using UnityEngine.Events;

/// <summary>
/// 受傷系統
/// </summary>
public class hurtsysystem : MonoBehaviour
{
    [Header("血條")]
    public Image imgHpBar;
    [Header("血量")]
    public float hp = 100;
    [Header("動畫參數")]
    public string parameterDead = "觸發死亡";
    [Header("死亡事件")]
    public UnityEvent onDead;

    private float hpMax;
        private Animator ani;

    //喚醒事件 : 在start 之前執行一次
    private void Awake()
    {
        ani = GetComponent<Animator>();
        hpMax = hp;

    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage">接收到的傷害</param>
    public void Hurt(float damage)
    {
        hp -= damage;
        imgHpBar.fillAmount = hp / hpMax;
        if (hp <= 0) Dead();
    }

    public void Dead()
    {
        ani.SetTrigger(parameterDead);
        onDead.Invoke();
    }

}

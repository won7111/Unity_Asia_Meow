using UnityEngine;
using UnityEngine.UI;  //�ޥΤ���API
using UnityEngine.Events;

/// <summary>
/// ���˨t��
/// </summary>
public class hurtsysystem : MonoBehaviour
{
    [Header("���")]
    public Image imgHpBar;
    [Header("��q")]
    public float hp = 100;
    [Header("�ʵe�Ѽ�")]
    public string parameterDead = "Ĳ�o���`";
    [Header("���`�ƥ�")]
    public UnityEvent onDead;

    private float hpMax;
        private Animator ani;

    //����ƥ� : �bstart ���e����@��
    private void Awake()
    {
        ani = GetComponent<Animator>();
        hpMax = hp;

    }

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="damage">�����쪺�ˮ`</param>
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

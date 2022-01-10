using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region
    [Header("�ˬd�l�ܰϰ�j�p�P�첾")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3TrackOffest;
    [Header("���ʳt��")]
    public float speed = 1.5f;
    [Header("�ؼйϼh")]
    public LayerMask layerTarget;
    [Header("�ʵe�Ѽ�")]
    public string parameterwalk = "�}������";
    public string parameterAttack = "Ĳ�o����";
    [Header("���ۥؼЪ���")]
    public Transform target;
    [Header("�����Z��"), Range(0, 5)]
    public float attackDistance = 1.3f;
    [Header("�����N�o�ɶ�"), Range(0, 10)]
    public float attackCD = 2.8f;


    private float angle = 0;
    private Rigidbody2D rig;
    private Animator ani;
    private float timerAttack;

    #endregion



    #region �ƥ�
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }


    private void OnDrawGizmos()
    {
        // ���w�ϥ��C��
        Gizmos.color = new Color(1, 0, 0, 0.3f);
        // ø�s�ߤ���(���ߡA�ؤo)
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3TrackOffest), v3TrackSize);
    }
    private void Update()
    {
        CheckTargertInArea();
    }
    #endregion

    #region ��k
    /// <summary>
    /// �ˬd�ؼЬO�_�b�ϰ줺
    /// </summary>
    private void CheckTargertInArea()
    {

        //2D���z.�л\����(���ߡA�ؤo�A����)
        Collider2D hit = Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3TrackOffest), v3TrackSize, 0, layerTarget);

        if (hit) Move();


    }
    /// <summary>
    /// ����
    /// </summary>
    private void Move()
    {
        //�T��B��l�y�k : ���L�� ? ���L�� �� ture : ���L�� �� false ;
        //�p�G �ؼЪ� x �p�� �ĤH�� x �N�N��b����  ����0
        //�p�G �ؼЪ� x �j�� �ĤH�� x �N�N��b�k��  ����180

        if (target.position.x > transform.position.x)
        {
            //�k�� angle = 180
        }
        else if (target.position.x < transform.position.x)
        {
            //���� angle =0
        }

        //�T���B��l�y�k : ���L�� ? ���L�Ȭ� ture : ���L�Ȭ� false ;
        angle = target.position.x > transform.position.x ? 180 : 0;
        //�ܧ�,�کԨ���= Y* ����
        transform.eulerAngles = Vector3.up * angle;

        rig.velocity = transform.TransformDirection(new Vector2(-speed, rig.velocity.y));
        ani.SetBool(parameterwalk, true);

        // �Z�� = �T���V�q.�Z��(A�I�AB�I)
        float distance = Vector3.Distance(target.position, transform.position);
        print("�P�ؼЪ��Z�� : " + distance);

        if (distance <= attackDistance)    //�p�G �Z�� �p�󵥩� �����Z��
        {
            rig.velocity = Vector3.zero;   //����
            Attack();
        }
    }
    /// <summary>
    /// ����
    /// </summary>
    private void Attack()
    {
        if (timerAttack < attackCD)         //�p�G�p�ɾ� �p�� �N�o�ɶ�
        {
            timerAttack += Time.deltaTime;  //�ɶ��֥[ Time.deltaTime �@�V���ɶ�
        }
        else
        {

            ani.SetTrigger(parameterAttack); //�p�G�p�ɾ� �j�󵥩� �N�o�ɶ� �N ����
            timerAttack = 0;                 // �p�ɾ� �k�s
        }


    }

    #endregion
}


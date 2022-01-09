
using UnityEngine;

/// <summary>
/// NPC�欰
/// �����ؼжi�J�I����
/// ��ܹ�ܨt��
/// </summary>

public class NPC : MonoBehaviour
{
    [Header("��ܸ��")]
    public DataDialogue DataDialogue;
    [Header("��ܨt��")]
    public DialogueSystem dialogueSystem;
    [Header("Ĳ�o��ܪ���H")]
    public string target = "�߿�";


    // Ĳ�o�}�l�ƥ�
   //1.��Ӫ��󳣭n�� Collider 2D
   //2.��ӳ����@��   Rigidbody 2D
   //3.��ӭn���@�Ӥ� Is Trigger
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == target)
        {
            dialogueSystem.StartDialogue(DataDialogue.dialogues);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == target)
        {
            dialogueSystem.StopDialogue();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �إ߱M�פ������(menuName = "���W��") ��Ƨ�/�l���
[CreateAssetMenu(menuName = "meow/��ܸ��")]

/// <summary>
/// ��ܸ��
/// �O�sNPC �n�򪱮a������ܤ��e
/// </summary>
/// ScriptableObject �}���ƪ��� : ��{������x�s�� Project��������
public class DataDialogue : ScriptableObject
{

    // Text Area (�̤p��ơA�̤j���) - �ȭ� string
    [Header("��ܤ��e"), TextArea(3, 5)]
    public string[] dialogues;
}
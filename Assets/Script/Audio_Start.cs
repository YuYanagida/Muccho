using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Audio_Start : MonoBehaviour
{
    [SerializeField] AudioClip AttackSE = null;//�Đ������鉹�y�ł���AudioClip�Ƃ̘A�g�̂��߂ɓ���
    AudioSource Audio;//���y���Đ������邽�߂�AudioSource�R���|�[�l���g��Play���\�b�h���g�����߂ɒ�`����
    //�U������SE���Đ������郁�\�b�h
    public void PlayAttackSE()
    {
        Audio = GetComponent<AudioSource>();//���̃X�N���v�g���A�^�b�`���ꂽ�I�u�W�F�N�g�ɕt�^����Ă���AudioSource�R���|�[�l���g��F��������
        Audio.PlayOneShot(AttackSE);//�ϐ�AttackSE���\�����y���Đ�����
    }
}
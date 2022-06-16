using UnityEngine;
using System;
using System.Collections;

[RequireComponent(typeof(Animator))]

public class IK : MonoBehaviour
{

    protected Animator animator;

    public bool ikActive = false;
    public Transform rightFootObj = null;
    public Transform leftFootObj = null;
    public Transform rightHandObj = null;
    public Transform leftHandObj = null;
    public Transform lookObj = null;
    public Transform waist = null;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // IK ���v�Z���邽�߂̃R�[���o�b�N
    void OnAnimatorIK()
    {
        if (animator)
        {

            // IK ���L���Ȃ�΁A�ʒu�Ɖ�]�𒼐ڐݒ肵�܂�
            if (ikActive)
            {

                // ���łɎw�肳��Ă���ꍇ�́A�����̃^�[�Q�b�g�ʒu��ݒ肵�܂�
                if (lookObj != null)
                {
                    animator.SetLookAtWeight(1);
                    animator.SetLookAtPosition(lookObj.position);
                }

                // �w�肳��Ă���ꍇ�́A�E��̃^�[�Q�b�g�ʒu�Ɖ�]��ݒ肵�܂�
                if (rightHandObj != null)
                {
                    animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
                    animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
                    animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandObj.position);
                    animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandObj.rotation);
                }

                // �w�肳��Ă���ꍇ�́A����̃^�[�Q�b�g�ʒu�Ɖ�]��ݒ肵�܂�
                if (leftHandObj != null)
                {
                    animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
                    animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
                    animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHandObj.position);
                    animator.SetIKRotation(AvatarIKGoal.LeftHand, leftHandObj.rotation);
                }

                // �w�肳��Ă���ꍇ�́A�E���̃^�[�Q�b�g�ʒu�Ɖ�]��ݒ肵�܂�
                if (rightFootObj != null)
                {
                    animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, 1);
                    animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, 1);
                    animator.SetIKPosition(AvatarIKGoal.RightFoot, rightFootObj.position);
                    animator.SetIKRotation(AvatarIKGoal.RightFoot, rightFootObj.rotation);
                }

                // �w�肳��Ă���ꍇ�́A�����̃^�[�Q�b�g�ʒu�Ɖ�]��ݒ肵�܂�
                if (leftFootObj != null)
                {
                    animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 1);
                    animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, 1);
                    animator.SetIKPosition(AvatarIKGoal.LeftFoot, leftFootObj.position);
                    animator.SetIKRotation(AvatarIKGoal.LeftFoot, leftFootObj.rotation);
                }

                //��
                if (waist != null)
                {
                    animator.bodyPosition = waist.position;
                    animator.bodyRotation = waist.rotation;
                }

            }

            //IK ���L���łȂ���΁A��Ɠ��̈ʒu�Ɖ�]�����̈ʒu�ɖ߂��܂�
            else
            {
                animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, 0);
                animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, 0);
                animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 0);
                animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, 0);
                animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 0);
                animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 0);
                animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 0);
                animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 0);
                animator.SetLookAtWeight(0);
            }
        }
    }
}

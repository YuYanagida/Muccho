using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Audio_Start : MonoBehaviour
{
    [SerializeField] AudioClip AttackSE = null;//再生させる音楽であるAudioClipとの連携のために導入
    AudioSource Audio;//音楽を再生させるためにAudioSourceコンポーネントのPlayメソッドを使うために定義する
    //攻撃時のSEを再生させるメソッド
    public void PlayAttackSE()
    {
        Audio = GetComponent<AudioSource>();//このスクリプトがアタッチされたオブジェクトに付与されているAudioSourceコンポーネントを認識させる
        Audio.PlayOneShot(AttackSE);//変数AttackSEが表す音楽を再生する
    }
}
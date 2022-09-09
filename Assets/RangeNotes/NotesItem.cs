using UnityEngine;
using UnityEngine.Events;
using SeikaGameKit.Timeline;
using System.Collections;
using System.Collections.Generic;

public class NotesItem : PlayingEventItem
{
    #region DEFINITION
    #endregion

    #region VARIABLE
    public string _targetTagName1 = "Player";
    public GameObject displayObject;
    public GameObject PoseObject;
    public GameObject AvaterObject;
    public GameObject[] KakegoeObject;
    public GameObject[] FeeverObject;
    public GameObject[] MissObject;
    public ParticleSystem activationEffect;
    public ParticleSystem hitEffect;
    public AudioSource se;
    public AudioClip clip;
    public bool SEplayed = false;
    public bool Mojibool = false;
    public AudioClip[] SEs;
    public AudioClip[] SEsm;
    public AudioClip[] SEsf;
    public int scorecheck;

    [Space]
    public UnityEvent<int> hitCallback;
    #endregion

    #region UNITY_EVENT
    /*
    void OnTriggerEnter(Collider other)
    {
        if (isPlaying && other.CompareTag(_targetTagName1))
        {
            //displayObject.SetActive(false);
            hitCallback?.Invoke(0);

            Debug.Log($"{currentTime} {normalizedTime}");

            if (hitEffect != null)
            {
                hitEffect.Play(true);
            }

            se.PlayOneShot(clip);

        }
    }
    */

    void OnTriggerStay(Collider other)
    {

        //ScoreCounter.AddScore(12);

        if (isPlaying && other.CompareTag(_targetTagName1))
        {
            //displayObject.SetActive(false);
           // hitCallback?.Invoke(0);

            Debug.Log($"{currentTime} {normalizedTime}");

            PoseObject.SetActive(true);

            AvaterObject.SetActive(false);


            if (Mojibool == false)
            {
                Instantiate(KakegoeObject[Random.Range(0, 9)], new Vector3(7.5f, 3.0f, 6), Quaternion.identity);

                Mojibool = true;

            }
            //Instantiate(KakegoeObject[Random.Range(0, 9)], new Vector3(7.5f, 3.5f, 6), Quaternion.identity);

            // KakegoeObject.SetActive(true);

            OVRInput.SetControllerVibration(frequency: 0.1f, amplitude: 0.1f);

            //指定された時間待つ
            //yield return new WaitForSeconds(2);

            //コントローラーの振動を止める
            //OVRInput.SetControllerVibration(0, 0);


            if (hitEffect != null)
            {
                hitEffect.Play(true);

               // hitEffect.Stop(true, ParticleSystemStopBehavior.StopEmitting);
            }

            /*if(SEplayed == false)
            {
                AudioClip _se = SEs[Random.Range(0,2)];
                
                se.PlayOneShot(_se);

                SEplayed = true;
            }*/

            if (normalizedTime >= 0f && normalizedTime <= 0.25f)
            {
                Debug.Log($"Fast");

                ScoreCounter.AddScore(3);

                scorecheck = 1;

                if (Mojibool == false)
                {
                    Instantiate(KakegoeObject[Random.Range(0, 9)], new Vector3(7.5f, 3.5f, 2), Quaternion.identity);

                    

                    Mojibool = true;

                }


                

            }
            else if (normalizedTime > 0.25f && normalizedTime <= 0.5f)
            {
                Debug.Log($"Just");

                //ScoreCounter.AddScore(2);

                scorecheck = 2;


                if (Mojibool == false)
                {
                    Instantiate(FeeverObject[Random.Range(0, 9)], new Vector3(7.5f, 3.5f, 2), Quaternion.identity);

                    

                    Mojibool = true;

                }

                

                /*if (SEplayed == false)
                {
                    AudioClip _sef = SEsf[Random.Range(0, 9)];

                    se.PlayOneShot(_sef);

                    SEplayed = true;

                    ScoreCounter.AddScore(2);

                }*/

            }
            else if (normalizedTime > 0.5f)
            {
                Debug.Log($"Slow");

                //ScoreCounter.AddScore(1);

                scorecheck = 3;

                if (Mojibool == false)
                {
                    Instantiate(MissObject[Random.Range(0, 6)], new Vector3(7.5f, 3.5f, 2), Quaternion.identity);

                    

                    Mojibool = true;

                }
                

            }

        }

        /*void OnTriggerExit(Collider other)
        {
            Debug.Log("はずれたオブジェクト : "+other);
            // 必要なら other がどのオブジェクトのものなのかチェック
            PoseObject.SetActive(false);
        }*/
    }

    #endregion

    #region PUBLIC_METHODS
    public override void OnPlay()
    {
        if (displayObject != null)
        {
            displayObject.SetActive(true);
        }

        if (activationEffect != null)
        {
            activationEffect.Play(true);
        }

        


    }

    public override void OnStop()
    {
        OVRInput.SetControllerVibration(0, 0);

        //Debug.Log("きえます");

        PoseObject.SetActive(false);
        //Kierubool = true;

        AvaterObject.SetActive(true);

        if (displayObject != null)
        {
            displayObject.SetActive(false);
        }

        if (activationEffect != null)
        {
            activationEffect.Stop(true, ParticleSystemStopBehavior.StopEmitting);
        }


    }
    #endregion

    #region PRIVATE_METHODS

    #endregion
}
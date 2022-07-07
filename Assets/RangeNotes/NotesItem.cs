using UnityEngine;
using UnityEngine.Events;
using SeikaGameKit.Timeline;

public class NotesItem : PlayingEventItem
{
    #region DEFINITION
    #endregion

    #region VARIABLE
    public string _targetTagName1 = "Player";
    public GameObject displayObject;
    public ParticleSystem activationEffect;
    public ParticleSystem hitEffect;
    public AudioSource se;
    public AudioClip clip;
    public bool SEplayed = false;
    public AudioClip[] SEs;
    public AudioClip[] SEsm;
    public AudioClip[] SEsf;

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
        if (isPlaying && other.CompareTag(_targetTagName1))
        {
            //displayObject.SetActive(false);
           // hitCallback?.Invoke(0);

            Debug.Log($"{currentTime} {normalizedTime}");

            if (hitEffect != null)
            {
                hitEffect.Play(true);
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

                if (SEplayed == false)
                {
                    AudioClip _se = SEs[Random.Range(0, 9)];

                    se.PlayOneShot(_se);

                    SEplayed = true;

                    ScoreCounter.AddScore(1);

                }

            }
            else if (normalizedTime > 0.25f && normalizedTime <= 0.5f)
            {
                Debug.Log($"Just");

                if (SEplayed == false)
                {
                    AudioClip _sef = SEsf[Random.Range(0, 9)];

                    se.PlayOneShot(_sef);

                    SEplayed = true;

                    ScoreCounter.AddScore(2);

                }

            }
            else if (normalizedTime > 0.5f)
            {
                Debug.Log($"Slow");

                if (SEplayed == false)
                {
                    AudioClip _sem = SEsm[Random.Range(0, 6)];

                    se.PlayOneShot(_sem);

                    SEplayed = true;

                    ScoreCounter.AddScore(3);

                }

            }

        }
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
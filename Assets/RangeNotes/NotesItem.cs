using UnityEngine;
using UnityEngine.Events;
using SeikaGameKit.Timeline;

public class NotesItem : PlayingEventItem
{
    #region DEFINITION
    #endregion

    #region VARIABLE
    string _targetTagName = "Player";
    public GameObject displayObject;
    public ParticleSystem activationEffect;
    public ParticleSystem hitEffect;
    public AudioSource se;
    public AudioClip clip;

    [Space]
    public UnityEvent<int> hitCallback;
    #endregion

    #region UNITY_EVENT
    void OnTriggerEnter(Collider other)
    {
        if (isPlaying && other.CompareTag(_targetTagName))
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
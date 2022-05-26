using UnityEngine;
using UnityEngine.Events;
using SeikaGameKit.Timeline;

public class NotesItem : MonoBehaviour, IPlayingEventItem
{
    #region DEFINITION
    #endregion

    #region VARIABLE
    public bool isPlaying { get; set; }
    string _targetTagName = "Player";

    public GameObject displayObject;
    public ParticleSystem activationEffect;
    public ParticleSystem hitEffect;
    [Space]
    public UnityEvent<int> hitCallback;
    #endregion

    #region UNITY_EVENT
    void OnTriggerEnter(Collider other)
    {
        if (isPlaying && other.CompareTag(_targetTagName))
        {
            displayObject.SetActive(false);
            hitCallback?.Invoke(0);
            if (hitEffect != null)
            {
                hitEffect.Play(true);
            }
        }
    }

    #endregion

    #region PUBLIC_METHODS
    public void OnPlay()
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

    public void OnStop()
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
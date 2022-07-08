using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelinePlayer : MonoBehaviour
{
    public PlayableDirector director;
    public GameObject controlPanel;

    private void Awake()
    {
        director = GetComponent<PlayableDirector>();
        director.played += Director_Played;
       // director.stopped += Director_Stopped;
    }

    /*private void Director_Stopped(PlayableDirector obj)
    {
        controlPanel.SetActive(true);
    }*/

    private void Director_Played(PlayableDirector obj)
    {
        controlPanel.SetActive(false);
    }

    public void StartTimeline()
    {
        Debug.Log("ƒ{ƒ^ƒ“‚ð‰Ÿ‚µ‚½‚æ");

        director.Play();

        //this.gameObject.SetActive(false);

    }

}
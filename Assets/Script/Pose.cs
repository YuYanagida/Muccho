using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SeikaGameKit.Timeline;

public class Pose : MonoBehaviour
{
    public GameObject colliderObject;
    public static bool Kierubool = false;


    private void OnTriggerStay(Collider other)
    {
        if (Kierubool == false)
        {
            Debug.Log("あたったよ");

            Kierubool = true;
        }
       
    }

    private void Update()
    {

        //Debug.Log("表示 ");

        //if()
        {
            Debug.Log("あたったよ");

            Kierubool = true;
        }

        if (Kierubool == true)
        {
            this.gameObject.SetActive(false);

            Debug.Log("きえたよ ");

        }

    }
    /* void OnTriggerExit(Collider other)
        
     {
       // if (other)

            this.gameObject.SetActive(false);

         Debug.Log("きえたよ ");

     }*/

}

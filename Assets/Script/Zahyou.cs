using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zahyou : MonoBehaviour
{
    // Start is called before the first frame update


    public Transform okurisaki;

    // Update is called once per frame
    void Update()
    {
        okurisaki.position = this.transform.position;

        okurisaki.rotation = this.transform.rotation;

    }
}

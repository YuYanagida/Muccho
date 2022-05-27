using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZahyouHead : MonoBehaviour
{
    // Start is called before the first frame update


    public Transform okurisaki;

    // Update is called once per frame
    void Update()
    {
        okurisaki.position = this.transform.position;

        okurisaki.rotation = this.transform.rotation;

        Vector3 pos = okurisaki.position;

            pos.x += 10.5f;

        pos.y += 0;

        pos.z += 0;


        okurisaki.position = pos;

    }
}

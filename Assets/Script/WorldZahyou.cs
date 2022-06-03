using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldZahyou : MonoBehaviour
{

    public GameObject hoge;
    public Vector3 fuga;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fuga = hoge.transform.positon;
        Debug.log();

    }
}

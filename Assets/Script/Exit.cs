using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Button button1;
    public GameObject @object;
    void Start()
    {
        button1.onClick.AddListener(SwitchScene);
    }
    void SwitchScene()
    {
#if UNITY_EDITOR //如果是在编辑器环境下
        UnityEditor.EditorApplication.isPlaying = false;
#else//在打包出来的环境下
        Application.Quit();
#endif

    }
    private void Update()
    {
        @object.transform.position += new Vector3(0, 0.1f, 0);
    }
}
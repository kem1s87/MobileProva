using UnityEngine;
using UnityEngine.SceneManagement;

public class ExampleClass : MonoBehaviour
{
    void Start() => SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Additive);

    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;

    private void start()
    {
        myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/scenes");
        scenePaths = myLoadedAssetBundle.GetAllScenePaths();
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 30), "Change Scene"))
        {
            Debug.Log("Scene2 loading: " + scenePaths[0]);
            SceneManager.LoadScene(scenePaths[0], LoadSceneMode.Single);

        }



    }
    public void GetInputFieldText(string text)
    {
        Debug.Log("Texto digitado pelo usuário: " + text);
    }


}
public class MessageBox : MonoBehaviour
{
    
    private Rect windowRect = new Rect((Screen.width - 200) / 2, (Screen.height - 300) / 2, 200, 300);
    private bool show = false;
    void OnGUI()
    {
        if (show)
            windowRect = GUI.Window(0, windowRect, DialogWindow, "Turma de 2009");
    }
    void DialogWindow(int windowID)
    {
        float y = 20;
        GUI.Label(new Rect(5, y, windowRect.width, 20), "Texto desejado");
        if (GUI.Button(new Rect(5, y, windowRect.width - 10, 20), "Fechar"))
            show = false;
    }
    public void Open()
    {
        show = true;
    }
}

using UnityEngine;
using System.Collections;

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

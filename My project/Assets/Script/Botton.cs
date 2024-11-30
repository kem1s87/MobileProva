using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Funcoes : MonoBehaviour
{

    public Button botton;
    public InputField input1;
    public InputField input2;
    public Text textoResposta;

    private void Start()
    {
        botton.onClick = new Button.ButtonClickedEvent();
        botton.onClick.AddListener(() => Multiplicacao(input1, input2, textoResposta));
    }

    public void Multiplicacao(InputField valor1, InputField valor2, Text resposta)
    {
        float _valor1 = float.Parse(valor1.text);
        float _valor2 = float.Parse(valor2.text);
        float multiplicacao = _valor1 * _valor2;
        resposta.text = multiplicacao.ToString();
    }
}

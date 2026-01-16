using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;
public class Sumatoria : MonoBehaviour
{
    public TextMeshProUGUI txtNumeros;
    public TextMeshProUGUI txtSumatoria;
    public TextMeshProUGUI msgNumeros;
    public TMP_InputField inputNumeros;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Generar()
    {
        List<int> numerosAleatorios = new List<int>();
        int sumatoria = 0;
        string result = "Números generados:\n";

        if (int.TryParse(inputNumeros.text, out int cantidad))
        {
            if (cantidad >= 1 || cantidad <= 20)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    int numAleatorio = Random.Range(1, 101);
                    numerosAleatorios.Add(numAleatorio);
                    sumatoria += numAleatorio;

                    result += numAleatorio + (i < cantidad - 1 ? ", " : "");
                }

                txtNumeros.SetText(result);
                txtSumatoria.SetText($"{sumatoria}");
            }
            else
            {
                msgNumeros.SetText("Digite un valor valido entre 1 y 20");
            }
        }
        else
        {
            msgNumeros.SetText("Digite un valor numerico");
        }
    }
}

using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CosteoDirecto : MonoBehaviour
{
    public TextMeshProUGUI txtMateriaPrima;
    public TextMeshProUGUI txtManoObra;
    public TextMeshProUGUI txtCifUnd;
    public TextMeshProUGUI txtUtilidad;
    public TextMeshProUGUI txtResult;

    public TMP_InputField inputCostoT;
    public TMP_InputField inputUtilidad;
    public TMP_InputField inputVenta;

    public TextMeshProUGUI msgCostoT;
    public TextMeshProUGUI msgUtilidad;
    public TextMeshProUGUI msgVenta;
    public TextMeshProUGUI msgResult;

    public float resCostoT;
    public float resUtilidad;
    public float resPrecio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float materiaPrima = Random.Range(100000, 500001);
        float manoObra = Random.Range(100000, 500001);
        float cifUnd = Random.Range(100000, 500001);
        float utilidad = Random.Range(0.5f, 1.20f);

        txtMateriaPrima.SetText($"Materia prima: {materiaPrima}");
        txtManoObra.SetText($"Mano de obra: {manoObra}");
        txtCifUnd.SetText($"CIF: {cifUnd}");
        txtUtilidad.SetText($"Utilidad (%): {utilidad * 100f}");

        resCostoT = materiaPrima + manoObra + cifUnd;
        resUtilidad = resCostoT * utilidad;
        resPrecio = resCostoT + resUtilidad;
    }

    public void ComprobarResult()
    {
        if (float.TryParse(inputCostoT.text, out float costoIngresado))
        {
            if (costoIngresado == resCostoT)
            {
                msgCostoT.SetText("Correcto!");
            }
            else
            {
                msgCostoT.SetText($"Incorrecto! El valor es: {resCostoT}");
            }
        }
        else
        {
            msgCostoT.SetText("Digite un valor valido");
        }
        if (float.TryParse(inputUtilidad.text, out float utilidadIngresada))
        {
            if (utilidadIngresada == resUtilidad)
            {
                msgUtilidad.SetText("Correcto!");
            }
            else
            {
                msgUtilidad.SetText($"Incorrecto! El valor es: {resUtilidad}");
            }
        }
        else
        {
            msgUtilidad.SetText("Digite un valor valido");
        }
        if (float.TryParse(inputVenta.text, out float ventaIngresada))
        {
            if (ventaIngresada == resPrecio)
            {
                msgVenta.SetText("Correcto!");
            }
            else
            {
                msgVenta.SetText($"Incorrecto! El valor es: {resPrecio}");
            }
        }
        else
        {
            msgVenta.SetText("Digite un valor valido");
        }
    }
}

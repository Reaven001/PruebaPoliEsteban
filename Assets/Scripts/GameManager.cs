using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float tiempoRes = 30f;
    public bool juegoActivo = true;

    private int puntaje = 0;
    private int amarillo = 0, azul = 0, rojo = 0;
    public TextMeshProUGUI txtTiempo;
    public TextMeshProUGUI txtPuntaje;

    void Awake() { instance = this; }


    // Update is called once per frame
    void Update()
    {
        if (juegoActivo)
        {
            tiempoRes -= Time.deltaTime;
            txtTiempo.SetText($"{tiempoRes}");

            if (tiempoRes <= 0)
            {
                juegoActivo = false;
            }
        }
        else
        {
            txtPuntaje.SetText($"Juego Terminado\nTotal: {puntaje}\nAmarillo: {amarillo}\nAzul: {azul}\nRojo: {rojo}");
        }
    }

    public void SumarPunto(string color)
    {
        if (!juegoActivo) return;
        puntaje++;
        if (color == "Amarillo") amarillo++;
        else if (color == "Azul") azul++;
        else if (color == "Rojo") rojo++;
    }
}

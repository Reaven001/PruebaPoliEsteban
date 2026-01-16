using UnityEngine;

public class MiniJuego : MonoBehaviour
{
    public string colorCubo;
    public float tiempoVida = 2.0f;
    private bool IsClickedCube = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("hola");
        Destroy(gameObject, tiempoVida);
    }

    void OnMouseDown()
    {
        Debug.Log("Click");
        if (!IsClickedCube)
        {
            IsClickedCube = true;
            GameManager.instance.SumarPunto(colorCubo);
            Destroy(gameObject);
        }
    }
}

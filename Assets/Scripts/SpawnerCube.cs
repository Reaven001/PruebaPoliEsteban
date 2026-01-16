using UnityEngine;
using System.Collections;

public class SpawnerCube : MonoBehaviour
{
    public GameObject[] prefabsCubos; // Asigna tus prefabs de colores aquí
    public float intervaloMin = 1f;
    public float intervaloMax = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(GenerarCubo());
    }
    IEnumerator GenerarCubo()
    {
        while (GameManager.instance.juegoActivo)
        {
            float espera = Random.Range(intervaloMin, intervaloMax);
            yield return new WaitForSeconds(espera);

            Vector3 posicionAleatoria = new Vector3(Random.Range(-10, 10), Random.Range(-3, 9), 0);

            int indiceCubo = Random.Range(0, prefabsCubos.Length);
            Instantiate(prefabsCubos[indiceCubo], posicionAleatoria, Quaternion.identity);
        }
    }
}

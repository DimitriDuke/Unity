using UnityEngine;

public class ObjetoSalto : MonoBehaviour
{
    public float fuerzaSalto = 1000f; // Fuerza del salto

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter ejecutado con: " + collision.gameObject.name); // Mensaje de depuración

        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            Debug.Log("Rigidbody encontrado, aplicando fuerza de salto."); // Mensaje de depuración
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            Debug.Log("Fuerza de salto aplicada: " + (Vector3.up * fuerzaSalto));
        }
        else
        {
            Debug.Log("No se encontró Rigidbody en el objeto que colisionó."); // Mensaje de depuración
        }
    }
}

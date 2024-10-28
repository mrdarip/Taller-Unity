using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ControladorPersonaje : MonoBehaviour
{
    public Rigidbody rb;
    public float velocidad = 100;
    public bool isModoMatador = false;
    public int vidas = 3;
    public TextMeshProUGUI vidasText;

    void Update()
    {
        vidasText.text = "Vidas: " + vidas;
        isModoMatador = Input.GetKey(KeyCode.Space);

        rb.AddForce(
            new Vector3(
                Input.GetAxis("Horizontal"), 
                0,
                Input.GetAxis("Vertical")
            )
            * velocidad
        );
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Malo")
        {
            if (isModoMatador)
            {
                Destroy(collision.gameObject);
            }
            else
            {
                vidas = vidas -1;
                if (vidas <= 0)
                {
                    SceneManager.LoadScene(0);
                }
            }
        }
    }
}

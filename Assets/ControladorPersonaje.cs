using UnityEngine;
using UnityEngine.SceneManagement;


public class ControladorPersonaje : MonoBehaviour
{
    public Rigidbody rb;
    public float velocidad = 100;
    public bool isModoMatador = false;

    void Update()
    {
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
                SceneManager.LoadScene(0);
            }
        }
    }
}

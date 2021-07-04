using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float Horizontal; // almacena el control horizontal del objecto
    float Vertical;
    public float velocidad = 4f; // velocidad del desplazamiento
    public float velocidadVertical = 4f; // velocidad del desplazamiento
    public Animator anim; // árbol de animaciones o animator
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal") * velocidad;
        Vertical = Input.GetAxis("Vertical") * velocidadVertical;

        // me permite desplazar al objeto en tres ejes
        transform.Translate(Horizontal*Time.deltaTime,0f,0f);
        transform.Translate(0f,Vertical*Time.deltaTime,0f);

        // NOTA: El parámetro "Velocidad" está definido dentro de los parámetros
        // de las animaciones.

        // Modifica la valocidad en el animator, y por lo tanto sus animaciones
        // anim.SetFloat("Velocidad", Mathf.Abs(Horizontal));
        // anim.SetFloat("Velocidad", Mathf.Abs(Vertical));
        Scale();
    }

    void Scale()
    {
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)) {
          this.transform.localScale = new Vector2(-4f, 4f);
        }

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)) {
          this.transform.localScale = new Vector2(4f, 4f);
        }

        if (Input.GetKey("s") || Input.GetKey(KeyCode.UpArrow)) {
          this.transform.localScale = new Vector2(4f, -4f);
        }

        if (Input.GetKey("w") || Input.GetKey(KeyCode.DownArrow)) {
          this.transform.localScale = new Vector2(4f, 4f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ESTA ES LA MANERA DE INFORMAR A UNITY QUE ES REQUERIDO ESTE OTRO COMPONENTE
// este otro comonente. Si no existe no va a servir. 
[RequireComponent(typeof(Rigidbody))]
public class fisicaDePelotas : MonoBehaviour
{
    // vamos a obtenerlo internamente PERO 
    // les pongo esto para el futuro
    [SerializeField]
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // COSA NUEVA
        // obtener referencia a un componente en el mismo gameobject 
        // GetComponent en start o awake
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Space)){
                rb.AddForce(new Vector3(0,200,0));
            }
        
    }
}

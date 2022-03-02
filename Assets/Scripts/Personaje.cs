using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personaje : MonoBehaviour
{

    // atributos publicos que sean primitivos o serializables
    // se pueden exponer al editor
    // primitivo- tipo de dato basico que se traduce directamente a bytes en memoria

    //¿por que exponer valores hacia el editor?
    // - facilidad de cambio de comportamiento sin meters al codigo
    public float velocidad = 5;
    public float dummy; 
    // cuando expongamos un objeto
    // que esperemos nos manden del editor
    // hay posibilidad que sea nulo
    public Text textito;
    
    //CICLO DE VIDA!
    // - existen métodos que se ejecutan en momentos especificos 
    // en la vida de un script

    // idioms -estandares de escritura en lenguaje

    //se ejecuta al inicio de la vida del script
    // 1 sola vez
    void Awake(){
        print("AWAKE");
    }

    // Start is called before the first frame update
    void Start(){

        Debug.Log("START");

        textito.fontSize = 18;
        textito.fontStyle = FontStyle.Italic;
        textito.text = "HOLA A TODOS";
    }

    // Update is called once per frame
    void Update(){
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(velocidad * horizontal * Time.deltaTime, 
        velocidad * vertical * Time.deltaTime,0);
        print(horizontal);
    }

    void LateUpdate(){}

    void FixedUpdate(){}

    //DETECCIÓN DE COLISIONES (con motor de física)
    // 1 - todos los involucrados tienen collider
    // 2 - almenos uno debe tener rigidbody (y se debe mover)

    void OnCollisionEnter(Collision c){
        print("ENTER");
    }

    void OnCollisionStay(Collision c){
        print("stay");
    }

    void OnCollisionExit(Collision c){
        print("exit");
    }

}   

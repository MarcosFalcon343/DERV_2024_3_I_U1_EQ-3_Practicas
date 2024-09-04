using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Dialogo : MonoBehaviour
{
    [System.Serializable]
    public struct Charla{
        public string nombre;
        public string mensaje;
        public Sprite imagen;
    }

    [SerializeField] List<Charla> charla;

    [SerializeField] TextMeshProUGUI nombre;
    [SerializeField] TextMeshProUGUI mensaje;
    [SerializeField] Image foto;
    
    int mensajeActual = 0;

        void actualizaMensaje(){
        nombre.text = charla[mensajeActual].nombre;
        mensaje.text = charla[mensajeActual].mensaje;
        foto.sprite = charla[mensajeActual].imagen;
    }
    void Start()
    {
        mensajeActual = 0;
        actualizaMensaje();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            mensajeActual++;
            mensajeActual%=charla.Count;
            actualizaMensaje();
        }
    }
}

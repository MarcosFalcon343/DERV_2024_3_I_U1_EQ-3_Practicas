using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenas : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L)){
            int indexEscena = SceneManager.GetActiveScene().buildIndex;

            switch(indexEscena){
                case 0:
                    cambioEscena(1);
                    break;
                case 1:
                    cambioEscena(2);
                    break;
                case 2:
                    cambioEscena(3);
                    break;
                case 3:
                    cambioEscena(0);
                    break;
            }
            
        }
    }

    void cambioEscena(int indexEscena){
        SceneManager.LoadScene(indexEscena);
    }
}

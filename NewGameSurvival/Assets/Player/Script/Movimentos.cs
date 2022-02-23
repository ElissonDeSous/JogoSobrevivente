using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentos : MonoBehaviour
{
    public Animator animMove;
  
    

    public float vel;
    public float Speed;
    public float Rotacao;
    
   

    // Update is called once per frame
    void Update()
    {
        Andar();
    }
    void Andar()
    {

        float velocidade = Input.GetAxis("Vertical")*vel;
        

        if (velocidade == 0) 
        {
            animMove.SetInteger("move" ,0 );
            
        }
        if (velocidade > 0)
        {
            animMove.SetInteger("move", 1);
        }

        float Rota = Input.GetAxis("Mouse X") * Rotacao;
        transform.Rotate(0, Rota, 0);
    }

}

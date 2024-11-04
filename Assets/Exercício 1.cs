using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Exercício1 : MonoBehaviour
{
    [SerializeField] private int VidaPersonagem = 10;
    [SerializeField] private System.Random Dado = new System.Random();
    [SerializeField] private int vidaperdida;
    // Start is called before the first frame update
    void Start()
    {   
        vidaperdida = Dado.Next(1, 20);

        VidaPersonagem -= vidaperdida;

        if (VidaPersonagem <= 0)
        {
            print("Foi de F");
        }
        else { print("ESTAIS VIVASSO!!!"); }
            

     
        
     
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

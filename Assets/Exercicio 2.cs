using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    private int power = 0;
    private System.Random Michael = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        power = Michael.Next(1,5);

        string powerUp = power.ToString();

        switch(powerUp) {
        
            case "0":
                print("Voc� n�o conseguiu nenhum power up")

                ;break;
            case "1":
                print("Voc� conseguiu um power up de for�a")

                ; break;
            case "2":
                print("Voc� conseguiu um power up de velocidade")

                ; break;
            case "3":
                print("Voc� conseguiu um power up de defesa")

                ; break;
            case "4":
                print("Voc� conseguiu um power up de voo")

                ; break;
            case "5":
                print("PARAB�NS, VOC� REVIVEU!!!")

                ; break;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

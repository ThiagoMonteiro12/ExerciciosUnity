using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    
    [SerializeField] private int power = 0;
    [SerializeField] private int VidaPersonagem = 10;
    [SerializeField] private System.Random Dado = new System.Random();
    [SerializeField] private int vidaperdida;
    private int vidamaxima = 10;
    // Start is called before the first frame update
    void Start()
    {
        vidaperdida = Dado.Next(1, 20);

        VidaPersonagem -= vidaperdida;

        if (VidaPersonagem <= 0)
        {
            power = Dado.Next(1, 5);

            string powerUp = power.ToString();

            switch (powerUp)
            {

                case "0":
                    print("Você não conseguiu nenhum power up e morreu. Vida atual: " + VidaPersonagem)

                    ; break;
                case "1":
                    print("Você conseguiu um power up de força e morreu. Vida atual: " + VidaPersonagem)

                    ; break;
                case "2":
                    print("Você conseguiu um power up de velocidade e morreu. Vida atual:" + VidaPersonagem)

                    ; break;
                case "3":
                    print("Você conseguiu um power up de defesa e morreu. Vida atual: " + VidaPersonagem)

                    ; break;
                case "4":
                    print("Você conseguiu um power up de voo e morreu. Vida atual: " + VidaPersonagem)

                    ; break;
                case "5":
                    print("PARABÉNS, VOCÊ REVIVEU!!!");
                    VidaPersonagem = vidamaxima / 2;
                    print("Vida Atual: " + VidaPersonagem);

                    ; break;
            }
        }
        else { print("ESTAIS VIVASSO!!!"); }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

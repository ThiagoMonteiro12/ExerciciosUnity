using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Exercicio9 : MonoBehaviour
{
//    9. (Placar final) Crie um script que lê o placar de uma partida entre
//time A e time B.Depois, escreva no console qual dos três
//resultados possíveis aconteceu: vitória do time A, vitória do time B
//ou empate.Se o empate teve mais de 3 pontos para cada lado,
//escreva que foi “um empate emocionante”.

    [SerializeField] private System.Random Jose = new System.Random();
    [SerializeField] private int pontosA;
    [SerializeField] private int pontosB;
    // Start is called before the first frame update
    void Start()
    {
        pontosA = Jose.Next(1,3);
        pontosB = Jose.Next(1,3);

        if( pontosA > pontosB )
        {
            print("O TIME A GANHA DE " + pontosA + " " + pontosB + " CONTRA O TIME B!!!");
         }        
        else if( pontosA < pontosB )
        {
            print("O TIME B GANHA DE " + pontosB + " " + pontosA + " CONTRA O TIME A!!!");
        }
        else {
            print("QUE EMPATE EMOCIONANTEEEEEEE");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

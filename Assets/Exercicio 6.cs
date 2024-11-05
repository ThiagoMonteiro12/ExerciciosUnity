using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//6. (Escolha de personagem) O jogador pode escolher entre o
//personagem Guerreiro ou Mago. Exiba "Guerreiro escolhido" se o
//jogador selecionar Guerreiro e "Mago escolhido" se selecionar
//Mago.
public class Exercicio6 : MonoBehaviour
{
    [SerializeField] private string escolha;

   
    void Start()
    {
        do
        {
            print("Escolha seu personagem \n 1 - Guerreiro / 2 - Mago");

            if (escolha == "1")
            {
                print("Guerreiro escolhido");
            }
            else if (escolha == "2") { print("Mago escolhido"); }
            else { print("Escolha invalida"); }
        } while (escolha == "1" || escolha == "2" );
    }
    void Update()
    {

    }
}

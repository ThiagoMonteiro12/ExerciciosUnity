using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//5. (Pontua��o de miss�o) Ap�s completar uma miss�o, o jogador
//recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
//exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
//incompleta".
public class Exercicio5 : MonoBehaviour
{

    [SerializeField] int pontos;
    [SerializeField] System.Random xp = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
            int pontos = xp.Next(1, 120);

        if (pontos > 50) {

            print("Passooooooou");
        }
        else
        {
            print("N�o passoooooooooooou");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

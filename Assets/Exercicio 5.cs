using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//5. (Pontuação de missão) Após completar uma missão, o jogador
//recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
//exiba "Missão bem-sucedida"; caso contrário, "Missão
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
            print("Não passoooooooooooou");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

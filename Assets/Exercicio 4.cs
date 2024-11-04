using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//4. (Verificar item de inventário) Um jogador possui itens limitados
//no inventário. Verifique se o jogador possui uma "Poção de Vida".
//Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
//indisponível".
public class Exercicio4 : MonoBehaviour
{
    [SerializeField] private int pocao = 1;

    // Start is called before the first frame update
    void Start()
    { 
        if (pocao >= 1)
        {
            print("Usando poção de vida");
            pocao -= 1;
            print("Você tem mais " +  pocao + " poções sobrando");
        }
        else
        {
            print("Você não tem mais poções");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

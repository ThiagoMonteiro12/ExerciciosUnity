using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//4. (Verificar item de invent�rio) Um jogador possui itens limitados
//no invent�rio. Verifique se o jogador possui uma "Po��o de Vida".
//Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o
//indispon�vel".
public class Exercicio4 : MonoBehaviour
{
    [SerializeField] private int pocao = 1;

    // Start is called before the first frame update
    void Start()
    { 
        if (pocao >= 1)
        {
            print("Usando po��o de vida");
            pocao -= 1;
            print("Voc� tem mais " +  pocao + " po��es sobrando");
        }
        else
        {
            print("Voc� n�o tem mais po��es");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

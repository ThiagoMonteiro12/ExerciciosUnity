using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;
using static UnityEditor.PlayerSettings;
using static UnityEngine.EventSystems.EventTrigger;

public class Exercicio7 : MonoBehaviour
{
    //    (dado com n faces) para fazer um jogo de rpg, vamos precisar
    //calcular probabilidades e simular a rolagem de dados.crie um
    //script em que o usuário defina o número de faces de um dado
    //    (int) e calcule a rolagem de um dado com esse número de faces.
    //use a função abaixo para o cálculo: random.range (valor_min,
    //valor_max); (coloque o código dentro da função-evento start).


    [SerializeField] private int numero;
    [SerializeField] private System.Random dado = new System.Random();
    [SerializeField] private int resultado;
    // Start is called before the first frame update
    void Start()
    {
        resultado = dado.Next(1, numero);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

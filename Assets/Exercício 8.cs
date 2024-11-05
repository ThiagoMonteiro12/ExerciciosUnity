using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEditor.PackageManager;
using UnityEditor;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;
using UnityEngine.UIElements;

public class Exercício8 : MonoBehaviour
{
    //    8. (contador de horas e dias) crie um script que em que uma
    //variável inteira hora seja incrementada de uma unidade a cada 10
    //segundos e volte a ser 0 quando alcançar o valor 24. quando
    //completar um ciclo, incremente uma variável dias e escreva o
    //número de dias que se passaram no console. (coloque o código
    //dentro da função-evento update).

    int hora;
    float segundos;
    int dias;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        segundos += Time.deltaTime;

        if (segundos > 10) {

            dias += 1;
            print(dias);

            segundos = 0;
        }
        
    }
}

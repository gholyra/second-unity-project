using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloScript : MonoBehaviour
{
    //Declaração de variáveis
    private string helloString;
    private string worldString;
    private string saudacao;
    private string nome;
    private string emote;
    private int numero1;
    private int numero2;
    private int idade;

    // Start is called before the first frame update
    void Start()
    {
        helloString = "Hello";
        worldString = "World!";
        print(helloString + " " + worldString);

        saudacao = "Meu nome é";
        nome = "Tiago";
        emote = "=)";
        print(saudacao + " " + nome + " " + emote);

        numero1 = 15;
        numero2 = 5;
        print(numero1 + numero2);

        idade = 11;
        print("Minha idade é " + idade);

        if (idade >= 18)
        {
            print("Sou maior de idade");
        }
        else if (idade > 12)
        {
            print("Sou um adolescente");
        }
        else if (idade >= 4 && idade <= 10)
        {
            print("Sou uma criança");
        }
        else
        {
            print("Sou um pré-adolescente");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloScript : MonoBehaviour
{
    //Declara��o de vari�veis
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

        saudacao = "Meu nome �";
        nome = "Tiago";
        emote = "=)";
        print(saudacao + " " + nome + " " + emote);

        numero1 = 15;
        numero2 = 5;
        print(numero1 + numero2);

        idade = 11;
        print("Minha idade � " + idade);

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
            print("Sou uma crian�a");
        }
        else
        {
            print("Sou um pr�-adolescente");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
﻿using System;
using Modelo;
using Core;

public class Program
{
    static int menu = 1;
    static Usuario usuario = new Usuario();
    static int selected;

    static void Main()
    {
        // remover após os testes
        usuario.logged = true;

        // Se usuario ainda não fez o cadastro ou login.
        if (!usuario.logged)
        {
            Console.WriteLine("+--------------------------------------------------------------------------+");
            Console.WriteLine("| Seja Bem Vindo!                                                          |");
        Begin:
            Console.WriteLine("+---------------------------------------------------------------------------+");
            Console.WriteLine("| Para acessar o sistema de reserva você precisa se cadastrar antes.        |");
            Console.WriteLine("|             Deseja fazer isso agora? s - (sim), n - (não)                 |");
            Console.WriteLine("+---------------------------------------------------------------------------+");

            var option = Console.ReadLine();
            // Termina programa.
            if (option == "n")
            {
                Console.Clear();
                Console.WriteLine("Infelizmente não é possível acessar o sistema sem um cadastro.");
                Console.WriteLine("Pressione qualquer botão para sair...");
                Console.ReadKey();
                return;
            }
            else if (option == "s")
            {
                // Cadastrar novo usuario.
                novoUsuario();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção inválida, tente novamente...");
                goto Begin;
            }
        }

        // se usuario fez login entra aqui.
        if (usuario.logged)
        {
            while (menu > 0)
            {
                Helpers.MakeMenu(usuario.nome!, "Dashboard", "Escolha uma opção abaixo...");
                selected = ConsoleHelper.MultipleChoice(true, "Reserva", "Itens");
                if (selected == 0)
                {
                    Console.Clear();
                    reservas();

                }

                if (selected == 1)
                {
                    Console.Clear();
                    reservado();
                }
            }
        }
    }

    static void reservas()
    {
        Helpers.MakeMenu(usuario.nome!, "Reservas", "Gerenciamento de Reservas.");
        selected = ConsoleHelper.MultipleChoice(true, "Cadastrar Reserva");

        Main();
    }

    static void reservado()
    {
        Helpers.MakeMenu(usuario.nome!, "Reservas", "Gerenciamento de Reservas.");
        selected = ConsoleHelper.MultipleChoice(true, "Cadastrar Cartão", "Deletar Reserva");

        Main();
    }

    /*
    * Cadastrar Usuário.
    *
    */
    static void novoUsuario()
    {
        Console.Clear();
        Console.WriteLine("Cadastro de usuário...");

        //Usuario usuario = new Usuario();
        Console.WriteLine("Ótimo, primeiro queremos saber qual seu primeiro nome.");
        usuario.nome = Helpers.SanitizeString(Console.ReadLine()!);

        Console.WriteLine("Agora o numero de matricula para acessar o sistema.");
    matricula:
        usuario.matricula = Console.ReadLine();
        if (!Helpers.IsValidEmail(usuario.matricula!))
        {
            Console.WriteLine("Matricula inválida, insira uma matricula válida.");
            goto matricula;
        }

        Console.WriteLine("Já estamos finalizando... Digite uma senha.");
        usuario.password = Console.ReadLine()!;

        // armazena arquivo de senha de usuario (AQUI TEMOS SEGURANÇA ZERO kkkkkk).
        // Só fiz pra aprender manipular arquivos e diretorios.
        FileStorage.createFolderAndFile("users", usuario.matricula!, ".dat", usuario.password);

        Console.Clear();
        login();
    }

    /*
    * Rotina para efetuar login no sistema.
    *
    */
    static void login()
    {
        string matricula = "";
        string senha = "";

    Login:
        Console.WriteLine("+---------------------------------------------------------------+");
        Console.WriteLine("| Login                                                         |");
        Console.WriteLine("+---------------------------------------------------------------+");

        Console.WriteLine("Email:");
        matricula = Console.ReadLine()!;

        Console.WriteLine("Senha:");
        senha = Console.ReadLine()!;
        if (usuario.isLogged(matricula, senha))
        {
            Main();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("matricula ou senha incorretos, tente novamente...");
            goto Login;
        }
    }
}
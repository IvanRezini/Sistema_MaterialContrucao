﻿using Sistema_MaterialContrucao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_MaterialContrucao.Dao;

namespace Sistema_MaterialContrucao.Controllers
{
    class ClienteController
    {
        public static string salvar(ClienteModel cli)
        {
            string resposata = "";
            cli.DataCadastro = DateTime.Now.ToString();
            if (cli.Nome != "")
            {
                cli.Nome = char.ToUpper(cli.Nome[0]) + cli.Nome.Substring(1);///Coloca a primeira letra em maisculu
                Console.WriteLine(cli.Cpf);
                if (Utilidades.IsValidCpf(cli.Cpf)) 
                {
                    string telefone = cli.Telefone;
                    telefone = telefone.Replace(")", "");
                    telefone = telefone.Replace("(", "");
                    telefone = telefone.Replace(" ", "");
                    if (telefone.Length == 11)
                    {
                        if (cli.Cep.Replace("-", "") != "")
                        {
                            if (cli.Cidade.Trim() != "")
                            {
                                if (cli.Bairro.Trim() != "")
                                {
                                    if (cli.Rua.Trim() != "")
                                    {
                                        if (cli.Numero >= 0)
                                        {
                                            if (Utilidades.IsValidEmail(cli.Email) || cli.Email == "")
                                            {
                                                if (cli.Id > 0)
                                                {
                                                    //ClienteDao.update(cli);//atualiza um cliente existente
                                                }
                                                else
                                                {
                                                    ClienteDao.insert(cli);//insere um novo client
                                                }
                                            }
                                            else
                                            {
                                                resposata = "Email invalido";
                                            }
                                        }
                                        else
                                        {
                                            resposata = "Numero invalido";
                                        }
                                    }
                                    else
                                    {
                                        resposata = "Rua em branco";
                                    }
                                }
                                else
                                {
                                    resposata = "Bairro em branco";
                                }
                            }
                            else
                            {
                                resposata = "Cidade em branco";
                            }
                        }
                        else
                        {
                            resposata = "Cep em branco";
                        }
                    }
                    else
                    {
                        resposata = "Telefone em branco ou invalido";
                    }
                }
                else
                {
                    resposata = "Cpf invaido";
                }
            }
            else
            {
                resposata = "Nome em branco";
            }
            return resposata;
        }

    }
}

using Sistema_MaterialContrucao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_MaterialContrucao.Dao;
using System.Windows.Forms;

namespace Sistema_MaterialContrucao.Controllers
{
    class ClienteController
    {
        public static string salvar(ClienteModel cli)
        {
            
            string resposata = "";
            string[] nomes = cli.Nome.Split(' ');
            cli.Nome = "";
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i].Trim() != "")
                {
                    nomes[i] = char.ToUpper(nomes[i][0]) + nomes[i].Substring(1);///Coloca a primeira letra em maisculu
                    cli.Nome += nomes[i] + " ";
                }
            }

            if (cli.Nome != "")
            {
                cli.Nome.Trim();
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
                                                cli.DataCadastro = DateTime.Now.ToString();
                                                if (cli.Id > 0)
                                                {
                                                    ClienteDao.update(cli);//atualiza um cliente existente
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
            MessageBox.Show(cli.Cidade);
            return resposata;
        }

    }
}


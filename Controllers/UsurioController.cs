using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_MaterialContrucao.Dao;
using Sistema_MaterialContrucao.Models;


namespace Sistema_MaterialContrucao.Controllers
{
    class UsurioController
    {

        public static string salvar(UsuarioModel uso)
        {
            string resposata = "";
            string[] nomes = uso.Nome.Split(' ');
            uso.Nome = "";
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i].Trim() != "")
                {
                    nomes[i] = char.ToUpper(nomes[i][0]) + nomes[i].Substring(1);///Coloca a primeira letra em maisculu
                    uso.Nome += nomes[i] + " ";
                }
            }
            uso.Nome.Trim();
            if (uso.Nome != "")
            {
                uso.Nome = char.ToUpper(uso.Nome[0]) + uso.Nome.Substring(1);
                
                if (uso.NomeUsuario.Trim() != "")
                {
                    if (uso.Senha.Trim() != "")
                    {
                        if (Utilidades.IsValidEmail(uso.Email))
                        {
                            string telefone = uso.Telefone;
                            telefone = telefone.Replace(")","");
                            telefone = telefone.Replace("(", "");
                            telefone = telefone.Replace(" ", "");
                            if (telefone.Length == 11)
                            {
                                if (uso.Id > 0 )
                                {
                                    UsuarioDao.update(uso);//atualiza um usuario existente
                                }
                                else
                                {
                                    UsuarioDao.insert(uso);//insere um novo usuario
                                }
                            }
                            else
                            {
                                resposata = "Telefone em branco ou invalido";
                            }
                        }
                        else
                        {
                            resposata = "Email em branco ou invaido";
                        }
                    }
                    else
                    {
                        resposata = "Senha em branco";
                    }
                }
                else
                {
                    resposata = "Nome de usuario em branco";
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

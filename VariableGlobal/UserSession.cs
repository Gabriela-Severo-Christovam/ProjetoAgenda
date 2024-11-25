using ProjetoAgenda.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.VariableGlobal
{
    //Transformando a classe em publica para todos ultilizarem e estatica pra os valores serem os mesmos 
    public static class UserSession
    {
        //As variveis vão guardar informações so usuario 
       private static string _usuario = null;
       private static string _senha = null;
       private static string _nome = null; 
        //Controle do que sera inserido ou pego 
        public static string usuario 
          {
            get { return _usuario; }
            set { 
                //value = value.ToUpper();
                _usuario = value;
                }
          }

        public static string senha
        {
            get { return _senha; }
            set
            {
                _senha = value;
            }
        }

        public static string nome
        {
            get { return _nome; }
            set
            {
               _nome = value;
            }
        }


    }
}

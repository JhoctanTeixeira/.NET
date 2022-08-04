using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula01.UI.Models
{
    public class Time
    {
        //Atributos (Campos/Fields)
        private string _formacao;
        private int _titulos;

        //Propiedade 
        public string Nome { get; set; }
        public bool Mundial { get; set; }


        //Propiedade para o titulo
        public int Titulos
        {
            get { return _titulos; }
            set { _titulos = value; }
        }

        //Encapsulamento Mesmo resultado que criar os atributos
   
        public string Formacao
        {
            get { return _formacao; }
            set { _formacao = value; }
        }
    }
}

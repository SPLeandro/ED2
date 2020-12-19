using System;
using System.Collections.Generic;
using System.Text;

namespace ContactList_Console
{
    class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public Data()
            : this(0, 0, 0)
        {
        }

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public void setData(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public override string ToString()
        {
            string rdia = dia < 9 ? "0" + dia : dia.ToString();
            string rmes = mes < 9 ? "0" + mes : mes.ToString();
            string rano = ano.ToString();
            while (rano.Length < 4)
            {
                rano = "0" + rano;
            }

            return rdia + "/" + rmes + "/" + rano;
        }
    }
}

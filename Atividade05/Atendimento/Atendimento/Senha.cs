using System;
using System.Collections.Generic;
using System.Text;

namespace Atendimento
{
    class Senha
    {
        private int id;
        private DateTime dataGerac, horaGerac, dataAtend, horaAtend;

        public Senha(int id)
        {
            this.id = id;
            dataGerac = DateTime.Now;
            horaGerac = DateTime.Now;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime DataGerac
        {
            get { return dataGerac; }
            set { dataGerac = value; }
        }

        public DateTime HoraGerac
        {
            get { return horaGerac; }
            set { horaGerac = value; }
        }

        public DateTime DataAtend
        {
            get { return dataAtend; }
            set { dataAtend = value; }
        }

        public DateTime HoraAtend
        {
            get { return horaAtend; }
            set { horaAtend = value; }
        }


        public string dadosParciais()
        {
            return Id + " - " + DataGerac;
        }

        public string dadosCompletos()
        {
            return Id + " - " + DataGerac + " - " + DataAtend;
        }
    }
}

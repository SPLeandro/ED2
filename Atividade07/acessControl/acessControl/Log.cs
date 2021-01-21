using System;
using System.Collections.Generic;
using System.Text;

namespace acessControl
{
    class Log
    {
        private DateTime dtAcesso;
        private Usuario usuario;
        private bool tipoAcesso;

        public Log(Usuario usuario, Boolean tipoAcesso)
        {
            this.dtAcesso = DateTime.Now;
            this.usuario = usuario;
            this.tipoAcesso = tipoAcesso;

        }

        public Log()
            : this(new Usuario(0, ""), false)
        {}        


        public DateTime DtAcesso
        {
            get { return dtAcesso; }
            set { dtAcesso = value; }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }


        public Boolean TipoAcesso
        {
            get { return tipoAcesso; }
            set { tipoAcesso = value; }
        }

    }
}

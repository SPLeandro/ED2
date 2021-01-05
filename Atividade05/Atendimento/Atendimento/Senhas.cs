using System;
using System.Collections.Generic;
using System.Text;

namespace Atendimento
{
    class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public int ProximoAtendimentos
        {
            get { return proximoAtendimento; }
            set { proximoAtendimento = value; }
        }

        public Queue<Senha> FilaSenhas
        {
            get { return filaSenhas; }
            set { filaSenhas = value; }
        }

        public Senhas()
        {
            this.proximoAtendimento = 1;
            filaSenhas = new Queue<Senha>();
        }

        public void gerar()
        {
            Senha proxSenha = new Senha(proximoAtendimento);
            proximoAtendimento++;
            filaSenhas.Enqueue(proxSenha);
        }
    }
}

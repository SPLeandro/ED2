using System;
using System.Collections.Generic;
using System.Text;

namespace acessControl
{
    class Ambiente
    {
        private int id;
        private string nome;
        private Queue<Log> logs;


        public Ambiente(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
            this.logs = new Queue<Log>();
        }

        public Ambiente ()
            :this(0, "")
        { }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Queue<Log> Logs
        {
            get { return logs; }
            set { logs = value; }
        }


        public void registrarLog(Log log)
        {
            if(logs.Count >= 100)
            {
                logs.Dequeue();
            } 

            logs.Enqueue(log);

        }
    }
}

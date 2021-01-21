using System;
using System.Collections.Generic;
using System.Text;

namespace acessControl
{
    class Usuario
    {
        private int id;
        private string nome;
        private List<Ambiente> ambientes;

        public Usuario(int id, string name)
        {
            this.id = id;
            this.nome = name;
            this.ambientes = new List<Ambiente>();
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return nome; }
            set { nome = value; }
        }

        public List<Ambiente> Ambientes
        {
            get { return ambientes; }
            set { ambientes = value; }
        }

        public Usuario()
            : this(0, "")
        { }

        public Boolean concederPermissao(Ambiente ambiente)
        {

            if (this.ambientes.Count > 0) {
                return false;
            } else {
                this.ambientes.Add(ambiente);
                Log log = new Log(new Usuario(this.id, this.nome), true);
                this.ambientes.Find(a => a.Id == ambiente.Id).registrarLog(log);
                return true;
            }

        }

           

        public Boolean revogarPermissao(Ambiente ambiente)
        {
                if (ambientes.Exists(a => a == ambiente))
                {
                    ambientes.Remove(ambiente);
                    Log log = new Log(new Usuario(this.id, this.nome), false);
                    ambiente.registrarLog(log);
                return true;
                }
                else
                {
                    return false;
                }

        }
    }
}

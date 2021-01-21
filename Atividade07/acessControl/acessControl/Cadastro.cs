using System;
using System.Collections.Generic;
using System.Text;

namespace acessControl
{
    class Cadastro
    {
        private List<Usuario> usuarios;
        private List<Ambiente> ambientes;

        public Cadastro(List<Usuario> usuarios, List<Ambiente> ambientes)
        {
            this.usuarios = usuarios;
            this.ambientes = ambientes;
        }

        public Cadastro()
            : this(new List<Usuario>(), new List<Ambiente>())
        { }

        public List<Usuario> Usuarios
        {
            get { return usuarios; }
            set { usuarios = value; }
        }

        public List<Ambiente> Ambientes
        {
            get { return ambientes; }
            set { ambientes = value; }
        }


        public void adicionarUsuario(Usuario usuario)
        {
            this.usuarios.Add(usuario);
        }

        public Boolean removerUsuario(Usuario usuario)
        {
            if(this.usuarios.Exists(u=> u == usuario))
            {
                if(this.usuarios.Find(u =>u== usuario).Ambientes.Count == 0)
                {
                    return this.usuarios.Remove(usuario);
                } else { return false; }
                
            } else return false;
        }

        public Usuario pesquisarUsuario(Usuario usuario)
        {
            if (this.usuarios.Exists(u => u.Id == usuario.Id)) {
                usuario = this.usuarios.Find(u => u.Id == usuario.Id);
            } else usuario = new Usuario(-1, "");
            return usuario;
        }

        public void adicionarAmbiente(Ambiente ambiente)
        {
            this.ambientes.Add(ambiente);
        }

        public Boolean removerAmbiente(Ambiente ambiente)
        {
            if(this.ambientes.Exists(a => a.Id == ambiente.Id))
            {
                return this.ambientes.Remove(ambiente);
            } else return false;
        }

        public Ambiente pesquisarAmbiente(Ambiente ambiente)
        {
            if (this.ambientes.Exists(a => a.Id == ambiente.Id))
            {
                ambiente = this.ambientes.Find(a => a.Id == ambiente.Id);
            } else ambiente =  new Ambiente(-1, "")
            ;
            return ambiente;
        }

        public void upload()
        {

        }

        public void download()
        {

        }


    }
}

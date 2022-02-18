using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Prático.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaId(int id);
        public void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();

    }
}

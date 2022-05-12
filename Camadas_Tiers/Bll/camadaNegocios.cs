using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;

namespace Bll
{
    public class camadaNegocios
    {
        public DataSet obtemAlunos()
        {
            conOleDb acessoDados = new conOleDb();
            return acessoDados.retornaDataSet("select * from alunos");
        }
    }
}

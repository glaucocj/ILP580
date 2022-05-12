using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Dal
{
    public class conOleDb
    {
        OleDbConnection minhaConexaoDB = new OleDbConnection(Properties.Settings.Default.ScaCon);
    
        public void abrirConexao () 
            {
            minhaConexaoDB.Open ();
            }
        
        public void fecharConexao()
        {
            minhaConexaoDB.Close ();
        }

        public DataSet retornaDataSet (string sql)
        {
            try
            {
                abrirConexao();
                OleDbDataAdapter meuDataAdapter = new OleDbDataAdapter(sql,minhaConexaoDB);
                DataSet meuDataSet = new DataSet();
                meuDataAdapter.Fill (meuDataSet);
                fecharConexao();
                return meuDataSet;
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
    
    
    }

    

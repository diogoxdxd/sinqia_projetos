using Projeto02_AcessoDados.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto01_CadastroEscolas.RepositoryDao
{
    public sealed class Repository
    {
        static EscolasDao escolasDao;
        static CursosDao cursosDao;

        public static EscolasDao GetEscolasDao()
        {
            if(escolasDao == null)
            {
                escolasDao = new EscolasDao();
            }
            return escolasDao;
        }
        public static CursosDao GetCursosDao()
        {
            if(cursosDao == null)
            {
                cursosDao = new CursosDao();
            }
            return cursosDao;
        }



    }
}

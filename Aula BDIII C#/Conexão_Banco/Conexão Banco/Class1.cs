using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexão_Banco
{
    class Conecta
    {
        public static MysqlConnection con = new MysqlConnection
            ("server=dspwiii.mysql.dbaas.com.br; database=dspwiii; user=dspwiii; password=Dspw3@");

        public void Abrir()
        {
            con.Open();
        }


    }
}

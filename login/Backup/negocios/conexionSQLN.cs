using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using datos;

namespace negocios
{
    public class conexionSQLN
    {
        ConexionSQL cn = new ConexionSQL();

        public int conSQL(string DNI, string PATERNO)
        {
            return cn.consultalogin(DNI, PATERNO);
        }

        public int conSQL1(string USUARIO, string CONTRASENA)
        {
            return cn.consultalogin2(USUARIO, CONTRASENA);
        }
    }
}

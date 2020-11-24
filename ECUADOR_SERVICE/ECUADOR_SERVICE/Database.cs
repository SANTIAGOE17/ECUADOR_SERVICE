using System;
using System.Collections.Generic;
using System.Text;
//
using SQLite;

namespace Proyecto_Movil
{
    public interface Database
    {
        SQLiteAsyncConnection GetConnection();
    }
}

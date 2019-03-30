using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppCursos
{
   public class Database
    {
        SQLiteConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<Curso>();
        }

        public int InsertarCurso(Curso nuevoCurso)
        {
            return _database.Insert(nuevoCurso);
        }
    }
}


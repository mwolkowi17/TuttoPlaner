using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TuttoPlaner
{
   
        public interface ISQLiteDb
        {
            SQLiteAsyncConnection GetConnection();
        }
    
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary
{
    class StaffData
    {
        private readonly IDataAccess _db;
        public StaffData(IDataAccess db)
        {
            _db = db;
        }
    }
}

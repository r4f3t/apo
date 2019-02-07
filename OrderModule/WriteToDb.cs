using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule
{
    class WriteToDb
    {
        IMoveType _moveType;
        public WriteToDb(IMoveType moveType)
        {
            _moveType = moveType;
        }
        public void InsertToDb()
        {
            _moveType.MakeInsert();
        }
    }
}

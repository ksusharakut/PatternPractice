using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class MitoticCell: ICell
    {
        private string _state;
        public MitoticCell(string state)
        {
            _state = state;
        }

        public ICell Clone()
        {
            return new MitoticCell(_state);
        }

        // свойство для тестирования
        public string State
        {
            get { return _state; }
        }
    }
}

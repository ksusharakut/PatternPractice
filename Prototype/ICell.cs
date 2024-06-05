using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    // интерфейс устанавливает контракт для любого класса, который хочет поддерживать клонирование своих экземпляров
    public interface ICell
    {
        //void SetStatus(string status);
        //string GetStatus();
        ICell Clone();
    }
}

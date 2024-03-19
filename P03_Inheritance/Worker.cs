using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Inheritance
{
    internal class Worker : Person // Kalıtım olayı gerçekleşmiş oluyor.
    {
        // Person sınıfı içindeki tüm özellikler bir anlamda buraya tasınmış ve kullanılabilir oluyor.

        public int Maas { get; set; }
    }
}

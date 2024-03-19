using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Inheritance
{
    internal class SubTutorials : Tutorials
    {
        // Burası bir alt sınıf. Burada olmayan bir özelliği ve bunlara ek olarak diğer özellik ve metodları üst sınıfta olan (Tutorials) dan kalıtım yoluyla buraya tasıdım. Üst sınıftan miras aldım.

        public void DersAdiBelirle(string pNewName) 
        {
            TutorialName = pNewName;
        }
    }
}

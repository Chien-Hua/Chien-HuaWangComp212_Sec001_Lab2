using System;
using System.Text;
using System.Threading.Tasks;
using ChienHuaLibrary;

namespace ChienHua_LinkListTest
{
    class ListTest
    {
        static void Main()
        {
            var list = new List <double>();

            list.InsertAtFront(22.34);
            list.Display();
            list.InsertAtFront(44.23);
            list.Display();
            list.InsertAtBack(512.4410);
            list.Display();
            list.InsertAtBack(354.67);
            list.Display();
            list.Search(33.1);
            list.Count();
            list.Avg();
        }
    }
}
    

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueInheritanceLibrary;
using ChienHuaLibrary;

namespace QueueTest
{
    class QueueTest
    {

        static void Main()
        {
            QueueInheritance queue = new QueueInheritance();

            queue.Enqueue("Hua");
            queue.Display();
            queue.Enqueue("Mary");
            queue.Display();
            queue.Enqueue("Edward");
            queue.Display();
            queue.Enqueue("Sophia");
            queue.Display();

                   
        }
    }
}


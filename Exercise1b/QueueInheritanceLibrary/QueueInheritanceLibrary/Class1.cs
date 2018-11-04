using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChienHuaLibrary;

namespace QueueInheritanceLibrary
{
    public class QueueInheritance : List<string>
    {
        public QueueInheritance() : base("queue") { }
        public void Enqueue(string dataValue)
        {
            InsertAtBack(dataValue);
        }
        public object Dequeue()
        {
            return RemoveFromFront();
        }
    }
}
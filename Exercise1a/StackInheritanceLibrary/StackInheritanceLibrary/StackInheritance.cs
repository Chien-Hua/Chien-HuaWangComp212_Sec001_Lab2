using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChienHuaLibrary;

public class StackInheritance : List<double>
{
    public StackInheritance() : base("stack") { }

    public void Push(double dataValue)
    {
        InsertAtFront(dataValue);
    }

    public object Pop()
    {
        return RemoveFromFront();
    }
}


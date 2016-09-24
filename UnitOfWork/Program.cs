using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnitOfWork.DAL;
using UnitOfWork.Model;

namespace UnitOfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unit = new UnitOfWork.DAL.UnitOfWork(new PlutoContext()))
            {
                if (unit  == null)
                    Console.WriteLine("NULL");
                else
                    Console.WriteLine("NOT NULL");
               

            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EcommerceMod1.Models;

namespace EcommerceMod1.Classes_Genericas
{

    public class CombosHelper : IDisposable
    {
        private static EcommerceContext db = new EcommerceContext();

        public static IList<Departaments> GetDepartaments()
        {
            var departaments = db.Departaments.ToList();
            departaments.Add(new Departaments
            {
                DepartamentsId = 0,
                Name = "[ Selecione um departamento ]"
            });

           return departaments = departaments.OrderBy(x => x.Name).ToList();

        }



        public void Dispose()
        {
           db.Dispose();
        }
    }
}
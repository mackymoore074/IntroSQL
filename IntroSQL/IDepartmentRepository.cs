﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroSQL
{
    public interface IDepartmentRepository 
    {
        IEnumerable<Department> GetDepartment();
        void CreateDepartment(string Name);

    }
}

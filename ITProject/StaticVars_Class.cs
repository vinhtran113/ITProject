﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITProject
{
    internal class StaticVars_Class
    {
        public static string username = "EMP001";

        public static int employeePerShift;

        public static string emID = "EMP001";

        public static string shifttime;

        public static string closetime = "Not in working time";

        public static string[] loginstate = { "Idle", "Cheked-in", "Checked-out" };

        public static string state = loginstate[0];
    }
}

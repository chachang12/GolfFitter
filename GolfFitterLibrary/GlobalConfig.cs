﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GolfFitterLibrary.DataBaseAccess;

namespace GolfFitterLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(bool database)
        {
            // TODO - Set up SQL connector properly
            SQLConnector sql = new SQLConnector();
            Connection = (sql);
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

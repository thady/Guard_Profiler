using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Guard_profiler.App_code
{
	internal static class Set_Report_logons
	{
		private static string SQLConnection;

		private static SqlConnectionStringBuilder builder;

		static Set_Report_logons()
		{
			Set_Report_logons.SQLConnection = ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString();
			Set_Report_logons.builder = new SqlConnectionStringBuilder(Set_Report_logons.SQLConnection);
		}

        public static void SetTableLogin(CrystalDecisions.CrystalReports.Engine.Table table)
        {
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent = table.LogOnInfo;

            tliCurrent.ConnectionInfo.UserID = builder.UserID;
            tliCurrent.ConnectionInfo.Password = builder.Password;
            if (builder.InitialCatalog != null)
                tliCurrent.ConnectionInfo.DatabaseName = builder.InitialCatalog;
            if (builder.DataSource != null)
                tliCurrent.ConnectionInfo.ServerName = builder.DataSource;
            table.ApplyLogOnInfo(tliCurrent);
        }
    }
}
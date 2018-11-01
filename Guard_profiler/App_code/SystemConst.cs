using System;

namespace Guard_profiler.App_code
{
	internal static class SystemConst
	{
		public static string OfficerID;

		public static string OfficerName;

		public static string record_guid;

		public static string guard_number;

		public static string _branch;

		public static string _username;

		public static string _branch_name;

		public static string _Single_report_type;

		public static string _guard_status;

		public static string _Report_update_month;

		public static string _client_name;

		public static string _client_code;

		public static string _client_id;

		public static string _finance_report_type;

		public static string _station_code;

		public static string _station_name;

		public static string _finance_crystal_report_type;

		public static string _bank_branch;

		public static string _user_department;

		public static bool is_admin;

		public static string _active_deployment_id;

		public static DateTime _deployment_start_date;

		public static DateTime _deployment_end_date;

		public static string _client_codee;
        public static string _client_ids;

        public static string _client_location;

		public static string _fire_arm_serial;

		public static int _ammunition_count;

		public static string _shift_type;

		public static bool _is_leave_day_for_guard;

		public static bool _is_public_holiday;

		public static string _record_guid;

		public static string _guard_name;

        public static string finance_report_type;

		static SystemConst()
		{
			SystemConst.OfficerID = string.Empty;
			SystemConst.OfficerName = string.Empty;
			SystemConst.record_guid = string.Empty;
			SystemConst.guard_number = string.Empty;
			SystemConst._branch = string.Empty;
			SystemConst._username = string.Empty;
			SystemConst._branch_name = string.Empty;
			SystemConst._Single_report_type = string.Empty;
			SystemConst._guard_status = string.Empty;
			SystemConst._Report_update_month = string.Empty;
			SystemConst._client_name = string.Empty;
			SystemConst._client_code = string.Empty;
			SystemConst._client_id = string.Empty;
			SystemConst._finance_report_type = string.Empty;
			SystemConst._station_code = string.Empty;
			SystemConst._station_name = string.Empty;
			SystemConst._finance_crystal_report_type = string.Empty;
			SystemConst._bank_branch = string.Empty;
			SystemConst._user_department = string.Empty;
			SystemConst.is_admin = false;
			SystemConst._active_deployment_id = string.Empty;
			SystemConst._deployment_start_date = DateTime.Now;
			SystemConst._deployment_end_date = DateTime.Now;
			SystemConst._client_codee = string.Empty;
			SystemConst._client_location = string.Empty;
			SystemConst._fire_arm_serial = string.Empty;
			SystemConst._ammunition_count = 0;
			SystemConst._shift_type = string.Empty;
			SystemConst._is_leave_day_for_guard = false;
			SystemConst._is_public_holiday = false;
			SystemConst._record_guid = string.Empty;
			SystemConst._guard_name = string.Empty;
		}

		public static string Get_officer_branch()
		{
			return SystemConst._branch;
		}

		public static string GET_OfficerAutoID()
		{
			return SystemConst.record_guid;
		}

		public static string GET_OfficerID()
		{
			return SystemConst.OfficerID;
		}

		public static string GET_OfficerName()
		{
			return SystemConst.OfficerName;
		}

		public static string Get_Record_Guid()
		{
			return SystemConst.record_guid;
		}

		public static string Get_username()
		{
			return SystemConst._username;
		}
	}
}
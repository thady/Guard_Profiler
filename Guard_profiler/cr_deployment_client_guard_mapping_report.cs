using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;

namespace Guard_profiler
{
	public class cr_deployment_client_guard_mapping_report : ReportClass
	{
		public override string FullResourceName
		{
			get
			{
				return "Guard_profiler.cr_deployment_client_guard_mapping_report.rpt";
			}
			set
			{
			}
		}

		public override bool NewGenerator
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_client_code
		{
			get
			{
                return this.DataDefinition.ParameterFields[7];
            }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_date_from
		{
			get
			{
                return this.DataDefinition.ParameterFields[8];
            }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_date_to
		{
			get
			{
                return this.DataDefinition.ParameterFields[9];
            }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_deploy_date_from
		{
			get
			{
                return this.DataDefinition.ParameterFields[5];
            }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_deploy_date_to
		{
			get
			{
                return this.DataDefinition.ParameterFields[6];
            }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_deploy_period_id
		{
			get
			{
                return this.DataDefinition.ParameterFields[2];
            }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_guard_number
		{
			get
			{
                return this.DataDefinition.ParameterFields[1];
            }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_QueryName
		{
			get
			{
                return this.DataDefinition.ParameterFields[0];
            }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_station_code
		{
			get
			{
                return this.DataDefinition.ParameterFields[3];
            }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_station_name
		{
			get
			{
                return this.DataDefinition.ParameterFields[4];
            }
		}

		public override string ResourceName
		{
			get
			{
				return "cr_deployment_client_guard_mapping_report.rpt";
			}
			set
			{
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section1
		{
			get
			{
                return this.ReportDefinition.Sections[0];
            }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section2
		{
			get
			{
                return this.ReportDefinition.Sections[1];
            }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section3
		{
			get
			{
                return this.ReportDefinition.Sections[2];
            }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section4
		{
			get
			{
                return this.ReportDefinition.Sections[3];
            }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section5
		{
			get
			{
                return this.ReportDefinition.Sections[4];
            }
		}

		public cr_deployment_client_guard_mapping_report()
		{
		}
	}
}
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;

namespace Guard_profiler
{
	public class finance_bank_salary_payment_report : ReportClass
	{
		public override string FullResourceName
		{
			get
			{
				return "Guard_profiler.finance_bank_salary_payment_report.rpt";
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
		public IParameterField Parameter_bank_branch
		{
			get
			{
                return this.DataDefinition.ParameterFields[5];
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
				return "finance_bank_salary_payment_report.rpt";
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
                return this.ReportDefinition.Sections[5];
            }
		}

		public finance_bank_salary_payment_report()
		{
		}
	}
}
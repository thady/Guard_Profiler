using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;

namespace Guard_profiler
{
	public class cr_kampala_report : ReportClass
	{
		public override string FullResourceName
		{
			get
			{
				return "Guard_profiler.cr_kampala_report.rpt";
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
		public IParameterField Parameter_branch
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
		public IParameterField Parameter_update_month
		{
			get
			{
                return this.DataDefinition.ParameterFields[2];
            }
		}

		public override string ResourceName
		{
			get
			{
				return "cr_kampala_report.rpt";
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

		public cr_kampala_report()
		{
		}
	}
}
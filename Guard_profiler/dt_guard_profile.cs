using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Guard_profiler
{
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.DataSet")]
	[Serializable]
	[ToolboxItem(true)]
	[XmlRoot("dt_guard_profile")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	public class dt_guard_profile : DataSet
	{
		private dt_guard_profile.Q_OFFICER_REPORTDataTable tableQ_OFFICER_REPORT;

		private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dt_guard_profile.Q_OFFICER_REPORTDataTable Q_OFFICER_REPORT
		{
			get
			{
				return this.tableQ_OFFICER_REPORT;
			}
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		[Browsable(true)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override System.Data.SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this._schemaSerializationMode;
			}
			set
			{
				this._schemaSerializationMode = value;
			}
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dt_guard_profile()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler schemaChangedHandler = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += schemaChangedHandler;
			base.Relations.CollectionChanged += schemaChangedHandler;
			base.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected dt_guard_profile(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			if (base.IsBinarySerialized(info, context))
			{
				this.InitVars(false);
				CollectionChangeEventHandler schemaChangedHandler1 = new CollectionChangeEventHandler(this.SchemaChanged);
				this.Tables.CollectionChanged += schemaChangedHandler1;
				this.Relations.CollectionChanged += schemaChangedHandler1;
				return;
			}
			string strSchema = (string)info.GetValue("XmlSchema", typeof(string));
			if (base.DetermineSchemaSerializationMode(info, context) != System.Data.SchemaSerializationMode.IncludeSchema)
			{
				base.ReadXmlSchema(new XmlTextReader(new StringReader(strSchema)));
			}
			else
			{
				DataSet ds = new DataSet();
				ds.ReadXmlSchema(new XmlTextReader(new StringReader(strSchema)));
				if (ds.Tables["Q_OFFICER_REPORT"] != null)
				{
					base.Tables.Add(new dt_guard_profile.Q_OFFICER_REPORTDataTable(ds.Tables["Q_OFFICER_REPORT"]));
				}
				base.DataSetName = ds.DataSetName;
				base.Prefix = ds.Prefix;
				base.Namespace = ds.Namespace;
				base.Locale = ds.Locale;
				base.CaseSensitive = ds.CaseSensitive;
				base.EnforceConstraints = ds.EnforceConstraints;
				base.Merge(ds, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			base.GetSerializationData(info, context);
			CollectionChangeEventHandler schemaChangedHandler = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += schemaChangedHandler;
			this.Relations.CollectionChanged += schemaChangedHandler;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataSet Clone()
		{
			dt_guard_profile cln = (dt_guard_profile)base.Clone();
			cln.InitVars();
			cln.SchemaSerializationMode = this.SchemaSerializationMode;
			return cln;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream stream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(stream, null));
			stream.Position = (long)0;
			return XmlSchema.Read(new XmlTextReader(stream), null);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType;
			XmlSchema xmlSchema;
			dt_guard_profile ds = new dt_guard_profile();
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			XmlSchemaAny any = new XmlSchemaAny()
			{
				Namespace = ds.Namespace
			};
			sequence.Items.Add(any);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					XmlSchema schema = null;
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						schema = (XmlSchema)schemas.Current;
						s2.SetLength((long)0);
						schema.Write(s2);
						if (s1.Length != s2.Length)
						{
							continue;
						}
						s1.Position = (long)0;
						s2.Position = (long)0;
						while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
						{
						}
						if (s1.Position != s1.Length)
						{
							continue;
						}
						xmlSchemaComplexType = type;
						return xmlSchemaComplexType;
					}
					xmlSchema = xs.Add(dsSchema);
					return type;
				}
				finally
				{
					if (s1 != null)
					{
						s1.Close();
					}
					if (s2 != null)
					{
						s2.Close();
					}
				}
				return xmlSchemaComplexType;
			}
			xmlSchema = xs.Add(dsSchema);
			return type;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			base.DataSetName = "dt_guard_profile";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/dt_guard_profile.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.tableQ_OFFICER_REPORT = new dt_guard_profile.Q_OFFICER_REPORTDataTable();
			base.Tables.Add(this.tableQ_OFFICER_REPORT);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars(bool initTable)
		{
			this.tableQ_OFFICER_REPORT = (dt_guard_profile.Q_OFFICER_REPORTDataTable)base.Tables["Q_OFFICER_REPORT"];
			if (initTable && this.tableQ_OFFICER_REPORT != null)
			{
				this.tableQ_OFFICER_REPORT.InitVars();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) != System.Data.SchemaSerializationMode.IncludeSchema)
			{
				base.ReadXml(reader);
				this.InitVars();
				return;
			}
			this.Reset();
			DataSet ds = new DataSet();
			ds.ReadXml(reader);
			if (ds.Tables["Q_OFFICER_REPORT"] != null)
			{
				base.Tables.Add(new dt_guard_profile.Q_OFFICER_REPORTDataTable(ds.Tables["Q_OFFICER_REPORT"]));
			}
			base.DataSetName = ds.DataSetName;
			base.Prefix = ds.Prefix;
			base.Namespace = ds.Namespace;
			base.Locale = ds.Locale;
			base.CaseSensitive = ds.CaseSensitive;
			base.EnforceConstraints = ds.EnforceConstraints;
			base.Merge(ds, false, MissingSchemaAction.Add);
			this.InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeQ_OFFICER_REPORT()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class Q_OFFICER_REPORTDataTable : TypedTableBase<dt_guard_profile.Q_OFFICER_REPORTRow>
		{
			private DataColumn columnrecord_guid;

			private DataColumn columnguard_number;

			private DataColumn columnf_name;

			private DataColumn columnl_name;

			private DataColumn columnfull_name;

			private DataColumn columnphone;

			private DataColumn columnbranch;

			private DataColumn columnposition;

			private DataColumn columndepartment;

			private DataColumn columnregistered_date;

			private DataColumn columnbirth_place;

			private DataColumn columndob;

			private DataColumn columnage;

			private DataColumn columngender;

			private DataColumn columnhome_district;

			private DataColumn columnhome_county;

			private DataColumn columnhome_sub_county;

			private DataColumn columnhome_parish;

			private DataColumn columnhome_village_lc1;

			private DataColumn columnreligion;

			private DataColumn columnmarital_status;

			private DataColumn columnpartners_name;

			private DataColumn columncurrent_residence_district;

			private DataColumn columncurrent_residence_sub_county;

			private DataColumn columncurrent_residence_parish;

			private DataColumn columncurrent_residence_zone;

			private DataColumn columncurrent_landlord_name;

			private DataColumn columnfather_name;

			private DataColumn columnfather_district;

			private DataColumn columnfather_county;

			private DataColumn columnfather_village;

			private DataColumn columnfather_zone;

			private DataColumn columnprev_employer_name;

			private DataColumn columnprev_employer_address;

			private DataColumn columncause_of_departure;

			private DataColumn columntin_number;

			private DataColumn columnprevious_salary;

			private DataColumn columnstart_date;

			private DataColumn columninstitution_name;

			private DataColumn columnaward_name;

			private DataColumn columnstudy_start_date;

			private DataColumn columnstudy_end_date;

			private DataColumn columnrefferees;

			private DataColumn columnimage_data;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ageColumn
			{
				get
				{
					return this.columnage;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn award_nameColumn
			{
				get
				{
					return this.columnaward_name;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn birth_placeColumn
			{
				get
				{
					return this.columnbirth_place;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn branchColumn
			{
				get
				{
					return this.columnbranch;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn cause_of_departureColumn
			{
				get
				{
					return this.columncause_of_departure;
				}
			}

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn current_landlord_nameColumn
			{
				get
				{
					return this.columncurrent_landlord_name;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn current_residence_districtColumn
			{
				get
				{
					return this.columncurrent_residence_district;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn current_residence_parishColumn
			{
				get
				{
					return this.columncurrent_residence_parish;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn current_residence_sub_countyColumn
			{
				get
				{
					return this.columncurrent_residence_sub_county;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn current_residence_zoneColumn
			{
				get
				{
					return this.columncurrent_residence_zone;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn departmentColumn
			{
				get
				{
					return this.columndepartment;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dobColumn
			{
				get
				{
					return this.columndob;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn f_nameColumn
			{
				get
				{
					return this.columnf_name;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn father_countyColumn
			{
				get
				{
					return this.columnfather_county;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn father_districtColumn
			{
				get
				{
					return this.columnfather_district;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn father_nameColumn
			{
				get
				{
					return this.columnfather_name;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn father_villageColumn
			{
				get
				{
					return this.columnfather_village;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn father_zoneColumn
			{
				get
				{
					return this.columnfather_zone;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn full_nameColumn
			{
				get
				{
					return this.columnfull_name;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn genderColumn
			{
				get
				{
					return this.columngender;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn guard_numberColumn
			{
				get
				{
					return this.columnguard_number;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn home_countyColumn
			{
				get
				{
					return this.columnhome_county;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn home_districtColumn
			{
				get
				{
					return this.columnhome_district;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn home_parishColumn
			{
				get
				{
					return this.columnhome_parish;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn home_sub_countyColumn
			{
				get
				{
					return this.columnhome_sub_county;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn home_village_lc1Column
			{
				get
				{
					return this.columnhome_village_lc1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn image_dataColumn
			{
				get
				{
					return this.columnimage_data;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn institution_nameColumn
			{
				get
				{
					return this.columninstitution_name;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dt_guard_profile.Q_OFFICER_REPORTRow this[int index]
			{
				get
				{
					return (dt_guard_profile.Q_OFFICER_REPORTRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn l_nameColumn
			{
				get
				{
					return this.columnl_name;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn marital_statusColumn
			{
				get
				{
					return this.columnmarital_status;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn partners_nameColumn
			{
				get
				{
					return this.columnpartners_name;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn phoneColumn
			{
				get
				{
					return this.columnphone;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn positionColumn
			{
				get
				{
					return this.columnposition;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn prev_employer_addressColumn
			{
				get
				{
					return this.columnprev_employer_address;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn prev_employer_nameColumn
			{
				get
				{
					return this.columnprev_employer_name;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn previous_salaryColumn
			{
				get
				{
					return this.columnprevious_salary;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn record_guidColumn
			{
				get
				{
					return this.columnrecord_guid;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn reffereesColumn
			{
				get
				{
					return this.columnrefferees;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn registered_dateColumn
			{
				get
				{
					return this.columnregistered_date;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn religionColumn
			{
				get
				{
					return this.columnreligion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn start_dateColumn
			{
				get
				{
					return this.columnstart_date;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn study_end_dateColumn
			{
				get
				{
					return this.columnstudy_end_date;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn study_start_dateColumn
			{
				get
				{
					return this.columnstudy_start_date;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn tin_numberColumn
			{
				get
				{
					return this.columntin_number;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Q_OFFICER_REPORTDataTable()
			{
				base.TableName = "Q_OFFICER_REPORT";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Q_OFFICER_REPORTDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected Q_OFFICER_REPORTDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddQ_OFFICER_REPORTRow(dt_guard_profile.Q_OFFICER_REPORTRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dt_guard_profile.Q_OFFICER_REPORTRow AddQ_OFFICER_REPORTRow(string record_guid, string guard_number, string f_name, string l_name, string full_name, string phone, string branch, string position, string department, DateTime registered_date, string birth_place, DateTime dob, int age, string gender, string home_district, string home_county, string home_sub_county, string home_parish, string home_village_lc1, string religion, string marital_status, string partners_name, string current_residence_district, string current_residence_sub_county, string current_residence_parish, string current_residence_zone, string current_landlord_name, string father_name, string father_district, string father_county, string father_village, string father_zone, string prev_employer_name, string prev_employer_address, string cause_of_departure, string tin_number, string previous_salary, DateTime start_date, string institution_name, string award_name, DateTime study_start_date, DateTime study_end_date, string refferees, byte[] image_data)
			{
				dt_guard_profile.Q_OFFICER_REPORTRow rowQ_OFFICER_REPORTRow = (dt_guard_profile.Q_OFFICER_REPORTRow)base.NewRow();
				object[] recordGuid = new object[] { record_guid, guard_number, f_name, l_name, full_name, phone, branch, position, department, registered_date, birth_place, dob, age, gender, home_district, home_county, home_sub_county, home_parish, home_village_lc1, religion, marital_status, partners_name, current_residence_district, current_residence_sub_county, current_residence_parish, current_residence_zone, current_landlord_name, father_name, father_district, father_county, father_village, father_zone, prev_employer_name, prev_employer_address, cause_of_departure, tin_number, previous_salary, start_date, institution_name, award_name, study_start_date, study_end_date, refferees, image_data };
				rowQ_OFFICER_REPORTRow.ItemArray = recordGuid;
				base.Rows.Add(rowQ_OFFICER_REPORTRow);
				return rowQ_OFFICER_REPORTRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				dt_guard_profile.Q_OFFICER_REPORTDataTable cln = (dt_guard_profile.Q_OFFICER_REPORTDataTable)base.Clone();
				cln.InitVars();
				return cln;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new dt_guard_profile.Q_OFFICER_REPORTDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(dt_guard_profile.Q_OFFICER_REPORTRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchema xmlSchema;
				XmlSchemaComplexType type = new XmlSchemaComplexType();
				XmlSchemaSequence sequence = new XmlSchemaSequence();
				dt_guard_profile ds = new dt_guard_profile();
				XmlSchemaAny any1 = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				sequence.Items.Add(any1);
				XmlSchemaAny any2 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				sequence.Items.Add(any2);
				XmlSchemaAttribute attribute1 = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = ds.Namespace
				};
				type.Attributes.Add(attribute1);
				XmlSchemaAttribute attribute2 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "Q_OFFICER_REPORTDataTable"
				};
				type.Attributes.Add(attribute2);
				type.Particle = sequence;
				XmlSchema dsSchema = ds.GetSchemaSerializable();
				if (xs.Contains(dsSchema.TargetNamespace))
				{
					MemoryStream s1 = new MemoryStream();
					MemoryStream s2 = new MemoryStream();
					try
					{
						XmlSchema schema = null;
						dsSchema.Write(s1);
						IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
						while (schemas.MoveNext())
						{
							schema = (XmlSchema)schemas.Current;
							s2.SetLength((long)0);
							schema.Write(s2);
							if (s1.Length != s2.Length)
							{
								continue;
							}
							s1.Position = (long)0;
							s2.Position = (long)0;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position != s1.Length)
							{
								continue;
							}
							xmlSchemaComplexType = type;
							return xmlSchemaComplexType;
						}
						xmlSchema = xs.Add(dsSchema);
						return type;
					}
					finally
					{
						if (s1 != null)
						{
							s1.Close();
						}
						if (s2 != null)
						{
							s2.Close();
						}
					}
					return xmlSchemaComplexType;
				}
				xmlSchema = xs.Add(dsSchema);
				return type;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnrecord_guid = new DataColumn("record_guid", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnrecord_guid);
				this.columnguard_number = new DataColumn("guard_number", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnguard_number);
				this.columnf_name = new DataColumn("f_name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnf_name);
				this.columnl_name = new DataColumn("l_name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnl_name);
				this.columnfull_name = new DataColumn("full_name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnfull_name);
				this.columnphone = new DataColumn("phone", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnphone);
				this.columnbranch = new DataColumn("branch", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnbranch);
				this.columnposition = new DataColumn("position", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnposition);
				this.columndepartment = new DataColumn("department", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columndepartment);
				this.columnregistered_date = new DataColumn("registered_date", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnregistered_date);
				this.columnbirth_place = new DataColumn("birth_place", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnbirth_place);
				this.columndob = new DataColumn("dob", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columndob);
				this.columnage = new DataColumn("age", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnage);
				this.columngender = new DataColumn("gender", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columngender);
				this.columnhome_district = new DataColumn("home_district", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnhome_district);
				this.columnhome_county = new DataColumn("home_county", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnhome_county);
				this.columnhome_sub_county = new DataColumn("home_sub_county", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnhome_sub_county);
				this.columnhome_parish = new DataColumn("home_parish", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnhome_parish);
				this.columnhome_village_lc1 = new DataColumn("home_village_lc1", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnhome_village_lc1);
				this.columnreligion = new DataColumn("religion", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnreligion);
				this.columnmarital_status = new DataColumn("marital_status", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnmarital_status);
				this.columnpartners_name = new DataColumn("partners_name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnpartners_name);
				this.columncurrent_residence_district = new DataColumn("current_residence_district", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncurrent_residence_district);
				this.columncurrent_residence_sub_county = new DataColumn("current_residence_sub_county", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncurrent_residence_sub_county);
				this.columncurrent_residence_parish = new DataColumn("current_residence_parish", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncurrent_residence_parish);
				this.columncurrent_residence_zone = new DataColumn("current_residence_zone", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncurrent_residence_zone);
				this.columncurrent_landlord_name = new DataColumn("current_landlord_name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncurrent_landlord_name);
				this.columnfather_name = new DataColumn("father_name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnfather_name);
				this.columnfather_district = new DataColumn("father_district", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnfather_district);
				this.columnfather_county = new DataColumn("father_county", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnfather_county);
				this.columnfather_village = new DataColumn("father_village", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnfather_village);
				this.columnfather_zone = new DataColumn("father_zone", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnfather_zone);
				this.columnprev_employer_name = new DataColumn("prev_employer_name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnprev_employer_name);
				this.columnprev_employer_address = new DataColumn("prev_employer_address", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnprev_employer_address);
				this.columncause_of_departure = new DataColumn("cause_of_departure", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncause_of_departure);
				this.columntin_number = new DataColumn("tin_number", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columntin_number);
				this.columnprevious_salary = new DataColumn("previous_salary", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnprevious_salary);
				this.columnstart_date = new DataColumn("start_date", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnstart_date);
				this.columninstitution_name = new DataColumn("institution_name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columninstitution_name);
				this.columnaward_name = new DataColumn("award_name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnaward_name);
				this.columnstudy_start_date = new DataColumn("study_start_date", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnstudy_start_date);
				this.columnstudy_end_date = new DataColumn("study_end_date", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnstudy_end_date);
				this.columnrefferees = new DataColumn("refferees", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnrefferees);
				this.columnimage_data = new DataColumn("image_data", typeof(byte[]), null, MappingType.Element);
				base.Columns.Add(this.columnimage_data);
				this.columnrecord_guid.MaxLength = 100;
				this.columnguard_number.ReadOnly = true;
				this.columnguard_number.MaxLength = 2147483647;
				this.columnf_name.MaxLength = 100;
				this.columnl_name.MaxLength = 100;
				this.columnfull_name.MaxLength = 150;
				this.columnphone.MaxLength = 50;
				this.columnbranch.MaxLength = 100;
				this.columnposition.MaxLength = 50;
				this.columndepartment.MaxLength = 50;
				this.columnbirth_place.MaxLength = 50;
				this.columngender.MaxLength = 50;
				this.columnhome_district.MaxLength = 50;
				this.columnhome_county.MaxLength = 50;
				this.columnhome_sub_county.MaxLength = 50;
				this.columnhome_parish.MaxLength = 50;
				this.columnhome_village_lc1.MaxLength = 50;
				this.columnreligion.MaxLength = 50;
				this.columnmarital_status.MaxLength = 50;
				this.columnpartners_name.MaxLength = 100;
				this.columncurrent_residence_district.MaxLength = 50;
				this.columncurrent_residence_sub_county.MaxLength = 50;
				this.columncurrent_residence_parish.MaxLength = 50;
				this.columncurrent_residence_zone.MaxLength = 50;
				this.columncurrent_landlord_name.MaxLength = 100;
				this.columnfather_name.MaxLength = 100;
				this.columnfather_district.MaxLength = 50;
				this.columnfather_county.MaxLength = 50;
				this.columnfather_village.MaxLength = 50;
				this.columnfather_zone.MaxLength = 50;
				this.columnprev_employer_name.MaxLength = 100;
				this.columnprev_employer_address.MaxLength = 1073741823;
				this.columncause_of_departure.MaxLength = 100;
				this.columntin_number.MaxLength = 50;
				this.columnprevious_salary.MaxLength = 1073741823;
				this.columnstart_date.ReadOnly = true;
				this.columninstitution_name.MaxLength = 100;
				this.columnaward_name.MaxLength = 100;
				this.columnstudy_end_date.ReadOnly = true;
				this.columnrefferees.MaxLength = 1073741823;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnrecord_guid = base.Columns["record_guid"];
				this.columnguard_number = base.Columns["guard_number"];
				this.columnf_name = base.Columns["f_name"];
				this.columnl_name = base.Columns["l_name"];
				this.columnfull_name = base.Columns["full_name"];
				this.columnphone = base.Columns["phone"];
				this.columnbranch = base.Columns["branch"];
				this.columnposition = base.Columns["position"];
				this.columndepartment = base.Columns["department"];
				this.columnregistered_date = base.Columns["registered_date"];
				this.columnbirth_place = base.Columns["birth_place"];
				this.columndob = base.Columns["dob"];
				this.columnage = base.Columns["age"];
				this.columngender = base.Columns["gender"];
				this.columnhome_district = base.Columns["home_district"];
				this.columnhome_county = base.Columns["home_county"];
				this.columnhome_sub_county = base.Columns["home_sub_county"];
				this.columnhome_parish = base.Columns["home_parish"];
				this.columnhome_village_lc1 = base.Columns["home_village_lc1"];
				this.columnreligion = base.Columns["religion"];
				this.columnmarital_status = base.Columns["marital_status"];
				this.columnpartners_name = base.Columns["partners_name"];
				this.columncurrent_residence_district = base.Columns["current_residence_district"];
				this.columncurrent_residence_sub_county = base.Columns["current_residence_sub_county"];
				this.columncurrent_residence_parish = base.Columns["current_residence_parish"];
				this.columncurrent_residence_zone = base.Columns["current_residence_zone"];
				this.columncurrent_landlord_name = base.Columns["current_landlord_name"];
				this.columnfather_name = base.Columns["father_name"];
				this.columnfather_district = base.Columns["father_district"];
				this.columnfather_county = base.Columns["father_county"];
				this.columnfather_village = base.Columns["father_village"];
				this.columnfather_zone = base.Columns["father_zone"];
				this.columnprev_employer_name = base.Columns["prev_employer_name"];
				this.columnprev_employer_address = base.Columns["prev_employer_address"];
				this.columncause_of_departure = base.Columns["cause_of_departure"];
				this.columntin_number = base.Columns["tin_number"];
				this.columnprevious_salary = base.Columns["previous_salary"];
				this.columnstart_date = base.Columns["start_date"];
				this.columninstitution_name = base.Columns["institution_name"];
				this.columnaward_name = base.Columns["award_name"];
				this.columnstudy_start_date = base.Columns["study_start_date"];
				this.columnstudy_end_date = base.Columns["study_end_date"];
				this.columnrefferees = base.Columns["refferees"];
				this.columnimage_data = base.Columns["image_data"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dt_guard_profile.Q_OFFICER_REPORTRow NewQ_OFFICER_REPORTRow()
			{
				return (dt_guard_profile.Q_OFFICER_REPORTRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dt_guard_profile.Q_OFFICER_REPORTRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.Q_OFFICER_REPORTRowChanged != null)
				{
					this.Q_OFFICER_REPORTRowChanged(this, new dt_guard_profile.Q_OFFICER_REPORTRowChangeEvent((dt_guard_profile.Q_OFFICER_REPORTRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.Q_OFFICER_REPORTRowChanging != null)
				{
					this.Q_OFFICER_REPORTRowChanging(this, new dt_guard_profile.Q_OFFICER_REPORTRowChangeEvent((dt_guard_profile.Q_OFFICER_REPORTRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.Q_OFFICER_REPORTRowDeleted != null)
				{
					this.Q_OFFICER_REPORTRowDeleted(this, new dt_guard_profile.Q_OFFICER_REPORTRowChangeEvent((dt_guard_profile.Q_OFFICER_REPORTRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.Q_OFFICER_REPORTRowDeleting != null)
				{
					this.Q_OFFICER_REPORTRowDeleting(this, new dt_guard_profile.Q_OFFICER_REPORTRowChangeEvent((dt_guard_profile.Q_OFFICER_REPORTRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveQ_OFFICER_REPORTRow(dt_guard_profile.Q_OFFICER_REPORTRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dt_guard_profile.Q_OFFICER_REPORTRowChangeEventHandler Q_OFFICER_REPORTRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dt_guard_profile.Q_OFFICER_REPORTRowChangeEventHandler Q_OFFICER_REPORTRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dt_guard_profile.Q_OFFICER_REPORTRowChangeEventHandler Q_OFFICER_REPORTRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dt_guard_profile.Q_OFFICER_REPORTRowChangeEventHandler Q_OFFICER_REPORTRowDeleting;
		}

		public class Q_OFFICER_REPORTRow : DataRow
		{
			private dt_guard_profile.Q_OFFICER_REPORTDataTable tableQ_OFFICER_REPORT;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int age
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableQ_OFFICER_REPORT.ageColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'age' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.ageColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string award_name
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.award_nameColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'award_name' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.award_nameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string birth_place
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.birth_placeColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'birth_place' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.birth_placeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string branch
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.branchColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'branch' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.branchColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string cause_of_departure
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.cause_of_departureColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'cause_of_departure' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.cause_of_departureColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string current_landlord_name
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.current_landlord_nameColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'current_landlord_name' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.current_landlord_nameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string current_residence_district
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.current_residence_districtColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'current_residence_district' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.current_residence_districtColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string current_residence_parish
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.current_residence_parishColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'current_residence_parish' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.current_residence_parishColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string current_residence_sub_county
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.current_residence_sub_countyColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'current_residence_sub_county' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.current_residence_sub_countyColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string current_residence_zone
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.current_residence_zoneColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'current_residence_zone' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.current_residence_zoneColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string department
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.departmentColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'department' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.departmentColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime dob
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableQ_OFFICER_REPORT.dobColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'dob' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.dobColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string f_name
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.f_nameColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'f_name' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.f_nameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string father_county
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.father_countyColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'father_county' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.father_countyColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string father_district
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.father_districtColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'father_district' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.father_districtColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string father_name
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.father_nameColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'father_name' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.father_nameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string father_village
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.father_villageColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'father_village' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.father_villageColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string father_zone
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.father_zoneColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'father_zone' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.father_zoneColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string full_name
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.full_nameColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'full_name' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.full_nameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string gender
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.genderColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'gender' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.genderColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string guard_number
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.guard_numberColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'guard_number' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.guard_numberColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string home_county
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.home_countyColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'home_county' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.home_countyColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string home_district
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.home_districtColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'home_district' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.home_districtColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string home_parish
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.home_parishColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'home_parish' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.home_parishColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string home_sub_county
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.home_sub_countyColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'home_sub_county' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.home_sub_countyColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string home_village_lc1
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.home_village_lc1Column];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'home_village_lc1' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.home_village_lc1Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public byte[] image_data
			{
				get
				{
					byte[] item;
					try
					{
						item = (byte[])base[this.tableQ_OFFICER_REPORT.image_dataColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'image_data' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.image_dataColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string institution_name
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.institution_nameColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'institution_name' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.institution_nameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string l_name
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.l_nameColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'l_name' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.l_nameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string marital_status
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.marital_statusColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'marital_status' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.marital_statusColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string partners_name
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.partners_nameColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'partners_name' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.partners_nameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string phone
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.phoneColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'phone' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.phoneColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string position
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.positionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'position' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.positionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string prev_employer_address
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.prev_employer_addressColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'prev_employer_address' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.prev_employer_addressColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string prev_employer_name
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.prev_employer_nameColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'prev_employer_name' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.prev_employer_nameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string previous_salary
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.previous_salaryColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'previous_salary' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.previous_salaryColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string record_guid
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.record_guidColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'record_guid' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.record_guidColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string refferees
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.reffereesColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'refferees' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.reffereesColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime registered_date
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableQ_OFFICER_REPORT.registered_dateColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'registered_date' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.registered_dateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string religion
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.religionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'religion' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.religionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime start_date
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableQ_OFFICER_REPORT.start_dateColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'start_date' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.start_dateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime study_end_date
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableQ_OFFICER_REPORT.study_end_dateColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'study_end_date' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.study_end_dateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime study_start_date
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableQ_OFFICER_REPORT.study_start_dateColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'study_start_date' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.study_start_dateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string tin_number
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableQ_OFFICER_REPORT.tin_numberColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'tin_number' in table 'Q_OFFICER_REPORT' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableQ_OFFICER_REPORT.tin_numberColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Q_OFFICER_REPORTRow(DataRowBuilder rb) : base(rb)
			{
				this.tableQ_OFFICER_REPORT = (dt_guard_profile.Q_OFFICER_REPORTDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsageNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.ageColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isaward_nameNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.award_nameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isbirth_placeNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.birth_placeColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsbranchNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.branchColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iscause_of_departureNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.cause_of_departureColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iscurrent_landlord_nameNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.current_landlord_nameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iscurrent_residence_districtNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.current_residence_districtColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iscurrent_residence_parishNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.current_residence_parishColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iscurrent_residence_sub_countyNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.current_residence_sub_countyColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iscurrent_residence_zoneNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.current_residence_zoneColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdepartmentNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.departmentColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdobNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.dobColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isf_nameNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.f_nameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isfather_countyNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.father_countyColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isfather_districtNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.father_districtColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isfather_nameNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.father_nameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isfather_villageNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.father_villageColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isfather_zoneNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.father_zoneColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isfull_nameNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.full_nameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsgenderNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.genderColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isguard_numberNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.guard_numberColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Ishome_countyNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.home_countyColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Ishome_districtNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.home_districtColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Ishome_parishNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.home_parishColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Ishome_sub_countyNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.home_sub_countyColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Ishome_village_lc1Null()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.home_village_lc1Column);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isimage_dataNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.image_dataColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isinstitution_nameNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.institution_nameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isl_nameNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.l_nameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Ismarital_statusNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.marital_statusColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Ispartners_nameNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.partners_nameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsphoneNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.phoneColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IspositionNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.positionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isprev_employer_addressNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.prev_employer_addressColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isprev_employer_nameNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.prev_employer_nameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isprevious_salaryNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.previous_salaryColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isrecord_guidNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.record_guidColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsreffereesNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.reffereesColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isregistered_dateNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.registered_dateColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsreligionNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.religionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isstart_dateNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.start_dateColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isstudy_end_dateNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.study_end_dateColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isstudy_start_dateNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.study_start_dateColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Istin_numberNull()
			{
				return base.IsNull(this.tableQ_OFFICER_REPORT.tin_numberColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetageNull()
			{
				base[this.tableQ_OFFICER_REPORT.ageColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setaward_nameNull()
			{
				base[this.tableQ_OFFICER_REPORT.award_nameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setbirth_placeNull()
			{
				base[this.tableQ_OFFICER_REPORT.birth_placeColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetbranchNull()
			{
				base[this.tableQ_OFFICER_REPORT.branchColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setcause_of_departureNull()
			{
				base[this.tableQ_OFFICER_REPORT.cause_of_departureColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setcurrent_landlord_nameNull()
			{
				base[this.tableQ_OFFICER_REPORT.current_landlord_nameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setcurrent_residence_districtNull()
			{
				base[this.tableQ_OFFICER_REPORT.current_residence_districtColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setcurrent_residence_parishNull()
			{
				base[this.tableQ_OFFICER_REPORT.current_residence_parishColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setcurrent_residence_sub_countyNull()
			{
				base[this.tableQ_OFFICER_REPORT.current_residence_sub_countyColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setcurrent_residence_zoneNull()
			{
				base[this.tableQ_OFFICER_REPORT.current_residence_zoneColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdepartmentNull()
			{
				base[this.tableQ_OFFICER_REPORT.departmentColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdobNull()
			{
				base[this.tableQ_OFFICER_REPORT.dobColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setf_nameNull()
			{
				base[this.tableQ_OFFICER_REPORT.f_nameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setfather_countyNull()
			{
				base[this.tableQ_OFFICER_REPORT.father_countyColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setfather_districtNull()
			{
				base[this.tableQ_OFFICER_REPORT.father_districtColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setfather_nameNull()
			{
				base[this.tableQ_OFFICER_REPORT.father_nameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setfather_villageNull()
			{
				base[this.tableQ_OFFICER_REPORT.father_villageColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setfather_zoneNull()
			{
				base[this.tableQ_OFFICER_REPORT.father_zoneColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setfull_nameNull()
			{
				base[this.tableQ_OFFICER_REPORT.full_nameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetgenderNull()
			{
				base[this.tableQ_OFFICER_REPORT.genderColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setguard_numberNull()
			{
				base[this.tableQ_OFFICER_REPORT.guard_numberColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Sethome_countyNull()
			{
				base[this.tableQ_OFFICER_REPORT.home_countyColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Sethome_districtNull()
			{
				base[this.tableQ_OFFICER_REPORT.home_districtColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Sethome_parishNull()
			{
				base[this.tableQ_OFFICER_REPORT.home_parishColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Sethome_sub_countyNull()
			{
				base[this.tableQ_OFFICER_REPORT.home_sub_countyColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Sethome_village_lc1Null()
			{
				base[this.tableQ_OFFICER_REPORT.home_village_lc1Column] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setimage_dataNull()
			{
				base[this.tableQ_OFFICER_REPORT.image_dataColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setinstitution_nameNull()
			{
				base[this.tableQ_OFFICER_REPORT.institution_nameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setl_nameNull()
			{
				base[this.tableQ_OFFICER_REPORT.l_nameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setmarital_statusNull()
			{
				base[this.tableQ_OFFICER_REPORT.marital_statusColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setpartners_nameNull()
			{
				base[this.tableQ_OFFICER_REPORT.partners_nameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetphoneNull()
			{
				base[this.tableQ_OFFICER_REPORT.phoneColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetpositionNull()
			{
				base[this.tableQ_OFFICER_REPORT.positionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setprev_employer_addressNull()
			{
				base[this.tableQ_OFFICER_REPORT.prev_employer_addressColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setprev_employer_nameNull()
			{
				base[this.tableQ_OFFICER_REPORT.prev_employer_nameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setprevious_salaryNull()
			{
				base[this.tableQ_OFFICER_REPORT.previous_salaryColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setrecord_guidNull()
			{
				base[this.tableQ_OFFICER_REPORT.record_guidColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetreffereesNull()
			{
				base[this.tableQ_OFFICER_REPORT.reffereesColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setregistered_dateNull()
			{
				base[this.tableQ_OFFICER_REPORT.registered_dateColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetreligionNull()
			{
				base[this.tableQ_OFFICER_REPORT.religionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setstart_dateNull()
			{
				base[this.tableQ_OFFICER_REPORT.start_dateColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setstudy_end_dateNull()
			{
				base[this.tableQ_OFFICER_REPORT.study_end_dateColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setstudy_start_dateNull()
			{
				base[this.tableQ_OFFICER_REPORT.study_start_dateColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Settin_numberNull()
			{
				base[this.tableQ_OFFICER_REPORT.tin_numberColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class Q_OFFICER_REPORTRowChangeEvent : EventArgs
		{
			private dt_guard_profile.Q_OFFICER_REPORTRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dt_guard_profile.Q_OFFICER_REPORTRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Q_OFFICER_REPORTRowChangeEvent(dt_guard_profile.Q_OFFICER_REPORTRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Q_OFFICER_REPORTRowChangeEventHandler(object sender, dt_guard_profile.Q_OFFICER_REPORTRowChangeEvent e);
	}
}
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
	[XmlRoot("guard_profiles_dbDataSet")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	public class guard_profiles_dbDataSet : DataSet
	{
		private guard_profiles_dbDataSet.Tbl_sg_profilesDataTable tableTbl_sg_profiles;

		private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

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

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public guard_profiles_dbDataSet.Tbl_sg_profilesDataTable Tbl_sg_profiles
		{
			get
			{
				return this.tableTbl_sg_profiles;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public guard_profiles_dbDataSet()
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
		protected guard_profiles_dbDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (ds.Tables["Tbl_sg_profiles"] != null)
				{
					base.Tables.Add(new guard_profiles_dbDataSet.Tbl_sg_profilesDataTable(ds.Tables["Tbl_sg_profiles"]));
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
			guard_profiles_dbDataSet cln = (guard_profiles_dbDataSet)base.Clone();
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
			guard_profiles_dbDataSet ds = new guard_profiles_dbDataSet();
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
			base.DataSetName = "guard_profiles_dbDataSet";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/guard_profiles_dbDataSet.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.tableTbl_sg_profiles = new guard_profiles_dbDataSet.Tbl_sg_profilesDataTable();
			base.Tables.Add(this.tableTbl_sg_profiles);
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
			this.tableTbl_sg_profiles = (guard_profiles_dbDataSet.Tbl_sg_profilesDataTable)base.Tables["Tbl_sg_profiles"];
			if (initTable && this.tableTbl_sg_profiles != null)
			{
				this.tableTbl_sg_profiles.InitVars();
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
			if (ds.Tables["Tbl_sg_profiles"] != null)
			{
				base.Tables.Add(new guard_profiles_dbDataSet.Tbl_sg_profilesDataTable(ds.Tables["Tbl_sg_profiles"]));
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTbl_sg_profiles()
		{
			return false;
		}

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class Tbl_sg_profilesDataTable : TypedTableBase<guard_profiles_dbDataSet.Tbl_sg_profilesRow>
		{
			private DataColumn columnguard_number;

			private DataColumn columnfull_name;

			private DataColumn columnbranch;

			private DataColumn columnregistered_date;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn branchColumn
			{
				get
				{
					return this.columnbranch;
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
			public DataColumn full_nameColumn
			{
				get
				{
					return this.columnfull_name;
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
			public guard_profiles_dbDataSet.Tbl_sg_profilesRow this[int index]
			{
				get
				{
					return (guard_profiles_dbDataSet.Tbl_sg_profilesRow)base.Rows[index];
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
			public Tbl_sg_profilesDataTable()
			{
				base.TableName = "Tbl_sg_profiles";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Tbl_sg_profilesDataTable(DataTable table)
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
			protected Tbl_sg_profilesDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTbl_sg_profilesRow(guard_profiles_dbDataSet.Tbl_sg_profilesRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public guard_profiles_dbDataSet.Tbl_sg_profilesRow AddTbl_sg_profilesRow(string guard_number, string full_name, string branch, DateTime registered_date)
			{
				guard_profiles_dbDataSet.Tbl_sg_profilesRow rowTbl_sg_profilesRow = (guard_profiles_dbDataSet.Tbl_sg_profilesRow)base.NewRow();
				object[] guardNumber = new object[] { guard_number, full_name, branch, registered_date };
				rowTbl_sg_profilesRow.ItemArray = guardNumber;
				base.Rows.Add(rowTbl_sg_profilesRow);
				return rowTbl_sg_profilesRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				guard_profiles_dbDataSet.Tbl_sg_profilesDataTable cln = (guard_profiles_dbDataSet.Tbl_sg_profilesDataTable)base.Clone();
				cln.InitVars();
				return cln;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new guard_profiles_dbDataSet.Tbl_sg_profilesDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(guard_profiles_dbDataSet.Tbl_sg_profilesRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchema xmlSchema;
				XmlSchemaComplexType type = new XmlSchemaComplexType();
				XmlSchemaSequence sequence = new XmlSchemaSequence();
				guard_profiles_dbDataSet ds = new guard_profiles_dbDataSet();
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
					FixedValue = "Tbl_sg_profilesDataTable"
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
				this.columnguard_number = new DataColumn("guard_number", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnguard_number);
				this.columnfull_name = new DataColumn("full_name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnfull_name);
				this.columnbranch = new DataColumn("branch", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnbranch);
				this.columnregistered_date = new DataColumn("registered_date", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnregistered_date);
				this.columnguard_number.ReadOnly = true;
				this.columnguard_number.MaxLength = 2147483647;
				this.columnfull_name.MaxLength = 150;
				this.columnbranch.MaxLength = 100;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnguard_number = base.Columns["guard_number"];
				this.columnfull_name = base.Columns["full_name"];
				this.columnbranch = base.Columns["branch"];
				this.columnregistered_date = base.Columns["registered_date"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new guard_profiles_dbDataSet.Tbl_sg_profilesRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public guard_profiles_dbDataSet.Tbl_sg_profilesRow NewTbl_sg_profilesRow()
			{
				return (guard_profiles_dbDataSet.Tbl_sg_profilesRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.Tbl_sg_profilesRowChanged != null)
				{
					this.Tbl_sg_profilesRowChanged(this, new guard_profiles_dbDataSet.Tbl_sg_profilesRowChangeEvent((guard_profiles_dbDataSet.Tbl_sg_profilesRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.Tbl_sg_profilesRowChanging != null)
				{
					this.Tbl_sg_profilesRowChanging(this, new guard_profiles_dbDataSet.Tbl_sg_profilesRowChangeEvent((guard_profiles_dbDataSet.Tbl_sg_profilesRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.Tbl_sg_profilesRowDeleted != null)
				{
					this.Tbl_sg_profilesRowDeleted(this, new guard_profiles_dbDataSet.Tbl_sg_profilesRowChangeEvent((guard_profiles_dbDataSet.Tbl_sg_profilesRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.Tbl_sg_profilesRowDeleting != null)
				{
					this.Tbl_sg_profilesRowDeleting(this, new guard_profiles_dbDataSet.Tbl_sg_profilesRowChangeEvent((guard_profiles_dbDataSet.Tbl_sg_profilesRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTbl_sg_profilesRow(guard_profiles_dbDataSet.Tbl_sg_profilesRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event guard_profiles_dbDataSet.Tbl_sg_profilesRowChangeEventHandler Tbl_sg_profilesRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event guard_profiles_dbDataSet.Tbl_sg_profilesRowChangeEventHandler Tbl_sg_profilesRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event guard_profiles_dbDataSet.Tbl_sg_profilesRowChangeEventHandler Tbl_sg_profilesRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event guard_profiles_dbDataSet.Tbl_sg_profilesRowChangeEventHandler Tbl_sg_profilesRowDeleting;
		}

		public class Tbl_sg_profilesRow : DataRow
		{
			private guard_profiles_dbDataSet.Tbl_sg_profilesDataTable tableTbl_sg_profiles;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string branch
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTbl_sg_profiles.branchColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'branch' in table 'Tbl_sg_profiles' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTbl_sg_profiles.branchColumn] = value;
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
						item = (string)base[this.tableTbl_sg_profiles.full_nameColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'full_name' in table 'Tbl_sg_profiles' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTbl_sg_profiles.full_nameColumn] = value;
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
						item = (string)base[this.tableTbl_sg_profiles.guard_numberColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'guard_number' in table 'Tbl_sg_profiles' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTbl_sg_profiles.guard_numberColumn] = value;
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
						item = (DateTime)base[this.tableTbl_sg_profiles.registered_dateColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'registered_date' in table 'Tbl_sg_profiles' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTbl_sg_profiles.registered_dateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Tbl_sg_profilesRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTbl_sg_profiles = (guard_profiles_dbDataSet.Tbl_sg_profilesDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsbranchNull()
			{
				return base.IsNull(this.tableTbl_sg_profiles.branchColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isfull_nameNull()
			{
				return base.IsNull(this.tableTbl_sg_profiles.full_nameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isguard_numberNull()
			{
				return base.IsNull(this.tableTbl_sg_profiles.guard_numberColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isregistered_dateNull()
			{
				return base.IsNull(this.tableTbl_sg_profiles.registered_dateColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetbranchNull()
			{
				base[this.tableTbl_sg_profiles.branchColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setfull_nameNull()
			{
				base[this.tableTbl_sg_profiles.full_nameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setguard_numberNull()
			{
				base[this.tableTbl_sg_profiles.guard_numberColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setregistered_dateNull()
			{
				base[this.tableTbl_sg_profiles.registered_dateColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class Tbl_sg_profilesRowChangeEvent : EventArgs
		{
			private guard_profiles_dbDataSet.Tbl_sg_profilesRow eventRow;

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
			public guard_profiles_dbDataSet.Tbl_sg_profilesRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Tbl_sg_profilesRowChangeEvent(guard_profiles_dbDataSet.Tbl_sg_profilesRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Tbl_sg_profilesRowChangeEventHandler(object sender, guard_profiles_dbDataSet.Tbl_sg_profilesRowChangeEvent e);
	}
}
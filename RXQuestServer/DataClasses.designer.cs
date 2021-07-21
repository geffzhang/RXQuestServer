﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RFTechnology
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AHRFKJ")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    #endregion
		
		public DataClassesDataContext() : 
				base(global::RFTechnology.Properties.Settings.Default.AHRFKJConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<UserComputerData> UserComputerData
		{
			get
			{
				return this.GetTable<UserComputerData>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CheckComputerWithRegInformation")]
		public int CheckComputerWithRegInformation([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserNetBoardID", DbType="NVarChar(128)")] string userNetBoardID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userNetBoardID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdataUserLogTime")]
		public int UpdataUserLogTime([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserNetBoardID", DbType="NVarChar(128)")] string userNetBoardID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userNetBoardID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetDbAllDataWithCurrentPC")]
		public int GetDbAllDataWithCurrentPC([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserNetBoardID", DbType="NVarChar(128)")] string userNetBoardID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="KeyCode", DbType="NVarChar(128)")] ref string keyCode, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CreateTime", DbType="DateTime")] ref System.Nullable<System.DateTime> createTime, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RegPayFinishedTime", DbType="DateTime")] ref System.Nullable<System.DateTime> regPayFinishedTime, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastLogTime", DbType="DateTime")] ref System.Nullable<System.DateTime> lastLogTime, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RegPayDays", DbType="Int")] ref System.Nullable<int> regPayDays)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userNetBoardID, keyCode, createTime, regPayFinishedTime, lastLogTime, regPayDays);
			keyCode = ((string)(result.GetParameterValue(1)));
			createTime = ((System.Nullable<System.DateTime>)(result.GetParameterValue(2)));
			regPayFinishedTime = ((System.Nullable<System.DateTime>)(result.GetParameterValue(3)));
			lastLogTime = ((System.Nullable<System.DateTime>)(result.GetParameterValue(4)));
			regPayDays = ((System.Nullable<int>)(result.GetParameterValue(5)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CreateNewReginformation")]
		public int CreateNewReginformation([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ComputerName", DbType="NVarChar(128)")] string computerName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NetBoardID", DbType="NVarChar(128)")] string netBoardID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="BIOSID", DbType="NVarChar(128)")] string bIOSID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CPUID", DbType="NVarChar(MAX)")] string cPUID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DiskID", DbType="NVarChar(MAX)")] string diskID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="BoardID", DbType="NVarChar(128)")] string boardID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="KeyCode", DbType="NVarChar(128)")] string keyCode, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SubmitTime", DbType="DateTime")] System.Nullable<System.DateTime> submitTime)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), computerName, netBoardID, bIOSID, cPUID, diskID, boardID, keyCode, submitTime);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserComputerData")]
	public partial class UserComputerData
	{
		
		private string _NetID;
		
		private string _CPUID;
		
		private string _BoardID;
		
		private string _BIOSID;
		
		private string _DiskID;
		
		public UserComputerData()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NetID", DbType="NVarChar(128)")]
		public string NetID
		{
			get
			{
				return this._NetID;
			}
			set
			{
				if ((this._NetID != value))
				{
					this._NetID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPUID", DbType="NChar(50)")]
		public string CPUID
		{
			get
			{
				return this._CPUID;
			}
			set
			{
				if ((this._CPUID != value))
				{
					this._CPUID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BoardID", DbType="NChar(50)")]
		public string BoardID
		{
			get
			{
				return this._BoardID;
			}
			set
			{
				if ((this._BoardID != value))
				{
					this._BoardID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BIOSID", DbType="NChar(50)")]
		public string BIOSID
		{
			get
			{
				return this._BIOSID;
			}
			set
			{
				if ((this._BIOSID != value))
				{
					this._BIOSID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiskID", DbType="NChar(50)")]
		public string DiskID
		{
			get
			{
				return this._DiskID;
			}
			set
			{
				if ((this._DiskID != value))
				{
					this._DiskID = value;
				}
			}
		}
	}
}
#pragma warning restore 1591

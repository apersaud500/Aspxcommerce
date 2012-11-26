﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SageFrame.ErrorLog
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="SageFrame")]
	public partial class ErrorLogDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public ErrorLogDataContext() :
        base(global::SageFrame.Core.Properties.Settings.Default.TempforSpConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ErrorLogDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ErrorLogDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ErrorLogDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ErrorLogDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[Function(Name="dbo.sp_LogClear")]
		public int sp_LogClear([Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), portalID);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_LogDelete")]
		public int sp_LogDelete([Parameter(Name="LogID", DbType="Int")] System.Nullable<int> logID, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), logID, portalID);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_LogDeleteByLogID")]
		public int sp_LogDeleteByLogID([Parameter(Name="LogID", DbType="Int")] System.Nullable<int> logID, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="DeletedBy", DbType="NVarChar(256)")] string deletedBy)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), logID, portalID, deletedBy);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_LogInsert")]
		public int sp_LogInsert([Parameter(Name="LogID", DbType="Int")] ref System.Nullable<int> logID, [Parameter(Name="LogTypeID", DbType="Int")] System.Nullable<int> logTypeID, [Parameter(Name="Severity", DbType="Int")] System.Nullable<int> severity, [Parameter(Name="Message", DbType="NVarChar(1000)")] string message, [Parameter(Name="Exception", DbType="NVarChar(4000)")] string exception, [Parameter(Name="ClientIPAddress", DbType="NVarChar(100)")] string clientIPAddress, [Parameter(Name="PageURL", DbType="NVarChar(100)")] string pageURL, [Parameter(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="AddedBy", DbType="NVarChar(256)")] string addedBy)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), logID, logTypeID, severity, message, exception, clientIPAddress, pageURL, isActive, portalID, addedBy);
			logID = ((System.Nullable<int>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_LogLoadAll")]
		public ISingleResult<sp_LogLoadAllResult> sp_LogLoadAll([Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), portalID);
			return ((ISingleResult<sp_LogLoadAllResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_LogLoadByLogID")]
		public int sp_LogLoadByLogID([Parameter(Name="LogID", DbType="Int")] System.Nullable<int> logID, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), logID, portalID);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_LogType")]
		public ISingleResult<sp_LogTypeResult> sp_LogType()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_LogTypeResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_LogView")]
		public ISingleResult<sp_LogViewResult> sp_LogView([Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="LogType", DbType="NVarChar(256)")] string logType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), portalID, logType);
			return ((ISingleResult<sp_LogViewResult>)(result.ReturnValue));
		}

        public void sp_LogDelete(string ID, int p)
        {
            throw new NotImplementedException();
        }
    }
	
	public partial class sp_LogLoadAllResult
	{
		
		private int _LogID;
		
		private int _LogTypeID;
		
		private int _Severity;
		
		private string _Message;
		
		private string _Exception;
		
		private string _ClientIPAddress;
		
		private string _PageURL;
		
		private System.Nullable<System.DateTime> _AddedOn;
		
		private System.Nullable<int> _PortalID;
		
		private string _Name;
		
		public sp_LogLoadAllResult()
		{
		}
		
		[Column(Storage="_LogID", DbType="Int NOT NULL")]
		public int LogID
		{
			get
			{
				return this._LogID;
			}
			set
			{
				if ((this._LogID != value))
				{
					this._LogID = value;
				}
			}
		}
		
		[Column(Storage="_LogTypeID", DbType="Int NOT NULL")]
		public int LogTypeID
		{
			get
			{
				return this._LogTypeID;
			}
			set
			{
				if ((this._LogTypeID != value))
				{
					this._LogTypeID = value;
				}
			}
		}
		
		[Column(Storage="_Severity", DbType="Int NOT NULL")]
		public int Severity
		{
			get
			{
				return this._Severity;
			}
			set
			{
				if ((this._Severity != value))
				{
					this._Severity = value;
				}
			}
		}
		
		[Column(Storage="_Message", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
		public string Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				if ((this._Message != value))
				{
					this._Message = value;
				}
			}
		}
		
		[Column(Storage="_Exception", DbType="NVarChar(4000) NOT NULL", CanBeNull=false)]
		public string Exception
		{
			get
			{
				return this._Exception;
			}
			set
			{
				if ((this._Exception != value))
				{
					this._Exception = value;
				}
			}
		}
		
		[Column(Storage="_ClientIPAddress", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string ClientIPAddress
		{
			get
			{
				return this._ClientIPAddress;
			}
			set
			{
				if ((this._ClientIPAddress != value))
				{
					this._ClientIPAddress = value;
				}
			}
		}
		
		[Column(Storage="_PageURL", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string PageURL
		{
			get
			{
				return this._PageURL;
			}
			set
			{
				if ((this._PageURL != value))
				{
					this._PageURL = value;
				}
			}
		}
		
		[Column(Storage="_AddedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> AddedOn
		{
			get
			{
				return this._AddedOn;
			}
			set
			{
				if ((this._AddedOn != value))
				{
					this._AddedOn = value;
				}
			}
		}
		
		[Column(Storage="_PortalID", DbType="Int")]
		public System.Nullable<int> PortalID
		{
			get
			{
				return this._PortalID;
			}
			set
			{
				if ((this._PortalID != value))
				{
					this._PortalID = value;
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
	}
	
	public partial class sp_LogTypeResult
	{
		
		private int _LogTypeID;
		
		private string _Name;
		
		public sp_LogTypeResult()
		{
		}
		
		[Column(Storage="_LogTypeID", DbType="Int NOT NULL")]
		public int LogTypeID
		{
			get
			{
				return this._LogTypeID;
			}
			set
			{
				if ((this._LogTypeID != value))
				{
					this._LogTypeID = value;
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
	}
	
	public partial class sp_LogViewResult
	{
		
		private int _LogTypeID;
		
		private string _LogTypeName;
		
		private int _LogID;
		
		private string _ClientIPAddress;
		
		private System.Nullable<System.DateTime> _AddedOn;
		
		private string _Exception;
		
		private string _PageURL;
		
		private string _PortalName;
		
		public sp_LogViewResult()
		{
		}
		
		[Column(Storage="_LogTypeID", DbType="Int NOT NULL")]
		public int LogTypeID
		{
			get
			{
				return this._LogTypeID;
			}
			set
			{
				if ((this._LogTypeID != value))
				{
					this._LogTypeID = value;
				}
			}
		}
		
		[Column(Storage="_LogTypeName", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
		public string LogTypeName
		{
			get
			{
				return this._LogTypeName;
			}
			set
			{
				if ((this._LogTypeName != value))
				{
					this._LogTypeName = value;
				}
			}
		}
		
		[Column(Storage="_LogID", DbType="Int NOT NULL")]
		public int LogID
		{
			get
			{
				return this._LogID;
			}
			set
			{
				if ((this._LogID != value))
				{
					this._LogID = value;
				}
			}
		}
		
		[Column(Storage="_ClientIPAddress", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string ClientIPAddress
		{
			get
			{
				return this._ClientIPAddress;
			}
			set
			{
				if ((this._ClientIPAddress != value))
				{
					this._ClientIPAddress = value;
				}
			}
		}
		
		[Column(Storage="_AddedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> AddedOn
		{
			get
			{
				return this._AddedOn;
			}
			set
			{
				if ((this._AddedOn != value))
				{
					this._AddedOn = value;
				}
			}
		}
		
		[Column(Storage="_Exception", DbType="NVarChar(4000) NOT NULL", CanBeNull=false)]
		public string Exception
		{
			get
			{
				return this._Exception;
			}
			set
			{
				if ((this._Exception != value))
				{
					this._Exception = value;
				}
			}
		}
		
		[Column(Storage="_PageURL", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string PageURL
		{
			get
			{
				return this._PageURL;
			}
			set
			{
				if ((this._PageURL != value))
				{
					this._PageURL = value;
				}
			}
		}
		
		[Column(Storage="_PortalName", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string PortalName
		{
			get
			{
				return this._PortalName;
			}
			set
			{
				if ((this._PortalName != value))
				{
					this._PortalName = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
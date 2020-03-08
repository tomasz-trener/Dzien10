﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P03PodgladZapytania
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="A_Zawodnicy")]
	public partial class ModelBazyDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertZawodnik(Zawodnik instance);
    partial void UpdateZawodnik(Zawodnik instance);
    partial void DeleteZawodnik(Zawodnik instance);
    #endregion
		
		public ModelBazyDataContext() : 
				base(global::P03PodgladZapytania.Properties.Settings.Default.A_ZawodnicyConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ModelBazyDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModelBazyDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModelBazyDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModelBazyDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Zawodnik> Zawodnik
		{
			get
			{
				return this.GetTable<Zawodnik>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.zawodnicy")]
	public partial class Zawodnik : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_zawodnika;
		
		private System.Nullable<int> _id_trenera;
		
		private string _imie;
		
		private string _nazwisko;
		
		private string _kraj;
		
		private System.Nullable<System.DateTime> _data_ur;
		
		private System.Nullable<int> _wzrost;
		
		private System.Nullable<int> _waga;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_zawodnikaChanging(int value);
    partial void Onid_zawodnikaChanged();
    partial void Onid_treneraChanging(System.Nullable<int> value);
    partial void Onid_treneraChanged();
    partial void OnimieChanging(string value);
    partial void OnimieChanged();
    partial void OnnazwiskoChanging(string value);
    partial void OnnazwiskoChanged();
    partial void OnkrajChanging(string value);
    partial void OnkrajChanged();
    partial void Ondata_urChanging(System.Nullable<System.DateTime> value);
    partial void Ondata_urChanged();
    partial void OnwzrostChanging(System.Nullable<int> value);
    partial void OnwzrostChanged();
    partial void OnwagaChanging(System.Nullable<int> value);
    partial void OnwagaChanged();
    #endregion
		
		public Zawodnik()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_zawodnika", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_zawodnika
		{
			get
			{
				return this._id_zawodnika;
			}
			set
			{
				if ((this._id_zawodnika != value))
				{
					this.Onid_zawodnikaChanging(value);
					this.SendPropertyChanging();
					this._id_zawodnika = value;
					this.SendPropertyChanged("id_zawodnika");
					this.Onid_zawodnikaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_trenera", DbType="Int")]
		public System.Nullable<int> id_trenera
		{
			get
			{
				return this._id_trenera;
			}
			set
			{
				if ((this._id_trenera != value))
				{
					this.Onid_treneraChanging(value);
					this.SendPropertyChanging();
					this._id_trenera = value;
					this.SendPropertyChanged("id_trenera");
					this.Onid_treneraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imie", DbType="VarChar(255)")]
		public string imie
		{
			get
			{
				return this._imie;
			}
			set
			{
				if ((this._imie != value))
				{
					this.OnimieChanging(value);
					this.SendPropertyChanging();
					this._imie = value;
					this.SendPropertyChanged("imie");
					this.OnimieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nazwisko", DbType="VarChar(255)")]
		public string nazwisko
		{
			get
			{
				return this._nazwisko;
			}
			set
			{
				if ((this._nazwisko != value))
				{
					this.OnnazwiskoChanging(value);
					this.SendPropertyChanging();
					this._nazwisko = value;
					this.SendPropertyChanged("nazwisko");
					this.OnnazwiskoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kraj", DbType="VarChar(255)")]
		public string kraj
		{
			get
			{
				return this._kraj;
			}
			set
			{
				if ((this._kraj != value))
				{
					this.OnkrajChanging(value);
					this.SendPropertyChanging();
					this._kraj = value;
					this.SendPropertyChanged("kraj");
					this.OnkrajChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_ur", DbType="DateTime")]
		public System.Nullable<System.DateTime> data_ur
		{
			get
			{
				return this._data_ur;
			}
			set
			{
				if ((this._data_ur != value))
				{
					this.Ondata_urChanging(value);
					this.SendPropertyChanging();
					this._data_ur = value;
					this.SendPropertyChanged("data_ur");
					this.Ondata_urChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wzrost", DbType="Int")]
		public System.Nullable<int> wzrost
		{
			get
			{
				return this._wzrost;
			}
			set
			{
				if ((this._wzrost != value))
				{
					this.OnwzrostChanging(value);
					this.SendPropertyChanging();
					this._wzrost = value;
					this.SendPropertyChanged("wzrost");
					this.OnwzrostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_waga", DbType="Int")]
		public System.Nullable<int> waga
		{
			get
			{
				return this._waga;
			}
			set
			{
				if ((this._waga != value))
				{
					this.OnwagaChanging(value);
					this.SendPropertyChanging();
					this._waga = value;
					this.SendPropertyChanged("waga");
					this.OnwagaChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591

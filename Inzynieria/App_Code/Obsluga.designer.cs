﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="hotels")]
public partial class ObslugaDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertGroup(Group instance);
  partial void UpdateGroup(Group instance);
  partial void DeleteGroup(Group instance);
  partial void InsertRezerwacje(Rezerwacje instance);
  partial void UpdateRezerwacje(Rezerwacje instance);
  partial void DeleteRezerwacje(Rezerwacje instance);
  partial void InsertPokoj_opi(Pokoj_opi instance);
  partial void UpdatePokoj_opi(Pokoj_opi instance);
  partial void DeletePokoj_opi(Pokoj_opi instance);
  partial void InsertRachunek(Rachunek instance);
  partial void UpdateRachunek(Rachunek instance);
  partial void DeleteRachunek(Rachunek instance);
  partial void InsertUslugi(Uslugi instance);
  partial void UpdateUslugi(Uslugi instance);
  partial void DeleteUslugi(Uslugi instance);
  partial void InsertUser(User instance);
  partial void UpdateUser(User instance);
  partial void DeleteUser(User instance);
  partial void InsertPokoje(Pokoje instance);
  partial void UpdatePokoje(Pokoje instance);
  partial void DeletePokoje(Pokoje instance);
  #endregion
	
	public ObslugaDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["hotelsConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public ObslugaDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public ObslugaDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public ObslugaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public ObslugaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Group> Groups
	{
		get
		{
			return this.GetTable<Group>();
		}
	}
	
	public System.Data.Linq.Table<Rezerwacje> Rezerwacjes
	{
		get
		{
			return this.GetTable<Rezerwacje>();
		}
	}
	
	public System.Data.Linq.Table<Pokoj_opi> Pokoj_opis
	{
		get
		{
			return this.GetTable<Pokoj_opi>();
		}
	}
	
	public System.Data.Linq.Table<Rachunek> Rachuneks
	{
		get
		{
			return this.GetTable<Rachunek>();
		}
	}
	
	public System.Data.Linq.Table<Uslugi> Uslugis
	{
		get
		{
			return this.GetTable<Uslugi>();
		}
	}
	
	public System.Data.Linq.Table<User> Users
	{
		get
		{
			return this.GetTable<User>();
		}
	}
	
	public System.Data.Linq.Table<Pokoje> Pokojes
	{
		get
		{
			return this.GetTable<Pokoje>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Group]")]
public partial class Group : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Name;
	
	private EntitySet<User> _Users;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
	
	public Group()
	{
		this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(10)")]
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
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Group_User", Storage="_Users", ThisKey="Id", OtherKey="Group_id")]
	public EntitySet<User> Users
	{
		get
		{
			return this._Users;
		}
		set
		{
			this._Users.Assign(value);
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
	
	private void attach_Users(User entity)
	{
		this.SendPropertyChanging();
		entity.Group = this;
	}
	
	private void detach_Users(User entity)
	{
		this.SendPropertyChanging();
		entity.Group = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rezerwacje")]
public partial class Rezerwacje : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private System.Nullable<System.DateTime> _Poczatek;
	
	private System.Nullable<System.DateTime> _Koniec;
	
	private System.Nullable<int> _User_id;
	
	private EntitySet<Rachunek> _Rachuneks;
	
	private EntitySet<Pokoje> _Pokojes;
	
	private EntityRef<User> _User;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPoczatekChanging(System.Nullable<System.DateTime> value);
    partial void OnPoczatekChanged();
    partial void OnKoniecChanging(System.Nullable<System.DateTime> value);
    partial void OnKoniecChanged();
    partial void OnUser_idChanging(System.Nullable<int> value);
    partial void OnUser_idChanged();
    #endregion
	
	public Rezerwacje()
	{
		this._Rachuneks = new EntitySet<Rachunek>(new Action<Rachunek>(this.attach_Rachuneks), new Action<Rachunek>(this.detach_Rachuneks));
		this._Pokojes = new EntitySet<Pokoje>(new Action<Pokoje>(this.attach_Pokojes), new Action<Pokoje>(this.detach_Pokojes));
		this._User = default(EntityRef<User>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Poczatek", DbType="Date")]
	public System.Nullable<System.DateTime> Poczatek
	{
		get
		{
			return this._Poczatek;
		}
		set
		{
			if ((this._Poczatek != value))
			{
				this.OnPoczatekChanging(value);
				this.SendPropertyChanging();
				this._Poczatek = value;
				this.SendPropertyChanged("Poczatek");
				this.OnPoczatekChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Koniec", DbType="Date")]
	public System.Nullable<System.DateTime> Koniec
	{
		get
		{
			return this._Koniec;
		}
		set
		{
			if ((this._Koniec != value))
			{
				this.OnKoniecChanging(value);
				this.SendPropertyChanging();
				this._Koniec = value;
				this.SendPropertyChanged("Koniec");
				this.OnKoniecChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_id", DbType="Int")]
	public System.Nullable<int> User_id
	{
		get
		{
			return this._User_id;
		}
		set
		{
			if ((this._User_id != value))
			{
				if (this._User.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUser_idChanging(value);
				this.SendPropertyChanging();
				this._User_id = value;
				this.SendPropertyChanged("User_id");
				this.OnUser_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rezerwacje_Rachunek", Storage="_Rachuneks", ThisKey="Id", OtherKey="Rezerwacje_id")]
	public EntitySet<Rachunek> Rachuneks
	{
		get
		{
			return this._Rachuneks;
		}
		set
		{
			this._Rachuneks.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rezerwacje_Pokoje", Storage="_Pokojes", ThisKey="Id", OtherKey="Rezerwacje_id")]
	public EntitySet<Pokoje> Pokojes
	{
		get
		{
			return this._Pokojes;
		}
		set
		{
			this._Pokojes.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Rezerwacje", Storage="_User", ThisKey="User_id", OtherKey="Id", IsForeignKey=true)]
	public User User
	{
		get
		{
			return this._User.Entity;
		}
		set
		{
			User previousValue = this._User.Entity;
			if (((previousValue != value) 
						|| (this._User.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._User.Entity = null;
					previousValue.Rezerwacjes.Remove(this);
				}
				this._User.Entity = value;
				if ((value != null))
				{
					value.Rezerwacjes.Add(this);
					this._User_id = value.Id;
				}
				else
				{
					this._User_id = default(Nullable<int>);
				}
				this.SendPropertyChanged("User");
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
	
	private void attach_Rachuneks(Rachunek entity)
	{
		this.SendPropertyChanging();
		entity.Rezerwacje = this;
	}
	
	private void detach_Rachuneks(Rachunek entity)
	{
		this.SendPropertyChanging();
		entity.Rezerwacje = null;
	}
	
	private void attach_Pokojes(Pokoje entity)
	{
		this.SendPropertyChanging();
		entity.Rezerwacje = this;
	}
	
	private void detach_Pokojes(Pokoje entity)
	{
		this.SendPropertyChanging();
		entity.Rezerwacje = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pokoj_opis")]
public partial class Pokoj_opi : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Opis_pokoju;
	
	private System.Nullable<int> _Ile_osob;
	
	private string _Cena;
	
	private EntitySet<Pokoje> _Pokojes;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnOpis_pokojuChanging(string value);
    partial void OnOpis_pokojuChanged();
    partial void OnIle_osobChanging(System.Nullable<int> value);
    partial void OnIle_osobChanged();
    partial void OnCenaChanging(string value);
    partial void OnCenaChanged();
    #endregion
	
	public Pokoj_opi()
	{
		this._Pokojes = new EntitySet<Pokoje>(new Action<Pokoje>(this.attach_Pokojes), new Action<Pokoje>(this.detach_Pokojes));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Opis_pokoju", DbType="NChar(100)")]
	public string Opis_pokoju
	{
		get
		{
			return this._Opis_pokoju;
		}
		set
		{
			if ((this._Opis_pokoju != value))
			{
				this.OnOpis_pokojuChanging(value);
				this.SendPropertyChanging();
				this._Opis_pokoju = value;
				this.SendPropertyChanged("Opis_pokoju");
				this.OnOpis_pokojuChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ile_osob", DbType="Int")]
	public System.Nullable<int> Ile_osob
	{
		get
		{
			return this._Ile_osob;
		}
		set
		{
			if ((this._Ile_osob != value))
			{
				this.OnIle_osobChanging(value);
				this.SendPropertyChanging();
				this._Ile_osob = value;
				this.SendPropertyChanged("Ile_osob");
				this.OnIle_osobChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cena", DbType="NChar(10)")]
	public string Cena
	{
		get
		{
			return this._Cena;
		}
		set
		{
			if ((this._Cena != value))
			{
				this.OnCenaChanging(value);
				this.SendPropertyChanging();
				this._Cena = value;
				this.SendPropertyChanged("Cena");
				this.OnCenaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pokoj_opi_Pokoje", Storage="_Pokojes", ThisKey="Id", OtherKey="Pokoj_opis_id")]
	public EntitySet<Pokoje> Pokojes
	{
		get
		{
			return this._Pokojes;
		}
		set
		{
			this._Pokojes.Assign(value);
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
	
	private void attach_Pokojes(Pokoje entity)
	{
		this.SendPropertyChanging();
		entity.Pokoj_opi = this;
	}
	
	private void detach_Pokojes(Pokoje entity)
	{
		this.SendPropertyChanging();
		entity.Pokoj_opi = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rachunek")]
public partial class Rachunek : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private System.Nullable<decimal> _Suma;
	
	private System.Nullable<decimal> _Rabat;
	
	private System.Nullable<int> _Rezerwacje_id;
	
	private System.Nullable<int> _Uslugi_id;
	
	private EntityRef<Rezerwacje> _Rezerwacje;
	
	private EntityRef<Uslugi> _Uslugi;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSumaChanging(System.Nullable<decimal> value);
    partial void OnSumaChanged();
    partial void OnRabatChanging(System.Nullable<decimal> value);
    partial void OnRabatChanged();
    partial void OnRezerwacje_idChanging(System.Nullable<int> value);
    partial void OnRezerwacje_idChanged();
    partial void OnUslugi_idChanging(System.Nullable<int> value);
    partial void OnUslugi_idChanged();
    #endregion
	
	public Rachunek()
	{
		this._Rezerwacje = default(EntityRef<Rezerwacje>);
		this._Uslugi = default(EntityRef<Uslugi>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Suma", DbType="Money")]
	public System.Nullable<decimal> Suma
	{
		get
		{
			return this._Suma;
		}
		set
		{
			if ((this._Suma != value))
			{
				this.OnSumaChanging(value);
				this.SendPropertyChanging();
				this._Suma = value;
				this.SendPropertyChanged("Suma");
				this.OnSumaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rabat", DbType="Money")]
	public System.Nullable<decimal> Rabat
	{
		get
		{
			return this._Rabat;
		}
		set
		{
			if ((this._Rabat != value))
			{
				this.OnRabatChanging(value);
				this.SendPropertyChanging();
				this._Rabat = value;
				this.SendPropertyChanged("Rabat");
				this.OnRabatChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rezerwacje_id", DbType="Int")]
	public System.Nullable<int> Rezerwacje_id
	{
		get
		{
			return this._Rezerwacje_id;
		}
		set
		{
			if ((this._Rezerwacje_id != value))
			{
				if (this._Rezerwacje.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnRezerwacje_idChanging(value);
				this.SendPropertyChanging();
				this._Rezerwacje_id = value;
				this.SendPropertyChanged("Rezerwacje_id");
				this.OnRezerwacje_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Uslugi_id", DbType="Int")]
	public System.Nullable<int> Uslugi_id
	{
		get
		{
			return this._Uslugi_id;
		}
		set
		{
			if ((this._Uslugi_id != value))
			{
				if (this._Uslugi.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUslugi_idChanging(value);
				this.SendPropertyChanging();
				this._Uslugi_id = value;
				this.SendPropertyChanged("Uslugi_id");
				this.OnUslugi_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rezerwacje_Rachunek", Storage="_Rezerwacje", ThisKey="Rezerwacje_id", OtherKey="Id", IsForeignKey=true)]
	public Rezerwacje Rezerwacje
	{
		get
		{
			return this._Rezerwacje.Entity;
		}
		set
		{
			Rezerwacje previousValue = this._Rezerwacje.Entity;
			if (((previousValue != value) 
						|| (this._Rezerwacje.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Rezerwacje.Entity = null;
					previousValue.Rachuneks.Remove(this);
				}
				this._Rezerwacje.Entity = value;
				if ((value != null))
				{
					value.Rachuneks.Add(this);
					this._Rezerwacje_id = value.Id;
				}
				else
				{
					this._Rezerwacje_id = default(Nullable<int>);
				}
				this.SendPropertyChanged("Rezerwacje");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Uslugi_Rachunek", Storage="_Uslugi", ThisKey="Uslugi_id", OtherKey="Id", IsForeignKey=true)]
	public Uslugi Uslugi
	{
		get
		{
			return this._Uslugi.Entity;
		}
		set
		{
			Uslugi previousValue = this._Uslugi.Entity;
			if (((previousValue != value) 
						|| (this._Uslugi.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Uslugi.Entity = null;
					previousValue.Rachuneks.Remove(this);
				}
				this._Uslugi.Entity = value;
				if ((value != null))
				{
					value.Rachuneks.Add(this);
					this._Uslugi_id = value.Id;
				}
				else
				{
					this._Uslugi_id = default(Nullable<int>);
				}
				this.SendPropertyChanged("Uslugi");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Uslugi")]
public partial class Uslugi : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Nazwa;
	
	private string _Opis;
	
	private System.Nullable<decimal> _Cena;
	
	private EntitySet<Rachunek> _Rachuneks;
	
	private EntitySet<User> _Users;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNazwaChanging(string value);
    partial void OnNazwaChanged();
    partial void OnOpisChanging(string value);
    partial void OnOpisChanged();
    partial void OnCenaChanging(System.Nullable<decimal> value);
    partial void OnCenaChanged();
    #endregion
	
	public Uslugi()
	{
		this._Rachuneks = new EntitySet<Rachunek>(new Action<Rachunek>(this.attach_Rachuneks), new Action<Rachunek>(this.detach_Rachuneks));
		this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nazwa", DbType="NChar(30)")]
	public string Nazwa
	{
		get
		{
			return this._Nazwa;
		}
		set
		{
			if ((this._Nazwa != value))
			{
				this.OnNazwaChanging(value);
				this.SendPropertyChanging();
				this._Nazwa = value;
				this.SendPropertyChanged("Nazwa");
				this.OnNazwaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Opis", DbType="NChar(255)")]
	public string Opis
	{
		get
		{
			return this._Opis;
		}
		set
		{
			if ((this._Opis != value))
			{
				this.OnOpisChanging(value);
				this.SendPropertyChanging();
				this._Opis = value;
				this.SendPropertyChanged("Opis");
				this.OnOpisChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cena", DbType="Money")]
	public System.Nullable<decimal> Cena
	{
		get
		{
			return this._Cena;
		}
		set
		{
			if ((this._Cena != value))
			{
				this.OnCenaChanging(value);
				this.SendPropertyChanging();
				this._Cena = value;
				this.SendPropertyChanged("Cena");
				this.OnCenaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Uslugi_Rachunek", Storage="_Rachuneks", ThisKey="Id", OtherKey="Uslugi_id")]
	public EntitySet<Rachunek> Rachuneks
	{
		get
		{
			return this._Rachuneks;
		}
		set
		{
			this._Rachuneks.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Uslugi_User", Storage="_Users", ThisKey="Id", OtherKey="Uslugi_id")]
	public EntitySet<User> Users
	{
		get
		{
			return this._Users;
		}
		set
		{
			this._Users.Assign(value);
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
	
	private void attach_Rachuneks(Rachunek entity)
	{
		this.SendPropertyChanging();
		entity.Uslugi = this;
	}
	
	private void detach_Rachuneks(Rachunek entity)
	{
		this.SendPropertyChanging();
		entity.Uslugi = null;
	}
	
	private void attach_Users(User entity)
	{
		this.SendPropertyChanging();
		entity.Uslugi = this;
	}
	
	private void detach_Users(User entity)
	{
		this.SendPropertyChanging();
		entity.Uslugi = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Login;
	
	private string _Password;
	
	private System.Nullable<int> _Group_id;
	
	private string _FirstName;
	
	private string _LastName;
	
	private System.Nullable<int> _Uslugi_id;
	
	private EntitySet<Rezerwacje> _Rezerwacjes;
	
	private EntityRef<Group> _Group;
	
	private EntityRef<Uslugi> _Uslugi;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnLoginChanging(string value);
    partial void OnLoginChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnGroup_idChanging(System.Nullable<int> value);
    partial void OnGroup_idChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnUslugi_idChanging(System.Nullable<int> value);
    partial void OnUslugi_idChanged();
    #endregion
	
	public User()
	{
		this._Rezerwacjes = new EntitySet<Rezerwacje>(new Action<Rezerwacje>(this.attach_Rezerwacjes), new Action<Rezerwacje>(this.detach_Rezerwacjes));
		this._Group = default(EntityRef<Group>);
		this._Uslugi = default(EntityRef<Uslugi>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Login", DbType="NChar(20)")]
	public string Login
	{
		get
		{
			return this._Login;
		}
		set
		{
			if ((this._Login != value))
			{
				this.OnLoginChanging(value);
				this.SendPropertyChanging();
				this._Login = value;
				this.SendPropertyChanged("Login");
				this.OnLoginChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NChar(20)")]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Group_id", DbType="Int")]
	public System.Nullable<int> Group_id
	{
		get
		{
			return this._Group_id;
		}
		set
		{
			if ((this._Group_id != value))
			{
				if (this._Group.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnGroup_idChanging(value);
				this.SendPropertyChanging();
				this._Group_id = value;
				this.SendPropertyChanged("Group_id");
				this.OnGroup_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NChar(20)")]
	public string FirstName
	{
		get
		{
			return this._FirstName;
		}
		set
		{
			if ((this._FirstName != value))
			{
				this.OnFirstNameChanging(value);
				this.SendPropertyChanging();
				this._FirstName = value;
				this.SendPropertyChanged("FirstName");
				this.OnFirstNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NChar(40)")]
	public string LastName
	{
		get
		{
			return this._LastName;
		}
		set
		{
			if ((this._LastName != value))
			{
				this.OnLastNameChanging(value);
				this.SendPropertyChanging();
				this._LastName = value;
				this.SendPropertyChanged("LastName");
				this.OnLastNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Uslugi_id", DbType="Int")]
	public System.Nullable<int> Uslugi_id
	{
		get
		{
			return this._Uslugi_id;
		}
		set
		{
			if ((this._Uslugi_id != value))
			{
				if (this._Uslugi.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUslugi_idChanging(value);
				this.SendPropertyChanging();
				this._Uslugi_id = value;
				this.SendPropertyChanged("Uslugi_id");
				this.OnUslugi_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Rezerwacje", Storage="_Rezerwacjes", ThisKey="Id", OtherKey="User_id")]
	public EntitySet<Rezerwacje> Rezerwacjes
	{
		get
		{
			return this._Rezerwacjes;
		}
		set
		{
			this._Rezerwacjes.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Group_User", Storage="_Group", ThisKey="Group_id", OtherKey="Id", IsForeignKey=true)]
	public Group Group
	{
		get
		{
			return this._Group.Entity;
		}
		set
		{
			Group previousValue = this._Group.Entity;
			if (((previousValue != value) 
						|| (this._Group.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Group.Entity = null;
					previousValue.Users.Remove(this);
				}
				this._Group.Entity = value;
				if ((value != null))
				{
					value.Users.Add(this);
					this._Group_id = value.Id;
				}
				else
				{
					this._Group_id = default(Nullable<int>);
				}
				this.SendPropertyChanged("Group");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Uslugi_User", Storage="_Uslugi", ThisKey="Uslugi_id", OtherKey="Id", IsForeignKey=true)]
	public Uslugi Uslugi
	{
		get
		{
			return this._Uslugi.Entity;
		}
		set
		{
			Uslugi previousValue = this._Uslugi.Entity;
			if (((previousValue != value) 
						|| (this._Uslugi.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Uslugi.Entity = null;
					previousValue.Users.Remove(this);
				}
				this._Uslugi.Entity = value;
				if ((value != null))
				{
					value.Users.Add(this);
					this._Uslugi_id = value.Id;
				}
				else
				{
					this._Uslugi_id = default(Nullable<int>);
				}
				this.SendPropertyChanged("Uslugi");
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
	
	private void attach_Rezerwacjes(Rezerwacje entity)
	{
		this.SendPropertyChanging();
		entity.User = this;
	}
	
	private void detach_Rezerwacjes(Rezerwacje entity)
	{
		this.SendPropertyChanging();
		entity.User = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pokoje")]
public partial class Pokoje : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Nr_pokoju;
	
	private string _Rodzaj;
	
	private System.Nullable<int> _Rezerwacje_id;
	
	private System.Nullable<int> _Pokoj_opis_id;
	
	private EntityRef<Pokoj_opi> _Pokoj_opi;
	
	private EntityRef<Rezerwacje> _Rezerwacje;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNr_pokojuChanging(string value);
    partial void OnNr_pokojuChanged();
    partial void OnRodzajChanging(string value);
    partial void OnRodzajChanged();
    partial void OnRezerwacje_idChanging(System.Nullable<int> value);
    partial void OnRezerwacje_idChanged();
    partial void OnPokoj_opis_idChanging(System.Nullable<int> value);
    partial void OnPokoj_opis_idChanged();
    #endregion
	
	public Pokoje()
	{
		this._Pokoj_opi = default(EntityRef<Pokoj_opi>);
		this._Rezerwacje = default(EntityRef<Rezerwacje>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nr_pokoju", DbType="NChar(10)")]
	public string Nr_pokoju
	{
		get
		{
			return this._Nr_pokoju;
		}
		set
		{
			if ((this._Nr_pokoju != value))
			{
				this.OnNr_pokojuChanging(value);
				this.SendPropertyChanging();
				this._Nr_pokoju = value;
				this.SendPropertyChanged("Nr_pokoju");
				this.OnNr_pokojuChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rodzaj", DbType="NChar(20)")]
	public string Rodzaj
	{
		get
		{
			return this._Rodzaj;
		}
		set
		{
			if ((this._Rodzaj != value))
			{
				this.OnRodzajChanging(value);
				this.SendPropertyChanging();
				this._Rodzaj = value;
				this.SendPropertyChanged("Rodzaj");
				this.OnRodzajChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rezerwacje_id", DbType="Int")]
	public System.Nullable<int> Rezerwacje_id
	{
		get
		{
			return this._Rezerwacje_id;
		}
		set
		{
			if ((this._Rezerwacje_id != value))
			{
				if (this._Rezerwacje.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnRezerwacje_idChanging(value);
				this.SendPropertyChanging();
				this._Rezerwacje_id = value;
				this.SendPropertyChanged("Rezerwacje_id");
				this.OnRezerwacje_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pokoj_opis_id", DbType="Int")]
	public System.Nullable<int> Pokoj_opis_id
	{
		get
		{
			return this._Pokoj_opis_id;
		}
		set
		{
			if ((this._Pokoj_opis_id != value))
			{
				if (this._Pokoj_opi.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPokoj_opis_idChanging(value);
				this.SendPropertyChanging();
				this._Pokoj_opis_id = value;
				this.SendPropertyChanged("Pokoj_opis_id");
				this.OnPokoj_opis_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pokoj_opi_Pokoje", Storage="_Pokoj_opi", ThisKey="Pokoj_opis_id", OtherKey="Id", IsForeignKey=true)]
	public Pokoj_opi Pokoj_opi
	{
		get
		{
			return this._Pokoj_opi.Entity;
		}
		set
		{
			Pokoj_opi previousValue = this._Pokoj_opi.Entity;
			if (((previousValue != value) 
						|| (this._Pokoj_opi.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Pokoj_opi.Entity = null;
					previousValue.Pokojes.Remove(this);
				}
				this._Pokoj_opi.Entity = value;
				if ((value != null))
				{
					value.Pokojes.Add(this);
					this._Pokoj_opis_id = value.Id;
				}
				else
				{
					this._Pokoj_opis_id = default(Nullable<int>);
				}
				this.SendPropertyChanged("Pokoj_opi");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rezerwacje_Pokoje", Storage="_Rezerwacje", ThisKey="Rezerwacje_id", OtherKey="Id", IsForeignKey=true)]
	public Rezerwacje Rezerwacje
	{
		get
		{
			return this._Rezerwacje.Entity;
		}
		set
		{
			Rezerwacje previousValue = this._Rezerwacje.Entity;
			if (((previousValue != value) 
						|| (this._Rezerwacje.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Rezerwacje.Entity = null;
					previousValue.Pokojes.Remove(this);
				}
				this._Rezerwacje.Entity = value;
				if ((value != null))
				{
					value.Pokojes.Add(this);
					this._Rezerwacje_id = value.Id;
				}
				else
				{
					this._Rezerwacje_id = default(Nullable<int>);
				}
				this.SendPropertyChanged("Rezerwacje");
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
#pragma warning restore 1591

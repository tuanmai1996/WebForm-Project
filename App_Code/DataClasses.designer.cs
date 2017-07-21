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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ShopCongNghe")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertCategory(Category instance);
  partial void UpdateCategory(Category instance);
  partial void DeleteCategory(Category instance);
  partial void InsertUser(User instance);
  partial void UpdateUser(User instance);
  partial void DeleteUser(User instance);
  partial void InsertOrderDetail(OrderDetail instance);
  partial void UpdateOrderDetail(OrderDetail instance);
  partial void DeleteOrderDetail(OrderDetail instance);
  partial void InsertOrder(Order instance);
  partial void UpdateOrder(Order instance);
  partial void DeleteOrder(Order instance);
  partial void InsertProduct(Product instance);
  partial void UpdateProduct(Product instance);
  partial void DeleteProduct(Product instance);
  partial void InsertRole(Role instance);
  partial void UpdateRole(Role instance);
  partial void DeleteRole(Role instance);
  partial void InsertSupplier(Supplier instance);
  partial void UpdateSupplier(Supplier instance);
  partial void DeleteSupplier(Supplier instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ShopCongNgheConnectionString"].ConnectionString, mappingSource)
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
	
	public System.Data.Linq.Table<Category> Categories
	{
		get
		{
			return this.GetTable<Category>();
		}
	}
	
	public System.Data.Linq.Table<User> Users
	{
		get
		{
			return this.GetTable<User>();
		}
	}
	
	public System.Data.Linq.Table<OrderDetail> OrderDetails
	{
		get
		{
			return this.GetTable<OrderDetail>();
		}
	}
	
	public System.Data.Linq.Table<Order> Orders
	{
		get
		{
			return this.GetTable<Order>();
		}
	}
	
	public System.Data.Linq.Table<Product> Products
	{
		get
		{
			return this.GetTable<Product>();
		}
	}
	
	public System.Data.Linq.Table<Role> Roles
	{
		get
		{
			return this.GetTable<Role>();
		}
	}
	
	public System.Data.Linq.Table<Supplier> Suppliers
	{
		get
		{
			return this.GetTable<Supplier>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categories")]
public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _CategoryID;
	
	private string _CategoryName;
	
	private EntitySet<Product> _Products;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategoryIDChanging(int value);
    partial void OnCategoryIDChanged();
    partial void OnCategoryNameChanging(string value);
    partial void OnCategoryNameChanged();
    #endregion
	
	public Category()
	{
		this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int CategoryID
	{
		get
		{
			return this._CategoryID;
		}
		set
		{
			if ((this._CategoryID != value))
			{
				this.OnCategoryIDChanging(value);
				this.SendPropertyChanging();
				this._CategoryID = value;
				this.SendPropertyChanged("CategoryID");
				this.OnCategoryIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryName", DbType="VarChar(20)")]
	public string CategoryName
	{
		get
		{
			return this._CategoryName;
		}
		set
		{
			if ((this._CategoryName != value))
			{
				this.OnCategoryNameChanging(value);
				this.SendPropertyChanging();
				this._CategoryName = value;
				this.SendPropertyChanged("CategoryName");
				this.OnCategoryNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Product", Storage="_Products", ThisKey="CategoryID", OtherKey="CategoryID")]
	public EntitySet<Product> Products
	{
		get
		{
			return this._Products;
		}
		set
		{
			this._Products.Assign(value);
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
	
	private void attach_Products(Product entity)
	{
		this.SendPropertyChanging();
		entity.Category = this;
	}
	
	private void detach_Products(Product entity)
	{
		this.SendPropertyChanging();
		entity.Category = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _UserID;
	
	private System.Nullable<int> _RoleID;
	
	private string _FName;
	
	private string _LName;
	
	private string _Email;
	
	private string _Phone;
	
	private string _Username;
	
	private string _Password;
	
	private System.Nullable<bool> _Status;
	
	private EntityRef<Role> _Role;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnRoleIDChanging(System.Nullable<int> value);
    partial void OnRoleIDChanged();
    partial void OnFNameChanging(string value);
    partial void OnFNameChanged();
    partial void OnLNameChanging(string value);
    partial void OnLNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnStatusChanging(System.Nullable<bool> value);
    partial void OnStatusChanged();
    #endregion
	
	public User()
	{
		this._Role = default(EntityRef<Role>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int UserID
	{
		get
		{
			return this._UserID;
		}
		set
		{
			if ((this._UserID != value))
			{
				this.OnUserIDChanging(value);
				this.SendPropertyChanging();
				this._UserID = value;
				this.SendPropertyChanged("UserID");
				this.OnUserIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleID", DbType="Int")]
	public System.Nullable<int> RoleID
	{
		get
		{
			return this._RoleID;
		}
		set
		{
			if ((this._RoleID != value))
			{
				if (this._Role.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnRoleIDChanging(value);
				this.SendPropertyChanging();
				this._RoleID = value;
				this.SendPropertyChanged("RoleID");
				this.OnRoleIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FName", DbType="VarChar(10)")]
	public string FName
	{
		get
		{
			return this._FName;
		}
		set
		{
			if ((this._FName != value))
			{
				this.OnFNameChanging(value);
				this.SendPropertyChanging();
				this._FName = value;
				this.SendPropertyChanged("FName");
				this.OnFNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LName", DbType="VarChar(10)")]
	public string LName
	{
		get
		{
			return this._LName;
		}
		set
		{
			if ((this._LName != value))
			{
				this.OnLNameChanging(value);
				this.SendPropertyChanging();
				this._LName = value;
				this.SendPropertyChanged("LName");
				this.OnLNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NChar(10)")]
	public string Phone
	{
		get
		{
			return this._Phone;
		}
		set
		{
			if ((this._Phone != value))
			{
				this.OnPhoneChanging(value);
				this.SendPropertyChanging();
				this._Phone = value;
				this.SendPropertyChanged("Phone");
				this.OnPhoneChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(10)")]
	public string Username
	{
		get
		{
			return this._Username;
		}
		set
		{
			if ((this._Username != value))
			{
				this.OnUsernameChanging(value);
				this.SendPropertyChanging();
				this._Username = value;
				this.SendPropertyChanged("Username");
				this.OnUsernameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Bit")]
	public System.Nullable<bool> Status
	{
		get
		{
			return this._Status;
		}
		set
		{
			if ((this._Status != value))
			{
				this.OnStatusChanging(value);
				this.SendPropertyChanging();
				this._Status = value;
				this.SendPropertyChanged("Status");
				this.OnStatusChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_User", Storage="_Role", ThisKey="RoleID", OtherKey="RoleID", IsForeignKey=true)]
	public Role Role
	{
		get
		{
			return this._Role.Entity;
		}
		set
		{
			Role previousValue = this._Role.Entity;
			if (((previousValue != value) 
						|| (this._Role.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Role.Entity = null;
					previousValue.Users.Remove(this);
				}
				this._Role.Entity = value;
				if ((value != null))
				{
					value.Users.Add(this);
					this._RoleID = value.RoleID;
				}
				else
				{
					this._RoleID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Role");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderDetails")]
public partial class OrderDetail : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ODetailID;
	
	private System.Nullable<int> _ProductID;
	
	private System.Nullable<System.DateTime> _OrderDate;
	
	private System.Nullable<System.DateTime> _ShippedDate;
	
	private string _UnitPrice;
	
	private System.Nullable<int> _Quantity;
	
	private EntitySet<Order> _Orders;
	
	private EntityRef<Product> _Product;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnODetailIDChanging(int value);
    partial void OnODetailIDChanged();
    partial void OnProductIDChanging(System.Nullable<int> value);
    partial void OnProductIDChanged();
    partial void OnOrderDateChanging(System.Nullable<System.DateTime> value);
    partial void OnOrderDateChanged();
    partial void OnShippedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnShippedDateChanged();
    partial void OnUnitPriceChanging(string value);
    partial void OnUnitPriceChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    #endregion
	
	public OrderDetail()
	{
		this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
		this._Product = default(EntityRef<Product>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ODetailID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ODetailID
	{
		get
		{
			return this._ODetailID;
		}
		set
		{
			if ((this._ODetailID != value))
			{
				this.OnODetailIDChanging(value);
				this.SendPropertyChanging();
				this._ODetailID = value;
				this.SendPropertyChanged("ODetailID");
				this.OnODetailIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", DbType="Int")]
	public System.Nullable<int> ProductID
	{
		get
		{
			return this._ProductID;
		}
		set
		{
			if ((this._ProductID != value))
			{
				if (this._Product.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnProductIDChanging(value);
				this.SendPropertyChanging();
				this._ProductID = value;
				this.SendPropertyChanged("ProductID");
				this.OnProductIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDate", DbType="Date")]
	public System.Nullable<System.DateTime> OrderDate
	{
		get
		{
			return this._OrderDate;
		}
		set
		{
			if ((this._OrderDate != value))
			{
				this.OnOrderDateChanging(value);
				this.SendPropertyChanging();
				this._OrderDate = value;
				this.SendPropertyChanged("OrderDate");
				this.OnOrderDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShippedDate", DbType="Date")]
	public System.Nullable<System.DateTime> ShippedDate
	{
		get
		{
			return this._ShippedDate;
		}
		set
		{
			if ((this._ShippedDate != value))
			{
				this.OnShippedDateChanging(value);
				this.SendPropertyChanging();
				this._ShippedDate = value;
				this.SendPropertyChanged("ShippedDate");
				this.OnShippedDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitPrice", DbType="NChar(10)")]
	public string UnitPrice
	{
		get
		{
			return this._UnitPrice;
		}
		set
		{
			if ((this._UnitPrice != value))
			{
				this.OnUnitPriceChanging(value);
				this.SendPropertyChanging();
				this._UnitPrice = value;
				this.SendPropertyChanged("UnitPrice");
				this.OnUnitPriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
	public System.Nullable<int> Quantity
	{
		get
		{
			return this._Quantity;
		}
		set
		{
			if ((this._Quantity != value))
			{
				this.OnQuantityChanging(value);
				this.SendPropertyChanging();
				this._Quantity = value;
				this.SendPropertyChanged("Quantity");
				this.OnQuantityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OrderDetail_Order", Storage="_Orders", ThisKey="ODetailID", OtherKey="ODetailID")]
	public EntitySet<Order> Orders
	{
		get
		{
			return this._Orders;
		}
		set
		{
			this._Orders.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_OrderDetail", Storage="_Product", ThisKey="ProductID", OtherKey="ProductID", IsForeignKey=true)]
	public Product Product
	{
		get
		{
			return this._Product.Entity;
		}
		set
		{
			Product previousValue = this._Product.Entity;
			if (((previousValue != value) 
						|| (this._Product.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Product.Entity = null;
					previousValue.OrderDetails.Remove(this);
				}
				this._Product.Entity = value;
				if ((value != null))
				{
					value.OrderDetails.Add(this);
					this._ProductID = value.ProductID;
				}
				else
				{
					this._ProductID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Product");
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
	
	private void attach_Orders(Order entity)
	{
		this.SendPropertyChanging();
		entity.OrderDetail = this;
	}
	
	private void detach_Orders(Order entity)
	{
		this.SendPropertyChanging();
		entity.OrderDetail = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Orders")]
public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _OrderID;
	
	private System.Nullable<int> _UserID;
	
	private System.Nullable<int> _ODetailID;
	
	private string _ShipAddress;
	
	private EntityRef<OrderDetail> _OrderDetail;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(int value);
    partial void OnOrderIDChanged();
    partial void OnUserIDChanging(System.Nullable<int> value);
    partial void OnUserIDChanged();
    partial void OnODetailIDChanging(System.Nullable<int> value);
    partial void OnODetailIDChanged();
    partial void OnShipAddressChanging(string value);
    partial void OnShipAddressChanged();
    #endregion
	
	public Order()
	{
		this._OrderDetail = default(EntityRef<OrderDetail>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int OrderID
	{
		get
		{
			return this._OrderID;
		}
		set
		{
			if ((this._OrderID != value))
			{
				this.OnOrderIDChanging(value);
				this.SendPropertyChanging();
				this._OrderID = value;
				this.SendPropertyChanged("OrderID");
				this.OnOrderIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
	public System.Nullable<int> UserID
	{
		get
		{
			return this._UserID;
		}
		set
		{
			if ((this._UserID != value))
			{
				this.OnUserIDChanging(value);
				this.SendPropertyChanging();
				this._UserID = value;
				this.SendPropertyChanged("UserID");
				this.OnUserIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ODetailID", DbType="Int")]
	public System.Nullable<int> ODetailID
	{
		get
		{
			return this._ODetailID;
		}
		set
		{
			if ((this._ODetailID != value))
			{
				if (this._OrderDetail.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnODetailIDChanging(value);
				this.SendPropertyChanging();
				this._ODetailID = value;
				this.SendPropertyChanged("ODetailID");
				this.OnODetailIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipAddress", DbType="VarChar(500)")]
	public string ShipAddress
	{
		get
		{
			return this._ShipAddress;
		}
		set
		{
			if ((this._ShipAddress != value))
			{
				this.OnShipAddressChanging(value);
				this.SendPropertyChanging();
				this._ShipAddress = value;
				this.SendPropertyChanged("ShipAddress");
				this.OnShipAddressChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OrderDetail_Order", Storage="_OrderDetail", ThisKey="ODetailID", OtherKey="ODetailID", IsForeignKey=true)]
	public OrderDetail OrderDetail
	{
		get
		{
			return this._OrderDetail.Entity;
		}
		set
		{
			OrderDetail previousValue = this._OrderDetail.Entity;
			if (((previousValue != value) 
						|| (this._OrderDetail.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._OrderDetail.Entity = null;
					previousValue.Orders.Remove(this);
				}
				this._OrderDetail.Entity = value;
				if ((value != null))
				{
					value.Orders.Add(this);
					this._ODetailID = value.ODetailID;
				}
				else
				{
					this._ODetailID = default(Nullable<int>);
				}
				this.SendPropertyChanged("OrderDetail");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ProductID;
	
	private System.Nullable<int> _CategoryID;
	
	private System.Nullable<int> _SupplierID;
	
	private string _ProductName;
	
	private string _Picture;
	
	private System.Nullable<bool> _ProductStatus;
	
	private string _Description;
	
	private System.Nullable<int> _Price;
	
	private EntitySet<OrderDetail> _OrderDetails;
	
	private EntityRef<Category> _Category;
	
	private EntityRef<Supplier> _Supplier;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnCategoryIDChanging(System.Nullable<int> value);
    partial void OnCategoryIDChanged();
    partial void OnSupplierIDChanging(System.Nullable<int> value);
    partial void OnSupplierIDChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnPictureChanging(string value);
    partial void OnPictureChanged();
    partial void OnProductStatusChanging(System.Nullable<bool> value);
    partial void OnProductStatusChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPriceChanging(System.Nullable<int> value);
    partial void OnPriceChanged();
    #endregion
	
	public Product()
	{
		this._OrderDetails = new EntitySet<OrderDetail>(new Action<OrderDetail>(this.attach_OrderDetails), new Action<OrderDetail>(this.detach_OrderDetails));
		this._Category = default(EntityRef<Category>);
		this._Supplier = default(EntityRef<Supplier>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ProductID
	{
		get
		{
			return this._ProductID;
		}
		set
		{
			if ((this._ProductID != value))
			{
				this.OnProductIDChanging(value);
				this.SendPropertyChanging();
				this._ProductID = value;
				this.SendPropertyChanged("ProductID");
				this.OnProductIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int")]
	public System.Nullable<int> CategoryID
	{
		get
		{
			return this._CategoryID;
		}
		set
		{
			if ((this._CategoryID != value))
			{
				if (this._Category.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCategoryIDChanging(value);
				this.SendPropertyChanging();
				this._CategoryID = value;
				this.SendPropertyChanged("CategoryID");
				this.OnCategoryIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SupplierID", DbType="Int")]
	public System.Nullable<int> SupplierID
	{
		get
		{
			return this._SupplierID;
		}
		set
		{
			if ((this._SupplierID != value))
			{
				if (this._Supplier.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnSupplierIDChanging(value);
				this.SendPropertyChanging();
				this._SupplierID = value;
				this.SendPropertyChanged("SupplierID");
				this.OnSupplierIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="VarChar(50)")]
	public string ProductName
	{
		get
		{
			return this._ProductName;
		}
		set
		{
			if ((this._ProductName != value))
			{
				this.OnProductNameChanging(value);
				this.SendPropertyChanging();
				this._ProductName = value;
				this.SendPropertyChanged("ProductName");
				this.OnProductNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="VarChar(50)")]
	public string Picture
	{
		get
		{
			return this._Picture;
		}
		set
		{
			if ((this._Picture != value))
			{
				this.OnPictureChanging(value);
				this.SendPropertyChanging();
				this._Picture = value;
				this.SendPropertyChanged("Picture");
				this.OnPictureChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductStatus", DbType="Bit")]
	public System.Nullable<bool> ProductStatus
	{
		get
		{
			return this._ProductStatus;
		}
		set
		{
			if ((this._ProductStatus != value))
			{
				this.OnProductStatusChanging(value);
				this.SendPropertyChanging();
				this._ProductStatus = value;
				this.SendPropertyChanged("ProductStatus");
				this.OnProductStatusChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(500)")]
	public string Description
	{
		get
		{
			return this._Description;
		}
		set
		{
			if ((this._Description != value))
			{
				this.OnDescriptionChanging(value);
				this.SendPropertyChanging();
				this._Description = value;
				this.SendPropertyChanged("Description");
				this.OnDescriptionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int")]
	public System.Nullable<int> Price
	{
		get
		{
			return this._Price;
		}
		set
		{
			if ((this._Price != value))
			{
				this.OnPriceChanging(value);
				this.SendPropertyChanging();
				this._Price = value;
				this.SendPropertyChanged("Price");
				this.OnPriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_OrderDetail", Storage="_OrderDetails", ThisKey="ProductID", OtherKey="ProductID")]
	public EntitySet<OrderDetail> OrderDetails
	{
		get
		{
			return this._OrderDetails;
		}
		set
		{
			this._OrderDetails.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Product", Storage="_Category", ThisKey="CategoryID", OtherKey="CategoryID", IsForeignKey=true)]
	public Category Category
	{
		get
		{
			return this._Category.Entity;
		}
		set
		{
			Category previousValue = this._Category.Entity;
			if (((previousValue != value) 
						|| (this._Category.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Category.Entity = null;
					previousValue.Products.Remove(this);
				}
				this._Category.Entity = value;
				if ((value != null))
				{
					value.Products.Add(this);
					this._CategoryID = value.CategoryID;
				}
				else
				{
					this._CategoryID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Category");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Supplier_Product", Storage="_Supplier", ThisKey="SupplierID", OtherKey="SupplierID", IsForeignKey=true)]
	public Supplier Supplier
	{
		get
		{
			return this._Supplier.Entity;
		}
		set
		{
			Supplier previousValue = this._Supplier.Entity;
			if (((previousValue != value) 
						|| (this._Supplier.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Supplier.Entity = null;
					previousValue.Products.Remove(this);
				}
				this._Supplier.Entity = value;
				if ((value != null))
				{
					value.Products.Add(this);
					this._SupplierID = value.SupplierID;
				}
				else
				{
					this._SupplierID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Supplier");
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
	
	private void attach_OrderDetails(OrderDetail entity)
	{
		this.SendPropertyChanging();
		entity.Product = this;
	}
	
	private void detach_OrderDetails(OrderDetail entity)
	{
		this.SendPropertyChanging();
		entity.Product = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Roles")]
public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _RoleID;
	
	private string _RoleName;
	
	private EntitySet<User> _Users;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRoleIDChanging(int value);
    partial void OnRoleIDChanged();
    partial void OnRoleNameChanging(string value);
    partial void OnRoleNameChanged();
    #endregion
	
	public Role()
	{
		this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int RoleID
	{
		get
		{
			return this._RoleID;
		}
		set
		{
			if ((this._RoleID != value))
			{
				this.OnRoleIDChanging(value);
				this.SendPropertyChanging();
				this._RoleID = value;
				this.SendPropertyChanged("RoleID");
				this.OnRoleIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleName", DbType="VarChar(50)")]
	public string RoleName
	{
		get
		{
			return this._RoleName;
		}
		set
		{
			if ((this._RoleName != value))
			{
				this.OnRoleNameChanging(value);
				this.SendPropertyChanging();
				this._RoleName = value;
				this.SendPropertyChanged("RoleName");
				this.OnRoleNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_User", Storage="_Users", ThisKey="RoleID", OtherKey="RoleID")]
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
		entity.Role = this;
	}
	
	private void detach_Users(User entity)
	{
		this.SendPropertyChanging();
		entity.Role = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Suppliers")]
public partial class Supplier : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _SupplierID;
	
	private string _SupplierName;
	
	private EntitySet<Product> _Products;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSupplierIDChanging(int value);
    partial void OnSupplierIDChanged();
    partial void OnSupplierNameChanging(string value);
    partial void OnSupplierNameChanged();
    #endregion
	
	public Supplier()
	{
		this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SupplierID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int SupplierID
	{
		get
		{
			return this._SupplierID;
		}
		set
		{
			if ((this._SupplierID != value))
			{
				this.OnSupplierIDChanging(value);
				this.SendPropertyChanging();
				this._SupplierID = value;
				this.SendPropertyChanged("SupplierID");
				this.OnSupplierIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SupplierName", DbType="VarChar(20)")]
	public string SupplierName
	{
		get
		{
			return this._SupplierName;
		}
		set
		{
			if ((this._SupplierName != value))
			{
				this.OnSupplierNameChanging(value);
				this.SendPropertyChanging();
				this._SupplierName = value;
				this.SendPropertyChanged("SupplierName");
				this.OnSupplierNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Supplier_Product", Storage="_Products", ThisKey="SupplierID", OtherKey="SupplierID")]
	public EntitySet<Product> Products
	{
		get
		{
			return this._Products;
		}
		set
		{
			this._Products.Assign(value);
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
	
	private void attach_Products(Product entity)
	{
		this.SendPropertyChanging();
		entity.Supplier = this;
	}
	
	private void detach_Products(Product entity)
	{
		this.SendPropertyChanging();
		entity.Supplier = null;
	}
}
#pragma warning restore 1591

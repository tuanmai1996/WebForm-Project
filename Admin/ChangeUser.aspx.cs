﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ChangeUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Kiem tra dang nhap:
        // Load thong tin account theo ma duoc truyen:
        var uid = 0;
        int.TryParse(Request.QueryString["uid"], out uid);
        if (!IsPostBack)
        {
            if (!IsPostBack)
                if (Session["user"] != null)
                {
                    if (uid != 0)
                        this.LoadTTND(uid);
                    else
                        Response.Redirect("~/UserMng");
                }
                else
                    Response.Redirect("AdLogin");
        }

    }

    private void LoadTTND(int uid)
    {

        // Load thong tin account:
        using (var k = new Kho())
        {
            #region Binding TextBox
            var nd = k.TimND(uid);
            txtName.Text = nd.Username;
            txtMK.Text = nd.Password;
            txtFName.Text = nd.FName;
            txtLName.Text = nd.LName;
            txtEmail.Text = nd.Email;
            txtPhone.Text = nd.Phone;
            txtAddr.Text = nd.Address;

            #endregion

            #region Binding Role
            var userList = k.DanhSachRole;

            ddlRole.DataSource = userList;
            ddlRole.DataValueField = "RoleID";
            ddlRole.DataTextField = "RoleName";
            ddlRole.DataBind();
            ddlRole.SelectedValue = nd.RoleID.ToString();

            #endregion
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        // Sua thong tin account:
        #region Sua User
        using (var k = new Kho())
        {
            var uid = 0;
            int.TryParse(Request.QueryString["uid"], out uid);
            if (uid != 0)
            {
                k.SuaTTND(new User()
                {
                    UserID = uid,
                    Username = txtName.Text,
                    Password = txtMK.Text,
                    RoleID = int.Parse(ddlRole.SelectedValue),
                    FName = txtFName.Text,
                    LName = txtLName.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddr.Text,
                });

                // Hien thong bao khi thanh cong:
                pnlUpdate.Visible = true;
                this.LoadTTND(uid);
            }
        }
        #endregion
    }

    protected void lbtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/UserMng");
    }
}
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.CompilerServices
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Public Class frmviewemp
    Dim a As New validation
    Dim d As New databind
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet

    Private Sub frmviewemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        gridvalid1()

        a.GridPropery(GridView1)
        d.PopulateCombo(cmbpost, "post_id", "post_name", "tbpost", Nothing, True, Nothing, -1)
        d.PopulateCombo(cmbempid, "emp_id", "emp_id", "emp_master", Nothing, True, Nothing, -1)

        d.conn()
        Dim _blankContextMenu As New ContextMenu()
        txtname.ContextMenu = _blankContextMenu
    End Sub
    Private Sub gridvalid1()
        GridView1.Columns("emp_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("emp_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("f_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("f_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("address").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("address").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("co_no").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("co_no").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("email").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("email").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dob").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dob").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("e_gender").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("e_gender").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("class_no").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("class_no").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("gov_no").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("gov_no").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte_frm").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte_frm").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte_to").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte_to").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If







    End Sub

    
    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        

        Try
            'd.gridfill("select * from emp_master where[f_name] like '%" & txtname.Text & "%' or [emp_id]='" & cmbempid.Text & "' or [post_id]='" & (cmbpost.SelectedItem).GetData() & "'", grdemp)
            If (txtname.Text = "" And cmbempid.Text = "" And cmbpost.Text = "") Then
                XtraMessageBox.Show("Please Enter Any One Field", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtname.Focus()


            Else
                If Not (txtname.Text = "") Then
                    '                d.gridfill("select * from emp_master where [f_name] like '%" & txtname.Text & "%'", grdemp)
                    d.gridfill("SELECT     emp_master.*, class_schema.class_no FROM class_schema INNER JOIN emp_master ON class_schema.class_no = emp_master.class_id WHERE     (emp_master.f_name like '%" & txtname.Text & "%')", grdemp)

                ElseIf Not (cmbempid.Text = "") Then
                    'd.gridfill("select * from emp_master where [emp_id]='" & cmbempid.Text & "'", grdemp)
                    d.gridfill("SELECT     class_schema.class_no, emp_master.* FROM class_schema INNER JOIN emp_master ON class_schema.class_no = emp_master.class_id WHERE     (emp_master.emp_id = '" & cmbempid.Text & "')", grdemp)
                ElseIf Not (cmbpost.Text = "") Then
                    'd.gridfill("select * from emp_master where [post_id]='" & (cmbpost.SelectedItem).GetData() & "'", grdemp)
                    d.gridfill("SELECT     class_schema.class_no, emp_master.* FROM class_schema INNER JOIN emp_master ON class_schema.class_no = emp_master.class_id WHERE     (emp_master.post_id = '" & (cmbpost.SelectedItem).GetData() & "')", grdemp)
                End If


            End If
        Catch ex As Exception

        End Try
        




    End Sub

    

    
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtname.Text = ""
        cmbempid.Text = ""
        cmbpost.Text = ""
        txtname.Enabled = True
        cmbempid.Enabled = True
        cmbpost.Enabled = True
        txtname.Focus()


    End Sub

    

    

    
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    
    Private Sub txtname_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.EditValueChanged
        If Not (txtname.Text = "") Then
            cmbempid.Enabled = False
            cmbpost.Enabled = False
        Else
            cmbempid.Enabled = True
            cmbpost.Enabled = True
        End If
    End Sub

    
    Private Sub cmbempid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbempid.SelectedIndexChanged
        txtname.Enabled = False
        cmbpost.Enabled = False
    End Sub

    Private Sub cmbpost_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpost.SelectedIndexChanged
        cmbempid.Enabled = False
        txtname.Enabled = False
    End Sub

    
    Private Sub btnpprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpprev.Click
        btnpprev.Tag = "prv"
        reporting()



    End Sub
    Public Sub reporting()
        Try
            'd.gridfill("select * from emp_master where[f_name] like '%" & txtname.Text & "%' or [emp_id]='" & cmbempid.Text & "' or [post_id]='" & (cmbpost.SelectedItem).GetData() & "'", grdemp)
            If (txtname.Text = "" And cmbempid.Text = "" And cmbpost.Text = "") Then
                XtraMessageBox.Show("Please Enter Any One Field", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtname.Focus()


            Else
                If Not (txtname.Text = "") Then
                    da = New SqlDataAdapter("SELECT     emp_master.*, class_schema.class_no FROM class_schema INNER JOIN emp_master ON class_schema.class_no = emp_master.class_id WHERE     (emp_master.f_name like '%" & txtname.Text & "%')", d.con)

                ElseIf Not (cmbempid.Text = "") Then


                    da = New SqlDataAdapter("SELECT     class_schema.class_no, emp_master.* FROM class_schema INNER JOIN emp_master ON class_schema.class_no = emp_master.class_id WHERE     (emp_master.emp_id = '" & cmbempid.Text & "')", d.con)

                ElseIf Not (cmbpost.Text = "") Then


                    da = New SqlDataAdapter("SELECT     class_schema.class_no, emp_master.* FROM class_schema INNER JOIN emp_master ON class_schema.class_no = emp_master.class_id WHERE     (emp_master.post_id = '" & (cmbpost.SelectedItem).GetData() & "')", d.con)
                End If

                If btnpprev.Tag = "prv" Then
                    rempinfo("prv")
                ElseIf btnpprev.Tag = "prn" Then
                    rempinfo("prn")
                End If







            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub rempinfo(ByVal rpttype As String)
        Try
            ds.Clear()

            da.Fill(ds, "abc")
            Dim report2 As New Employeeinfo
            report2.DataSource = ds.Tables("abc")
            report2.DataMember = "abc"
            report2.xrempid.DataBindings.Add("Text", ds.Tables("abc"), "abc.emp_id")
            report2.xrname.DataBindings.Add("Text", ds.Tables("abc"), "abc.f_name")
            report2.xradd.DataBindings.Add("Text", ds.Tables("abc"), "abc.address")
            report2.xrcontact.DataBindings.Add("Text", ds.Tables("abc"), "abc.co_no")
            report2.xrdob.DataBindings.Add("Text", ds.Tables("abc"), "abc.dob")
            report2.xrgender.DataBindings.Add("Text", ds.Tables("abc"), "abc.e_gender")
            report2.xrclasste.DataBindings.Add("Text", ds.Tables("abc"), "abc.class_no")
            report2.xrgovno.DataBindings.Add("Text", ds.Tables("abc"), "abc.gov_no")
            report2.xrdtefrm.DataBindings.Add("Text", ds.Tables("abc"), "abc.dte_frm")


            Try
                cmd = New SqlCommand("select u_name from log_regi where log_id=(select max(log_id) from log_regi)", d.con)
                report2.xruser.Text = cmd.ExecuteScalar

            Catch ex As Exception

            End Try


            If rpttype = "prv" Then
                report2.ShowPreview()
            ElseIf rpttype = "prn" Then
                report2.Print()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        btnpprev.Tag = "prn"
        reporting()


    End Sub
End Class
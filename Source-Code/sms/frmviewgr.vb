Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.CompilerServices
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Public Class frmviewgr
    Dim a As New validation
    Dim d As New databind
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim con As New SqlConnection
    Dim str, str1 As String
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtfirstname.Text = ""
        txtlastname.Text = ""
        txtgrno.Text = ""
        cmbyear.Text = ""
        txtfirstname.Enabled = True
        txtlastname.Enabled = True
        txtgrno.Enabled = True
        cmbyear.Enabled = True
        txtgrno.Focus()

    End Sub
    Public Sub grid()
        Dim ds As New DataSet

        If ds.Tables.Contains("master") = True Then
            ds.Tables("master").Clear()
        End If
        If ds.Tables.Contains("Detail") = True Then
            ds.Tables("Detail").Clear()
        End If

        da = New SqlDataAdapter(str, d.con)
        ds.Clear()

        da.Fill(ds, "master")

        da = New SqlDataAdapter(str1, d.con)


        da.Fill(ds, "Detail")

        d.SetRelation("master", "gr_no", "Detail", "gr_no", ds, "Detail")

        grdgr.DataSource = ds.Tables("master")
        gridvalid1()

        grdgr.LevelTree.Nodes.Add("Detail", GridView2)
        GridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        GridView2.PopulateColumns(ds.Tables("Detail"))


        GridView2.Columns("std_id").VisibleIndex = -1
        GridView2.Columns("gr_no").VisibleIndex = -1
        gridvalid2()



    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If (txtfirstname.Text = "" And txtlastname.Text = "" And cmbyear.Text = "" And txtgrno.Text = "") Then
            XtraMessageBox.Show("Please Enter Any One Field", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtgrno.Focus()
        Else
            If Not (txtgrno.Text = "") Then
                str = "SELECT     gr_no, year, f_name, l_name,address, stdfrom, stddob, stdgender, category, stdcaste FROM std_master where [gr_no]='" & txtgrno.Text & "' order by gr_no asc"
                str1 = "SELECT     gr_no, std_id, add_dte, add_std, remarks, category, leave_dte, leave_std, leave_rsn, progress, conduct, try_pass FROM         std_master  where [gr_no]='" & txtgrno.Text & "' order by gr_no asc"
                grid()

            ElseIf Not (cmbyear.Text = "") Then
                str = "SELECT     gr_no, year, f_name, l_name,address, stdfrom, stddob, stdgender, category, stdcaste FROM std_master where [year]='" & cmbyear.Text & "' order by gr_no asc"

                str1 = "SELECT     gr_no, std_id, add_dte, add_std, remarks, category, leave_dte, leave_std, leave_rsn, progress, conduct, try_pass FROM         std_master  where [year]='" & cmbyear.Text & "' order by gr_no asc"


                grid()
            ElseIf Not (txtfirstname.Text = "" Or txtlastname.Text = "") Then
                str = "SELECT     gr_no, year, f_name, l_name,address, stdfrom, stddob, stdgender, category, stdcaste FROM std_master where [f_name]='" & txtfirstname.Text & "' And [l_name]='" & txtlastname.Text & "' order by gr_no asc"
                str1 = "SELECT     gr_no, std_id, add_dte, add_std, remarks, category, leave_dte, leave_std, leave_rsn, progress, conduct, try_pass FROM         std_master where [f_name]='" & txtfirstname.Text & "' And [l_name]='" & txtlastname.Text & "' order by gr_no asc"


                grid()
            Else
                str = "SELECT     gr_no, year, f_name, l_name,address, stdfrom, stddob, stdgender, category, stdcaste FROM std_master where [f_name]='" & txtfirstname.Text & "' or [l_name]='" & txtlastname.Text & "' order by gr_no asc"
                str1 = "SELECT     gr_no, std_id, add_dte, add_std, remarks, category, leave_dte, leave_std, leave_rsn, progress, conduct, try_pass FROM         std_master where [f_name]='" & txtfirstname.Text & "' or [l_name]='" & txtlastname.Text & "' order by gr_no asc"

                grid()

            End If
        End If
    End Sub

    Private Sub txtfirstname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfirstname.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtlastname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlastname.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtgrno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgrno.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmviewgr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a.GridPropery(GridView1)
       

        d.conn()
        Dim _blankContextMenu As New ContextMenu()
        txtfirstname.ContextMenu = _blankContextMenu
        txtlastname.ContextMenu = _blankContextMenu
        txtgrno.ContextMenu = _blankContextMenu
    End Sub
    Private Sub gridvalid1()

        GridView1.Columns("gr_no").Caption = "GR No"
        GridView1.Columns("f_name").Caption = "First Name"
        GridView1.Columns("l_name").Caption = "Last Name"
        GridView1.Columns("address").Caption = "Address"
        GridView1.Columns("stdfrom").Caption = "From"
        GridView1.Columns("stddob").Caption = "DOB"
        GridView1.Columns("stdgender").Caption = "Gender"
        GridView1.Columns("category").Caption = "Category"

        GridView1.Columns("stdcaste").Caption = "Caste"
        GridView1.Columns("year").Caption = "Year"




        GridView1.Columns("gr_no").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("f_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("l_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("address").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stdfrom").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stddob").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stdgender").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("category").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        GridView1.Columns("stdcaste").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("year").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center




        GridView1.Columns("gr_no").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("f_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("l_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("address").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stdfrom").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stddob").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stdgender").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("category").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stdcaste").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("year").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

    End Sub
    Private Sub gridvalid2()
        GridView2.Columns("add_dte").Caption = "Admission Date"
        GridView2.Columns("add_std").Caption = "Admission Std"
        GridView2.Columns("remarks").Caption = "Remarks"
        GridView2.Columns("category").Caption = "Category"
        GridView2.Columns("leave_dte").Caption = "Leave Date"
        GridView2.Columns("leave_std").Caption = "Leave STD"
        GridView2.Columns("leave_rsn").Caption = "Reason"
        GridView2.Columns("progress").Caption = "Progress"
        GridView2.Columns("conduct").Caption = "Conduct"
        GridView2.Columns("try_pass").Caption = "Try of Passing"

        GridView2.Columns("add_dte").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("add_std").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("remarks").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("category").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("leave_dte").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("leave_std").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("leave_rsn").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("progress").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("conduct").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("try_pass").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        GridView2.Columns("add_dte").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("add_std").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("remarks").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("category").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("leave_dte").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("leave_std").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("leave_rsn").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("progress").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("conduct").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("try_pass").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center






    End Sub


    Private Sub txtgrno_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgrno.EditValueChanged
        If Not (txtgrno.Text = "") Then
            cmbyear.Enabled = False
            txtfirstname.Enabled = False
            txtlastname.Enabled = False

        Else
            cmbyear.Enabled = True
            txtfirstname.Enabled = True
            txtlastname.Enabled = True
        End If
    End Sub

    Private Sub cmbyear_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbyear.EditValueChanged
        If Not (cmbyear.Text = "") Then
            txtgrno.Enabled = False
            txtfirstname.Enabled = False
            txtlastname.Enabled = False

        Else
            txtgrno.Enabled = True
            txtfirstname.Enabled = True
            txtlastname.Enabled = True
        End If
    End Sub

    Private Sub txtfirstname_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfirstname.EditValueChanged
        If Not (txtfirstname.Text = "") Then
            txtgrno.Enabled = False
            cmbyear.Enabled = False
        Else
            If (txtlastname.Text = "") Then
                txtgrno.Enabled = True
                cmbyear.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtlastname_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlastname.EditValueChanged
        If Not (txtlastname.Text = "") Then
            txtgrno.Enabled = False
            cmbyear.Enabled = False
        Else
            If (txtfirstname.Text = "") Then
                txtgrno.Enabled = True
                cmbyear.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnprintp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpprev.Click
        btnpprev.Tag = "prv"
        reporting()

    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        btnpprev.Tag = "prn"
        reporting()
    End Sub
    Public Sub reporting()
        If (txtfirstname.Text = "" And txtlastname.Text = "" And cmbyear.Text = "" And txtgrno.Text = "") Then
            XtraMessageBox.Show("Please Enter Any One Field", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtgrno.Focus()
        Else
            If Not (txtgrno.Text = "") Then
               
                da = New SqlDataAdapter("SELECT     gr_no, year, f_name, l_name,address, stdfrom, stddob, stdgender, category, stdcaste,photo FROM std_master where [gr_no]='" & txtgrno.Text & "' order by gr_no asc", d.con)

            ElseIf Not (cmbyear.Text = "") Then
                
                da = New SqlDataAdapter("SELECT     gr_no, year, f_name, l_name,address, stdfrom, stddob, stdgender, category, stdcaste,photo FROM std_master where [year]='" & cmbyear.Text & "' order by gr_no asc", d.con)

            ElseIf Not (txtfirstname.Text = "" Or txtlastname.Text = "") Then
                
                da = New SqlDataAdapter("SELECT     gr_no, year, f_name, l_name,address, stdfrom, stddob, stdgender, category, stdcaste,photo FROM std_master where [f_name]='" & txtfirstname.Text & "' And [l_name]='" & txtlastname.Text & "' order by gr_no asc", d.con)

            Else
              
                da = New SqlDataAdapter("SELECT     gr_no, year, f_name, l_name,address, stdfrom, stddob, stdgender, category, stdcaste,photo FROM std_master where [f_name]='" & txtfirstname.Text & "' or [l_name]='" & txtlastname.Text & "' order by gr_no asc", d.con)


            End If
            If btnpprev.Tag = "prv" Then
                rempinfo("prv")
            ElseIf btnpprev.Tag = "prn" Then
                rempinfo("prn")
            End If
        End If

    End Sub
    Private Sub rempinfo(ByVal rpttype As String)
        Try
            ds.Clear()

            da.Fill(ds, "abc")
            Dim report2 As New rptgrstatement
            report2.DataSource = ds.Tables("abc")
            report2.DataMember = "abc"
            Try

                report2.xrphoto.DataBindings.Add("ImageUrl", ds.Tables("abc"), "abc.photo")

            Catch ex As Exception

            End Try
            report2.xrgrno.DataBindings.Add("Text", ds.Tables("abc"), "abc.gr_no")
            report2.xryear.DataBindings.Add("Text", ds.Tables("abc"), "abc.year")
            report2.xrfname.DataBindings.Add("Text", ds.Tables("abc"), "abc.f_name")

            report2.xrlname.DataBindings.Add("Text", ds.Tables("abc"), "abc.l_name")
            report2.xraddress.DataBindings.Add("Text", ds.Tables("abc"), "abc.address")
            report2.xrfrom.DataBindings.Add("Text", ds.Tables("abc"), "abc.stdfrom")
           
            report2.xrdob.DataBindings.Add("Text", ds.Tables("abc"), "abc.stddob")
            report2.xrgender.DataBindings.Add("Text", ds.Tables("abc"), "abc.stdgender")

            report2.Xrcategory.DataBindings.Add("Text", ds.Tables("abc"), "abc.category")
            report2.xrcaste.DataBindings.Add("Text", ds.Tables("abc"), "abc.stdcaste")



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
End Class
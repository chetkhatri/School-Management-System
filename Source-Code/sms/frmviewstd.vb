Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.CompilerServices
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports sms.DataItem



Public Class frmviewstd
    Dim a As New validation
    Dim d As New databind
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim con As New SqlConnection
    Dim str, str1 As String











    Private Sub frmviewstd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a.GridPropery(GridView1)
        d.PopulateCombo(cmbclassno, "class_id", "class_no", "class_schema", Nothing, True, Nothing, -1)
        d.conn()
        Dim _blankContextMenu As New ContextMenu()
        txtname.ContextMenu = _blankContextMenu

    End Sub
    Public Sub grid()
        Try
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

            grdstdview.DataSource = ds.Tables("master")
            gridvalid1()

            grdstdview.LevelTree.Nodes.Add("Detail", GridView2)
            GridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
            GridView2.PopulateColumns(ds.Tables("Detail"))


            GridView2.Columns("std_id").VisibleIndex = -1
            GridView2.Columns("gr_no").VisibleIndex = -1
            gridvalid2()
        Catch ex As Exception

        End Try

        

    End Sub
    Private Sub gridvalid1()
        GridView1.Columns("gr_no").Caption = "GR No"
        GridView1.Columns("std_id").Caption = "Student ID"
        GridView1.Columns("f_name").Caption = "First Name"
        GridView1.Columns("l_name").Caption = "Last Name"
        GridView1.Columns("address").Caption = "Address"
        GridView1.Columns("stddob").Caption = "DOB"
        GridView1.Columns("add_std").Caption = "Standard"
        GridView1.Columns("category").Caption = "Category"
        GridView1.Columns("stdgender").Caption = "Gender"
        GridView1.Columns("contactno").Caption = "Contact No"


        GridView1.Columns("gr_no").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("std_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("f_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("l_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("address").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stddob").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("add_std").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("category").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stdgender").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("contactno").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        GridView1.Columns("gr_no").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("std_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("f_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("l_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("address").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stddob").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("add_std").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("category").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stdgender").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("contactno").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

    End Sub
    Private Sub gridvalid2()
        GridView2.Columns("add_dte").Caption = "Admission Date"
        GridView2.Columns("add_std").Caption = "Admission Std"
        GridView2.Columns("skill").Caption = "Skills"
        GridView2.Columns("income_certi").Caption = "Income Certi."
        GridView2.Columns("caste_certi").Caption = "Caste Certi."
        GridView2.Columns("lc_entry").Caption = "LC Entry"
        GridView2.Columns("result_entry").Caption = "Result"
        GridView2.Columns("last_Scl").Caption = "Last Study"
        GridView2.Columns("entrance").Caption = "Entrance"

        GridView2.Columns("add_dte").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("add_std").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("skill").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("income_certi").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("caste_certi").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("lc_entry").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("result_entry").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("last_Scl").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("entrance").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        GridView2.Columns("add_dte").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("add_std").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("skill").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("income_certi").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("caste_certi").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("lc_entry").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("result_entry").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("last_Scl").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("entrance").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center






    End Sub

    Private Sub cmbclassno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclassno.SelectedIndexChanged
        txtname.Enabled = False

        Try
            d.PopulateCombo(cmbstdid, "std_id", "std_id", "std_master where add_std =" & cmbclassno.Text)
        Catch ex As Exception

        End Try

    End Sub
    

    Private Sub btnviewall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewall.Click
        If (txtname.Text = "" And cmbclassno.Text = "" And cmbstdid.Text = "") Then
            XtraMessageBox.Show("Please Enter Any One Field", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtname.Focus()
        Else
            If Not (txtname.Text = "") Then
                str = "SELECT     gr_no, std_id, f_name, l_name, address, stddob, stdgender, add_std, category, contactno FROM std_master WHERE     (f_name like '%" & txtname.Text & "%')"
                str1 = "SELECT    gr_no, std_id, add_dte, add_std, skill, income_certi, caste_certi, lc_entry, result_entry, entrance, last_Scl  FROM std_master WHERE     (f_name like '%" & txtname.Text & "%')"
                grid()

            ElseIf Not (cmbclassno.Text = "") Then
                If Not (cmbstdid.Text = "") Then
                    str = "SELECT     gr_no, std_id, f_name, l_name, address, stddob, stdgender, add_std, category, contactno FROM std_master WHERE     (add_std = '" & cmbclassno.Text & "' and [std_id]='" & cmbstdid.Text & "')"
                    str1 = "SELECT    gr_no, std_id, add_dte, add_std, skill, income_certi, caste_certi, lc_entry, result_entry, entrance, last_Scl  FROM std_master WHERE     (add_std = '" & cmbclassno.Text & "' and [std_id]='" & cmbstdid.Text & "')"
                    grid()
                Else
                    str = "SELECT     gr_no, std_id, f_name, l_name, address, stddob, stdgender, add_std, category, contactno FROM std_master WHERE     (add_std = '" & cmbclassno.Text & "')"
                    str1 = "SELECT    gr_no, std_id, add_dte, add_std, skill, income_certi, caste_certi, lc_entry, result_entry, entrance, last_Scl  FROM std_master WHERE     (add_std = '" & cmbclassno.Text & "')"
                    grid()

                End If

            End If
        End If
    End Sub
    Public Sub reporting()
        If (txtname.Text = "" And cmbclassno.Text = "" And cmbstdid.Text = "") Then
            XtraMessageBox.Show("Please Enter Any One Field", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtname.Focus()
        Else
            If Not (txtname.Text = "") Then
                
                da = New SqlDataAdapter("SELECT     gr_no, std_id, f_name, l_name, m_name, add_dte, address, stddob, stdgender, add_std, category, contactno,mail,photo FROM std_master WHERE     (f_name like '%" & txtname.Text & "%')", d.con)

            ElseIf Not (cmbclassno.Text = "") Then
                If Not (cmbstdid.Text = "") Then
                    
                    da = New SqlDataAdapter("SELECT     gr_no, std_id, f_name, l_name, m_name, add_dte, address, stddob, stdgender, add_std, category, contactno,mail,photo FROM std_master WHERE     (add_std = '" & cmbclassno.Text & "' and [std_id]='" & cmbstdid.Text & "')", d.con)
                Else
                    
                    da = New SqlDataAdapter("SELECT     gr_no, std_id, f_name, l_name, m_name, add_dte, address, stddob, stdgender, add_std, category, contactno,mail,photo FROM std_master WHERE     (add_std = '" & cmbclassno.Text & "')", d.con)

                End If
               

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
            Dim report2 As New rptaddmission
            report2.DataSource = ds.Tables("abc")
            report2.DataMember = "abc"
            Try
                
                report2.xrphoto.DataBindings.Add("ImageUrl", ds.Tables("abc"), "abc.photo")

            Catch ex As Exception

            End Try
            report2.xrfname.DataBindings.Add("Text", ds.Tables("abc"), "abc.f_name")
            report2.xrmname.DataBindings.Add("Text", ds.Tables("abc"), "abc.m_name")
            report2.xrlname.DataBindings.Add("Text", ds.Tables("abc"), "abc.l_name")
            report2.xrgrno.DataBindings.Add("Text", ds.Tables("abc"), "abc.gr_no")
            report2.xrdte.DataBindings.Add("Text", ds.Tables("abc"), "abc.add_dte")
            report2.xrstdid.DataBindings.Add("Text", ds.Tables("abc"), "abc.std_id")
            report2.xrfirst.DataBindings.Add("Text", ds.Tables("abc"), "abc.f_name")
            report2.xrlast.DataBindings.Add("Text", ds.Tables("abc"), "abc.l_name")
            report2.xradd.DataBindings.Add("Text", ds.Tables("abc"), "abc.address")
            report2.xrdob.DataBindings.Add("Text", ds.Tables("abc"), "abc.stddob")
            report2.xrgender.DataBindings.Add("Text", ds.Tables("abc"), "abc.stdgender")
            report2.xrstd.DataBindings.Add("Text", ds.Tables("abc"), "abc.add_std")
            report2.xrcatogory.DataBindings.Add("Text", ds.Tables("abc"), "abc.category")
            report2.xrcontactno.DataBindings.Add("Text", ds.Tables("abc"), "abc.contactno")
            report2.xremailid.DataBindings.Add("Text", ds.Tables("abc"), "abc.mail")


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

    Private Sub txtname_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.EditValueChanged
        If Not (txtname.Text = "") Then
            cmbclassno.Enabled = False
            cmbstdid.Enabled = False
        Else
            cmbclassno.Enabled = True
            cmbstdid.Enabled = True
        End If
    End Sub

    Private Sub cmbstdid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstdid.SelectedIndexChanged
        txtname.Enabled = False
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtname.Text = ""
        cmbclassno.Text = ""
        cmbstdid.Text = ""
        txtname.Enabled = True
        cmbclassno.Enabled = True
        cmbstdid.Enabled = True
        txtname.Focus()

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub txtname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
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
End Class


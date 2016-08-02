Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.CompilerServices
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Public Class frmviewall
    Dim a As New validation
    Dim d As New databind
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Private Sub frmviewall_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.PopulateCombo(cmbempid, "emp_id", "emp_id", "emp_master", Nothing, True, Nothing, -1)
        grid1valid()

        d.conn()

        a.GridPropery(GridView1)
        GridView1.OptionsView.ShowAutoFilterRow = True
        Dim _blankContextMenu As New ContextMenu()
        txtempname.ContextMenu = _blankContextMenu
        txtyear.ContextMenu = _blankContextMenu

    End Sub
    Private Sub grid1valid()
        GridView1.Columns("emp_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("emp_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("f_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("f_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("month").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("month").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("year").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("year").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("attend").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("attend").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("tax").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("tax").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("basic").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("basic").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("deduction").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("deduction").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("gross").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("gross").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("net_sal").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("net_sal").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center



    End Sub
    Private Sub txtempname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtempname.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtyear_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtyear.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If (cmbempid.Text = "" And txtempname.Text = "" And cmbmonth.Text = "" And txtyear.Text = "") Then
            XtraMessageBox.Show("Please Enter Any One Field", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbempid.Focus()
        Else
            If Not (cmbempid.Text = "") Then

                d.gridfill("SELECT      emp_master.f_name,HRM_regi.* FROM         emp_master INNER JOIN HRM_regi ON emp_master.emp_id = HRM_regi.emp_id WHERE     (HRM_regi.emp_id = '" & cmbempid.Text & "')", grdsal)




            ElseIf Not (txtempname.Text = "") Then
                d.gridfill("SELECT      emp_master.f_name,HRM_regi.* FROM         emp_master INNER JOIN HRM_regi ON emp_master.emp_id = HRM_regi.emp_id WHERE     (emp_master.f_name like '%" & txtempname.Text & "%')", grdsal)


            ElseIf Not (cmbmonth.Text = "") Then
                d.gridfill("SELECT     emp_master.f_name,HRM_regi.* FROM         emp_master INNER JOIN HRM_regi ON emp_master.emp_id = HRM_regi.emp_id WHERE     (HRM_regi.month = '" & cmbmonth.Text & "') order by HRM_regi.emp_id asc", grdsal)



            ElseIf Not (txtyear.Text = "") Then
                d.gridfill("SELECT     HRM_regi.*, emp_master.f_name FROM         emp_master INNER JOIN HRM_regi ON emp_master.emp_id = HRM_regi.emp_id WHERE     (HRM_regi.year = '" & txtyear.Text & "') order by HRM_regi.emp_id asc", grdsal)

            End If

        End If
    End Sub
    Private Sub reporting()
        If (cmbempid.Text = "" And txtempname.Text = "" And cmbmonth.Text = "" And txtyear.Text = "") Then
            XtraMessageBox.Show("Please Enter Any One Field", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbempid.Focus()
        Else
            If Not (cmbempid.Text = "") Then


                'da = New SqlDataAdapter("SELECT      emp_master.f_name,HRM_regi.* FROM         emp_master INNER JOIN HRM_regi ON emp_master.emp_id = HRM_regi.emp_id WHERE     (HRM_regi.emp_id = '" & cmbempid.Text & "')", d.con)
                da = New SqlDataAdapter("SELECT     HRM_regi.emp_id, emp_master.f_name,emp_master.post_id,emp_master.m_name,emp_master.l_name,emp_master.gov_no,emp_master.pan,emp_master.gpf,emp_master.pran, CONVERT(varchar(11), HRM_regi.dte, 103) AS dte, HRM_regi.month, HRM_regi.year, HRM_regi.attend, HRM_regi.tax, HRM_regi.basic, HRM_regi.deduction, HRM_regi.gross, HRM_regi.net_sal FROM         emp_master INNER JOIN HRM_regi ON emp_master.emp_id = HRM_regi.emp_id WHERE     (HRM_regi.emp_id = '" & cmbempid.Text & "')", d.con)


            ElseIf Not (txtempname.Text = "") Then

                'da = New SqlDataAdapter("SELECT      emp_master.f_name,HRM_regi.* FROM         emp_master INNER JOIN HRM_regi ON emp_master.emp_id = HRM_regi.emp_id WHERE     (emp_master.f_name like '%" & txtempname.Text & "%')", d.con)
                da = New SqlDataAdapter("SELECT     HRM_regi.emp_id, emp_master.f_name,emp_master.post_id,emp_master.m_name,emp_master.l_name,emp_master.gov_no,emp_master.pan,emp_master.gpf,emp_master.pran, CONVERT(varchar(11), HRM_regi.dte, 103) AS dte, HRM_regi.month, HRM_regi.year, HRM_regi.attend, HRM_regi.tax, HRM_regi.basic, HRM_regi.deduction, HRM_regi.gross, HRM_regi.net_sal FROM         emp_master INNER JOIN HRM_regi ON emp_master.emp_id = HRM_regi.emp_id WHERE     (emp_master.f_name like '%" & txtempname.Text & "%')", d.con)


            ElseIf Not (cmbmonth.Text = "") Then

                'da = New SqlDataAdapter("SELECT     emp_master.f_name,HRM_regi.* FROM         emp_master INNER JOIN HRM_regi ON emp_master.emp_id = HRM_regi.emp_id WHERE     (HRM_regi.month = '" & cmbmonth.Text & "')", d.con)
                da = New SqlDataAdapter("SELECT     HRM_regi.emp_id, emp_master.f_name,emp_master.post_id,emp_master.m_name,emp_master.l_name,emp_master.gov_no,emp_master.pan,emp_master.gpf,emp_master.pran, CONVERT(varchar(11), HRM_regi.dte, 103) AS dte, HRM_regi.month, HRM_regi.year, HRM_regi.attend, HRM_regi.tax, HRM_regi.basic, HRM_regi.deduction, HRM_regi.gross, HRM_regi.net_sal FROM         emp_master INNER JOIN HRM_regi ON emp_master.emp_id = HRM_regi.emp_id WHERE     (HRM_regi.month = '" & cmbmonth.Text & "' ) order by HRM_regi.emp_id asc", d.con)



            ElseIf Not (txtyear.Text = "") Then

                'da = New SqlDataAdapter("SELECT     HRM_regi.*, emp_master.f_name FROM         emp_master INNER JOIN HRM_regi ON emp_master.emp_id = HRM_regi.emp_id WHERE     (HRM_regi.year = '" & txtyear.Text & "')", d.con)
                da = New SqlDataAdapter("SELECT     HRM_regi.emp_id, emp_master.f_name,emp_master.post_id,emp_master.m_name,emp_master.l_name,emp_master.gov_no,emp_master.pan,emp_master.gpf,emp_master.pran, CONVERT(varchar(11), HRM_regi.dte, 103) AS dte, HRM_regi.month, HRM_regi.year, HRM_regi.attend, HRM_regi.tax, HRM_regi.basic, HRM_regi.deduction, HRM_regi.gross, HRM_regi.net_sal FROM         emp_master INNER JOIN HRM_regi ON emp_master.emp_id = HRM_regi.emp_id WHERE     (HRM_regi.year = '" & txtyear.Text & "') order by HRM_regi.emp_id asc", d.con)

            End If

            If btnpprev.Tag = "prv" Then
                rempinfo("prv")
            ElseIf btnpprev.Tag = "prn" Then
                rempinfo("prn")
            End If
        End If
    End Sub

    Private Sub cmbempid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbempid.SelectedIndexChanged
        txtempname.Enabled = False
        cmbmonth.Enabled = False
        txtyear.Enabled = False

    End Sub

    Private Sub txtempname_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtempname.EditValueChanged
        If Not (txtempname.Text = "") Then
            cmbempid.Enabled = False
            cmbmonth.Enabled = False
            txtyear.Enabled = False
        Else
            cmbempid.Enabled = True
            cmbmonth.Enabled = True
            txtyear.Enabled = True
        End If
    End Sub

    Private Sub txtyear_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtyear.EditValueChanged
        If Not (txtyear.Text = "") Then
            cmbempid.Enabled = False
            cmbmonth.Enabled = False
            txtempname.Enabled = False
        Else
            cmbempid.Enabled = True
            cmbmonth.Enabled = True
            txtempname.Enabled = True
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
       
        cmbmonth.Text = ""
        cmbempid.Text = ""
        txtempname.Text = ""
        txtyear.Text = ""
        cmbempid.Enabled = True
        cmbmonth.Enabled = True
        txtempname.Enabled = True
        txtyear.Enabled = True
        cmbempid.Focus()

    End Sub

    Private Sub cmbmonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmonth.SelectedIndexChanged
        cmbempid.Enabled = False
        txtempname.Enabled = False
        txtyear.Enabled = False
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub btnpprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpprev.Click
        btnpprev.Tag = "prv"
        reporting()

    End Sub
    Private Sub rempinfo(ByVal rpttype As String)
        Try
            ds.Clear()

            da.Fill(ds, "abc")
            Dim report2 As New rptempsal
            report2.DataSource = ds.Tables("abc")
            report2.DataMember = "abc"
            report2.xrempid.DataBindings.Add("Text", ds.Tables("abc"), "abc.emp_id")
            report2.xrname.DataBindings.Add("Text", ds.Tables("abc"), "abc.f_name")
            report2.xrdte.DataBindings.Add("Text", ds.Tables("abc"), "abc.dte")
            report2.xrmonth.DataBindings.Add("Text", ds.Tables("abc"), "abc.month")
            report2.xryear.DataBindings.Add("Text", ds.Tables("abc"), "abc.year")
            report2.xrattend.DataBindings.Add("Text", ds.Tables("abc"), "abc.attend")
            report2.xrmethod.DataBindings.Add("Text", ds.Tables("abc"), "abc.tax")
            report2.xrbasic.DataBindings.Add("Text", ds.Tables("abc"), "abc.basic")
            report2.xrded.DataBindings.Add("Text", ds.Tables("abc"), "abc.deduction")
            report2.xrgross.DataBindings.Add("Text", ds.Tables("abc"), "abc.gross")
            report2.xrnet.DataBindings.Add("Text", ds.Tables("abc"), "abc.net_sal")
            Try
                report2.xrfname.DataBindings.Add("Text", ds.Tables("abc"), "abc.f_name")
                report2.xrmname.DataBindings.Add("Text", ds.Tables("abc"), "abc.m_name")
                report2.xrlname.DataBindings.Add("Text", ds.Tables("abc"), "abc.l_name")
                'report2.xrpost.DataBindings.Add("Text", ds.Tables("abc"), "abc.f_name")

                report2.xrgovno.DataBindings.Add("Text", ds.Tables("abc"), "abc.gov_no")
                report2.xrpanno.DataBindings.Add("Text", ds.Tables("abc"), "abc.pan")
                report2.xrpranno.DataBindings.Add("Text", ds.Tables("abc"), "abc.pran")
                report2.xrgpfno.DataBindings.Add("Text", ds.Tables("abc"), "abc.gpf")
            Catch ex As Exception

            End Try
            Try
                cmd = New SqlCommand("select post_name from tbpost where post_id='" & ds.Tables("abc").Rows(0).Item("post_id") & "'", d.con)
                report2.xrpost.Text = cmd.ExecuteScalar

            Catch ex As Exception

            End Try
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
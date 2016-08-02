Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Runtime.CompilerServices
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Public Class frmresultfilter
    Dim a As New validation
    Dim d As New databind
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim con As New SqlConnection
    Dim str, str1 As String
    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If (cmbclsno.Text = "" And cmbsem.Text = "" And cmbstdid.Text = "" And cmbsub.Text = "") Then
            XtraMessageBox.Show("Please Select Any One Field", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbclsno.Focus()
        ElseIf (cmbclsno.Text = "" And cmbstdid.Text = "" And cmbsub.Text = "") Then
            XtraMessageBox.Show("Please Select Class NO", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbclsno.Focus()
        ElseIf Not (cmbsub.Text = "") Then
            If Not (cmbsem.Text = "") Then
                d.gridfill("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem,exam_master.sub_id, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id where exam_master.class_id=" & cmbclsno.Text & " and exam_master.std_id=" & cmbstdid.Text & " and exam_master.sem=" & cmbsem.Text & " and sub_regi.s_name='" & cmbsub.Text & "' order by exam_master.class_id asc", grdresult)
            Else
                XtraMessageBox.Show("Please Select Semester", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbsem.Focus()

            End If
        ElseIf Not (cmbclsno.Text = "") Then
            If Not (cmbstdid.Text = "") Then
                If Not (cmbsem.Text = "") Then
                    If Not (cmbsub.Text = "") Then
                        d.gridfill("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem,exam_master.sub_id, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id where exam_master.class_id=" & cmbclsno.Text & " and exam_master.std_id=" & cmbstdid.Text & " and exam_master.sem=" & cmbsem.Text & " and sub_regi.s_name='" & cmbsub.Text & "' order by exam_master.class_id asc", grdresult)
                    Else
                        d.gridfill("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem,exam_master.sub_id, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id where exam_master.class_id=" & cmbclsno.Text & " and exam_master.std_id=" & cmbstdid.Text & " and exam_master.sem=" & cmbsem.Text & " order by exam_master.class_id asc", grdresult)
                    End If
                Else
                    d.gridfill("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem,exam_master.sub_id, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id where exam_master.class_id=" & cmbclsno.Text & " and exam_master.std_id=" & cmbstdid.Text & " order by exam_master.class_id asc", grdresult)
                End If
            ElseIf Not (cmbsem.Text = "") Then
                d.gridfill("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem,exam_master.sub_id, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id where exam_master.class_id=" & cmbclsno.Text & " and exam_master.sem=" & cmbsem.Text & " order by exam_master.class_id asc", grdresult)

            Else
                d.gridfill("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem,exam_master.sub_id, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id where exam_master.class_id=" & cmbclsno.Text & " order by exam_master.class_id asc", grdresult)
            End If

        End If
    End Sub
    Private Sub gridvalid()
        GridView1.Columns("class_id").Caption = "Class ID"
        GridView1.Columns("std_id").Caption = "Student ID"
        GridView1.Columns("sem").Caption = "Sem"
        GridView1.Columns("s_name").Caption = "Subject"
        GridView1.Columns("fa1").Caption = "FA-1"
        GridView1.Columns("fa2").Caption = "FA-2"
        GridView1.Columns("sa1").Caption = "SA-1"
        GridView1.Columns("siddhi").Caption = "Siddhi Marks"
        GridView1.Columns("krupa").Caption = "Krupa Marks"
        GridView1.Columns("total").Caption = "Total"
        GridView1.Columns("status").Caption = "Status"


        GridView1.Columns("exam_id").VisibleIndex = -1
        GridView1.Columns("sub_id").VisibleIndex = -1

        GridView1.Columns("class_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("class_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("std_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("std_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("sem").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("sem").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("s_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("s_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("fa1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("fa1").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("fa2").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("fa2").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("sa1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("sa1").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("siddhi").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("siddhi").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("krupa").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("krupa").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("total").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("total").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("status").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("status").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

    End Sub

    Private Sub frmresultfilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        a.GridPropery(GridView1)
        d.PopulateCombo(cmbclsno, "class_id", "class_no", "class_schema", Nothing, True, Nothing, -1)
        d.conn()
        d.gridfill("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem,exam_master.sub_id, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id order by exam_master.class_id asc", grdresult)
        gridvalid()
        GridView1.OptionsView.ShowAutoFilterRow = True
        Try
            cmbstdid.SelectedIndex = -1

            cmbsem.SelectedIndex = -1
            cmbsub.SelectedIndex = -1
            cmbclsno.Focus()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbclsno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclsno.SelectedIndexChanged
        d.PopulateCombo(cmbstdid, "std_id", "std_id", "std_master where add_std =" & cmbclsno.Text)
        d.conn()
    End Sub

    Private Sub cmbstdid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstdid.SelectedIndexChanged
        d.PopulateCombo(cmbsub, "sub_id", "s_name", "sub_regi")
        
        d.conn()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub
    Private Sub GridView1_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell

        If CType(CType(e.Cell, Object), DevExpress.XtraGrid.Views.Grid.ViewInfo.GridCellInfo).ColumnInfo.Caption = "Status" Then
            If e.DisplayText = "Fail" Then
                e.Appearance.BackColor = System.Drawing.Color.Red
            Else
                e.Appearance.BackColor = Nothing
            End If
        End If

    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        Try
            cmbstdid.SelectedIndex = -1

            cmbsem.SelectedIndex = -1
            cmbsub.SelectedIndex = -1
            cmbclsno.Focus()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnpprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpprev.Click
        btnpprev.Tag = "prv"
        reporting()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        btnpprev.Tag = "prn"
        reporting()
    End Sub
    Public Sub reporting()
        If (cmbclsno.Text = "" And cmbsem.Text = "" And cmbstdid.Text = "" And cmbsub.Text = "") Then
            XtraMessageBox.Show("Please Select Any One Field", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbclsno.Focus()
        ElseIf (cmbclsno.Text = "" And cmbstdid.Text = "" And cmbsub.Text = "") Then
            XtraMessageBox.Show("Please Select Class NO", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbclsno.Focus()
        ElseIf Not (cmbsub.Text = "") Then
            If Not (cmbsem.Text = "") Then

                da = New SqlDataAdapter("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem, exam_master.sub_id, sub_regi.s_name, exam_master.fa1,exam_master.fa2, exam_master.sa1, exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status, std_master.f_name FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id INNER JOIN std_master ON exam_master.std_id = std_master.std_id AND exam_master.class_id = std_master.add_std where exam_master.class_id=" & cmbclsno.Text & " and exam_master.std_id=" & cmbstdid.Text & " and exam_master.sem=" & cmbsem.Text & " and sub_regi.s_name='" & cmbsub.Text & "' order by exam_master.class_id asc", d.con)

            Else
                XtraMessageBox.Show("Please Select Semester", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbsem.Focus()

            End If
        ElseIf Not (cmbclsno.Text = "") Then
            If Not (cmbstdid.Text = "") Then
                If Not (cmbsem.Text = "") Then
                    If Not (cmbsub.Text = "") Then

                        'da = New SqlDataAdapter("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem,exam_master.sub_id, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id where exam_master.class_id=" & cmbclsno.Text & " and exam_master.std_id=" & cmbstdid.Text & " and exam_master.sem=" & cmbsem.Text & " and sub_regi.s_name='" & cmbsub.Text & "' order by exam_master.class_id asc", d.con)

                        da = New SqlDataAdapter("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem, exam_master.sub_id, sub_regi.s_name, exam_master.fa1,exam_master.fa2, exam_master.sa1, exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status, std_master.f_name FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id INNER JOIN std_master ON exam_master.std_id = std_master.std_id AND exam_master.class_id = std_master.add_std where exam_master.class_id=" & cmbclsno.Text & " and exam_master.std_id=" & cmbstdid.Text & " and exam_master.sem=" & cmbsem.Text & " and sub_regi.s_name='" & cmbsub.Text & "' order by exam_master.class_id asc", d.con)

                    Else

                        'da = New SqlDataAdapter("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem,exam_master.sub_id, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id where exam_master.class_id=" & cmbclsno.Text & " and exam_master.std_id=" & cmbstdid.Text & " and exam_master.sem=" & cmbsem.Text & " order by exam_master.class_id asc", d.con)

                        da = New SqlDataAdapter("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem, exam_master.sub_id, sub_regi.s_name, exam_master.fa1,exam_master.fa2, exam_master.sa1, exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status, std_master.f_name FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id INNER JOIN std_master ON exam_master.std_id = std_master.std_id AND exam_master.class_id = std_master.add_std where exam_master.class_id=" & cmbclsno.Text & " and exam_master.std_id=" & cmbstdid.Text & " and exam_master.sem=" & cmbsem.Text & " order by exam_master.class_id asc", d.con)

                    End If
                Else

                    'da = New SqlDataAdapter("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem,exam_master.sub_id, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id where exam_master.class_id=" & cmbclsno.Text & " and exam_master.std_id=" & cmbstdid.Text & " order by exam_master.class_id asc", d.con)

                    da = New SqlDataAdapter("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem, exam_master.sub_id, sub_regi.s_name, exam_master.fa1,exam_master.fa2, exam_master.sa1, exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status, std_master.f_name FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id INNER JOIN std_master ON exam_master.std_id = std_master.std_id AND exam_master.class_id = std_master.add_std where exam_master.class_id=" & cmbclsno.Text & " and exam_master.std_id=" & cmbstdid.Text & " order by exam_master.class_id asc", d.con)

                End If
            ElseIf Not (cmbsem.Text = "") Then

                'da = New SqlDataAdapter("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem,exam_master.sub_id, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id where exam_master.class_id=" & cmbclsno.Text & " and exam_master.sem=" & cmbsem.Text & " order by exam_master.class_id asc", d.con)

                da = New SqlDataAdapter("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem, exam_master.sub_id, sub_regi.s_name, exam_master.fa1,exam_master.fa2, exam_master.sa1, exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status, std_master.f_name FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id INNER JOIN std_master ON exam_master.std_id = std_master.std_id AND exam_master.class_id = std_master.add_std where exam_master.class_id=" & cmbclsno.Text & " and exam_master.sem=" & cmbsem.Text & " order by exam_master.class_id asc", d.con)


            Else

                'da = New SqlDataAdapter("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem,exam_master.sub_id, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id where exam_master.class_id=" & cmbclsno.Text & " order by exam_master.class_id asc", d.con)

                da = New SqlDataAdapter("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem, exam_master.sub_id, sub_regi.s_name, exam_master.fa1,exam_master.fa2, exam_master.sa1, exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status, std_master.f_name FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id INNER JOIN std_master ON exam_master.std_id = std_master.std_id AND exam_master.class_id = std_master.add_std where exam_master.class_id=" & cmbclsno.Text & " order by exam_master.class_id asc", d.con)

            End If
           

        End If
        If btnpprev.Tag = "prv" Then
            rempinfo("prv")
        ElseIf btnpprev.Tag = "prn" Then
            rempinfo("prn")
        End If
    End Sub
    Private Sub rempinfo(ByVal rpttype As String)
        Dim stat As String
        Try
            ds.Clear()

            da.Fill(ds, "abc")
            Dim report2 As New rptresultall
            report2.DataSource = ds.Tables("abc")
            report2.DataMember = "abc"

            report2.xrclassid.DataBindings.Add("Text", ds.Tables("abc"), "abc.class_id")
            report2.xrstdid.DataBindings.Add("Text", ds.Tables("abc"), "abc.std_id")
            report2.xrsem.DataBindings.Add("Text", ds.Tables("abc"), "abc.sem")

            report2.xrname.DataBindings.Add("Text", ds.Tables("abc"), "abc.f_name")
            report2.xrsub.DataBindings.Add("Text", ds.Tables("abc"), "abc.s_name")
            report2.xrfa1.DataBindings.Add("Text", ds.Tables("abc"), "abc.fa1")

            report2.xrfa2.DataBindings.Add("Text", ds.Tables("abc"), "abc.fa2")
            report2.xrsa1.DataBindings.Add("Text", ds.Tables("abc"), "abc.sa1")

            report2.xrsiddhi.DataBindings.Add("Text", ds.Tables("abc"), "abc.siddhi")
            report2.xrkrupa.DataBindings.Add("Text", ds.Tables("abc"), "abc.krupa")
            report2.xrtotal.DataBindings.Add("Text", ds.Tables("abc"), "abc.total")
            Try
                'stat = report2.xrstatus.DataBindings.Add("Text", ds.Tables("abc"), "abc.status").ToString()
                stat = Conversions.ToString(report2.xrstatus.DataBindings.Add("Text", ds.Tables("abc"), "abc.status"))


                If stat = "Fail" Then
                    report2.xrstatus.ForeColor = Color.Red
                ElseIf stat = "Pass" Then
                    report2.xrstatus.ForeColor = Color.Black
                End If
            Catch ex As Exception

            End Try
            report2.xrstatus.DataBindings.Add("Text", ds.Tables("abc"), "abc.status")



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
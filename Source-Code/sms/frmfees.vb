Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Public Class frmfees
    Dim a As New validation

    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim d As New databind
    Dim j As Integer

    Private Sub frmfeesscholor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        a.GridPropery(GridView1)
        d.PopulateCombo(cmbclsno, "class_id", "class_no", "class_schema", Nothing, True, Nothing, -1)
        d.conn()
        d.gridfill("select * from fees_master order by fees_id asc", grdfees)
        gridvalid()
        totalfee()
        GridView1.OptionsView.ShowAutoFilterRow = True
        grpfees.Enabled = False
        btnsave.Enabled = False
        btnreset.Enabled = False
        Try
            cmd = New SqlCommand("select count(fees_id) from fees_master", d.con)
            If cmd.ExecuteScalar <= 0 Then
                btnedit.Enabled = False
            Else
                btnedit.Enabled = True
            End If
        Catch ex As Exception

        End Try
        Dim _blankContextMenu As New ContextMenu()
        txtamt.ContextMenu = _blankContextMenu

    End Sub

    Private Sub cmbclsno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclsno.SelectedIndexChanged
        d.PopulateCombo(cmbstdno, "std_id", "std_id", "std_master where add_std =" & cmbclsno.Text)
        d.conn()
    End Sub
    Private Sub gridvalid()
        GridView1.Columns("std_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("std_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("class_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("class_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("fee_type").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("fee_type").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("amt").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("amt").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If a.txtstring(cmbclsno, lblclassno) = True Then
            XtraMessageBox.Show("Please Select Class", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(cmbstdno, lblstdno) = True Then
            XtraMessageBox.Show("Please Select Student ID", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(cmbfees, lblfeetype) = True Then
            XtraMessageBox.Show("Please Fees Type", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtamt, lblamt) = True Then
            XtraMessageBox.Show("Please Enter Fees Amount", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                If btnsave.Tag = "add" Then
                    cmd = New SqlCommand("insert into fees_master values(" & cmbstdno.Text & "," & cmbclsno.Text & ",'" & cmbfees.Text & "','" & txtamt.Text & "','" & Now.ToString("dd/MM/yyyy") & "')", d.con)
                    cmd.ExecuteNonQuery()
                    XtraMessageBox.Show("Fees Accepted Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ElseIf btnsave.Tag = "update" Then
                    cmd = New SqlCommand("update fees_master set[std_id]='" & cmbstdno.Text & "',[class_id]='" & cmbclsno.Text & "',[fee_type]='" & cmbfees.Text & "',[amt]='" & txtamt.Text & "',[dte]='" & Now.ToString("dd/MM/yyyy") & "' where [fees_id]='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "fees_id") & "'", d.con)
                    cmd.ExecuteNonQuery()
                    XtraMessageBox.Show("Fees Record Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                d.gridfill("select * from fees_master order by fees_id asc", grdfees)
                


                btnsave.Enabled = False
                btnreset.Enabled = False
                btnedit.Enabled = True
                btnadd.Enabled = True
                grpfees.Enabled = False
                Try
                    cmd = New SqlCommand("select count(fees_id) from fees_master", d.con)
                    If cmd.ExecuteScalar <= 0 Then
                        btnedit.Enabled = False
                    Else
                        btnedit.Enabled = True
                    End If
                Catch ex As Exception

                End Try
                totalfee()

            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        If (Me.GridView1.FocusedRowHandle >= 0) Then

            Try
                grpfees.Enabled = False

                cmbclsno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "class_id")
                cmbstdno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "std_id")
                cmbfees.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "fee_type")
                txtamt.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "amt")
                btnsave.Enabled = False
                btnreset.Enabled = False
                btnedit.Enabled = True
                btnadd.Enabled = True
            Catch ex As Exception

            End Try

            
        End If
        

    End Sub

    Private Sub txtamt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamt.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub
    

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        cmbstdno.SelectedIndex = -1
        cmbfees.SelectedIndex = -1
        txtamt.Text = ""
        cmbclsno.Focus()

    End Sub
    Private Sub totalfee()
        Try
            cmd = New SqlCommand("select sum(amt) from fees_master", d.con)
            lbltotal.Text = cmd.ExecuteScalar()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        grpfees.Enabled = True
        cmbstdno.SelectedIndex = -1
        cmbfees.SelectedIndex = -1
        txtamt.Text = ""
        btnsave.Tag = "add"

        btnedit.Enabled = False

        btnadd.Enabled = False
        btnsave.Enabled = True


        btnreset.Enabled = True

    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        btnsave.Tag = "update"
        btnedit.Enabled = False
        btnsave.Enabled = True
        btnadd.Enabled = False
        btnreset.Enabled = True
        grpfees.Enabled = True
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub btnpprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpprev.Click
        btnpprev.Tag = "prv"
        reporting()
    End Sub
    Private Sub reporting()
        If a.txtstring(cmbclsno, lblclassno) = True Then
            XtraMessageBox.Show("Please Select Class", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(cmbstdno, lblstdno) = True Then
            XtraMessageBox.Show("Please Select Student ID", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(cmbfees, lblfeetype) = True Then
            XtraMessageBox.Show("Please Fees Type", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtamt, lblamt) = True Then
            XtraMessageBox.Show("Please Enter Fees Amount", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If btnpprev.Tag = "prv" Then
                rempinfo("prv")
            ElseIf btnpprev.Tag = "prn" Then
                rempinfo("prn")
            End If
        End If

    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        btnpprev.Tag = "prn"
        reporting()
    End Sub
    Private Sub rempinfo(ByVal rpttype As String)
        Dim add As Integer = 0
        Dim sem As Integer = 0
        Dim tut As Integer = 0
        Dim exam As Integer = 0
        Dim all As Integer = 0
        Try
            da = New SqlDataAdapter("SELECT     std_master.f_name, std_master.m_name, std_master.l_name, fees_master.std_id, fees_master.class_id, fees_master.fee_type, fees_master.amt FROM         fees_master INNER JOIN std_master ON fees_master.std_id = std_master.std_id AND fees_master.class_id = std_master.add_std WHERE     (fees_master.class_id = " & cmbclsno.Text & ") AND (fees_master.std_id = " & cmbstdno.Text & ")", d.con)

            ds.Clear()

            da.Fill(ds, "abc")
            Dim report2 As New rptfeesreceipt
            report2.DataSource = ds.Tables("abc")
            report2.DataMember = "abc"


            report2.xrfname.DataBindings.Add("Text", ds.Tables("abc"), "abc.f_name")
            report2.xrmname.DataBindings.Add("Text", ds.Tables("abc"), "abc.m_name")
            report2.xrlname.DataBindings.Add("Text", ds.Tables("abc"), "abc.l_name")

            report2.xrclass.DataBindings.Add("Text", ds.Tables("abc"), "abc.class_id")
            report2.xrstdid.DataBindings.Add("Text", ds.Tables("abc"), "abc.std_id")
            report2.xrfeetype.DataBindings.Add("Text", ds.Tables("abc"), "abc.fee_type")
            report2.xrfamt.DataBindings.Add("Text", ds.Tables("abc"), "abc.amt")

            Try
                cmd = New SqlCommand("select sum(amt) from fees_master where std_id=" & cmbstdno.Text & " and class_id=" & cmbclsno.Text & "", d.con)
                report2.xrtotal.Text = cmd.ExecuteScalar

            Catch ex As Exception

            End Try

            'Try
            '    da = New SqlDataAdapter("select fee_type,amt from fees_master where std_id=1 and class_id=8", d.con)
            '    Dim ds As New DataSet
            '    da.Fill(ds, "fees")
            '    Dim max As Integer = ds.Tables("fees").Rows.Count




            '    For Me.j = 0 To max - 1
            '        Dim str As String = ds.Tables("fees").Rows(j).Item("fee_type")
            '        If str = "Admission Fee" Then
            '            add = ds.Tables("fees").Rows(j).Item("amt")

            '        ElseIf str = "Semester Fee" Then
            '            sem = ds.Tables("fees").Rows(j).Item("amt")
            '        ElseIf str = "Tution Fee" Then
            '            tut = ds.Tables("fees").Rows(j).Item("amt")
            '        ElseIf str = "Exam Fee" Then
            '            exam = ds.Tables("fees").Rows(j).Item("amt")
            '        ElseIf str = "All In One Fee" Then
            '            all = ds.Tables("fees").Rows(j).Item("amt")
            '        End If
            '    Next


            'Catch ex As Exception

            'End Try
            'report2.xradd.Text = add
            'report2.xrsem.Text = sem
            'report2.xrtution.Text = tut
            'report2.xrexam.Text = exam
            'report2.xrallinone.Text = all



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
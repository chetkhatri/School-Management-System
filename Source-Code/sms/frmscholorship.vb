Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Public Class frmscholorship
    Dim a As New validation

    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim d As New databind
    Private Sub frmscholorship_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a.GridPropery(GridView1)
        d.PopulateCombo(cmbclsno, "class_id", "class_no", "class_schema", Nothing, True, Nothing, -1)
        d.conn()
        a.GridPropery(GridView1)

        d.gridfill("select * from scholor_regi order by sch_id asc", grdscholor)
        gridvalid()

        total()

        GridView1.OptionsView.ShowAutoFilterRow = True
        grpscholor.Enabled = False
        btnsave.Enabled = False
        btnreset.Enabled = False
        Try
            cmd = New SqlCommand("select count(sch_id) from scholor_regi", d.con)
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

    Private Sub cmbclasno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclsno.SelectedIndexChanged
        d.PopulateCombo(cmbstdno, "std_id", "std_id", "std_master where add_std =" & cmbclsno.Text)
        d.conn()
    End Sub

    Private Sub txtamt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamt.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

        

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        grpscholor.Enabled = True
        cmbstdno.SelectedIndex = -1
        cmbscholor.SelectedIndex = -1
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
        grpscholor.Enabled = True
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        cmbstdno.SelectedIndex = -1
        cmbscholor.SelectedIndex = -1
        txtamt.Text = ""
        cmbclsno.Focus()
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        If (Me.GridView1.FocusedRowHandle >= 0) Then

            Try
                grpscholor.Enabled = False

                cmbclsno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "class_id")
                cmbstdno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "std_id")
                cmbscholor.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "sch_type")
                txtamt.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "amt")
                btnsave.Enabled = False
                btnreset.Enabled = False
                btnedit.Enabled = True
                btnadd.Enabled = True
            Catch ex As Exception

            End Try


        End If


    End Sub
    Private Sub total()
        Try
            cmd = New SqlCommand("select sum(amt) from scholor_regi", d.con)
            lbltotal.Text = cmd.ExecuteScalar()


        Catch ex As Exception

        End Try
    End Sub
    Private Sub gridvalid()
        GridView1.Columns("std_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("std_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("class_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("class_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("sch_type").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("sch_type").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("amt").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("amt").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

    End Sub


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If a.txtstring(cmbclsno, lblclsno) = True Then
            XtraMessageBox.Show("Please Select Class", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(cmbstdno, lblstdno) = True Then
            XtraMessageBox.Show("Please Select Student ID", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(cmbscholor, lblscholortype) = True Then
            XtraMessageBox.Show("Please Select ScholorShip Type", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(txtamt, lblamt) = True Then
            XtraMessageBox.Show("Please Enter Amount", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            If btnsave.Tag = "add" Then
                Try
                    cmd = New SqlCommand("insert into scholor_regi values('" & cmbstdno.Text & "','" & cmbclsno.Text & "','" & cmbscholor.Text & "','" & txtamt.Text & "','" & Now.ToString("dd/MM/yyyy") & "')", d.con)
                    cmd.ExecuteNonQuery()
                    XtraMessageBox.Show("Scholorship Accepted Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception

                End Try
            ElseIf btnsave.Tag = "update" Then
                Try
                    cmd = New SqlCommand("update scholor_regi set[std_id]='" & cmbstdno.Text & "',[class_id]='" & cmbclsno.Text & "',[sch_type]='" & cmbscholor.Text & "',[amt]='" & txtamt.Text & "',[dte]='" & Now.ToString("dd/MM/yyyy") & "' where [sch_id]='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "sch_id") & "'", d.con)

                    cmd.ExecuteNonQuery()
                    XtraMessageBox.Show("Scholorship Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception

                End Try
            End If
            d.gridfill("select * from scholor_regi order by sch_id asc", grdscholor)


            btnsave.Enabled = False
            btnreset.Enabled = False
            btnedit.Enabled = True
            btnadd.Enabled = True
            grpscholor.Enabled = False
            Try
                cmd = New SqlCommand("select count(sch_id) from scholor_regi", d.con)
                If cmd.ExecuteScalar <= 0 Then
                    btnedit.Enabled = False
                Else
                    btnedit.Enabled = True
                End If
            Catch ex As Exception

            End Try
            total()
        End If

    End Sub
End Class
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmclass_entry
    Dim a As New validation

    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim d As New databind


    Private Sub frmclass_entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a.GridPropery(GridView1)
        d.conn()
        gridvalid()

        d.gridfill("select * from class_schema", grdclass)
        GridView1.Columns("class_id").VisibleIndex = -1
        starting()
        Dim _blankContextMenu As New ContextMenu()
        txtclsname.ContextMenu = _blankContextMenu
        txtclsno.ContextMenu = _blankContextMenu
      
    End Sub
    Private Sub gridvalid()
        GridView1.Columns("class_no").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("class_no").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("class_dsc").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("class_dsc").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("class_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("class_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center


    End Sub
    ''''this function is in class file global it..

    'Public Sub grdfill()
    '    da = New SqlDataAdapter("select * from class_schema", d.con)
    '    ds.Clear()
    '    da.Fill(ds, "tbclass_schema")


    '    grdclass.DataSource = ds.Tables("tbclass_schema")


    'End Sub
    Public Sub starting()
        GroupControl2.Enabled = False
        btnsave.Enabled = False
        btnedit.Enabled = True
        btnadd.Enabled = True

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If a.txtstring(txtclsno, lblclsno) = True Then
                XtraMessageBox.Show("Please Enter Class No", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf a.txtstring(txtclsname, lblclsname) = True Then
                XtraMessageBox.Show("Please Enter Class Name", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If Me.btnsave.Tag = "ADD" Then
                    Try
                        cmd = New SqlCommand("insert into class_schema values('" & txtclsno.Text & "','" & txtclsname.Text & "')", d.con)
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Try
                        cmd = New SqlCommand("insert into sem_master values('" & 1 & "','" & txtclsno.Text & "')", d.con)
                        cmd.ExecuteNonQuery()
                        cmd = New SqlCommand("insert into sem_master values('" & 2 & "','" & txtclsno.Text & "')", d.con)
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)

                    End Try
                    XtraMessageBox.Show("Class Added Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    cmd = New SqlCommand("update class_schema set [class_no]='" & txtclsno.Text & "',[class_dsc]='" & txtclsname.Text & "' where [class_id]=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "class_id"), d.con)
                    cmd.ExecuteNonQuery()
                    XtraMessageBox.Show("Class Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                d.gridfill("select * from class_schema", grdclass)
                starting()

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Me.btnsave.Tag = "ADD"
       
        txtclsno.Text = ""
        txtclsname.Text = ""
        GroupControl2.Enabled = True

        txtclsno.Focus()
        btnsave.Enabled = True
        btnedit.Enabled = False
        Me.btnadd.Enabled = False



    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        If (Me.GridView1.FocusedRowHandle >= 0) Then
            Me.txtclsno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "class_no")
            Me.txtclsname.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "class_dsc")







            lblclsname.Text = ""
            lblclsno.Text = ""

            GroupControl2.Enabled = False

            btnsave.Enabled = False
            btnedit.Enabled = True
            btnadd.Enabled = True



        End If


    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click

        Me.btnsave.Tag = "EDIT"
        GroupControl2.Enabled = True
        txtclsno.Focus()
        btnsave.Enabled = True
        Me.btnedit.Enabled = False
        btnadd.Enabled = False


    End Sub
End Class
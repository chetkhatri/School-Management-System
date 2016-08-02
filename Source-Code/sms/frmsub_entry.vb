Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.VisualBasic.CompilerServices
Public Class frmsub_entry
    Dim a As New validation

    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim d As New databind
    Private Sub frmsub_entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.conn()
        a.GridPropery(GridView1)
        gridvalid()



        d.gridfill("select * from sub_regi", grdsub)
        GridView1.Columns("sub_id").VisibleIndex = -1
        starting()
        Dim _blankContextMenu As New ContextMenu()
        txtsubcode.ContextMenu = _blankContextMenu
        txtsubname.ContextMenu = _blankContextMenu
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub
    Private Sub gridvalid()
        GridView1.Columns("s_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("s_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("s_code").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("s_code").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("sub_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("sub_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("sem_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("sem_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

    End Sub
    Public Sub starting()
        GroupControl2.Enabled = False
        btnsave.Enabled = False
        btnedit.Enabled = True
        btnadd.Enabled = True

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        btnsave.Tag = "ADD"
        txtsubcode.Text = ""
        txtsubname.Text = ""
        cmbsem.Text = ""

        GroupControl2.Enabled = True

        txtsubname.Focus()
        btnsave.Enabled = True
        btnedit.Enabled = False
        Me.btnadd.Enabled = False
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Me.btnsave.Tag = "EDIT"
        GroupControl2.Enabled = True
        txtsubname.Focus()
        btnsave.Enabled = True
        Me.btnedit.Enabled = False
        btnadd.Enabled = False
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        If (Me.GridView1.FocusedRowHandle >= 0) Then
            Try
                Me.txtsubname.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "s_name")
                Me.txtsubcode.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "s_code")
                Me.cmbsem.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "sem_id")

            Catch ex As Exception

            End Try







            GroupControl2.Enabled = False

            btnsave.Enabled = False
            btnedit.Enabled = True
            btnadd.Enabled = True



        End If


    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If a.txtstring(txtsubname, lblsubname) = True Then
                XtraMessageBox.Show("Please Enter Subject Name", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf a.txtstring(txtsubcode, lblsubcode) = True Then
                XtraMessageBox.Show("Please Enter Subject Code", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf a.txtstring(cmbsem, lblsem) = True Then
                XtraMessageBox.Show("Please Select Semester", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
               
                If Me.btnsave.Tag = "ADD" Then
                    cmd = New SqlCommand("select count(*) from  sub_regi where [s_name] like '%" & Me.txtsubname.Text & "%' ", d.con)
                    Dim no As Integer = Conversions.ToInteger(cmd.ExecuteScalar())
                    If no > 0 Then
                        XtraMessageBox.Show("Subject Already Exists", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtsubname.Focus()
                        txtsubname.SelectAll()

                    ElseIf (no = 0) Then
                        cmd = New SqlCommand("insert into sub_regi values('" & cmbsem.SelectedItem & "','" & txtsubcode.Text & "','" & txtsubname.Text & "')", d.con)
                        cmd.ExecuteNonQuery()
                        XtraMessageBox.Show("Subject Added Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                    
                ElseIf Me.btnsave.Tag = "EDIT" Then
                    cmd = New SqlCommand("update sub_regi set[s_code]='" & txtsubcode.Text & "',[s_name]='" & txtsubname.Text & "',[sem_id]='" & cmbsem.SelectedItem & "' where [sub_id]=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "sub_id"), d.con)
                    cmd.ExecuteNonQuery()
                    XtraMessageBox.Show("Subject Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If
                    d.gridfill("select * from sub_regi", grdsub)
                    starting()
                End If
                

               

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtsubname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsubname.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsubcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsubcode.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub
End Class
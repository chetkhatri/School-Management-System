Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frmnewac

    Dim cmd As New SqlCommand
    Dim a As New validation
    Dim d As New databind
    Dim da As New SqlDataAdapter
    Dim ustat As New Integer




    

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub frmnewac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.conn()
        Dim _blankContextMenu As New ContextMenu()
        txtempid.ContextMenu = _blankContextMenu
        txtpw.ContextMenu = _blankContextMenu
        txtrepw.ContextMenu = _blankContextMenu
        txtuname.ContextMenu = _blankContextMenu

    End Sub

    

    

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If a.txtstring(txtempid, lblempid) = True Then
            XtraMessageBox.Show("Please Enter Employee ID", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(cmbutype, lblutype) = True Then
            XtraMessageBox.Show("Please Select UserType", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(txtuname, lbluname) = True Then
            XtraMessageBox.Show("Please Enter UserName", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(txtpw, lblpw) = True Then
            XtraMessageBox.Show("Please Enter Password", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
       
        ElseIf a.txtstring(txtrepw, lblrepw) = True Then
            XtraMessageBox.Show("Please Re-Enter Password", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (txtpw.Text <> txtrepw.Text) Then
            XtraMessageBox.Show("Please Doesnt Match", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpw.Text = ""
            txtrepw.Text = ""
            txtpw.Focus()


        Else
            Try
                cmd = New SqlCommand("select count(*) from user_master where [u_name]='" & txtuname.Text & "'", d.con)
                ustat = cmd.ExecuteScalar()
                If (ustat > 0) Then
                    XtraMessageBox.Show("Username Already Exist", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtpw.Text = ""
                    txtrepw.Text = ""
                    txtuname.Focus()
                    txtuname.SelectAll()


                ElseIf (ustat = 0) Then
                    cmd = New SqlCommand("insert into user_master values('" & txtuname.Text & "','" & txtempid.Text & "','" & cmbutype.Text & "','" & txtpw.Text & "')", d.con)
                    cmd.ExecuteNonQuery()
                    XtraMessageBox.Show("User Account Created Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    resetall()

                End If
            Catch ex As Exception

            End Try

        End If
      
    End Sub

    Private Sub txtempid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtempid.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If

    End Sub

    
    Private Sub btncancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub
    Public Sub resetall()
        txtempid.Text = ""
        txtuname.Text = ""
        txtpw.Text = ""
        txtrepw.Text = ""
        cmbutype.Text = ""
        txtempid.Focus()

    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        resetall()
       
    End Sub

    Private Sub txtuname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuname.KeyPress
        Dim ch As Char = e.KeyChar
        If (ch = "'" Or ch = "=" Or ch = "*" Or ch = "%" Or ch = "-" Or ch = "(" Or ch = ")" Or ch = ";" Or ch = ChrW(22)) Then
            e.Handled = True
        End If
        'Dim ch As Char = e.KeyChar
        'If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
        '    e.Handled = True
        'End If
    End Sub

   
    
End Class
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.CompilerServices



Public Class frmpost
    Dim cmd As New SqlCommand
    Dim a As New databind



    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtpost.Text = ""
        txtpost.Focus()


    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtpost.Text = "" Then
            XtraMessageBox.Show("Please Enter Post", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpost.Focus()

        Else
            'Dim no As Integer = Conversions.ToInteger
            'cmd = New SqlCommand("select count(*) from tbpost where upper(post_name)='" & Me.txtpost.Text.ToUpper & "'", a.con)
            Try
                cmd = New SqlCommand("select count(*) from tbpost where post_name  like '%" & Me.txtpost.Text & "%' ", a.con)
                Dim no As Integer = Conversions.ToInteger(cmd.ExecuteScalar())
                If no > 0 Then
                    XtraMessageBox.Show("Post Already Exist", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtpost.Focus()
                    txtpost.SelectAll()
                ElseIf (no = 0) Then
                    cmd = New SqlCommand("insert into tbpost values('" & txtpost.Text & "')", a.con)
                    cmd.ExecuteNonQuery()
                    XtraMessageBox.Show("Post Added Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtpost.Text = ""
                    txtpost.Focus()



                End If
            Catch ex As Exception

            End Try



        End If
    End Sub

    Private Sub frmpost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a.conn()
       
        
        Me.Focus()
        Dim _blankContextMenu As New ContextMenu()
        txtpost.ContextMenu = _blankContextMenu


    End Sub

    Private Sub txtpost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpost.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

   
    Private Sub frmpost_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed




    End Sub
End Class
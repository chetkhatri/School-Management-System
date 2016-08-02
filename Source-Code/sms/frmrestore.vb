Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frmrestore
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub frmrestore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=db_jign;Integrated Security=True")
            con.Open()

        Catch ex As Exception
            MsgBox("Connection Fail")

        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.EditValue = 100 Then
            Timer1.Enabled = False
            ProgressBar1.Visible = False
            XtraMessageBox.Show("Restore Success", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Else
            ProgressBar1.EditValue = ProgressBar1.EditValue + 10
        End If
    End Sub

    Private Sub btnrestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestore.Click
        Try
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName = "" Then

                XtraMessageBox.Show("Please Select Data file to restore", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                Timer1.Enabled = True
                ProgressBar1.Visible = True

                cmd = New SqlCommand("RESTORE DATABASE db_jign FROM disk='" & OpenFileDialog1.FileName & "' WITH REPLACE", con)
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class
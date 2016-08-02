Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frmbackup
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand



    Private Sub frmbackup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            XtraMessageBox.Show("Backup Success", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Else
            ProgressBar1.EditValue = ProgressBar1.EditValue + 10
        End If
    End Sub

    Private Sub btnbackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbackup.Click
        Try

            SaveFileDialog1.ShowDialog()
            
            Dim s As String
            If SaveFileDialog1.FileName = "" Then

                XtraMessageBox.Show("Please Choose location to Backup", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                SaveFileDialog1.FileName = "jign"
                Timer1.Enabled = True
                ProgressBar1.Visible = True
                s = SaveFileDialog1.FileName
                cmd = New SqlCommand("backup database db_jign to disk='" & s & "'", con)
                cmd.ExecuteNonQuery()

            End If
            

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
Imports System.Data.SqlClient
Public Class frmuserview
    Dim d As New databind
    Dim a As New validation
    Public str As String



    Private Sub frmuserview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.conn()

        a.GridPropery(GridView1)
      

     


        d.gridfill(str, grduser)
        GridView1.OptionsView.ShowAutoFilterRow = True





    End Sub

    

    
    Private Sub frmuserview_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed






    End Sub
End Class
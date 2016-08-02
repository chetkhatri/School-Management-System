
Public Class frmtaxallview
    Dim a As New validation
    Dim d As New databind
    Public str As String




    Private Sub frmtaxallview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.conn()
        a.GridPropery(GridView1)
        'If Me.GroupControl1.Tag = "tax" Then
        '    GridView1.Columns("GridColumn7").Visible = False

        '    GridView1.Columns("GridColumn8").Visible = False


        'End If
        d.gridfill(str, grdallw)
        GridView1.OptionsView.ShowAutoFilterRow = True
    End Sub
End Class
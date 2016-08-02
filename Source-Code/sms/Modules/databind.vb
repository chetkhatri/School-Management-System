Imports System.Data.SqlClient

Public Class databind
    Public con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As New SqlCommand


    Public Sub conn()

        Try
            con = New SqlConnection("workstation id=dbschool.mssql.somee.com;packet size=4096;user id=chetkhatri_SQLLogin_1;pwd=o34afai6jc;data source=dbschool.mssql.somee.com;persist security info=False;initial catalog=dbschool")
            con.Open()
            
        Catch ex As Exception

        End Try
    End Sub
    Public Sub gridfill(ByRef str As String, ByRef grid As DevExpress.XtraGrid.GridControl)
        Try
            da = New SqlDataAdapter(str, con)
            ds.Clear()
            da.Fill(ds, "tbclass_schema")


            grid.DataSource = ds.Tables("tbclass_schema")
        Catch ex As Exception

        End Try

    End Sub
    Public Function ComboSelectedIndex(ByVal combo As DevExpress.XtraEditors.ComboBoxEdit, ByVal id As Long) As Long
        Try
            If combo.Properties.Items.Count > 0 Then
                For i As Long = 0 To combo.Properties.Items.Count - 1
                    Dim di As DataItem = combo.Properties.Items(i)
                    If id = di.GetData Then
                        combo.SelectedIndex = i
                        Return i
                    End If
                Next
            End If
            Return -1
        Catch ex As Exception

        End Try
    End Function
    Public Sub PopulateCombo(ByVal combo As DevExpress.XtraEditors.ComboBoxEdit, ByVal id As String, ByVal name As String, ByVal tabname As String, Optional ByVal desc As String = Nothing, Optional ByVal CLEAR As Boolean = True, Optional ByVal column3 As String = Nothing, Optional ByVal Selected_Index As Integer = -1)
        Dim myreader As System.Data.SqlClient.SqlDataReader


        Dim SqlStr As String
        If desc = Nothing Then
            If column3 Is Nothing Then
                SqlStr = "Select " & id & "," & name & " From " & tabname
            Else
                SqlStr = "Select " & id & "," & name & "," & column3 & " From " & tabname
            End If
        Else
            If column3 Is Nothing Then
                SqlStr = "Select " & id & "," & name & " From " & tabname & " " & desc
            Else
                SqlStr = "Select " & id & "," & name & "," & column3 & " From " & tabname & " " & desc
            End If
        End If

        Try
            cmd.CommandText = SqlStr
            If (con.State = ConnectionState.Closed) Then
                conn()

            End If
            cmd.Connection = con

            myreader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If CLEAR = True Then combo.Properties.Items.Clear()
            While myreader.Read
                If column3 Is Nothing Then
                    combo.Properties.Items.Add(New DataItem(myreader(1), myreader(0)))
                Else
                    combo.Properties.Items.Add(New DataItem(myreader(1), myreader(0), myreader(2)))
                End If
            End While
            myreader.Close()
            If combo.Properties.Items.Count > 0 Then
                combo.SelectedIndex = Selected_Index
            Else
                combo.SelectedIndex = -1
            End If
        Catch ex As Exception

        Finally
            If myreader.IsClosed = False Then
                myreader.Close()
            End If
        End Try
    End Sub
    Public Function SetRelation(ByVal sParentTableAlias As String, ByVal sParentCol As Object, ByVal sChildTableAlias As String, ByVal sChildCol As Object, ByRef sDs As DataSet, Optional ByVal sRelationName As String = "") As String
        '====================================================================
        'Description: sets relation between 2 table of dataset
        '====================================================================
        Try
            Dim parentcol As DataColumn
            Dim childcol As DataColumn
            'Dim ff As Integer
            parentcol = sDs.Tables(sParentTableAlias).Columns(sParentCol)
            childcol = sDs.Tables(sChildTableAlias).Columns(sChildCol)
            If sRelationName = "" Then
                sRelationName = sParentTableAlias & sChildTableAlias
            End If
            'sDs.Relations.Clear()
            If sDs.Relations.Contains(sRelationName) = True Then
                sDs.Relations.Remove(sRelationName)
            End If

            sDs.Relations.Add(sRelationName, parentcol, childcol)
            SetRelation = sRelationName
        Catch ex As Exception
            Throw ex
            'MyCon.InformationMessage(ex.Message)
            'Show_ExceptionMessage(ex)
        End Try
    End Function
    
    
End Class

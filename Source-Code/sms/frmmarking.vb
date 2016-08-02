Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.VisualBasic.CompilerServices
Imports sms.DataItem
Imports System.Runtime.CompilerServices



Public Class frmmarking
    Dim a As New validation

    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim d As New databind
    Dim stdstatus As Integer = 0

    Private Sub frmmarking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        a.GridPropery(GridView1)

        d.PopulateCombo(cmbclsno, "class_id", "class_no", "class_schema", Nothing, True, Nothing, -1)
        d.conn()





        btnedit.Enabled = False
        Dim _blankContextMenu As New ContextMenu()
        txtfa1.ContextMenu = _blankContextMenu
        txtfa2.ContextMenu = _blankContextMenu
        txtsa1.ContextMenu = _blankContextMenu
        txtsiddhi.ContextMenu = _blankContextMenu
        txtkrupa.ContextMenu = _blankContextMenu
       
    End Sub
 
    Private Sub GridView1_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell

        If CType(CType(e.Cell, Object), DevExpress.XtraGrid.Views.Grid.ViewInfo.GridCellInfo).ColumnInfo.Caption = "Total Marks" Then

            If e.CellValue < 17 Then
                e.Appearance.BackColor = System.Drawing.Color.Red

            Else
                e.Appearance.BackColor = Nothing

            End If
        End If

    End Sub
    
    

    Private Sub cmbstdno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstdno.SelectedIndexChanged
        d.PopulateCombo(cmbsubcode, "sub_id", "s_code", "sub_regi")
        d.conn()
        'status()


    End Sub

    
    
    
    Public Sub reserall()
        ' cmbclsno.SelectedIndex = -1
        cmbstdno.SelectedIndex = -1
        cmbsubcode.SelectedIndex = -1
        cmbsem.SelectedIndex = -1
        txtfa1.Text = ""
        txtfa2.Text = ""
        txtsa1.Text = ""
        lblclassid.Text = ""
        lblstdid.Text = ""
        lblsubcode.Text = ""
        lblsubname.Text = ""
        lblfa1.Text = ""
        lblfa2.Text = ""
        lblsa1.Text = ""

        txtsiddhi.Text = ""
        txtkrupa.Text = ""
        grpkrupa.Enabled = False

        txtsubname.Text = ""
        txttotal.Text = ""
        txtnet.Text = ""
        txtstatus.Text = ""
        txtstatus.BackColor = Nothing
        cmbclsno.Focus()

    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        btnsave.Tag = "update"
        btnedit.Enabled = False
        btnsave.Enabled = True

        btnreset.Enabled = True
    End Sub

    Private Sub cmbclsno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclsno.SelectedIndexChanged
        d.PopulateCombo(cmbstdno, "std_id", "std_id", "std_master where add_std =" & cmbclsno.Text)
        d.conn()
    End Sub
    
    

    Private Sub txtfa1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfa1.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfa2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfa2.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsa1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsa1.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If a.txtstring(cmbclsno, lblclassid) = True Then
            XtraMessageBox.Show("Please Select Class", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(cmbstdno, lblstdid) = True Then
            XtraMessageBox.Show("Please Select Student ID", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(cmbsem, lblsem) = True Then
            XtraMessageBox.Show("Please Select Semester", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf (a.txtstring(cmbsubcode, lblsubcode) = True Or a.txtstring(txtsubname, lblsubname) = True) Then
            XtraMessageBox.Show("Please Select Subject Details", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

       
        ElseIf (a.txtstring(txtfa1, lblfa1) = True Or faval(txtfa1, lblfa1) = True) Then
            If txtfa1.Text = "" Then
                XtraMessageBox.Show("Please Enter FA-1 Marks", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("FA-1 Marks Should Be Less or Equal to 10", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        ElseIf (a.txtstring(txtfa2, lblfa2) = True Or faval(txtfa2, lblfa2) = True) Then
            If txtfa2.Text = "" Then
                XtraMessageBox.Show("Please Enter FA-2 Marks", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("FA-2 Marks Should Be Less or Equal to 10", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If

        ElseIf (a.txtstring(txtsa1, lblsa1) = True Or saval(txtsa1, lblsa1) = True) Then
            If txtsa1.Text = "" Then
                XtraMessageBox.Show("Please Select SA-1 Marks", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("SA-1 Marks Should Be Less or Equal to 30", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If Val(txtnet.Text) >= 17 Then
                txtstatus.Text = "Pass"
                txtstatus.BackColor = Color.Green
            ElseIf Val(txtnet.Text < 17) Then
                txtstatus.Text = "Fail"
                txtstatus.BackColor = Color.Red
            End If

            If btnsave.Tag = "add" Then
                
                Try
                    cmd = New SqlCommand("insert into exam_master(std_id,class_id,sub_id,sem,fa1,fa2,sa1,total,status) values(" & cmbstdno.Text & "," & cmbclsno.Text & "," & cmbsubcode.Text & "," & cmbsem.Text & "," & txtfa1.Text & "," & txtfa2.Text & "," & txtsa1.Text & "," & txtnet.Text & ",'" & txtstatus.Text & "')", d.con)
                    cmd.ExecuteNonQuery()
                    XtraMessageBox.Show("Marking Success", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    reserall()
                    'd.gridfill("SELECT     exam_master.fa1, exam_master.fa2, exam_master.sa1, sub_regi.s_name, exam_master.total FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id WHERE     (exam_master.std_id = " & cmbstdno.Text & ") AND (exam_master.class_id = " & cmbclsno.Text & ") AND (exam_master.sem = " & cmbsem.Text & ")", grdlookup)
                   

                Catch ex As Exception

                End Try
            ElseIf btnsave.Tag = "update" Then

                If grpkrupa.Enabled = True Then
                    If (txtsiddhi.Text = "" Or txtkrupa.Text = "") Then
                        If txtsiddhi.Text = "" Then
                            txtsiddhi.Text = 0
                        ElseIf txtkrupa.Text = "" Then
                            txtkrupa.Text = 0
                        End If
                    End If
                    Try
                        cmd = New SqlCommand("update exam_master set[fa1]=" & txtfa1.Text & ",[fa2]=" & txtfa2.Text & ",[sa1]=" & txtsa1.Text & ",[siddhi]=" & txtsiddhi.Text & ",[krupa]=" & txtkrupa.Text & ",[total]=" & txtnet.Text & ",[status]='" & txtstatus.Text & "' where [class_id]=" & cmbclsno.Text & " and [std_id]=" & cmbstdno.Text & " and [sem]=" & cmbsem.Text & " and [sub_id]=" & cmbsubcode.Text & "", d.con)
                        cmd.ExecuteNonQuery()
                        XtraMessageBox.Show("Marking Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        reserall()
                    Catch ex As Exception

                    End Try
                ElseIf grpkrupa.Enabled = False Then
                    Try
                        cmd = New SqlCommand("update exam_master set[fa1]=" & txtfa1.Text & ",[fa2]=" & txtfa2.Text & ",[sa1]=" & txtsa1.Text & ",[total]=" & txtnet.Text & ",[status]='" & txtstatus.Text & "' where [class_id]=" & cmbclsno.Text & " and [std_id]=" & cmbstdno.Text & " and [sem]=" & cmbsem.Text & " and [sub_id]=" & cmbsubcode.Text & "", d.con)
                        cmd.ExecuteNonQuery()
                        XtraMessageBox.Show("Marking Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        reserall()
                    Catch ex As Exception

                    End Try
                End If
               

            End If
            End If
    End Sub
    Public Function faval(ByRef txt As DevExpress.XtraEditors.TextEdit, ByRef lbl As System.Windows.Forms.Label) As Boolean
        If Val(txt.Text) > 10 Then
            lbl.Text = "*"
            lbl.ForeColor = Color.Brown
            txt.Focus()
            txt.SelectAll()

            faval = True
        Else
            lbl.Text = ""
            faval = False
        End If
    End Function
    Public Function saval(ByRef txt As DevExpress.XtraEditors.TextEdit, ByRef lbl As System.Windows.Forms.Label) As Boolean
        If Val(txt.Text) > 30 Then
            lbl.Text = "*"
            lbl.ForeColor = Color.Brown
            txt.Focus()
            txt.SelectAll()

            saval = True
        Else
            lbl.Text = ""
            saval = False
        End If
    End Function
    
    Private Sub cmbsubcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsubcode.SelectedIndexChanged
        Try
            cmd = New SqlCommand("select [s_name] from sub_regi where [s_code]=" & cmbsubcode.Text & "", d.con)
            txtsubname.Text = cmd.ExecuteScalar


        Catch ex As Exception

        End Try
        fetchmarks()
        If grpkrupa.Enabled = False Then
            txtsiddhi.Text = ""
            txtkrupa.Text = ""
        End If

        netmarks()

    End Sub
    
    Public Sub totalmrks()
        
        'Try
        '    txttotal.Text = Val(txtfa1.Text) + Val(txtfa2.Text) + Val(txtsa1.Text)
        'Catch ex As Exception

        'End Try
        'Try

        '    If Not (txtfa1.Text = "" And txtfa2.Text = "" And txtsa1.Text = "") And Not (txtfa2.Text = "" And txtsa1.Text = "") Then
        '        If Val(txttotal.Text) > 16 Then
        '            grpkrupa.Enabled = False
        '        Else
        '            grpkrupa.Enabled = True
        '            txttotal.Text = ""
        '        End If
        '    ElseIf (txtfa1.Text = "" And txtfa2.Text = "" And txtsa1.Text = "") Then
        '        grpkrupa.Enabled = False
        '    Else
        '        grpkrupa.Enabled = False
        '    End If
        'Catch ex As Exception

        'End Try
        If (txtsiddhi.Text = "" And txtkrupa.Text = "") Then
            Try
                txttotal.Text = Val(txtfa1.Text) + Val(txtfa2.Text) + Val(txtsa1.Text)
            Catch ex As Exception
                txttotal.Text = ""
            End Try
        ElseIf Not (txtsiddhi.Text = "" And txtkrupa.Text = "") Then
            Try
                txttotal.Text = Val(txtfa1.Text) + Val(txtfa2.Text) + Val(txtsa1.Text) + Val(txtsiddhi.Text) + Val(txtkrupa.Text)
            Catch ex As Exception
                txttotal.Text = ""
            End Try
        End If
        Try

            If Not (txtfa1.Text = "" And txtfa2.Text = "" And txtsa1.Text = "") And Not (txtfa2.Text = "" And txtsa1.Text = "") Then
                If Val(txttotal.Text) > 16 Then

                    grpkrupa.Enabled = False
                    txtsiddhi.Text = ""
                    txtkrupa.Text = ""
                Else
                    grpkrupa.Enabled = True
                    'txttotal.Text = ""
                End If
            ElseIf (txtfa1.Text = "" And txtfa2.Text = "" And txtsa1.Text = "") Then
                grpkrupa.Enabled = False
                txtsiddhi.Text = ""
                txtkrupa.Text = ""
            Else
                grpkrupa.Enabled = False
                txtsiddhi.Text = ""
                txtkrupa.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtfa1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfa1.EditValueChanged
        If Not (txtfa2.Text = "" And txtsa1.Text = "") Then
            totalmrks()

        End If

    End Sub



    Private Sub txtsa1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsa1.EditValueChanged
        If Not (txtfa1.Text = "" And txtfa2.Text = "") Then
            totalmrks()


        End If
    End Sub
    Private Sub txtfa2_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtfa2.EditValueChanging
        If Not (txtfa1.Text = "" And txtsa1.Text = "") Then
            totalmrks()


        End If
    End Sub

    Private Sub cmbsem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsem.SelectedIndexChanged
        If Not (cmbclsno.Text = "" And cmbstdno.Text = "") Then
            'd.gridfill("select fa1,fa2,sa1,total from exam_master where [class_id]=" & cmbclsno.Text & " and [std_id]=" & cmbstdno.Text & " and [sem]=" & cmbsem.Text & "  ", grdlookup)
            ds.Clear()
            'd.gridfill("SELECT     exam_master.fa1, exam_master.fa2, exam_master.sa1, sub_regi.s_name, exam_master.total FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id WHERE     (exam_master.std_id = " & cmbstdno.Text & ") AND (exam_master.class_id = " & cmbclsno.Text & ") AND (exam_master.sem = " & cmbsem.Text & ")", grdlookup)
            d.gridfill("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id WHERE     (exam_master.std_id = " & cmbstdno.Text & ") AND (exam_master.class_id = " & cmbclsno.Text & ") AND (exam_master.sem = " & cmbsem.Text & ")", grdlookup)







                'gridvalid2()


        Else


        End If


    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reserall()

    End Sub

    Private Sub txttotal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotal.EditValueChanged
        netmarks()
        If Not (Me.txttotal.Text = "") Then
            status()
        End If

        
    End Sub
    Public Sub netmarks()
        'Try
        '    cmd = New SqlCommand("select sum(total) from exam_master where [class_id]=" & cmbclsno.Text & " and [std_id]=" & cmbstdno.Text & " and [sem]=" & cmbsem.Text & "  ", d.con)
        '    txtnet.Text = cmd.ExecuteScalar


        'Catch ex As Exception
        '    txtnet.Text = ""
        'End Try
        Me.txtnet.Text = Val(txtfa1.Text) + Val(txtfa2.Text) + Val(txtsa1.Text) + Val(txtsiddhi.Text) + Val(txtkrupa.Text)
        txttotal.Text = Val(txtnet.Text) - (Val(txtsiddhi.Text) + Val(txtkrupa.Text))
    End Sub
    
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub
    Public Sub status1()
        stdstatus = 0
        Try
            cmd = New SqlCommand("select count(*) from exam_master where [class_id]=" & cmbclsno.Text & " and [std_id]=" & cmbstdno.Text & " and [sem]=" & cmbsem.Text & "  ", d.con)
            cmd.ExecuteScalar()
            Dim no As Integer = Conversions.ToInteger(cmd.ExecuteScalar())
            If no > 0 Then
                da = New SqlDataAdapter("select [total] from exam_master where [class_id]=" & cmbclsno.Text & " and [std_id]=" & cmbstdno.Text & " and [sem]=" & cmbsem.Text & "  ", d.con)
                ds.Clear()

                da.Fill(ds, "exam")
                For i = 0 To no - 1
                    If ds.Tables("exam").Rows(i).Item("total") < 17 Then
                        txtstatus.Text = ""
                        txtstatus.BackColor = Nothing
                        stdstatus = 1
                    ElseIf ds.Tables("exam").Rows(i).Item("total") >= 17 Then
                        txtstatus.Text = ""
                        txtstatus.BackColor = Nothing
                        stdstatus = 2
                    End If
                Next
            ElseIf (no = 0) Then
                txtstatus.Text = ""
                txtstatus.BackColor = Nothing
            Else
                txtstatus.Text = ""
                txtstatus.BackColor = Nothing

            End If
            If stdstatus = 1 Then
                txtstatus.Text = "Fail"
                txtstatus.BackColor = Color.Red
            ElseIf stdstatus = 2 Then
                txtstatus.Text = "Pass"
                txtstatus.BackColor = Color.Green
            ElseIf stdstatus = 0 Then
                txtstatus.Text = ""
                txtstatus.BackColor = Nothing
            End If
        Catch ex As Exception
            txtstatus.Text = ""
            txtstatus.BackColor = Nothing
        End Try

    End Sub
    Public Sub status()
        If Val(txtnet.Text) >= 17 Then
            txtstatus.Text = "Pass"
            txtstatus.BackColor = Color.Green
        ElseIf Val(txtnet.Text) < 17 Then
            txtstatus.Text = "Fail"
            txtstatus.BackColor = Color.Red
        Else
            txtstatus.Text = ""
            txtstatus.BackColor = Nothing
        End If
    End Sub

    Private Sub txtsubname_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsubname.EditValueChanged
        fetchmarks()

    End Sub
    Public Sub fetchmarks()
        Try
            cmd = New SqlCommand("select count(*) from exam_master where [class_id]=" & cmbclsno.Text & " and [std_id]=" & cmbstdno.Text & " and [sem]=" & cmbsem.Text & " and [sub_id]=" & cmbsubcode.Text & "", d.con)
            Dim no As Integer = Conversions.ToInteger(cmd.ExecuteScalar())
            If no > 0 Then
                da = New SqlDataAdapter("select fa1,fa2,sa1,siddhi,krupa from exam_master where [class_id]=" & cmbclsno.Text & " and [std_id]=" & cmbstdno.Text & " and [sem]=" & cmbsem.Text & " and [sub_id]=" & cmbsubcode.Text & "", d.con)
                ds.Clear()

                da.Fill(ds, "abc")
                txtfa1.Text = ds.Tables("abc").Rows(0).Item("fa1")
                txtfa2.Text = ds.Tables("abc").Rows(0).Item("fa2")
                txtsa1.Text = ds.Tables("abc").Rows(0).Item("sa1")
                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(ds.Tables("abc").Rows(0).Item("siddhi"))) Then
                    txtsiddhi.Text = ""
                Else
                    txtsiddhi.Text = ds.Tables("abc").Rows(0).Item("siddhi")

                End If
                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(ds.Tables("abc").Rows(0).Item("krupa"))) Then
                    txtkrupa.Text = ""
                Else
                    txtkrupa.Text = ds.Tables("abc").Rows(0).Item("krupa")

                End If
                btnsave.Tag = "update"


            ElseIf (no = 0) Then
                ds.Clear()

                txtfa1.Text = ""
                txtfa2.Text = ""
                txtsa1.Text = ""

                txttotal.Text = ""
                txtstatus.Text = ""
                txtstatus.BackColor = Nothing
                btnsave.Tag = "add"

            End If
        Catch ex As Exception

        End Try
    End Sub

    

    
    Private Sub txtsiddhi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsiddhi.EditValueChanged
        If Not (Me.txttotal.Text = "") Then
            Me.txtnet.Text = Val(txtfa1.Text) + Val(txtfa2.Text) + Val(txtsa1.Text) + Val(txtsiddhi.Text) + Val(txtkrupa.Text)
            txttotal.Text = Val(txtnet.Text) - (Val(txtsiddhi.Text) + Val(txtkrupa.Text))
            status()

        End If
    End Sub

    Private Sub txtkrupa_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkrupa.EditValueChanged
        If Not (Me.txttotal.Text = "") Then
            Me.txtnet.Text = Val(txtfa1.Text) + Val(txtfa2.Text) + Val(txtsa1.Text) + Val(txtsiddhi.Text) + Val(txtkrupa.Text)
            txttotal.Text = Val(txtnet.Text) - (Val(txtsiddhi.Text) + Val(txtkrupa.Text))
            status()

        End If
    End Sub
End Class
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.VisualBasic.CompilerServices
Imports sms.DataItem
Imports System.Runtime.CompilerServices


Public Class frmmarksedit
    Dim a As New validation

    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim d As New databind
    Dim stdstatus As Integer = 0
    Private Sub frmmarksedit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a.GridPropery(GridView1)
        d.PopulateCombo(cmbclsno, "class_id", "class_no", "class_schema", Nothing, True, Nothing, -1)
        d.conn()

        d.gridfill("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem,exam_master.sub_id, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id order by exam_master.class_id asc", grdmarking)
        gridvalid()
        GridView1.OptionsView.ShowAutoFilterRow = True
        grpfinal.Enabled = False
        grpgeninfo.Enabled = False
        grpkrupa.Enabled = False
        grpmarks.Enabled = False
        grptotal.Enabled = True

        btnsave.Enabled = False
        'btnreset.Enabled = False
        btnedit.Enabled = True
        Dim _blankContextMenu As New ContextMenu()
        txtfa1.ContextMenu = _blankContextMenu
        txtfa2.ContextMenu = _blankContextMenu
        txtsa1.ContextMenu = _blankContextMenu
        txtsiddhi.ContextMenu = _blankContextMenu
        txtkrupa.ContextMenu = _blankContextMenu

    End Sub
    Private Sub cmbstdno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstdno.SelectedIndexChanged
        d.PopulateCombo(cmbsubcode, "sub_id", "s_code", "sub_regi")
        d.conn()
        'status()
        netmarks()

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
    Private Sub cmbsubcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsubcode.SelectedIndexChanged
        Try
            cmd = New SqlCommand("select [s_name] from sub_regi where [s_code]=" & cmbsubcode.Text & "", d.con)
            txtsubname.Text = cmd.ExecuteScalar


        Catch ex As Exception

        End Try
        fetchmarks()

        netmarks()

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

            ds.Clear()










            'status()
            netmarks()
        Else


        End If


    End Sub
    Private Sub txttotal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotal.EditValueChanged
        'netmarks()
        If Not (Me.txttotal.Text = "") Then
            Me.txtnet.Text = Val(txtfa1.Text) + Val(txtfa2.Text) + Val(txtsa1.Text) + Val(txtsiddhi.Text) + Val(txtkrupa.Text)
            txttotal.Text = Val(txtnet.Text) - (Val(txtsiddhi.Text) + Val(txtkrupa.Text))
            status()
            
        End If
        


    End Sub
    
    Private Sub gridvalid()
        GridView1.Columns("class_id").Caption = "Class ID"
        GridView1.Columns("std_id").Caption = "Student ID"
        GridView1.Columns("sem").Caption = "Sem"
        GridView1.Columns("s_name").Caption = "Subject"
        GridView1.Columns("fa1").Caption = "FA-1"
        GridView1.Columns("fa2").Caption = "FA-2"
        GridView1.Columns("sa1").Caption = "SA-1"
        GridView1.Columns("siddhi").Caption = "Siddhi Marks"
        GridView1.Columns("krupa").Caption = "Krupa Marks"
        GridView1.Columns("total").Caption = "Total"
        GridView1.Columns("status").Caption = "Status"


        GridView1.Columns("exam_id").VisibleIndex = -1
        GridView1.Columns("sub_id").VisibleIndex = -1

        GridView1.Columns("class_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("class_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("std_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("std_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("sem").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("sem").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("s_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("s_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("fa1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("fa1").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("fa2").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("fa2").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("sa1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("sa1").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("siddhi").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("siddhi").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("krupa").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("krupa").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("total").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("total").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("status").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("status").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        grpgeninfo.Enabled = True
        grpmarks.Enabled = True
        grpfinal.Enabled = True

        grptotal.Enabled = True

        btnedit.Enabled = False
        btnsave.Enabled = True

        'btnreset.Enabled = True
        If Not (txtsiddhi.Text = "" Or txtkrupa.Text = "") Then
            grpkrupa.Enabled = True
        Else
            grpkrupa.Enabled = False
        End If
    End Sub
    
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        If (Me.GridView1.FocusedRowHandle >= 0) Then

            Try
                

                cmbclsno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "class_id")
                cmbstdno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "std_id")
                cmbsem.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "sem")
                cmbsubcode.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "sub_id")
                txtsubname.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "s_name")
                txtfa1.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "fa1")
                txtfa2.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "fa2")
                txtsa1.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "sa1")
                txtnet.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "total")
                txtstatus.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "status")

                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "siddhi"))) Then
                    txtsiddhi.Text = ""
                Else
                    txtsiddhi.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "siddhi")

                End If
                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "krupa"))) Then
                    txtkrupa.Text = ""
                Else
                    txtkrupa.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "krupa")

                End If
                txttotal.Text = Val(txtnet.Text) - (Val(txtsiddhi.Text) + Val(txtkrupa.Text))

                grpgeninfo.Enabled = False
                grpmarks.Enabled = False
                grpfinal.Enabled = False
                grpkrupa.Enabled = False
                grptotal.Enabled = False

                btnsave.Enabled = False
                'btnreset.Enabled = False
                btnedit.Enabled = True

            Catch ex As Exception

            End Try


        End If


    End Sub

    Private Sub cmbclsno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclsno.SelectedIndexChanged
        d.PopulateCombo(cmbstdno, "std_id", "std_id", "std_master where add_std =" & cmbclsno.Text)
        d.conn()
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
    Public Sub fetchmarks()
        Try
            cmd = New SqlCommand("select count(*) from exam_master where [class_id]=" & cmbclsno.Text & " and [std_id]=" & cmbstdno.Text & " and [sem]=" & cmbsem.Text & " and [sub_id]=" & cmbsubcode.Text & "", d.con)
            Dim no As Integer = Conversions.ToInteger(cmd.ExecuteScalar())
            If no > 0 Then
                da = New SqlDataAdapter("select fa1,fa2,sa1 from exam_master where [class_id]=" & cmbclsno.Text & " and [std_id]=" & cmbstdno.Text & " and [sem]=" & cmbsem.Text & " and [sub_id]=" & cmbsubcode.Text & "", d.con)
                ds.Clear()

                da.Fill(ds, "abc")
                txtfa1.Text = ds.Tables("abc").Rows(0).Item("fa1")
                txtfa2.Text = ds.Tables("abc").Rows(0).Item("fa2")
                txtsa1.Text = ds.Tables("abc").Rows(0).Item("sa1")

               
            ElseIf (no = 0) Then
                ds.Clear()

                txtfa1.Text = ""
                txtfa2.Text = ""
                txtsa1.Text = ""

                txttotal.Text = ""
                txtstatus.Text = ""
                txtstatus.BackColor = Nothing


            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub netmarks()
        Try
            cmd = New SqlCommand("select sum(total) from exam_master where [class_id]=" & cmbclsno.Text & " and [std_id]=" & cmbstdno.Text & " and [sem]=" & cmbsem.Text & "  ", d.con)
            txtnet.Text = cmd.ExecuteScalar


        Catch ex As Exception
            txtnet.Text = ""
        End Try
    End Sub
    Public Sub totalmrks()

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

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim m As New frmmarking

        If a.txtstring(cmbclsno, lblclassid) = True Then
            XtraMessageBox.Show("Please Select Class", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(cmbstdno, lblstdid) = True Then
            XtraMessageBox.Show("Please Select Student ID", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(cmbsem, lblsem) = True Then
            XtraMessageBox.Show("Please Select Semester", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf (a.txtstring(cmbsubcode, lblsubcode) = True Or a.txtstring(txtsubname, lblsubname) = True) Then
            XtraMessageBox.Show("Please Select Subject Details", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)


        ElseIf (a.txtstring(txtfa1, lblfa1) = True Or m.faval(txtfa1, lblfa1) = True) Then
            If txtfa1.Text = "" Then
                XtraMessageBox.Show("Please Enter FA-1 Marks", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("FA-1 Marks Should Be Less or Equal to 10", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        ElseIf (a.txtstring(txtfa2, lblfa2) = True Or m.faval(txtfa2, lblfa2) = True) Then
            If txtfa2.Text = "" Then
                XtraMessageBox.Show("Please Enter FA-2 Marks", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("FA-2 Marks Should Be Less or Equal to 10", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If

        ElseIf (a.txtstring(txtsa1, lblsa1) = True Or m.saval(txtsa1, lblsa1) = True) Then
            If txtsa1.Text = "" Then
                XtraMessageBox.Show("Please Select SA-1 Marks", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("SA-1 Marks Should Be Less or Equal to 30", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If Val(txtnet.Text) >= 17 Then
                txtstatus.Text = "Pass"
                txtstatus.BackColor = Color.Green
                If grpkrupa.Enabled = False Then
                    Try
                        cmd = New SqlCommand("update exam_master set[std_id]=" & cmbstdno.Text & ",[class_id]=" & cmbclsno.Text & ",[sub_id]=" & cmbsubcode.Text & ",[sem]=" & cmbsem.Text & ",[fa1]=" & txtfa1.Text & ",[fa2]=" & txtfa2.Text & ",[sa1]=" & txtsa1.Text & ",[total]=" & txtnet.Text & ",[status]='" & txtstatus.Text & "' where [exam_id]='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "exam_id") & "'", d.con)
                        cmd.ExecuteNonQuery()


                        XtraMessageBox.Show("Marking Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        d.gridfill("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem,exam_master.sub_id, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id order by exam_master.class_id asc", grdmarking)

                    Catch ex As Exception

                    End Try
                ElseIf grpkrupa.Enabled = True Then
                    If (txtsiddhi.Text = "" Or txtkrupa.Text = "") Then
                        If txtsiddhi.Text = "" Then
                            txtsiddhi.Text = 0
                        ElseIf txtkrupa.Text = "" Then
                            txtkrupa.Text = 0
                        End If
                    End If
                    Try
                        cmd = New SqlCommand("update exam_master set[std_id]=" & cmbstdno.Text & ",[class_id]=" & cmbclsno.Text & ",[sub_id]=" & cmbsubcode.Text & ",[sem]=" & cmbsem.Text & ",[fa1]=" & txtfa1.Text & ",[fa2]=" & txtfa2.Text & ",[sa1]=" & txtsa1.Text & ",[siddhi]=" & txtsiddhi.Text & ",[krupa]=" & txtkrupa.Text & ",[total]=" & txtnet.Text & ",[status]='" & txtstatus.Text & "' where [exam_id]='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "exam_id") & "'", d.con)
                        cmd.ExecuteNonQuery()


                        XtraMessageBox.Show("Marking Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        d.gridfill("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem,exam_master.sub_id, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id order by exam_master.class_id asc", grdmarking)

                    Catch ex As Exception

                    End Try
                End If
            ElseIf Val(txtnet.Text) < 17 Then
                txtstatus.Text = "Fail"
                txtstatus.BackColor = Color.Red

                Try
                    If txtsiddhi.Text = "" Then
                        txtsiddhi.Text = 0
                    End If
                    If txtkrupa.Text = "" Then
                        txtkrupa.Text = 0
                    End If

                    cmd = New SqlCommand("update exam_master set[std_id]=" & cmbstdno.Text & ",[class_id]=" & cmbclsno.Text & ",[sub_id]=" & cmbsubcode.Text & ",[sem]=" & cmbsem.Text & ",[fa1]=" & txtfa1.Text & ",[fa2]=" & txtfa2.Text & ",[sa1]=" & txtsa1.Text & ",[siddhi]=" & txtsiddhi.Text & ",[krupa]=" & txtkrupa.Text & ",[total]=" & txtnet.Text & ",[status]='" & txtstatus.Text & "' where [exam_id]='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "exam_id") & "'", d.con)
                    cmd.ExecuteNonQuery()


                    XtraMessageBox.Show("Marking Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    d.gridfill("SELECT     exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem,exam_master.sub_id, sub_regi.s_name, exam_master.fa1, exam_master.fa2, exam_master.sa1,exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id order by exam_master.class_id asc", grdmarking)

                Catch ex As Exception

                End Try
            End If


            
        End If
    End Sub

    
    Private Sub txtsiddhi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsiddhi.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    
    Private Sub txtkrupa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkrupa.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
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

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        reserall()

    End Sub
    Private Sub GridView1_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell

        If CType(CType(e.Cell, Object), DevExpress.XtraGrid.Views.Grid.ViewInfo.GridCellInfo).ColumnInfo.Caption = "Status" Then
            If e.DisplayText = "Fail" Then
                e.Appearance.BackColor = System.Drawing.Color.Red
            Else
                e.Appearance.BackColor = Nothing
            End If
        End If

    End Sub

    
    Private Sub txtnet_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnet.EditValueChanged
        status()

    End Sub
End Class
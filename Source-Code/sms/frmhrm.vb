Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.CompilerServices
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid


Public Class frmhrm
    Dim a As New validation
    Dim d As New databind
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim gpay, daa, hra, med, fpi, cash, was, gpf, cpf, pf, it, gi As Integer
    Dim updteid As Integer








    Private Sub frmhrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _blankContextMenu As New ContextMenu()
        txtattned.ContextMenu = _blankContextMenu
        txtsalary.ContextMenu = _blankContextMenu


        Try
            a.GridPropery(GridView1)
            grid1valid()


            d.PopulateCombo(cmbempid, "emp_id", "emp_id", "emp_master", Nothing, True, Nothing, -1)
            d.conn()
            txtmonth.Text = ""
            txtyear.Text = ""
            grpallowance.Enabled = False
            grpnet.Enabled = False
            grptax.Enabled = False
            dtpdte.Tag = "on"
            btnsave.Enabled = False
            grpemp.Enabled = False

            GridView1.OptionsView.ShowAutoFilterRow = True


            'd.gridfill("select * from HRM_regi", grdhrm)
            d.gridfill("SELECT     emp_master.f_name,HRM_regi.* FROM emp_master INNER JOIN HRM_regi ON emp_master.emp_id = HRM_regi.emp_id", grdhrm)
            GridView1.Columns("empname").VisibleIndex = -1
            btnreset.Enabled = False
        Catch ex As Exception

        End Try

    End Sub
    Private Sub grid1valid()
        GridView1.Columns("emp_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("emp_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("f_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("f_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("month").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("month").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("year").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("year").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("attend").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("attend").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("tax").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("tax").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("basic").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("basic").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("deduction").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("deduction").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("gross").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("gross").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("net_sal").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("net_sal").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center



    End Sub
    Private Sub dtpdte_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpdte.EditValueChanged




        txtmonth.Text = Strings.Format(Me.dtpdte.DateTime, "MM")
        txtyear.Text = Strings.Format(Me.dtpdte.DateTime, "yyyy")
        txtattned.Focus()
        If dtpdte.Tag = "on" Then
            fetchrate()
            calc()

        End If

        'Try


        '    'da = New SqlDataAdapter("select * from tballw_tax where cast('" & String.Format(Me.dtpdte.DateTime, "MM-dd-yyyy") & "' as datetime) between [dte] and [ex_dte]", d.con)
        '    da = New SqlDataAdapter("select * from tballw_tax where cast('" & dtpdte.DateTime.ToString("MM/dd/yyyy") & "' as datetime) between [dte] and [ex_dte]", d.con)
        '    da.Fill(ds, "tballw_tax")



        'Catch ex As Exception

        'End Try


    End Sub

    
    
    Private Sub cmbempid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbempid.SelectedIndexChanged
        Try
            cmd = New SqlCommand("select [f_name] from emp_master where[emp_id]='" & cmbempid.Text & "'", d.con)
            txtname.Text = cmd.ExecuteScalar


        Catch ex As Exception

        End Try
        dtpdte.Focus()

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If a.txtstring(cmbempid, lblempid) = True Then
            XtraMessageBox.Show("Please Select Employee ID", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(dtpdte, lbldte) = True Or a.dtevalid(dtpdte) = True Then
            If dtpdte.Text = "" Then
                XtraMessageBox.Show("Please Select Date", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Date Should n't be less than today", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf a.txtstring(txtattned, lblattend) = True Or a.attend(txtattned, lblattend) = True Then
            If Me.txtattned.Text = "" Then
                XtraMessageBox.Show("Please Enter Attandance", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Please Enter Valid Attandance", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf a.txtstring(cmbtaxmethod, lbltax) = True Then
            XtraMessageBox.Show("Please Select Tax Method", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtsalary, lblbasic) = True Then
            XtraMessageBox.Show("Please Enter Basic Salary", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If btnsave.Tag = "add" Then
                Try
                    cmd = New SqlCommand("insert into HRM_regi values('" & cmbempid.Text & "','" & updteid & "','" & Strings.Format(Me.dtpdte.DateTime, "yyyy-MM-dd") & "','" & txtmonth.Text & "','" & txtyear.Text & "','" & txtattned.Text & "','" & cmbtaxmethod.Text & "','" & txtsalary.Text & "','" & txtgpay.Text & "','" & txtda.Text & "','" & txthra.Text & "','" & txtmedall.Text & "','" & txtfpi.Text & "','" & txtcashall.Text & "','" & txtwasall.Text & "','" & txtgross.Text & "','" & txtgpf.Text & "','" & txtcpf.Text & "','" & txtpf.Text & "','" & txtit.Text & "','" & txtgi.Text & "','" & txtdeduc.Text & "','" & txtnet.Text & "')", d.con)
                    cmd.ExecuteNonQuery()
                    XtraMessageBox.Show("Salary Record Success", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    'd.gridfill("select * from HRM_regi", grdhrm)
                    d.gridfill("SELECT     emp_master.f_name,HRM_regi.* FROM emp_master INNER JOIN HRM_regi ON emp_master.emp_id = HRM_regi.emp_id", grdhrm)

                    resetall()
                Catch ex As Exception

                End Try
            ElseIf btnsave.Tag = "update" Then

                Try
                    cmd = New SqlCommand("update HRM_regi set[emp_id]='" & cmbempid.Text & "',[dte]='" & Strings.Format(Me.dtpdte.DateTime, "yyyy-MM-dd") & "',[month]='" & txtmonth.Text & "',[year]='" & txtyear.Text & "',[attend]='" & txtattned.Text & "',[tax]='" & cmbtaxmethod.Text & "',[basic]='" & txtsalary.Text & "',[g_pay]='" & txtgpay.Text & "',[da]='" & txtda.Text & "',[hra]='" & txthra.Text & "',[med_all]='" & txtmedall.Text & "',[fpi]='" & txtfpi.Text & "',[cash_all]='" & txtcashall.Text & "',[was_all]='" & txtwasall.Text & "',[gross]='" & txtgross.Text & "',[gpf]='" & txtgpf.Text & "',[cpf]='" & txtcpf.Text & "',[pf]='" & txtpf.Text & "',[in_tax]='" & txtit.Text & "',[gi]='" & txtgi.Text & "',[deduction]='" & txtdeduc.Text & "',[net_sal]='" & txtnet.Text & "' where [sal_id]='" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "sal_id") & "'", d.con)
                    cmd.ExecuteNonQuery()
                    XtraMessageBox.Show("Salary Record Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    d.gridfill("SELECT     emp_master.f_name,HRM_regi.* FROM emp_master INNER JOIN HRM_regi ON emp_master.emp_id = HRM_regi.emp_id", grdhrm)

                Catch ex As Exception

                End Try






                




            End If
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        If (Me.GridView1.FocusedRowHandle >= 0) Then

            Try
                cmbempid.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "emp_id")
                txtname.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "f_name")
                dtpdte.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "dte")
                txtattned.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "attend")
                cmbtaxmethod.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "tax")
                txtsalary.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "basic")





                btnsave.Enabled = False
                btnreset.Enabled = False
                btnedit.Enabled = True
                btnadd.Enabled = True
                grpemp.Enabled = False
            Catch ex As Exception

            End Try

            



        End If


    End Sub

    

    
    Private Sub cmbtaxmethod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtaxmethod.SelectedIndexChanged
        fetchrate()

    End Sub
    Private Sub fetchrate()
        Try


            'da = New SqlDataAdapter("select * from tballw_tax where cast('" & String.Format(Me.dtpdte.DateTime, "MM-dd-yyyy") & "' as datetime) between [dte] and [ex_dte]", d.con)
            da = New SqlDataAdapter("select * from tballw_tax where cast('" & dtpdte.DateTime.ToString("MM/dd/yyyy") & "' as datetime) between [dte] and [ex_dte]", d.con)
            ds.Clear()
            da.Fill(ds, "tballw_tax")


            gpay = ds.Tables("tballw_tax").Rows(0).Item("gpay")
            daa = ds.Tables("tballw_tax").Rows(0).Item("da")
            hra = ds.Tables("tballw_tax").Rows(0).Item("hra")
            med = ds.Tables("tballw_tax").Rows(0).Item("med_all")
            fpi = ds.Tables("tballw_tax").Rows(0).Item("fpi")
            cash = ds.Tables("tballw_tax").Rows(0).Item("cash_all")
            was = ds.Tables("tballw_tax").Rows(0).Item("was_all")
            gpf = ds.Tables("tballw_tax").Rows(0).Item("gpf")
            cpf = ds.Tables("tballw_tax").Rows(0).Item("cpf")
            pf = ds.Tables("tballw_tax").Rows(0).Item("pf")
            it = ds.Tables("tballw_tax").Rows(0).Item("it")
            gi = ds.Tables("tballw_tax").Rows(0).Item("gi")
            updteid = ds.Tables("tballw_tax").Rows(0).Item("update_id")




        Catch ex As Exception


        End Try
    End Sub

    Private Sub txtattned_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtattned.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsalary_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsalary.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    

    Private Sub txtsalary_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsalary.EditValueChanged
        calc()


    End Sub
    Private Sub calc()
        Dim sal As Integer = Val(txtsalary.Text)
        txtgpay.Text = (sal * gpay) / 100
        txtda.Text = (sal * daa) / 100
        txthra.Text = (sal * hra) / 100
        txtmedall.Text = (sal * med) / 100
        txtfpi.Text = (sal * fpi) / 100
        txtcashall.Text = (sal * cash) / 100
        txtwasall.Text = (sal * was) / 100
        'txtwasall.Text = Conversions.ToLong((sal * was) / 100)




        txtgpf.Text = (sal * gpf) / 100
        txtcpf.Text = (sal * cpf) / 100
        txtpf.Text = (sal * pf) / 100
        txtit.Text = (sal * it) / 100
        txtgi.Text = (sal * gi) / 100

        ''''''gross salary goes here''''
        txtgross.Text = sal + Val(txtgpay.Text) + Val(txtda.Text) + Val(txthra.Text) + Val(txtmedall.Text) + Val(txtfpi.Text) + Val(txtcashall.Text) + Val(txtwasall.Text)
        txtdeduc.Text = Val(txtgpf.Text) + Val(txtcpf.Text) + Val(txtpf.Text) + Val(txtit.Text) + Val(txtgi.Text)
        txtnet.Text = Val(txtgross.Text) - Val(txtdeduc.Text)



    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        resetall()

    End Sub
    Private Sub resetall()
        cmbempid.Text = ""
        dtpdte.EditValue = Now.ToString("dd/MM/yyyy")
        txtname.Text = ""
        txtmonth.Text = ""
        txtyear.Text = ""
        txtattned.Text = ""
        cmbtaxmethod.Text = ""
        txtsalary.Text = ""

        cmbempid.Focus()

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        resetall()
        btnedit.Enabled = False
        grpemp.Enabled = True
        btnadd.Enabled = False
        btnsave.Enabled = True
        cmbempid.Focus()
        btnsave.Tag = "add"
        btnreset.Enabled = True


    End Sub
    
    
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        grpemp.Enabled = True
        btnedit.Enabled = False
        btnsave.Enabled = True
        btnadd.Enabled = False
        btnreset.Enabled = True
        btnsave.Tag = "update"

    End Sub

    Private Sub SimpleButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton12.Click
        frmviewemp.ShowDialog()

    End Sub
End Class
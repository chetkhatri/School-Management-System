Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports Microsoft.VisualBasic.CompilerServices
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO
Imports System.Runtime.CompilerServices


Public Class frmgrmaster
    Dim a As New validation
    Dim d As New databind
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim lc, result, gender As String




    

   

    

    Private Sub frmgrmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ArcScaleComponent5.Value = 20
        Dim _blankContextMenu As New ContextMenu()
        txtgrno.ContextMenu = _blankContextMenu
        txtstdid.ContextMenu = _blankContextMenu
        txtbplace.ContextMenu = _blankContextMenu
        txtlastscl.ContextMenu = _blankContextMenu
        txtcaste.ContextMenu = _blankContextMenu
        Dim a As New validation
        a.GridPropery(GridView1)

        d.PopulateCombo(cmbadstd, "class_no", "class_no", "class_schema", Nothing, True, Nothing, -1)
        d.PopulateCombo(cmbleavestd, "class_no", "class_no", "class_schema", Nothing, True, Nothing, -1)
        d.conn()
        GridView1.OptionsView.ShowAutoFilterRow = True

        'grpacadinfo.Enabled = False
        'grpgeninfo.Enabled = False
        'cmbconduct.Enabled = False
        'cmbprogress.Enabled = False
        'cmbtry.Enabled = False
        'LabelControl18.Enabled = False
        'LabelControl19.Enabled = False
        'LabelControl20.Enabled = False

        'btnsave.Enabled = False
        'btnreset.Enabled = False
        grid()

        

    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            If (Me.GridView1.FocusedRowHandle >= 0) Then

                grpacadinfo.Enabled = False
                grpgeninfo.Enabled = False
                cmbconduct.Enabled = False
                cmbprogress.Enabled = False
                cmbtry.Enabled = False
                LabelControl18.Enabled = False
                LabelControl19.Enabled = False
                LabelControl20.Enabled = False

                
                btnsave.Enabled = False
                btnreset.Enabled = False
                btnedit.Enabled = True

                txtgrno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "gr_no")
                txtstdid.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "std_id")
                dtpdob.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "stddob")
                cmbyear.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "year")
                dtpaddte.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "add_dte")
                cmbadstd.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "add_std")
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "lc_entry") = "Yes" Then
                    rdlcyes.Checked = True
                ElseIf GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "lc_entry") = "No" Then
                    rdlcno.Checked = True
                End If
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "result_entry") = "Yes" Then
                    rdresultyes.Checked = True

                ElseIf GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "result_entry") = "No" Then
                    rdresultno.Checked = True
                End If
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "stdgender") = "Male" Then
                    rdmale.Checked = True
                ElseIf GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "stdgender") = "Female" Then
                    rdfemale.Checked = True
                ElseIf GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "stdgender") = "Other" Then
                    rdother.Checked = True
                End If
                txtbplace.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "b_place")

                txtlastscl.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "last_Scl")
                txtcaste.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "stdcaste")
                cmbcategory.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "category")
                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "remarks"))) Then
                    txtremarks.Text = ""
                Else
                    txtremarks.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "remarks")

                End If

                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "leave_dte"))) Then
                    dtpleavedate.Text = ""
                Else
                    dtpleavedate.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "leave_dte")

                End If

                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "leave_std"))) Then
                    
                    cmbleavestd.Text = ""
                Else
                    cmbleavestd.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "leave_std")

                End If

                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "leave_rsn"))) Then
                    txtleavereson.Text = ""
                Else
                    txtleavereson.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "leave_rsn")

                End If

                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "progress"))) Then
                    ArcScaleComponent3.Value = "0"
                    cmbprogress.Text = ""
                Else
                    Dim progress As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "progress")

                    If progress = "Bad" Then
                        ArcScaleComponent3.Value = 30
                        cmbprogress.Text = "Bad"
                    ElseIf progress = "Good" Then
                        ArcScaleComponent3.Value = 70
                        cmbprogress.Text = "Good"
                    ElseIf progress = "Excellent" Then
                        ArcScaleComponent3.Value = 98
                        cmbprogress.Text = "Excellent"
                    End If
                End If

                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "conduct"))) Then
                    ArcScaleComponent5.Value = 20
                    cmbconduct.Text = ""
                Else
                    Dim conduct As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "conduct")

                    If conduct = "Bad" Then
                        ArcScaleComponent5.Value = 35
                        cmbconduct.Text = "Bad"
                    ElseIf conduct = "Good" Then
                        ArcScaleComponent5.Value = 60
                        cmbconduct.Text = "Good"
                    ElseIf conduct = "Excellent" Then
                        ArcScaleComponent5.Value = 77
                        cmbconduct.Text = "Excellent"
                    End If

                End If

                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "try_pass"))) Then
                    DigitalGauge1.Text = "0"
                    cmbtry.Text = DigitalGauge1.Text
                Else
                    DigitalGauge1.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "try_pass")
                    cmbtry.Text = DigitalGauge1.Text
                End If

                

            End If
        Catch ex As Exception

        End Try


    End Sub
    Private Sub gridvalid1()
        GridView1.Columns("gr_no").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("f_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("l_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("address").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stdfrom").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stddob").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stdgender").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("category").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("handicap").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stdcaste").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("year").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center




        GridView1.Columns("gr_no").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("f_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("l_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("address").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stdfrom").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stddob").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stdgender").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("category").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("handicap").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("year").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

    End Sub
    Private Sub gridvalid2()
        GridView2.Columns("add_dte").Caption = "Admission Date"
        GridView2.Columns("add_std").Caption = "Admission Std"
        GridView2.Columns("remarks").Caption = "Remarks"
        GridView2.Columns("category").Caption = "Category"
        GridView2.Columns("leave_dte").Caption = "Leave Date"
        GridView2.Columns("leave_std").Caption = "Leave STD"
        GridView2.Columns("leave_rsn").Caption = "Reason"
        GridView2.Columns("progress").Caption = "Progress"
        GridView2.Columns("conduct").Caption = "Conduct"
        GridView2.Columns("try_pass").Caption = "Try of Passing"

        GridView2.Columns("add_dte").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("add_std").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("remarks").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("category").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("leave_dte").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("leave_std").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("leave_rsn").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("progress").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("conduct").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("try_pass").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        GridView2.Columns("add_dte").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("add_std").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("remarks").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("category").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("leave_dte").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("leave_std").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("leave_rsn").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("progress").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("conduct").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("try_pass").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center






    End Sub
    
    
    

    Private Sub txtstdid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstdid.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtgrno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgrno.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbplace_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbplace.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtremarks_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtremarks.KeyPress

    End Sub

    Private Sub txtlastscl_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlastscl.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcaste_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcaste.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    

    
    Public Sub resetall()

        dtpdob.Text = ""
        txtbplace.Text = ""
        cmbyear.Text = ""
        txtremarks.Text = ""
        dtpaddte.Text = ""
        cmbadstd.Text = ""
        rdlcno.Checked = False And rdlcyes.Checked = False
        rdresultyes.Checked = False And rdresultno.Checked = False
        txtlastscl.Text = ""
        txtcaste.Text = ""
        rdmale.Checked = False And rdfemale.Checked = False And rdother.Checked = False
        cmbcategory.Text = ""
        dtpleavedate.Text = ""
        txtleavereson.Text = ""
        cmbleavestd.Text = ""
        cmbprogress.Text = ""
        cmbconduct.Text = ""
        cmbtry.Text = ""
        ArcScaleComponent3.Value = 0
        DigitalGauge1.Text = 0
        ArcScaleComponent5.Value = 20
        dtpdob.Focus()



    End Sub

    Private Sub cmbprogress_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprogress.SelectedIndexChanged
        If cmbprogress.SelectedItem = "Bad" Then
            ArcScaleComponent3.Value = 30
        ElseIf cmbprogress.SelectedItem = "Good" Then
            ArcScaleComponent3.Value = 70
        ElseIf cmbprogress.SelectedItem = "Excellent" Then
            ArcScaleComponent3.Value = 98
        End If
    End Sub

    

    Private Sub cmbconduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbconduct.SelectedIndexChanged
        If cmbconduct.SelectedItem = "Bad" Then
            ArcScaleComponent5.Value = 35
        ElseIf cmbconduct.SelectedItem = "Good" Then
            ArcScaleComponent5.Value = 60
        ElseIf cmbconduct.SelectedItem = "Excellent" Then
            ArcScaleComponent5.Value = 77
        End If
    End Sub
    Public Sub grid()
        Try

            grpacadinfo.Enabled = False
            grpgeninfo.Enabled = False
            cmbconduct.Enabled = False
            cmbprogress.Enabled = False
            cmbtry.Enabled = False
            LabelControl18.Enabled = False
            LabelControl19.Enabled = False
            LabelControl20.Enabled = False

            btnsave.Enabled = False
            btnreset.Enabled = False


            Dim ds As New DataSet

            If ds.Tables.Contains("master") = True Then
                ds.Tables("master").Clear()
            End If
            If ds.Tables.Contains("Detail") = True Then
                ds.Tables("Detail").Clear()
            End If

            ' da = New SqlDataAdapter("SELECT     std_id, gr_no, f_name, l_name, address, stdfrom, stddob, stdgender, category, handicap, stdcaste, m_name, mo_name , blood_grp ,b_place ,contactno ,phno ,mail ,add_dte ,add_std ,skill ,f_contact ,f_business ,f_income ,income_certi ,caste_certi ,lc_entry ,result_entry ,entrance ,last_Scl  FROM         std_master", d.con)
            da = New SqlDataAdapter("select * from std_master order by gr_no asc", d.con)

            ds.Clear()

            da.Fill(ds, "master")

            da = New SqlDataAdapter("SELECT     gr_no, std_id, add_dte, add_std, remarks, category, leave_dte, leave_std, leave_rsn, progress, conduct, try_pass FROM         std_master order by gr_no asc", d.con)


            da.Fill(ds, "Detail")

            d.SetRelation("master", "gr_no", "Detail", "gr_no", ds, "Detail")

            grdgrmaster.DataSource = ds.Tables("master")
            gridvalid1()

            grdgrmaster.LevelTree.Nodes.Add("Detail", GridView2)
            GridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
            GridView2.PopulateColumns(ds.Tables("Detail"))


            GridView2.Columns("std_id").VisibleIndex = -1
            GridView2.Columns("gr_no").VisibleIndex = -1
            gridvalid2()

           
        Catch ex As Exception

        End Try


    End Sub
    
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If a.txtstring(txtgrno, lblgrno) = True Then
            XtraMessageBox.Show("Please Enter GR No.", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtstdid, lblstdid) = True Then
            XtraMessageBox.Show("Please Enter Student ID.", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(dtpdob, lbldob) = True Then
            XtraMessageBox.Show("Please Select DOB.", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtbplace, lblbplace) = True Then
            XtraMessageBox.Show("Please Enter Birth Place", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(cmbyear, lblyear) = True Then
            XtraMessageBox.Show("Please Select Year", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(dtpaddte, lbladdate) = True Then
            XtraMessageBox.Show("Please Select Addmission date", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(cmbadstd, lbladstd) = True Then
            XtraMessageBox.Show("Please Select Addmission Standard", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.rdvalid(rdlcno, rdlcyes, lbllcentery) = True Then
            XtraMessageBox.Show("Please Select Status of LC", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.rdvalid(rdresultno, rdresultyes, lblresultentry) = True Then
            XtraMessageBox.Show("Please Select Status of Result", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtlastscl, lbllastschool) = True Then
            XtraMessageBox.Show("Please Enter Last School Detail", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtcaste, lblcaste) = True Then
            XtraMessageBox.Show("Please Enter Religion & Caste", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.rdvalid(rdmale, rdfemale, rdother, lblgender) = True Then
            XtraMessageBox.Show("Please Select Gender", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(cmbcategory, lblcategory) = True Then
            XtraMessageBox.Show("Please Select Category", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If rdlcyes.Checked = True Then
                lc = "True"
            ElseIf rdlcno.Checked = True Then
                lc = "False"

            End If
            If rdresultyes.Checked = True Then
                result = "Yes"
            ElseIf rdresultno.Checked = True Then
                result = "No"
            End If
            If rdfemale.Checked = True Then
                gender = "Famale"
            ElseIf rdmale.Checked = True Then
                gender = "Male"
            ElseIf rdother.Checked = True Then
                gender = "Other"
            End If

            'cmd = New SqlCommand("update std_master set[stddob]='" & dtpdob.Text & "',[b_place]='" & txtbplace.Text & "',[year]='" & cmbyear.Text & "',[remarks]='" & txtremarks.Text & "',[add_dte]='" & dtpaddte.Text & "',[add_std]='" & cmbadstd.Text & "',[lc_entry]='" & lc & "',[result_entry]='" & result & "',[last_Scl]='" & txtlastscl.Text & "',[stdcaste]='" & txtcaste.Text & "',[stdgender]='" & gender & "',[category]='" & cmbcategory.Text & "',[leave_dte]='" & dtpleavedate.Text & "',[leave_std]=" & cmbleavestd.Text & ",[leave_rsn]='" & txtleavereson.Text & "',[progress]='" & ArcScaleComponent3.Value & "',[conduct]='" & ArcScaleComponent5.Value & "',[try_pass]='" & DigitalGauge1.Text & "'", d.con)



















            Try
                cmd = New SqlCommand("update std_master set[stddob]='" & dtpdob.Text & "',[b_place]='" & txtbplace.Text & "',[year]='" & cmbyear.Text & "',[remarks]='" & txtremarks.Text & "',[add_dte]='" & dtpaddte.Text & "',[add_std]='" & cmbadstd.Text & "',[category]='" & cmbcategory.Text & "',[lc_entry]='" & lc & "',[result_entry]='" & result & "',[last_Scl]='" & txtlastscl.Text & "',[stdcaste]='" & txtcaste.Text & "',[stdgender]='" & gender & "',[leave_rsn]='" & txtleavereson.Text & "',[leave_dte]='" & dtpleavedate.Text & "',[leave_std]='" & cmbleavestd.Text & "',[progress]='" & cmbprogress.Text & "',[conduct]='" & cmbconduct.Text & "',[try_pass]='" & DigitalGauge1.Text & "' where [gr_no]='" & txtgrno.Text & "'", d.con)









                cmd.ExecuteNonQuery()
                XtraMessageBox.Show("GR Information Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                grid()
            Catch ex As Exception

            End Try


        End If
    End Sub

    
    
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        resetall()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

   

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        btnedit.Enabled = False
        btnsave.Enabled = True
        btnreset.Enabled = True

        grpacadinfo.Enabled = True
        grpgeninfo.Enabled = True
        cmbconduct.Enabled = True
        cmbprogress.Enabled = True
        cmbtry.Enabled = True
        LabelControl18.Enabled = True
        LabelControl19.Enabled = True
        LabelControl20.Enabled = True
    End Sub

    
    Private Sub cmbtry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtry.SelectedIndexChanged
        If cmbtry.SelectedItem = "3" Then
            DigitalGauge1.Text = 3
        ElseIf cmbtry.SelectedItem = "2" Then
            DigitalGauge1.Text = 2
        ElseIf cmbtry.SelectedItem = "1" Then
            DigitalGauge1.Text = 1




        End If
    End Sub
End Class
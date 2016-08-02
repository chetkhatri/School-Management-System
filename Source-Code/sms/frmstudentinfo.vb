Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports Microsoft.VisualBasic.CompilerServices
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO






Public Class frmstudentinfo
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim a As New validation
    Dim d As New databind
    Dim x As String
    Dim frm, handi, gender, lc, income, caste, result As String
    Dim stdid As String
    Dim yes As String = "YES"
    Dim no As String = "NO"
    Dim desti As String = "D:\smsdata"
    Dim newpath, newpath1 As String




   
    Private Sub frmstudentinfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

        a.GridPropery(GridView1)
        d.PopulateCombo(cmbaddstd, "class_no", "class_no", "class_schema", Nothing, True, Nothing, -1)
        d.conn()

        Dim _blankContextMenu As New ContextMenu()
        txtgrno.ContextMenu = _blankContextMenu
        txtfname.ContextMenu = _blankContextMenu
        txtmname.ContextMenu = _blankContextMenu
        txtlname.ContextMenu = _blankContextMenu
        txtmothername.ContextMenu = _blankContextMenu
        txtcaste.ContextMenu = _blankContextMenu
        txtbplace.ContextMenu = _blankContextMenu
        txtcontactno.ContextMenu = _blankContextMenu
        txtphoneno.ContextMenu = _blankContextMenu
        txtemailid.ContextMenu = _blankContextMenu
        txtfcont.ContextMenu = _blankContextMenu
        txtfbusiness.ContextMenu = _blankContextMenu
        txtfyearlyin.ContextMenu = _blankContextMenu
        txtlaststudy.ContextMenu = _blankContextMenu

        grno()

        GridView1.OptionsView.ShowAutoFilterRow = True
        grid()

        newpath = ""
        newpath1 = ""
        ''''add validations'''''
        ''''''''''''''''''''''''

      




    End Sub
    Private Sub btnsign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start("mspaint.exe")
    End Sub
    Public Sub grid()
        Dim ds As New DataSet

        If ds.Tables.Contains("master") = True Then
            ds.Tables("master").Clear()
        End If
        If ds.Tables.Contains("Detail") = True Then
            ds.Tables("Detail").Clear()
        End If

        da = New SqlDataAdapter("SELECT     std_id, gr_no, f_name, l_name, address, stdfrom, stddob, stdgender, category, handicap, stdcaste, m_name, mo_name , blood_grp ,b_place ,contactno ,phno ,mail ,add_dte ,add_std ,skill ,f_contact ,f_business ,f_income ,income_certi ,caste_certi ,lc_entry ,result_entry ,entrance ,last_Scl  FROM         std_master order by gr_no asc", d.con)
        ds.Clear()

        da.Fill(ds, "master")

        da = New SqlDataAdapter("SELECT    gr_no, std_id, add_dte, add_std, skill, income_certi, caste_certi, lc_entry, result_entry, entrance, last_Scl FROM         std_master", d.con)


        da.Fill(ds, "Detail")

        d.SetRelation("master", "gr_no", "Detail", "gr_no", ds, "Detail")

        grdstdinfo.DataSource = ds.Tables("master")
        gridvalid1()

        grdstdinfo.LevelTree.Nodes.Add("Detail", GridView2)
        GridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        GridView2.PopulateColumns(ds.Tables("Detail"))


        GridView2.Columns("std_id").VisibleIndex = -1
        GridView2.Columns("gr_no").VisibleIndex = -1
        gridvalid2()

        btnsave.Enabled = False
        btnreset.Enabled = False
        grpaccont.Enabled = False
        grpcontact.Enabled = False
        grpextrainfo.Enabled = False
        grpgeninfo.Enabled = False
        grpparentdtl.Enabled = False
        grpphoto.Enabled = False
        grprelatedinfo.Enabled = False
        grpsign.Enabled = False

    End Sub
    

    
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        If a.txtstring(txtgrno, lblgrno) = True Then
            XtraMessageBox.Show("Please Enter GR No", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtfname, lblfname) = True Then
            XtraMessageBox.Show("Please Enter First Name", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtmname, lblmname) = True Then
            XtraMessageBox.Show("Please Enter Middle Name", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(txtlname, lbllname) = True Then
            XtraMessageBox.Show("Please Enter Last Name", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(txtmothername, lblmoname) = True Then
            XtraMessageBox.Show("Please Enter Mother Name", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(txtadd, lbladd) = True Then
            XtraMessageBox.Show("Please Enter Address", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.rdvalid(rdvillage, rdcity, lblfrom) = True Then
            XtraMessageBox.Show("Please Select From Stream", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(dtpdob, lbldob) = True Then
            XtraMessageBox.Show("Please Select Date of Birth", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.rdvalid(rdmale, rdfmale, rdother, lblgender) = True Then
            XtraMessageBox.Show("Please Select Gender", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(cmbcategory, lblcategory) = True Then
            XtraMessageBox.Show("Please Select Category", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(cmbbldgrp, lblblood) = True Then
            XtraMessageBox.Show("Please Select Blood Group", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.rdvalid(rdhandiyes, rdhandino, lblhandicap) = True Then
            XtraMessageBox.Show("Please Select Whether Handicap?", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtcaste, lblregion) = True Then
            XtraMessageBox.Show("Please Enter Caste", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtbplace, lblbsplace) = True Then
            XtraMessageBox.Show("Please Enter BirthPlace", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtcontactno, lblcontact) = True Or a.mobvalid(txtcontactno, lblcontact) = True Then

            If txtcontactno.Text = "" Then
                XtraMessageBox.Show("Please Enter Contact Number", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Incorrect Contact Number Format ", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf a.txtstring(txtphoneno, lblphone) = True Or a.phvalid(txtphoneno, lblphone) = True Then
            If txtphoneno.Text = "" Then
                XtraMessageBox.Show("Please Enter Phone Number", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Incorrect Phone Number Format", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        ElseIf a.txtstring(txtemailid, lblemail) = True Or a.EmailAddressCheck(txtemailid, lblemail) = False Then
            If txtemailid.Text = "" Then
                XtraMessageBox.Show("Please Enter Email ID", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Please Enter valid Email ID", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        ElseIf a.txtstring(dtpadddate, lbladdate) = True Then
            XtraMessageBox.Show("Please Select Addimission Date", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(cmbaddstd, lbladdstd) = True Then
            XtraMessageBox.Show("Please Select Addimission Standard", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtskill, lblskills) = True Then
            XtraMessageBox.Show("Please Enter Skills And Awards", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtfcont, lblfatherno) = True Or a.mobvalid(txtfcont, lblfatherno) = True Then
            If txtfcont.Text = "" Then
                XtraMessageBox.Show("Please Father Contact Number", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                XtraMessageBox.Show("Incorrect Contact Number Format ", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        ElseIf a.txtstring(txtfbusiness, lblf_business) = True Then
            XtraMessageBox.Show("Please Enter Father Business Detail", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtfyearlyin, lbly_income) = True Then
            XtraMessageBox.Show("Please Enter Father Yearly Income", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.rdvalid(rdincno, rdincyes, lblincome_certi) = True Then
            XtraMessageBox.Show("Please Select Status of Income Certi.", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.rdvalid(rdcasteno, rdcasteyes, lblcaste_certi) = True Then
            XtraMessageBox.Show("Please Select Status of Caste Certi.", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.rdvalid(rdlcno, rdlcyes, lbllc) = True Then
            XtraMessageBox.Show("Please Select Status of LC.", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.rdvalid(rdresultno, rdresultyes, lbl_result) = True Then
            XtraMessageBox.Show("Please Select Status of Result", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(cmbextrance, lblentrance) = True Then
            XtraMessageBox.Show("Please Select Entrance Result", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtlaststudy, lbllastscl) = True Then
            XtraMessageBox.Show("Please Enter Last School Detail", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If rdvillage.Checked = True Then
                frm = "Village"
            ElseIf rdcity.Checked = True Then
                frm = "City"
            End If
            If rdmale.Checked = True Then
                gender = "Male"
            ElseIf rdfmale.Checked = True Then
                gender = "Female"
            ElseIf rdother.Checked = True Then
                gender = "Other"
            End If
            If rdhandiyes.Checked = True Then
                handi = "Yes"
            Else
                handi = "No"
            End If
            If rdincyes.Checked = True Then
                income = "Yes"
            Else
                income = "No"
            End If
            If rdcasteyes.Checked = True Then
                caste = "Yes"
            Else
                caste = "No"
            End If
            If rdlcyes.Checked = True Then
                lc = "Yes"
            Else
                lc = "No"
            End If
            If rdresultyes.Checked = True Then
                result = "Yes"
            Else
                result = "No"
            End If
            If btnsave.Tag = "add" Then
                If newpath = "" Then
                    newpath = no
                End If
                If newpath1 = "" Then
                    newpath1 = no
                End If
                Try
                    cmd = New SqlCommand("select count(std_id) from std_master where [add_std]='" & cmbaddstd.Text & "'", d.con)
                    stdid = cmd.ExecuteScalar
                    stdid += 1
                Catch ex As Exception

                End Try

                'stdid = cmbaddstd.Text + "-" + stdid


                Try
                    cmd = New SqlCommand("insert into std_master(std_id,gr_no,f_name,m_name,l_name,mo_name,address,stdfrom,stddob,stdgender,category,blood_grp,handicap,stdcaste,b_place,contactno,phno,mail,add_dte,add_std,skill,f_contact,f_business,f_income,income_certi,caste_certi,lc_entry,result_entry,entrance,last_Scl,photo,sign,year) values('" & stdid & "','" & txtgrno.Text & "','" & txtfname.Text & "','" & txtmname.Text & "','" & txtlname.Text & "','" & txtmothername.Text & "','" & txtadd.Text & "','" & frm & "','" & dtpdob.Text & "','" & gender & "','" & cmbcategory.Text & "','" & cmbbldgrp.Text & "','" & handi & "','" & txtcaste.Text & "','" & txtbplace.Text & "','" & txtcontactno.Text & "','" & txtphoneno.Text & "','" & txtemailid.Text & "','" & dtpadddate.Text & "','" & cmbaddstd.Text & "','" & txtskill.Text & "','" & txtfcont.Text & "','" & txtfbusiness.Text & "','" & txtfyearlyin.Text & "','" & income & "','" & caste & "','" & lc & "','" & result & "','" & cmbextrance.Text & "','" & txtlaststudy.Text & "','" & newpath & "','" & newpath1 & "','" & Now.ToString("yyyy") & "')", d.con)

                    cmd.ExecuteNonQuery()
                    XtraMessageBox.Show("Addmission Done Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    resetall()
                    txtgrno.Text = ""
                    'grno()

                    grid()
                  
                Catch ex As Exception

                End Try
                

            ElseIf btnsave.Tag = "update" Then

                
                If Not (newpath = "" And newpath1 = "") Then
                    Try
                        cmd = New SqlCommand("update std_master set[f_name]='" & txtfname.Text & "',[m_name]='" & txtmname.Text & "',[l_name]='" & txtlname.Text & "',[mo_name]='" & txtmothername.Text & "',[address]='" & txtadd.Text & "',[stdfrom]='" & frm & "',[stddob]='" & dtpdob.Text & "',[stdgender]='" & gender & "',[category]='" & cmbcategory.Text & "',[blood_grp]='" & cmbbldgrp.Text & "',[handicap]='" & handi & "',[stdcaste]='" & txtcaste.Text & "',[b_place]='" & txtbplace.Text & "',[contactno]='" & txtcontactno.Text & "',[phno]='" & txtphoneno.Text & "',[mail]='" & txtemailid.Text & "',[add_dte]='" & dtpadddate.Text & "',[add_std]='" & cmbaddstd.Text & "',[skill]='" & txtskill.Text & "',[f_contact]='" & txtfcont.Text & "',[f_business]='" & txtfbusiness.Text & "',[f_income]='" & txtfyearlyin.Text & "',[income_certi]='" & income & "',[caste_certi]='" & caste & "',[lc_entry]='" & lc & "',[result_entry]='" & result & "',[entrance]='" & cmbextrance.Text & "',[last_Scl]='" & txtlaststudy.Text & "',[photo]='" & newpath & "',[sign]='" & newpath1 & "',[year]='" & Now.ToString("yyyy") & "' where [gr_no]='" & txtgrno.Text & "'", d.con)
                        cmd.ExecuteNonQuery()
                        XtraMessageBox.Show("GR Record Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)



                        grid()

                    Catch ex As Exception

                    End Try
                Else
                    Try
                        cmd = New SqlCommand("update std_master set[f_name]='" & txtfname.Text & "',[m_name]='" & txtmname.Text & "',[l_name]='" & txtlname.Text & "',[mo_name]='" & txtmothername.Text & "',[address]='" & txtadd.Text & "',[stdfrom]='" & frm & "',[stddob]='" & dtpdob.Text & "',[stdgender]='" & gender & "',[category]='" & cmbcategory.Text & "',[blood_grp]='" & cmbbldgrp.Text & "',[handicap]='" & handi & "',[stdcaste]='" & txtcaste.Text & "',[b_place]='" & txtbplace.Text & "',[contactno]='" & txtcontactno.Text & "',[phno]='" & txtphoneno.Text & "',[mail]='" & txtemailid.Text & "',[add_dte]='" & dtpadddate.Text & "',[add_std]='" & cmbaddstd.Text & "',[skill]='" & txtskill.Text & "',[f_contact]='" & txtfcont.Text & "',[f_business]='" & txtfbusiness.Text & "',[f_income]='" & txtfyearlyin.Text & "',[income_certi]='" & income & "',[caste_certi]='" & caste & "',[lc_entry]='" & lc & "',[result_entry]='" & result & "',[entrance]='" & cmbextrance.Text & "',[last_Scl]='" & txtlaststudy.Text & "',[year]='" & Now.ToString("yyyy") & "' where [gr_no]='" & txtgrno.Text & "'", d.con)
                        cmd.ExecuteNonQuery()
                        XtraMessageBox.Show("GR Record Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)



                        grid()

                    Catch ex As Exception

                    End Try
                End If




            End If
        End If
        


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



        GridView1.Columns("gr_no").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("f_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("l_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("address").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stdfrom").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stddob").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stdgender").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("category").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("handicap").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("stdcaste").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

    End Sub
    Private Sub gridvalid2()
        GridView2.Columns("add_dte").Caption = "Admission Date"
        GridView2.Columns("add_std").Caption = "Admission Std"
        GridView2.Columns("skill").Caption = "Skills"
        GridView2.Columns("income_certi").Caption = "Income Certi."
        GridView2.Columns("caste_certi").Caption = "Caste Certi."
        GridView2.Columns("lc_entry").Caption = "LC Entry"
        GridView2.Columns("result_entry").Caption = "Result"
        GridView2.Columns("last_Scl").Caption = "Last Study"
        GridView2.Columns("entrance").Caption = "Entrance"

        GridView2.Columns("add_dte").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("add_std").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("skill").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("income_certi").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("caste_certi").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("lc_entry").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("result_entry").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("last_Scl").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("entrance").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        GridView2.Columns("add_dte").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("add_std").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("skill").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("income_certi").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("caste_certi").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("lc_entry").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("result_entry").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("last_Scl").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns("entrance").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center






    End Sub
    Private Sub grno()
        Try
            cmd = New SqlCommand("select count(gr_no) from std_master", d.con)
            x = cmd.ExecuteScalar
            x = x + 1
            txtgrno.Text = "0" + x

        Catch ex As Exception

        End Try




    End Sub
    Public Sub resetall()

        txtfname.Text = ""
        txtmname.Text = ""
        txtlname.Text = ""
        txtmothername.Text = ""
        txtadd.Text = ""
        rdvillage.Checked = False
        rdcity.Checked = False
        dtpdob.Text = ""
        rdmale.Checked = False
        rdfmale.Checked = False
        rdother.Checked = False
        cmbcategory.Text = ""
        cmbbldgrp.Text = ""
        rdhandino.Checked = False
        rdhandiyes.Checked = False
        txtcaste.Text = ""
        txtbplace.Text = ""
        txtcontactno.Text = ""
        txtphoneno.Text = ""
        txtemailid.Text = ""
        dtpadddate.Text = ""
        cmbaddstd.Text = ""
        txtskill.Text = ""
        txtfcont.Text = ""
        txtfbusiness.Text = ""
        txtfyearlyin.Text = ""
        rdincno.Checked = False
        rdincyes.Checked = False
        rdcasteno.Checked = False
        rdcasteyes.Checked = False
        rdlcno.Checked = False
        rdlcyes.Checked = False
        rdresultno.Checked = False
        rdresultyes.Checked = False
        cmbextrance.Text = ""
        txtlaststudy.Text = ""
        picstd.Image = Nothing
        picsign.Image = Nothing
        txtfname.Focus()

    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        Try
            If (Me.GridView1.FocusedRowHandle >= 0) Then


                txtgrno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "gr_no")
                txtfname.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "f_name")
                txtmname.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "m_name")
                txtlname.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "l_name")
                txtmothername.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "mo_name")
                txtadd.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "address")
                Dim stdfrom As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "stdfrom")
                If stdfrom = "Village" Then
                    rdvillage.Checked = True
                ElseIf stdfrom = "City" Then
                    rdcity.Checked = True

                End If
                dtpdob.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "stddob")
                Dim stdgender As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "stdgender")
                If stdgender = "Male" Then
                    rdmale.Checked = True
                ElseIf stdgender = "Female" Then
                    rdfmale.Checked = True
                ElseIf stdgender = "Other" Then
                    rdother.Checked = True
                End If
                cmbcategory.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "category")
                cmbbldgrp.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "blood_grp")
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "handicap") = "Yes" Then
                    rdhandiyes.Checked = True
                ElseIf GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "handicap") = "No" Then
                    rdhandino.Checked = True
                End If
                txtcaste.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "stdcaste")
                txtbplace.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "b_place")
                txtcontactno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "contactno")
                txtphoneno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "phno")
                txtemailid.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "mail")

                ''''''''''''''''''fetching data from child grid'''''''''''''''''''''''''''
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


                dtpadddate.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "add_dte")
                cmbaddstd.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "add_std")
                txtskill.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "skill")
                txtfcont.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "f_contact")
                txtfbusiness.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "f_business")
                txtfyearlyin.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "f_income")
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "income_certi") = "Yes" Then
                    rdincyes.Checked = True
                ElseIf GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "income_certi") = "No" Then
                    rdincno.Checked = True
                End If
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "caste_certi") = "Yes" Then
                    rdcasteyes.Checked = True
                ElseIf GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "caste_certi") = "No" Then
                    rdcasteno.Checked = True

                End If

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
                cmbextrance.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "entrance")
                txtlaststudy.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "last_Scl")

                cmd = New SqlCommand("select [photo] from std_master where [gr_no]='" & txtgrno.Text & "'", d.con)
                Dim picpth As String = cmd.ExecuteScalar()

                cmd = New SqlCommand("select [sign] from std_master where [gr_no]='" & txtgrno.Text & "'", d.con)
                Dim picpth1 As String = cmd.ExecuteScalar()
                newpath = picpth
                newpath1 = picpth1

                If newpath = "NO" Then
                    picstd.Image = Nothing

                End If
                If newpath1 = "NO" Then
                    picsign.Image = Nothing

                End If

                Try
                    picstd.Image = New Bitmap(Bitmap.FromFile(picpth))
                    picsign.Image = New Bitmap(Bitmap.FromFile(picpth1))

                Catch ex As Exception

                End Try




                grpaccont.Enabled = False
                grpcontact.Enabled = False
                grpextrainfo.Enabled = False
                grpgeninfo.Enabled = False
                grpparentdtl.Enabled = False
                grpphoto.Enabled = False
                grprelatedinfo.Enabled = False
                grpsign.Enabled = False










                btnadd.Enabled = True
                btnsave.Enabled = False
                btnedit.Enabled = True
                btnreset.Enabled = False




            End If
        Catch ex As Exception

        End Try


    End Sub
    Private Sub txtfname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfname.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtmname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmname.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtlname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlname.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtmothername_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmothername.KeyPress
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

    Private Sub txtbplace_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbplace.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfbusiness_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfbusiness.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcontactno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontactno.KeyPress
        Dim ch As Char = e.KeyChar
        
        If txtcontactno.Text = "" Then
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8) Or e.KeyChar = "+") Then
                e.Handled = True
            End If
        Else
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtphoneno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphoneno.KeyPress
        Dim ch As Char = e.KeyChar
        If txtphoneno.Text = "" Then
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8) Or e.KeyChar = "+") Then
                e.Handled = True
            End If
        Else
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
                e.Handled = True
            End If
        End If
    End Sub

   

    Private Sub txtfyearlyin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfyearlyin.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()


    End Sub
   
    
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        resetall()

    End Sub

    
    Private Sub txtfcont_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfcont.KeyPress
        Dim ch As Char = e.KeyChar

        If txtfcont.Text = "" Then
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8) Or e.KeyChar = "+") Then
                e.Handled = True
            End If
        Else
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        resetall()
        grno()

        btnsave.Enabled = True
        btnreset.Enabled = True

        grpaccont.Enabled = True
        grpcontact.Enabled = True
        grpextrainfo.Enabled = True
        grpgeninfo.Enabled = True
        grpparentdtl.Enabled = True
        grpphoto.Enabled = True
        grprelatedinfo.Enabled = True
        grpsign.Enabled = True

        btnedit.Enabled = False
        btnadd.Enabled = False

        btnsave.Tag = "add"
        txtfname.Focus()


    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click

        btnedit.Enabled = False
        btnsave.Enabled = True
        btnadd.Enabled = False
        btnreset.Enabled = True
        grpaccont.Enabled = True
        grpcontact.Enabled = True
        grpextrainfo.Enabled = True
        grpgeninfo.Enabled = True
        grpparentdtl.Enabled = True
        grpphoto.Enabled = True
        grprelatedinfo.Enabled = True
        grpsign.Enabled = True
        btnsave.Tag = "update"

    End Sub

    Private Sub btnpicbro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpicbro.Click
        Try
            Dim dlg As New OpenFileDialog()
            Dim StrPath As String = ""
            dlg.Filter = "Jpeg Files|*.jpg|All Files|*.*"
            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                StrPath = dlg.FileName.ToString
            End If
            'TextBox1.Text = StrPath
            newpath = Path.Combine(desti, Path.GetFileName(StrPath))
            If Not Directory.Exists(desti) Then
                Directory.CreateDirectory(desti)
                If Not File.Exists(newpath) Then
                    File.Copy(StrPath, newpath)

                End If
            Else
                If Not File.Exists(newpath) Then
                    File.Copy(StrPath, newpath)

                End If

            End If
            picstd.Image = New Bitmap(Bitmap.FromFile(StrPath))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsignbro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsignbro.Click
        Try
            Dim dlg As New OpenFileDialog()
            Dim StrPath1 As String = ""
            dlg.Filter = "Jpeg Files|*.jpg|All Files|*.*"
            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                StrPath1 = dlg.FileName.ToString
            End If
            'TextBox1.Text = StrPath
            newpath1 = Path.Combine(desti, Path.GetFileName(StrPath1))
            If Not Directory.Exists(desti) Then
                Directory.CreateDirectory(desti)
                If Not File.Exists(newpath1) Then
                    File.Copy(StrPath1, newpath1)

                End If
            Else
                If Not File.Exists(newpath1) Then
                    File.Copy(StrPath1, newpath1)

                End If

            End If
            picsign.Image = New Bitmap(Bitmap.FromFile(StrPath1))
        Catch ex As Exception
            newpath1 = no

        End Try
    End Sub

    
End Class

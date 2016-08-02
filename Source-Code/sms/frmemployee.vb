Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.CompilerServices
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO







Public Class frmemployee
    Dim a As New validation
    Dim d As New databind
    Dim cmd, cmd1 As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dr As SqlDataReader
    Dim str As String
    Dim gender As String
    Dim x As String
    Dim yes As String = "YES"
    Dim no As String = "NO"
    Dim desti As String = "D:\smsdata"
    Dim newpath, newpath1 As String











    Private Sub frmemployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpdteto.Enabled = False

        Try
            d.PopulateCombo(cmbpost, "post_id", "post_name", "tbpost", Nothing, True, Nothing, -1)
            d.PopulateCombo(cmbsubject, "sub_id", "s_name", "sub_regi", Nothing, True, Nothing, -1)
            d.PopulateCombo(cmbclass, "class_no", "class_no", "class_schema", Nothing, True, Nothing, -1)
        Catch ex As Exception

        End Try

        d.conn()
        GridView1.OptionsView.ShowAutoFilterRow = True

        If btnsave.Tag = "Add" Then
            empno()
        End If

        a.GridPropery(GridView1)
        gridvalid()


        d.gridfill("select * from emp_master where [status]='" & yes & "' ", grdemp)
        Dim _blankContextMenu As New ContextMenu()
        txtfname.ContextMenu = _blankContextMenu
        txtlname.ContextMenu = _blankContextMenu
        txtmname.ContextMenu = _blankContextMenu
        txtadd.ContextMenu = _blankContextMenu
        txtcontactno.ContextMenu = _blankContextMenu
        txtemailid.ContextMenu = _blankContextMenu
        txtgovempno.ContextMenu = _blankContextMenu
        txtpanno.ContextMenu = _blankContextMenu
        txtgpfno.ContextMenu = _blankContextMenu
        txtcpfno.ContextMenu = _blankContextMenu
        txtpranno.ContextMenu = _blankContextMenu














    End Sub
    Private Sub gridvalid()
        GridView1.Columns("emp_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("emp_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("f_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("f_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("l_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("l_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("address").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("address").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("co_no").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("co_no").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("e_gender").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("e_gender").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("gov_no").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("gov_no").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte_frm").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte_frm").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte_to").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("dte_to").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("tax").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("tax").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        If (Me.GridView1.FocusedRowHandle >= 0) Then
           

            txtempid.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "emp_id")
            txtfname.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "f_name")
            txtmname.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "m_name")

            txtlname.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "l_name")
            txtadd.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "address")
            txtcontactno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "co_no")
            txtemailid.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "email")
            cmbtaxmethod.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "tax")
            txtgovempno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "gov_no")
            dtpdob.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "dob")
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "e_gender") = "Male" Then
                rdmale.Checked = True
            ElseIf GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "e_gender") = "Female" Then
                rdfmale.Checked = True
            ElseIf GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "e_gender") = "Other" Then
                rdother.Checked = True

            End If
            dtpdtefrom.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "dte_frm")
            dtpdteto.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "dte_to")
            txtpanno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "pan")
            txtpranno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "pran")
            txtcpfno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "gpf")
            txtgpfno.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cpf")
            cmbclass.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "class_id")

            


            d.con.Close()
            d.con.Open()
            cmd = New SqlCommand("select [post_name] from tbpost where post_id=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "post_id"), d.con)
            cmbpost.Text = cmd.ExecuteScalar
            cmd = New SqlCommand("select [s_name] from sub_regi where sub_id=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "sub_id"), d.con)
            cmbsubject.Text = cmd.ExecuteScalar
            cmd = New SqlCommand("select [photo] from emp_master where [emp_id]='" & txtempid.Text & "'", d.con)
            Dim picpth As String = cmd.ExecuteScalar()
            cmd = New SqlCommand("select [sign] from emp_master where [emp_id]='" & txtempid.Text & "'", d.con)
            Dim picpth1 As String = cmd.ExecuteScalar()
            newpath = picpth
            newpath1 = picpth1

            If picpth = "NO" Then

                picphoto.Image = Nothing



            End If
            If picpth1 = "NO" Then
                picsign.Image = Nothing

            End If

            Try
                picphoto.Image = New Bitmap(Bitmap.FromFile(picpth))
                picsign.Image = New Bitmap(Bitmap.FromFile(picpth1))

            Catch ex As Exception

            End Try
            d.ComboSelectedIndex(Me.cmbpost, Conversions.ToLong(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "post_id")))
            d.ComboSelectedIndex(Me.cmbsubject, Conversions.ToLong(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "sub_id")))














            btnsave.Enabled = False
            btnedit.Enabled = True
            btnreset.Enabled = False
            grpempgen.Enabled = False
            grpempadv.Enabled = False
            grpempgvt.Enabled = False
            grpemppersonal.Enabled = False



        End If


    End Sub
    Private Sub empno()
        cmd = New SqlCommand("select max(emp_id) from emp_master", d.con)
        x = cmd.ExecuteScalar()
        x = x + 1
        txtempid.Text = "0" + x
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If a.txtstring(txtempid, lblempid) = True Then
            XtraMessageBox.Show("Please Enter Employee ID", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(txtfname, lblfname) = True Then
            XtraMessageBox.Show("Please Enter First Name", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtmname, lblmname) = True Then
            XtraMessageBox.Show("Please Enter Middle Name", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtlname, lbllname) = True Then
            XtraMessageBox.Show("Please Enter Last Name", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(cmbpost, lblpost) = True Then
            XtraMessageBox.Show("Please Select Post", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtadd, lbladd) = True Then
            XtraMessageBox.Show("Please Enter Address", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtcontactno, lblcontactno) = True Or a.mobvalid(txtcontactno, lblcontactno) = True Then
            If txtcontactno.Text = "" Then
                XtraMessageBox.Show("Please Enter Contact No", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Please Enter Valid Contact No", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf a.txtstring(txtemailid, lblemailid) = True Or a.EmailAddressCheck(txtemailid, lblemailid) = False Then
            If txtemailid.Text = "" Then
                XtraMessageBox.Show("Please Enter Email ID", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Please Enter Valid Email ID", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf a.txtstring(cmbtaxmethod, lbltaxmethod) = True Then
            XtraMessageBox.Show("Please Select Tax Method", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtgovempno, lblgovno) = True Then
            XtraMessageBox.Show("Please Enter Gov.Employee No", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(dtpdob, lbldob) = True Then
            XtraMessageBox.Show("Please Select Date of Birth", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.rdvalid(rdmale, rdfmale, rdother, lblgender) = True Then
            XtraMessageBox.Show("Please Select Gender", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(dtpdtefrom, lbldtefrom) = True Then
            XtraMessageBox.Show("Please Select Date From", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(cmbsubject, lblsubject) = True Then
            XtraMessageBox.Show("Please Select Subject", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(cmbclass, lblclass) = True Then
            XtraMessageBox.Show("Please Select Class", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtpanno, lblpanno) = True Then
            XtraMessageBox.Show("Please Enter PAN No", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(txtpranno, lblpranno) = True Then
            XtraMessageBox.Show("Please Enter PRAN No", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtgpfno, lblgpf) = True Then
            XtraMessageBox.Show("Please Enter GPF No", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a.txtstring(txtcpfno, lblcpf) = True Then
            XtraMessageBox.Show("Please Enter CPF No", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            


        
            






            If rdmale.Checked = True Then
                gender = "Male"
            ElseIf rdfmale.Checked = True Then
                gender = "Female"
            ElseIf rdother.Checked = True Then
                gender = "Other"
            End If


            Try
                


                If Me.btnsave.Tag = "Add" Then
                    If newpath = "" Then
                        newpath = no
                    End If
                    If newpath1 = "" Then
                        newpath1 = no
                    End If


                    cmd = New SqlCommand("insert into emp_master values('" & x & "','" & (cmbclass.SelectedItem).GetData() & "','" & (cmbsubject.SelectedItem).GetData() & "','" & (cmbpost.SelectedItem).GetData() & "','" & txtfname.Text & "','" & txtmname.Text & "','" & txtlname.Text & "','" & txtadd.Text & "','" & txtcontactno.Text & "','" & txtemailid.Text & "','" & cmbtaxmethod.Text & "','" & txtgovempno.Text & "','" & dtpdob.Text & "','" & gender & "','" & dtpdtefrom.Text & "','" & dtpdteto.Text & "','" & txtpanno.Text & "','" & txtpranno.Text & "','" & txtgpfno.Text & "','" & txtcpfno.Text & "','" & yes & "','" & newpath & "','" & newpath1 & "')", d.con)
                    cmd.ExecuteNonQuery()
                    XtraMessageBox.Show("Employee Registration Success", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    empno()

                    clearall()



                ElseIf Me.btnsave.Tag = "Update" Then
                    d.con.Close()
                    d.con.Open()

                    If a.txtstring(dtpdteto, lbldteto) = True Then
                        XtraMessageBox.Show("Please Select Date To", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        cmd = New SqlCommand("select [post_name] from tbpost where post_id=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "post_id"), d.con)
                        cmd1 = New SqlCommand("select [s_name] from sub_regi where sub_id=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "sub_id"), d.con)

                        If cmbpost.Text = cmd.ExecuteScalar() Then
                            If cmbsubject.Text = cmd1.ExecuteScalar Then

                                cmd = New SqlCommand("update emp_master set[class_id]='" & cmbclass.Text & "',[f_name]='" & txtfname.Text & "',[m_name]='" & txtmname.Text & "',[l_name]='" & txtlname.Text & "',[address]='" & txtadd.Text & "',[co_no]='" & txtcontactno.Text & "',[email]='" & txtemailid.Text & "',[tax]='" & cmbtaxmethod.Text & "',[gov_no]='" & txtgovempno.Text & "',[dob]='" & dtpdob.Text & "',[e_gender]='" & gender & "',[dte_frm]='" & dtpdtefrom.Text & "',[dte_to]='" & dtpdteto.Text & "',[pan]='" & txtpanno.Text & "',[pran]='" & txtpranno.Text & "',[gpf]='" & txtgpfno.Text & "',[cpf]='" & txtcpfno.Text & "',[photo]='" & newpath & "',[sign]='" & newpath1 & "' where [emp_id]='" & txtempid.Text & "'", d.con)
                                cmd.ExecuteNonQuery()
                                XtraMessageBox.Show("Employee Record Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Else
                                cmd = New SqlCommand("update emp_master set[class_id]='" & cmbclass.Text & "',[sub_id]='" & (cmbsubject.SelectedItem).GetData() & "',[f_name]='" & txtfname.Text & "',[m_name]='" & txtmname.Text & "',[l_name]='" & txtlname.Text & "',[address]='" & txtadd.Text & "',[co_no]='" & txtcontactno.Text & "',[email]='" & txtemailid.Text & "',[tax]='" & cmbtaxmethod.Text & "',[gov_no]='" & txtgovempno.Text & "',[dob]='" & dtpdob.Text & "',[e_gender]='" & gender & "',[dte_frm]='" & dtpdtefrom.Text & "',[dte_to]='" & dtpdteto.Text & "',[pan]='" & txtpanno.Text & "',[pran]='" & txtpranno.Text & "',[gpf]='" & txtgpfno.Text & "',[cpf]='" & txtcpfno.Text & "',[photo]='" & newpath & "',[sign]='" & newpath1 & "' where [emp_id]='" & txtempid.Text & "'", d.con)
                                cmd.ExecuteNonQuery()
                                XtraMessageBox.Show("Employee Record Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            End If
                        ElseIf cmbsubject.Text = cmd1.ExecuteScalar Then
                            cmd = New SqlCommand("update emp_master set[class_id]='" & cmbclass.Text & "',[post_id]='" & (cmbpost.SelectedItem).GetData() & "',[f_name]='" & txtfname.Text & "',[m_name]='" & txtmname.Text & "',[l_name]='" & txtlname.Text & "',[address]='" & txtadd.Text & "',[co_no]='" & txtcontactno.Text & "',[email]='" & txtemailid.Text & "',[tax]='" & cmbtaxmethod.Text & "',[gov_no]='" & txtgovempno.Text & "',[dob]='" & dtpdob.Text & "',[e_gender]='" & gender & "',[dte_frm]='" & dtpdtefrom.Text & "',[dte_to]='" & dtpdteto.Text & "',[pan]='" & txtpanno.Text & "',[pran]='" & txtpranno.Text & "',[gpf]='" & txtgpfno.Text & "',[cpf]='" & txtcpfno.Text & "',[photo]='" & newpath & "',[sign]='" & newpath1 & "' where [emp_id]='" & txtempid.Text & "'", d.con)
                            cmd.ExecuteNonQuery()
                            XtraMessageBox.Show("Employee Record Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            cmd = New SqlCommand("update emp_master set[class_id]='" & cmbclass.Text & "',[sub_id]='" & (cmbsubject.SelectedItem).GetData() & "',[post_id]='" & (cmbpost.SelectedItem).GetData() & "',[f_name]='" & txtfname.Text & "',[m_name]='" & txtmname.Text & "',[l_name]='" & txtlname.Text & "',[address]='" & txtadd.Text & "',[co_no]='" & txtcontactno.Text & "',[email]='" & txtemailid.Text & "',[tax]='" & cmbtaxmethod.Text & "',[gov_no]='" & txtgovempno.Text & "',[dob]='" & dtpdob.Text & "',[e_gender]='" & gender & "',[dte_frm]='" & dtpdtefrom.Text & "',[dte_to]='" & dtpdteto.Text & "',[pan]='" & txtpanno.Text & "',[pran]='" & txtpranno.Text & "',[gpf]='" & txtgpfno.Text & "',[cpf]='" & txtcpfno.Text & "',[photo]='" & newpath & "',[sign]='" & newpath1 & "' where [emp_id]='" & txtempid.Text & "'", d.con)
                            cmd.ExecuteNonQuery()
                            XtraMessageBox.Show("Employee Record Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                    End If


                    





                    End If
                    d.gridfill("select * from emp_master where [status]='" & yes & "' ", grdemp)
            Catch ex As Exception
                
            End Try


        End If


    End Sub
    Private Sub clearall()
        txtfname.Text = ""
        txtmname.Text = ""
        txtlname.Text = ""
        cmbpost.Text = ""
        txtadd.Text = ""
        txtcontactno.Text = ""
        txtemailid.Text = ""
        cmbtaxmethod.Text = ""
        txtgovempno.Text = ""
        dtpdob.Text = ""
        rdmale.Checked = False
        rdfmale.Checked = False
        rdother.Checked = False
        dtpdtefrom.Text = ""
        dtpdteto.Text = ""
        cmbsubject.Text = ""
        cmbclass.Text = ""
        txtpanno.Text = ""
        txtpranno.Text = ""
        txtgpfno.Text = ""
        txtcpfno.Text = ""

        txtfname.Focus()
        picphoto.Image = Nothing
        picsign.Image = Nothing

    End Sub
    

    Private Sub btnpost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpost.Click
        frmpost.Dispose()

        frmpost.ShowDialog()
        frmpost.ShowInTaskbar = False
        frmpost.SizeGripStyle = SizeGripStyle.Hide
        d.PopulateCombo(cmbpost, "post_id", "post_name", "tbpost", Nothing, True, Nothing, -1)

    End Sub
    

    Private Sub GroupControl2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles grpempgen.Paint

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

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        btnedit.Enabled = False
        btnsave.Enabled = True
        btnreset.Enabled = True
        grpempadv.Enabled = True
        grpempgen.Enabled = True
        grpempgvt.Enabled = True
        grpemppersonal.Enabled = True
        btnsave.Tag = "Update"
        dtpdteto.Enabled = True


    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        Me.clearall()

    End Sub

    Private Sub btnresign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnresign.Click
        If (XtraMessageBox.Show("Are you sure you want to delete selected record?", "SMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
            Try
                cmd = New SqlCommand("update emp_master set[status]='" & no & "' where [emp_id]='" & txtempid.Text & "'", d.con)
                cmd.ExecuteNonQuery()
                XtraMessageBox.Show("Employee Record Deleted Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                d.gridfill("select * from emp_master where [status]='" & yes & "' ", grdemp)
            Catch ex As Exception

            End Try

        End If






    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub btnphotobro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnphotobro.Click

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
            picphoto.Image = New Bitmap(Bitmap.FromFile(StrPath))
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

        End Try
    End Sub
End Class

Imports System.Data.SqlClient
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors



Public Class frmstartscreen

    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As New SqlCommand
    Dim d As New databind


    Private Sub CommandBarItem35_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        frmstudentinfo.Show()

    End Sub

    

    Private Sub frmstartscreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Coffee")
        DevExpress.LookAndFeel.UserLookAndFeel.Default.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Coffee"

      

        d.conn()
        Me.Hide()





        frmlogin.Show()
        If frmlogin.btnlogin.Tag = "log" Then
            Me.Visible = True

        End If
        Me.Visible = False












    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    

    Private Sub CommandBarItem46_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CommandBarItem46.ItemClick

    End Sub

   

    Private Sub frmstartscreen_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing


        If (XtraMessageBox.Show("Are you sure you want to Close?", "SMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
            e.Cancel = False
            XtraMessageBox.Show("Thank you", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            e.Cancel = True
        End If


    End Sub

    Private Sub CommandBarItem32_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CommandBarItem32.ItemClick

    End Sub

    Private Sub PrintControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
    Private Sub barnewadd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barnewadd.ItemClick
        frmstudentinfo.Show()

    End Sub

    Private Sub barstdgrmaster_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barstdgrmaster.ItemClick
        frmgrmaster.Show()

    End Sub

    Private Sub barfees_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barfees.ItemClick
        frmfees.Show()


    End Sub

    Private Sub barscholor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barscholor.ItemClick
        frmscholorship.Show()

    End Sub

    
    Private Sub barexam_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barexam.ItemClick
        frmmarking.Dispose()

        frmmarking.ShowDialog()

    End Sub

    
    Private Sub barresult_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barresult.ItemClick
        frmresultfilter.ShowDialog()


    End Sub

    Private Sub barstnview_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub barstnadfilter_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barstnadfilter.ItemClick
        frmviewstd.Show()

    End Sub

    Private Sub bargrAdvanceview_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bargrAdvanceview.ItemClick
        frmviewgr.Show()

    End Sub

    Private Sub BarButtonItem43_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnempview.ItemClick
        frmviewemp.Show()

    End Sub

    Private Sub BarButtonItem34_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnempnew.ItemClick
        Try
            frmemployee.Dispose()
        Catch ex As Exception

        End Try
        Dim size As New Size(938, 425)
        frmemployee.ClientSize = size
        frmemployee.Text = "New Employee Registration"
        frmemployee.btnedit.Enabled = False
        frmemployee.btnresign.Enabled = False
        frmemployee.GroupControl8.Dispose()
        ' frmemployee.txtemailid.Properties.ReadOnly = True
        frmemployee.btnsave.Tag = "Add"




        frmemployee.Show()

    End Sub

    Private Sub BarButtonItem24_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnusernew.ItemClick
        frmnewac.ShowDialog()

    End Sub

    Private Sub BarButtonItem27_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnchngepw.ItemClick
        frmchangepw.ShowDialog()


    End Sub

    Private Sub BarButtonItem28_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnbackup.ItemClick
        frmbackup.ShowDialog()

    End Sub

    Private Sub BarButtonItem29_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnrestore.ItemClick
        frmrestore.ShowDialog()

    End Sub

    Private Sub BarButtonItem38_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnmonthsal.ItemClick
        frmhrm.Show()

    End Sub

    Private Sub BarButtonItem41_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub BarButtonItem42_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnhrmadview.ItemClick
        frmviewall.Show()

    End Sub

    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnallowance.ItemClick
        frmallowance.ShowDialog()

    End Sub

    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btntax.ItemClick
        frmtaxrate.ShowDialog()

    End Sub

    Private Sub btnclass_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnclass.ItemClick
        frmclass_entry.Show()

    End Sub

    Private Sub btnsubject_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnsubject.ItemClick
        frmsub_entry.Show()

    End Sub

    Private Sub btnmanagepost_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnmanagepost.ItemClick
        frmpost.Dispose()

        frmpost.ShowDialog()





    End Sub

    Private Sub btncalender_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btncalender.ItemClick
        frmcalender.ShowDialog()

    End Sub

    Private Sub btnuserview_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnuserview.ItemClick
        frmuserview.Dispose()
        frmuserview.str = "select * from user_master"
        frmuserview.GroupControl1.Text = "User LookUp"
        frmuserview.Text = "User LookUp"
        frmuserview.GridColumn1.FieldName = "emp_id"
        frmuserview.GridColumn1.Caption = "Employee ID"
        frmuserview.GridColumn2.FieldName = "u_name"
        frmuserview.GridColumn2.Caption = "UserName"
        frmuserview.GridColumn3.FieldName = "usertype"
        frmuserview.GridColumn3.Caption = "User Type"
        frmuserview.GridColumn4.FieldName = "pwd"
        frmuserview.GridColumn4.Caption = "Password"
        frmuserview.GridView1.Columns("emp_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmuserview.GridView1.Columns("emp_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmuserview.GridView1.Columns("u_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmuserview.GridView1.Columns("u_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmuserview.GridView1.Columns("usertype").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmuserview.GridView1.Columns("usertype").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmuserview.GridView1.Columns("pwd").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmuserview.GridView1.Columns("pwd").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center


        frmuserview.ShowDialog()


    End Sub

    Private Sub btnlogdtl_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnlogdtl.ItemClick
        frmuserview.Dispose()

        frmuserview.str = "select * from log_regi"
        frmuserview.GroupControl1.Text = "User Log LookUp"
        frmuserview.Text = "User Log Information"
        frmuserview.GridColumn1.FieldName = "log_id"
        frmuserview.GridColumn1.Caption = "Log ID"
        frmuserview.GridColumn2.FieldName = "u_name"
        frmuserview.GridColumn2.Caption = "UserName"
        frmuserview.GridColumn3.FieldName = "dte"
        frmuserview.GridColumn3.Caption = "Date"
        frmuserview.GridColumn4.FieldName = "tme"
        frmuserview.GridColumn4.Caption = "Time"
        frmuserview.GridView1.Columns("log_id").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmuserview.GridView1.Columns("log_id").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmuserview.GridView1.Columns("u_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmuserview.GridView1.Columns("u_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmuserview.GridView1.Columns("dte").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmuserview.GridView1.Columns("dte").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmuserview.GridView1.Columns("tme").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmuserview.GridView1.Columns("tme").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        frmuserview.ShowDialog()

    End Sub

    Private Sub btnempedit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnempedit.ItemClick
        frmemployee.Dispose()

        Dim size As New Size(938, 640)
        frmemployee.ClientSize = size
        frmemployee.Text = "Employee Information"
        


        frmemployee.Show()
    End Sub

    Private Sub btnempallow_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnempallow.ItemClick
        frmtaxallview.str = "select [dte],[gpay],[da],[hra],[med_all],[fpi],[cash_all],[was_all] from tballw_tax"
        frmtaxallview.GroupControl1.Text = "HRM Allowance Rate LookUp"
        frmtaxallview.Text = "Allowance Rate Information"
        frmtaxallview.GridColumn1.FieldName = "dte"
        frmtaxallview.GridColumn1.Caption = "Date"
        frmtaxallview.GridColumn2.FieldName = "gpay"
        frmtaxallview.GridColumn2.Caption = "G.Pay"
        frmtaxallview.GridColumn3.FieldName = "da"
        frmtaxallview.GridColumn3.Caption = "D.A."
        frmtaxallview.GridColumn4.FieldName = "hra"
        frmtaxallview.GridColumn4.Caption = "H.R.A"
        frmtaxallview.GridColumn5.FieldName = "med_all"
        frmtaxallview.GridColumn5.Caption = "Med.All"
        frmtaxallview.GridColumn6.FieldName = "fpi"
        frmtaxallview.GridColumn6.Caption = "F.P.I"
        frmtaxallview.GridColumn7.FieldName = "cash_all"
        frmtaxallview.GridColumn7.Caption = "Cash.All."
        frmtaxallview.GridColumn8.FieldName = "was_all"
        frmtaxallview.GridColumn8.Caption = "Wash.All."

        frmtaxallview.GridView1.Columns("dte").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("dte").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("gpay").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("gpay").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("da").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("da").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("hra").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("hra").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("med_all").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("med_all").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("fpi").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("fpi").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("cash_all").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("cash_all").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("was_all").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("was_all").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        frmtaxallview.ShowDialog()






    End Sub

    Private Sub btnemptax_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnemptax.ItemClick
     
        frmtaxallview.str = "select * from tballw_tax"
        frmtaxallview.GroupControl1.Tag = "tax"
        frmtaxallview.GroupControl1.Text = "HRM Tax Rate LookUp"
        frmtaxallview.Text = "Allowance Tax Information"
        frmtaxallview.GridColumn1.FieldName = "dte"
        frmtaxallview.GridColumn1.Caption = "Date"
        frmtaxallview.GridColumn2.FieldName = "gpf"
        frmtaxallview.GridColumn2.Caption = "G.P.F"
        frmtaxallview.GridColumn3.FieldName = "cpf"
        frmtaxallview.GridColumn3.Caption = "C.P.F"
        frmtaxallview.GridColumn4.FieldName = "pf"
        frmtaxallview.GridColumn4.Caption = "P.F."
        frmtaxallview.GridColumn5.FieldName = "it"
        frmtaxallview.GridColumn5.Caption = "I.T"
        frmtaxallview.GridColumn6.FieldName = "gi"
        frmtaxallview.GridColumn6.Caption = "G.I"
        frmtaxallview.GridColumn7.Visible = False
        frmtaxallview.GridColumn8.Visible = False

        frmtaxallview.GridView1.Columns("dte").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("dte").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("gpf").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("gpf").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("cpf").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("cpf").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("pf").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("pf").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("it").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("it").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("gi").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        frmtaxallview.GridView1.Columns("gi").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center


       
        frmtaxallview.ShowDialog()
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btneditmarks.ItemClick
        frmmarksedit.ShowDialog()

    End Sub

    Private Sub btnrptusrinfo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnrptusrinfo.ItemClick
        Try
            da = New SqlDataAdapter("select * from user_master", d.con)
            ds.Clear()

            da.Fill(ds, "abc")

            Dim report2 As New rptuserinfo
            report2.DataSource = ds.Tables("abc")
            report2.DataMember = "abc"
            report2.xrempid.DataBindings.Add("Text", ds.Tables("abc"), "abc.emp_id")
            report2.xruname.DataBindings.Add("Text", ds.Tables("abc"), "abc.u_name")
            report2.xrutype.DataBindings.Add("Text", ds.Tables("abc"), "abc.usertype")
            Try
                cmd = New SqlCommand("select u_name from log_regi where log_id=(select max(log_id) from log_regi)", d.con)
                report2.xruser.Text = cmd.ExecuteScalar

            Catch ex As Exception

            End Try


            report2.ShowPreview()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnrptallw_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnrptallw.ItemClick
        Try
            da = New SqlDataAdapter("select convert(varchar(10), dte,103) as dte,[gpay],[da],[hra],[med_all],[fpi],[cash_all],[was_all] from tballw_tax", d.con)
            ds.Clear()

            da.Fill(ds, "abc")

            Dim report2 As New rptallowance
            report2.DataSource = ds.Tables("abc")
            report2.DataMember = "abc"
            report2.xrdte.DataBindings.Add("Text", ds.Tables("abc"), "abc.dte")
            report2.xrgpay.DataBindings.Add("Text", ds.Tables("abc"), "abc.gpay")
            report2.xrda.DataBindings.Add("Text", ds.Tables("abc"), "abc.da")
            report2.xrhra.DataBindings.Add("Text", ds.Tables("abc"), "abc.hra")
            report2.xrmedall.DataBindings.Add("Text", ds.Tables("abc"), "abc.med_all")
            report2.xrfpi.DataBindings.Add("Text", ds.Tables("abc"), "abc.fpi")
            report2.xrcashall.DataBindings.Add("Text", ds.Tables("abc"), "abc.cash_all")
            report2.xrwasall.DataBindings.Add("Text", ds.Tables("abc"), "abc.was_all")

            Try
                cmd = New SqlCommand("select u_name from log_regi where log_id=(select max(log_id) from log_regi)", d.con)
                report2.xruser.Text = cmd.ExecuteScalar

            Catch ex As Exception

            End Try


            report2.ShowPreview()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnrpttax_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnrpttax.ItemClick
        Try
            da = New SqlDataAdapter("SELECT    convert(varchar(10), dte,103) as dte, gpf, cpf, pf, it, gi FROM tballw_tax", d.con)
            ds.Clear()

            da.Fill(ds, "abc")

            Dim report2 As New rpttax
            report2.DataSource = ds.Tables("abc")
            report2.DataMember = "abc"
            report2.xrdte.DataBindings.Add("Text", ds.Tables("abc"), "abc.dte")
            report2.xrgpf.DataBindings.Add("Text", ds.Tables("abc"), "abc.gpf")
            report2.xrcpf.DataBindings.Add("Text", ds.Tables("abc"), "abc.cpf")
            report2.xrpf.DataBindings.Add("Text", ds.Tables("abc"), "abc.pf")
            report2.xrit.DataBindings.Add("Text", ds.Tables("abc"), "abc.it")
            report2.xrgi.DataBindings.Add("Text", ds.Tables("abc"), "abc.gi")
            

            Try
                cmd = New SqlCommand("select u_name from log_regi where log_id=(select max(log_id) from log_regi)", d.con)
                report2.xruser.Text = cmd.ExecuteScalar

            Catch ex As Exception

            End Try


            report2.ShowPreview()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnrptemp_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnrptemp.ItemClick
        frmviewemp.ShowDialog()

    End Sub

    Private Sub btnrptsal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnrptsal.ItemClick
        frmviewall.ShowDialog()

    End Sub

    Private Sub btnrptfest_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnrptfest.ItemClick
        Try
            da = New SqlDataAdapter("SELECT     std_id, class_id, fee_type, amt, dte FROM fees_master ORDER BY class_id", d.con)
            ds.Clear()

            da.Fill(ds, "abc")

            Dim report2 As New rptfeestat
            report2.DataSource = ds.Tables("abc")
            report2.DataMember = "abc"
            report2.xrclassid.DataBindings.Add("Text", ds.Tables("abc"), "abc.class_id")
            report2.xrstdid.DataBindings.Add("Text", ds.Tables("abc"), "abc.std_id")
            report2.xrdte.DataBindings.Add("Text", ds.Tables("abc"), "abc.dte")
            report2.xrfeetype.DataBindings.Add("Text", ds.Tables("abc"), "abc.fee_type")
            report2.xramt.DataBindings.Add("Text", ds.Tables("abc"), "abc.amt")
            Try
                cmd = New SqlCommand("select sum(amt) from fees_master", d.con)
                report2.xrtotal.Text = cmd.ExecuteScalar


            Catch ex As Exception

            End Try


            Try
                cmd = New SqlCommand("select u_name from log_regi where log_id=(select max(log_id) from log_regi)", d.con)
                report2.xruser.Text = cmd.ExecuteScalar

            Catch ex As Exception

            End Try


            report2.ShowPreview()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnrptscholor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnrptscholor.ItemClick
        Try
            da = New SqlDataAdapter("SELECT     std_id, class_id, sch_type, amt, dte FROM scholor_regi ORDER BY class_id", d.con)
            ds.Clear()

            da.Fill(ds, "abc")

            Dim report2 As New rptscholorstat
            report2.DataSource = ds.Tables("abc")
            report2.DataMember = "abc"
            report2.xrclassid.DataBindings.Add("Text", ds.Tables("abc"), "abc.class_id")
            report2.xrstdid.DataBindings.Add("Text", ds.Tables("abc"), "abc.std_id")
            report2.xrdte.DataBindings.Add("Text", ds.Tables("abc"), "abc.dte")
            report2.xrschotype.DataBindings.Add("Text", ds.Tables("abc"), "abc.sch_type")
            report2.xramt.DataBindings.Add("Text", ds.Tables("abc"), "abc.amt")
            Try
                cmd = New SqlCommand("select sum(amt) from scholor_regi", d.con)
                report2.xrtotal.Text = cmd.ExecuteScalar


            Catch ex As Exception

            End Try


            Try
                cmd = New SqlCommand("select u_name from log_regi where log_id=(select max(log_id) from log_regi)", d.con)
                report2.xruser.Text = cmd.ExecuteScalar

            Catch ex As Exception

            End Try


            report2.ShowPreview()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnresultstat.ItemClick
        frmresultfilter.ShowDialog()

    End Sub

    Private Sub btnuserlog_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnuserlog.ItemClick
        Try
            da = New SqlDataAdapter("select * from log_regi", d.con)
            ds.Clear()

            da.Fill(ds, "abc")

            Dim report2 As New rptloginfo
            report2.DataSource = ds.Tables("abc")
            report2.DataMember = "abc"
            report2.xrlogid.DataBindings.Add("Text", ds.Tables("abc"), "abc.log_id")
            report2.xruname.DataBindings.Add("Text", ds.Tables("abc"), "abc.u_name")
            report2.xrdte.DataBindings.Add("Text", ds.Tables("abc"), "abc.dte")
            report2.xrtme.DataBindings.Add("Text", ds.Tables("abc"), "abc.tme")
            Try
                cmd = New SqlCommand("select u_name from log_regi where log_id=(select max(log_id) from log_regi)", d.con)
                report2.xruser.Text = cmd.ExecuteScalar

            Catch ex As Exception

            End Try


            report2.ShowPreview()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnrptresult_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnrptresult.ItemClick
        xrresult.Dispose()

        xrresult.ShowDialog()

    End Sub

    Private Sub BarButtonItem4_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        frmabt.ShowDialog()

    End Sub

    Private Sub btnfeesrcpt_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnfeesrcpt.ItemClick
        frmfees.ShowDialog()

    End Sub

    Private Sub btnrptadd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnrptadd.ItemClick
        frmviewstd.ShowDialog()

    End Sub

    Private Sub bnrptgr_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bnrptgr.ItemClick
        frmviewgr.ShowDialog()

    End Sub

    Private Sub BarStaticItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarStaticItem2.ItemClick

    End Sub
End Class
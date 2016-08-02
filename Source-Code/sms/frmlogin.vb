Imports DevExpress.LookAndFeel
Imports System.Data.SqlClient
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.XtraEditors



Public Class frmlogin
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim max, j As Integer
    Dim both, uid, pw As Integer
    Private dlg As DevExpress.Utils.WaitDialogForm = Nothing
    Dim i As Integer = 1
    Dim d As New databind
    Public user As String





    Public Sub WaitDlg(ByVal sStatus As sWaitDlgStatus, Optional ByVal Caption As String = "Loading Default Settings...", Optional ByVal Title As String = "Wait")
        Try
            Select Case sStatus
                Case sWaitDlgStatus.Show
                    If Title <> "Wait" Then
                        If Not dlg Is Nothing Then
                            dlg.Dispose()
                        End If
                        dlg = New DevExpress.Utils.WaitDialogForm(Caption, Title)
                    Else
                        If dlg Is Nothing Then
                            dlg = New DevExpress.Utils.WaitDialogForm(Caption, Title)
                        End If
                        dlg.SetCaption(Caption)
                        dlg.Show()
                    End If
                Case sWaitDlgStatus.Hide
                    If Not dlg Is Nothing Then
                        dlg.Hide()
                    End If
            End Select
            'Application.DoEvents()
        Catch ex As Exception
        End Try
    End Sub

    Enum sWaitDlgStatus
        Show = 0
        Hide = 1
    End Enum
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        
        If (txtusername.Text = "" And txtpassword.Text = "") Then
            XtraMessageBox.Show("Username And Password Are Empty", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusername.Focus()
        Else
            Try
                cmd = New SqlCommand("select count(*) from user_master where [u_name]='" + txtusername.Text + "'", d.con)
                Dim no As Integer = cmd.ExecuteScalar
                If no > 0 Then
                    da = New SqlDataAdapter("select * from user_master where [u_name]='" + txtusername.Text + "'", d.con)
                    da.Fill(ds, "user")
                    If txtpassword.Text = ds.Tables("user").Rows(0).Item("pwd") Then
                        Try
                            cmd = New SqlCommand("select usertype from user_master where [u_name]='" & txtusername.Text & "' and [pwd]='" & txtpassword.Text & "'", d.con)
                            Dim utype As String = cmd.ExecuteScalar()
                            If utype = "Admin" Then
                                
                                logged()

                            ElseIf utype = "Employee" Then
                                frmstartscreen.btneditmarks.Enabled = False
                                frmstartscreen.barexam.Enabled = False
                                frmstartscreen.btnempedit.Enabled = False
                                frmstartscreen.btnmonthsal.Enabled = False
                                frmstartscreen.btnusernew.Enabled = False
                                frmstartscreen.btnuserview.Enabled = False
                                frmstartscreen.btnlogdtl.Enabled = False
                                frmstartscreen.btnchngepw.Enabled = False
                                frmstartscreen.btnrestore.Enabled = False
                                frmstartscreen.btnclass.Enabled = False
                                frmstartscreen.btnsubject.Enabled = False
                                frmstartscreen.btnmanagepost.Enabled = False
                                frmstartscreen.btnallowance.Enabled = False
                                frmstartscreen.btntax.Enabled = False
                                frmstartscreen.btnrptadd.Enabled = False
                                frmstartscreen.bnrptgr.Enabled = False
                                frmstartscreen.btnfeesrcpt.Enabled = False
                                frmstartscreen.btnrptfest.Enabled = False
                                frmstartscreen.btnrptscholor.Enabled = False
                                frmstartscreen.btnresultstat.Enabled = False
                                frmstartscreen.btnrptresult.Enabled = False
                                frmstartscreen.btnrptemp.Enabled = False
                                frmstartscreen.btnrptsal.Enabled = False
                                frmstartscreen.btnrptusrinfo.Enabled = False
                                frmstartscreen.btnuserlog.Enabled = False
                                frmstartscreen.btnrptallw.Enabled = False
                                frmstartscreen.btnrpttax.Enabled = False



                                logged()

                            End If
                        Catch ex As Exception

                        End Try


                    Else
                            XtraMessageBox.Show("Incorrect Password", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            txtpassword.Text = ""
                            txtpassword.Focus()
                    End If

                ElseIf (no = 0) Then
                    XtraMessageBox.Show("Incorrect UserName", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtusername.Focus()
                    txtusername.SelectAll()
                End If
            Catch ex As Exception

            End Try
        End If
       
       
    End Sub
    Public Sub logged()
        Dim dte As Date = Today.Date
        Dim tme As Date = Now.TimeOfDay.ToString



        Try
            cmd = New SqlCommand("insert into log_regi values('" & txtusername.Text & "','" & dte & "','" & tme & "')", d.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try


        XtraMessageBox.Show("You Logged successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        WaitDlg(frmlogin.sWaitDlgStatus.Show)
        Timer1.Start()
        'frmstartscreen.Show()
        Me.Hide()
        'process.Show()
        ' frmstartscreen.Show()
        frmstartscreen.Enabled = True
        btnlogin.Tag = "log"
    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.conn()

         SkinManager.EnableFormSkins()
        UserLookAndFeel.Default.SetSkinStyle("Coffee")

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Coffee")
        DevExpress.LookAndFeel.UserLookAndFeel.Default.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Coffee"
        Dim _blankContextMenu As New ContextMenu()
        txtpassword.ContextMenu = _blankContextMenu
        txtusername.ContextMenu = _blankContextMenu

    End Sub


  

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        frmstartscreen.Close()


    End Sub
   
    Private Sub frmlogin_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' frmstartscreen.Close()

       
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i = i + 14

        If i > 64 Then
            WaitDlg(frmlogin.sWaitDlgStatus.Hide)
            frmstartscreen.Show()
            frmstartscreen.Enabled = True
            frmstartscreen.Opacity = 100%
            Timer1.Stop()


            Me.Close()


        End If
    End Sub

    Private Sub GroupControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl1.Paint

    End Sub
End Class
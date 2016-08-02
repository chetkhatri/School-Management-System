Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frmchangepw

    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim a As New validation
    Dim d As New databind



    

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub frmchangepw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.conn()

        cmbutype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Dim _blankContextMenu As New ContextMenu()
        txtuname.ContextMenu = _blankContextMenu
        txtnewpw.ContextMenu = _blankContextMenu
        txtcupw.ContextMenu = _blankContextMenu

    End Sub

    Private Sub txtuname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuname.KeyPress
        Dim ch As Char = e.KeyChar
        If Not (Char.IsLetter(ch) Or e.KeyChar = Chr(Keys.Delete) Or e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = True


        End If
    End Sub

    
    
   
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If a.txtstring(txtuname, lblusername) = True Then
            XtraMessageBox.Show("Please Enter UserName", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(cmbutype, lblusertype) = True Then
            XtraMessageBox.Show("Please Select Usertype", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(txtcupw, lblcupw) = True Then
            XtraMessageBox.Show("Please Enter Current Password", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf a.txtstring(txtnewpw, lblnewpw) = True Then
            XtraMessageBox.Show("Please Enter New Password", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                da = New SqlDataAdapter("select * from user_master where [u_name]='" + txtuname.Text + "'", d.con)
                da.Fill(ds, "user_master")
                If txtuname.Text = ds.Tables("user_master").Rows(0).Item("u_name") Then
                    If txtcupw.Text = ds.Tables("user_master").Rows(0).Item("pwd") Then
                        If cmbutype.Text = ds.Tables("user_master").Rows(0).Item("usertype") Then
                            lblusername.Text = ""
                            lblcupw.Text = ""
                            lblnewpw.Text = ""
                            lblusertype.Text = ""
                            cmd = New SqlCommand("update user_master set[pwd]='" + txtnewpw.Text + "' where [u_name]='" + txtuname.Text + "' and [usertype]='" + cmbutype.EditValue + "' and [pwd]='" + txtcupw.Text + "'", d.con)
                            cmd.ExecuteNonQuery()

                            XtraMessageBox.Show("Your password Change Successfully with " + txtnewpw.Text, "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            txtuname.Text = ""
                            txtcupw.Text = ""
                            txtnewpw.Text = ""
                            cmbutype.Text = ""
                            txtuname.Focus()



                        Else

                            XtraMessageBox.Show("Incorrect Password or Usertype", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            txtcupw.Text = ""
                            cmbutype.Text = ""
                            txtnewpw.Text = ""
                            lblcupw.Text = "*"
                            lblusertype.Text = "*"
                            lblcupw.ForeColor = Color.Brown
                            lblusertype.ForeColor = Color.Brown
                            cmbutype.Focus()
                        End If
                    Else

                        XtraMessageBox.Show("Incorrect Password or Usertype", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        txtcupw.Text = ""
                        cmbutype.Text = ""
                        txtnewpw.Text = ""
                        lblcupw.Text = "*"
                        lblusertype.Text = "*"
                        lblcupw.ForeColor = Color.Brown
                        lblusertype.ForeColor = Color.Brown
                        cmbutype.Focus()

                    End If
                Else

                    XtraMessageBox.Show("Username is Incorrect", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    lblcupw.Text = ""
                    lblnewpw.Text = ""
                    lblusertype.Text = ""
                    lblusername.Text = "*"
                    lblusername.ForeColor = Color.Brown
                    txtuname.Focus()
                    txtuname.SelectAll()

                End If


            Catch ex As Exception

                XtraMessageBox.Show("Username is Incorrect", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lblcupw.Text = ""
                lblnewpw.Text = ""
                lblusertype.Text = ""
                lblusername.Text = "*"
                lblusername.ForeColor = Color.Brown
                txtuname.Focus()
                txtuname.SelectAll()

            End Try

        End If
    End Sub

    Private Sub btncancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtuname.Text = ""
        cmbutype.Text = ""
        txtcupw.Text = ""
        txtnewpw.Text = ""
        txtuname.Focus()

    End Sub
End Class
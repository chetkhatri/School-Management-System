Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frmallowance


    Dim a As New validation
    Dim d As New databind
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim max As Integer
    Dim gpf, cpf, pf, it, gi As Double
    Dim lastdte As String






    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If a.txtstring(dtpdte, lbldte) = True Then
            XtraMessageBox.Show("Please Select Date", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)


        ElseIf a.txtstring(txtgpay, lblgpay) = True Or a.validrate(txtgpay, lblgpay) = True Then

            If txtgpay.Text = "" Then
                XtraMessageBox.Show("Please Enter G.Pay Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Please Enter Valid G.Pay Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf a.txtstring(txtda, lblda) = True Or a.validrate(txtda, lblda) = True Then
            If txtda.Text = "" Then
                XtraMessageBox.Show("Please Enter D.A Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Please Enter Valid D.A Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf a.txtstring(txthra, lblhra) = True Or a.validrate(txthra, lblhra) = True Then
            If txthra.Text = "" Then
                XtraMessageBox.Show("Please Enter H.R.A Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Please Enter Valid H.R.A Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf a.txtstring(txtmedall, lblmedall) = True Or a.validrate(txtmedall, lblmedall) = True Then
            If txtmedall.Text = "" Then
                XtraMessageBox.Show("Please Enter Med.All. Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Please Enter Valid Med.All. Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        ElseIf a.txtstring(txtfpi, lblfpi) = True Or a.validrate(txtfpi, lblfpi) = True Then
            If txtfpi.Text = "" Then
                XtraMessageBox.Show("Please Enter F.P.I Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Please Enter Valid F.P.I Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        ElseIf a.txtstring(txtcashall, lblcashall) = True Or a.validrate(txtcashall, lblcashall) = True Then
            If txtcashall.Text = "" Then
                XtraMessageBox.Show("Please Enter Cash.All. Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Please Enter Valid Cash.All. Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        ElseIf a.txtstring(txtwasall, lblwasall) = True Or a.validrate(txtwasall, lblwasall) = True Then
            If txtwasall.Text = "" Then
                XtraMessageBox.Show("Please Enter Wash.All. Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Please Enter Valid Wash.All. Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Else


            Try
                If max = -1 Then
                    storerate()

                Else
                    If a.dtevalid(dtpdte) = True Then

                        XtraMessageBox.Show("Date Should n't be less than today", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ElseIf a.checkdte(dtpdte, lastdte) = True Then
                        XtraMessageBox.Show("Last Rate Update on " + lastdte, "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)



                    ElseIf txtgpay.Text = ds.Tables("tballw_tax").Rows(max).Item("gpay") And txtda.Text = ds.Tables("tballw_tax").Rows(max).Item("da") And txthra.Text = ds.Tables("tballw_tax").Rows(max).Item("hra") And txtmedall.Text = ds.Tables("tballw_tax").Rows(max).Item("med_all") And txtmedall.Text = ds.Tables("tballw_tax").Rows(max).Item("med_all") And txtfpi.Text = ds.Tables("tballw_tax").Rows(max).Item("fpi") And txtcashall.Text = ds.Tables("tballw_tax").Rows(max).Item("cash_all") And txtwasall.Text = ds.Tables("tballw_tax").Rows(max).Item("was_all") Then
                        XtraMessageBox.Show("Allowance Rate Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)



                    Else

                        'Dim da As Date = Today.Date
                        'cmd = New SqlCommand("insert into tballw_tax (dte,gpay,da,hra,med_all,fpi,cash_all,was_all) values('" & da & "','" & txtgpay.Text & "','" & txtda.Text & "','" & txthra.Text & "','" & txtmedall.Text & "','" & txtfpi.Text & "','" & txtcashall.Text & "','" & txtwasall.Text & "')", d.con)

                        max += 1
                        cmd = New SqlCommand("update tballw_tax set[ex_dte]='" & Strings.Format(Me.dtpdte.DateTime, "yyyy-MM-dd") & "' where [update_id]='" & max & "'", d.con)
                        cmd.ExecuteNonQuery()
                        storerate()
                        resetrate()

                        loadrate()

                End If
                End If

            Catch ex As Exception

        End Try
        End If
    End Sub
    Private Sub storerate()
        cmd = New SqlCommand("insert into tballw_tax(dte,gpay,da,hra,med_all,fpi,cash_all,was_all,gpf,cpf,pf,it,gi)  values('" & Strings.Format(Me.dtpdte.DateTime, "yyyy-MM-dd") & "','" & txtgpay.Text & "','" & txtda.Text & "','" & txthra.Text & "','" & txtmedall.Text & "','" & txtfpi.Text & "','" & txtcashall.Text & "','" & txtwasall.Text & "','" & gpf & "','" & cpf & "','" & pf & "','" & it & "','" & gi & "')", d.con)
        cmd.ExecuteNonQuery()
        XtraMessageBox.Show("Allowance Rate Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    
    Public Sub resetrate()
        txtgpay.Text = ""
        txtda.Text = ""
        txthra.Text = ""
        txtmedall.Text = ""
        txtfpi.Text = ""
        txtcashall.Text = ""
        txtwasall.Text = ""
        lblcashall.Text = ""
        lblda.Text = ""
        lblfpi.Text = ""
        lblgpay.Text = ""
        lblhra.Text = ""
        lblmedall.Text = ""
        lblwasall.Text = ""
        lbldte.Text = ""
        dtpdte.Text = ""
        dtpdte.Focus()


    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        resetrate()

    End Sub

    Private Sub GroupControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub frmallowance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.conn()
        loadrate()

       
        Dim _blankContextMenu As New ContextMenu()
        txtgpay.ContextMenu = _blankContextMenu
        txtda.ContextMenu = _blankContextMenu
        txthra.ContextMenu = _blankContextMenu
        txtmedall.ContextMenu = _blankContextMenu
        txtfpi.ContextMenu = _blankContextMenu
        txtcashall.ContextMenu = _blankContextMenu
        txtwasall.ContextMenu = _blankContextMenu
    


    End Sub
    Public Sub loadrate()
        Try


            da = New SqlDataAdapter("select * from tballw_tax", d.con)
            ds.Clear()
            da.Fill(ds, "tballw_tax")
            cmd = New SqlCommand("select count(update_id) from tballw_tax", d.con)

            max = cmd.ExecuteScalar()
            max -= 1
            dtpdte.EditValue = ds.Tables("tballw_tax").Rows(max).Item("dte")
            lastdte = Strings.Format(Me.dtpdte.EditValue, "dd/MM/yyyy")








            txtgpay.Text = ds.Tables("tballw_tax").Rows(max).Item("gpay")
            txtda.Text = ds.Tables("tballw_tax").Rows(max).Item("da")
            txthra.Text = ds.Tables("tballw_tax").Rows(max).Item("hra")
            txtmedall.Text = ds.Tables("tballw_tax").Rows(max).Item("med_all")
            txtfpi.Text = ds.Tables("tballw_tax").Rows(max).Item("fpi")
            txtcashall.Text = ds.Tables("tballw_tax").Rows(max).Item("cash_all")
            txtwasall.Text = ds.Tables("tballw_tax").Rows(max).Item("was_all")



            gpf = ds.Tables("tballw_tax").Rows(max).Item("gpf")
            cpf = ds.Tables("tballw_tax").Rows(max).Item("cpf")
            pf = ds.Tables("tballw_tax").Rows(max).Item("pf")
            it = ds.Tables("tballw_tax").Rows(max).Item("it")
            gi = ds.Tables("tballw_tax").Rows(max).Item("gi")
        Catch ex As Exception


        End Try
    End Sub
    
    Private Sub txtgpay_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgpay.KeyPress
        Dim ch As Char = e.KeyChar
        If txtgpay.Text = "." Then
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
                e.Handled = True
            End If
        Else
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8) Or ch = ".") Then
                e.Handled = True
            End If

        End If

        
    End Sub

    Private Sub txtda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtda.KeyPress
        Dim ch As Char = e.KeyChar
        If txtda.Text = "." Then
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
                e.Handled = True
            End If
        Else
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8) Or ch = ".") Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txthra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthra.KeyPress
        Dim ch As Char = e.KeyChar
        If txthra.Text = "." Then
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
                e.Handled = True
            End If
        Else
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8) Or ch = ".") Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtmedall_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmedall.KeyPress
        Dim ch As Char = e.KeyChar
        If txtmedall.Text = "." Then
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
                e.Handled = True
            End If
        Else
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8) Or ch = ".") Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtfpi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfpi.KeyPress
        Dim ch As Char = e.KeyChar
        If txtfpi.Text = "." Then
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
                e.Handled = True
            End If
        Else
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8) Or ch = ".") Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtcashall_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcashall.KeyPress
        Dim ch As Char = e.KeyChar
        If txtcashall.Text = "." Then
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
                e.Handled = True
            End If
        Else
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8) Or ch = ".") Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtwasall_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtwasall.KeyPress
        Dim ch As Char = e.KeyChar
        If txtwasall.Text = "." Then
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
                e.Handled = True
            End If
        Else
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8) Or ch = ".") Then
                e.Handled = True
            End If

        End If
    End Sub
End Class
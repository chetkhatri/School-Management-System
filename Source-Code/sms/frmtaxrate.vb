Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Public Class frmtaxrate

    Dim a As New validation
    Dim d As New databind
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim max As Integer
    Dim gpay, daa, hra, med, fpi, cash, was As Double
    Dim lastdate As String



    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If a.txtstring(txtgpf, lblgpf) = True Or a.validrate(txtgpf, lblgpf) = True Then
            If txtgpf.Text = "" Then
                XtraMessageBox.Show("Please Enter G.P.F Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Please Enter Valid G.P.F Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        ElseIf a.txtstring(txtcpf, lblcpf) = True Or a.validrate(txtcpf, lblcpf) = True Then
            If txtcpf.Text = "" Then
                XtraMessageBox.Show("Please Enter C.P.F Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Please Enter Valid C.P.F Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        ElseIf a.txtstring(txtpf, lblpf) = True Or a.validrate(txtpf, lblpf) = True Then
            If txtpf.Text = "" Then
                XtraMessageBox.Show("Please Enter P.F Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Please Enter Valid P.F Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        ElseIf a.txtstring(txtit, lblit) = True Or a.validrate(txtit, lblit) = True Then
            If txtit.Text = "" Then
                XtraMessageBox.Show("Please Enter I.T Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Please Enter Valid I.T Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        ElseIf a.txtstring(txtgi, lblgi) = True Or a.validrate(txtgi, lblgi) = True Then
            If txtgi.Text = "" Then
                XtraMessageBox.Show("Please Enter G.I Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Please Enter Valid G.I Rate", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        Else
            If max = -1 Then
                storerate()

            Else
                If a.dtevalid(dtpdte) = True Then
                    XtraMessageBox.Show("Date Should n't be less than today", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf a.checkdte(dtpdte, lastdate) = True Then
                    XtraMessageBox.Show("Last Rate Update on " + lastdate, "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ElseIf txtgpf.Text = ds.Tables("tballw_tax").Rows(max).Item("gpf") And txtcpf.Text = ds.Tables("tballw_tax").Rows(max).Item("cpf") And txtpf.Text = ds.Tables("tballw_tax").Rows(max).Item("pf") And txtit.Text = ds.Tables("tballw_tax").Rows(max).Item("it") And txtgi.Text = ds.Tables("tballw_tax").Rows(max).Item("gi") Then
                    XtraMessageBox.Show("Tax Rate Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Try
                        max += 1
                        cmd = New SqlCommand("update tballw_tax set[ex_dte]='" & Strings.Format(Me.dtpdte.DateTime, "yyyy-MM-dd") & "' where [update_id]='" & max & "'", d.con)
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception

                    End Try



                    storerate()

                    resetall()

                    loadrate()

                End If
        End If


        End If
    End Sub
    Private Sub storerate()
        Try
            'cmd = New SqlCommand("insert into tballw_tax values(dte,gpay,da,hra,med_all,fpi,cash_all,was_all,gpf,cpf,pf,it,gi)('" & Strings.Format(Me.dtpdte.DateTime, "yyyy-MM-dd") & "','" & gpay & "','" & daa & "','" & hra & "','" & med & "','" & fpi & "','" & cash & "','" & was & "','" & txtgpf.Text & "','" & txtcpf.Text & "','" & txtpf.Text & "','" & txtit.Text & "','" & txtgi.Text & "')", d.con)
            'cmd.ExecuteNonQuery()
            cmd = New SqlCommand("insert into tballw_tax(dte,gpay,da,hra,med_all,fpi,cash_all,was_all,gpf,cpf,pf,it,gi) values('" & Strings.Format(Me.dtpdte.DateTime, "yyyy-MM-dd") & "','" & gpay & "','" & daa & "','" & hra & "','" & med & "','" & fpi & "','" & cash & "','" & was & "','" & txtgpf.Text & "','" & txtcpf.Text & "','" & txtpf.Text & "','" & txtit.Text & "','" & txtgi.Text & "')", d.con)
            cmd.ExecuteNonQuery()

            XtraMessageBox.Show("Tax Rate Updated Successfully", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmtaxrate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.conn()
        loadrate()

        Dim _blankContextMenu As New ContextMenu()
        txtgpf.ContextMenu = _blankContextMenu
        txtcpf.ContextMenu = _blankContextMenu
        txtpf.ContextMenu = _blankContextMenu
        txtit.ContextMenu = _blankContextMenu
        txtgi.ContextMenu = _blankContextMenu
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub
    Private Sub loadrate()
        Try

            da = New SqlDataAdapter("select * from tballw_tax", d.con)
            ds.Clear()
            da.Fill(ds, "tballw_tax")
            cmd = New SqlCommand("select count(update_id) from tballw_tax", d.con)
            max = cmd.ExecuteScalar()
            max -= 1

            dtpdte.EditValue = ds.Tables("tballw_tax").Rows(max).Item("dte")
            lastdate = Strings.Format(Me.dtpdte.EditValue, "dd/MM/yyyy")

            txtgpf.Text = ds.Tables("tballw_tax").Rows(max).Item("gpf")
            txtcpf.Text = ds.Tables("tballw_tax").Rows(max).Item("cpf")
            txtpf.Text = ds.Tables("tballw_tax").Rows(max).Item("pf")
            txtit.Text = ds.Tables("tballw_tax").Rows(max).Item("it")
            txtgi.Text = ds.Tables("tballw_tax").Rows(max).Item("gi")

            gpay = ds.Tables("tballw_tax").Rows(max).Item("gpay")
            daa = ds.Tables("tballw_tax").Rows(max).Item("da")
            hra = ds.Tables("tballw_tax").Rows(max).Item("hra")
            med = ds.Tables("tballw_tax").Rows(max).Item("med_all")
            fpi = ds.Tables("tballw_tax").Rows(max).Item("fpi")
            cash = ds.Tables("tballw_tax").Rows(max).Item("cash_all")
            was = ds.Tables("tballw_tax").Rows(max).Item("was_all")


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        resetall()



    End Sub
    Private Sub resetall()
        txtgpf.Text = ""
        txtcpf.Text = ""
        txtpf.Text = ""
        txtit.Text = ""
        txtgi.Text = ""
        lblcpf.Text = ""
        lblgpf.Text = ""
        lblpf.Text = ""
        lblit.Text = ""
        lblgi.Text = ""
        lbldte.Text = ""
        dtpdte.Text = ""

        dtpdte.Focus()
    End Sub

    Private Sub txtgpf_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgpf.KeyPress
        Dim ch As Char = e.KeyChar
        If txtgpf.Text = "." Then
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
                e.Handled = True
            End If
        Else
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8) Or ch = ".") Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtcpf_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcpf.KeyPress
        Dim ch As Char = e.KeyChar
        If txtcpf.Text = "." Then
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
                e.Handled = True
            End If
        Else
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8) Or ch = ".") Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtpf_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpf.KeyPress
        Dim ch As Char = e.KeyChar
        If txtpf.Text = "." Then
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
                e.Handled = True
            End If
        Else
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8) Or ch = ".") Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtit.KeyPress
        Dim ch As Char = e.KeyChar
        If txtit.Text = "." Then
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8)) Then
                e.Handled = True
            End If
        Else
            If Not (Char.IsDigit(ch) Or e.KeyChar = ChrW(8) Or ch = ".") Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtgi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgi.KeyPress
        Dim ch As Char = e.KeyChar
        If txtgi.Text = "." Then
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
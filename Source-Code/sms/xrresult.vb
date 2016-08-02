Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Public Class xrresult
    Dim a As New validation
    Dim d As New databind
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet

    Private Sub btnpprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpprev.Click
        btnpprev.Tag = "prv"
        reporting()
    End Sub

    Private Sub xrresult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d.PopulateCombo(cmbclsno, "class_id", "class_no", "class_schema", Nothing, True, Nothing, -1)
        d.conn()
    End Sub

    Private Sub cmbclsno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclsno.SelectedIndexChanged
        d.PopulateCombo(cmbstdid, "std_id", "std_id", "std_master where add_std =" & cmbclsno.Text)
        d.conn()
    End Sub

    
    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        btnpprev.Tag = "prn"
        reporting()
    End Sub
    Public Sub reporting()
        If (cmbclsno.Text = "" And cmbsem.Text = "" And cmbstdid.Text = "") Then
            XtraMessageBox.Show("Please Select Class No", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbclsno.Focus()
        ElseIf Not (cmbclsno.Text = "") Then
            If Not (cmbsem.Text = "") Then
                If Not (cmbstdid.Text = "") Then

                    da = New SqlDataAdapter("SELECT   ROW_NUMBER() OVER(ORDER BY class_id) AS row_no,  exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem, exam_master.sub_id, sub_regi.s_name, exam_master.fa1,exam_master.fa2, exam_master.sa1, exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status, std_master.gr_no, std_master.f_name,std_master.m_name, std_master.l_name, std_master.photo FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id INNER JOIN std_master ON exam_master.std_id = std_master.std_id AND exam_master.class_id = std_master.add_std  where exam_master.class_id=" & cmbclsno.Text & " and exam_master.sem=" & cmbsem.Text & " and exam_master.std_id=" & cmbstdid.Text & " ORDER BY exam_master.class_id", d.con)
                    btnprint.Tag = "all"
                Else

                    'da = New SqlDataAdapter("SELECT   ROW_NUMBER() OVER(ORDER BY class_id) AS row_no,  exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem, exam_master.sub_id, sub_regi.s_name, exam_master.fa1,exam_master.fa2, exam_master.sa1, exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status, std_master.gr_no, std_master.f_name,std_master.m_name, std_master.l_name, std_master.photo FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id INNER JOIN std_master ON exam_master.std_id = std_master.std_id AND exam_master.class_id = std_master.add_std  where exam_master.class_id=" & cmbclsno.Text & " and exam_master.sem=" & cmbsem.Text & " ORDER BY exam_master.class_id", d.con)
                    'btnprint.Tag = "semcls"
                    XtraMessageBox.Show("Please Select Student ID", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cmbstdid.Focus()

                End If
            Else

                'da = New SqlDataAdapter("SELECT   ROW_NUMBER() OVER(ORDER BY class_id) AS row_no,  exam_master.exam_id, exam_master.class_id, exam_master.std_id, exam_master.sem, exam_master.sub_id, sub_regi.s_name, exam_master.fa1,exam_master.fa2, exam_master.sa1, exam_master.siddhi, exam_master.krupa, exam_master.total, exam_master.status, std_master.gr_no, std_master.f_name,std_master.m_name, std_master.l_name, std_master.photo FROM         sub_regi INNER JOIN exam_master ON sub_regi.s_code = exam_master.sub_id INNER JOIN std_master ON exam_master.std_id = std_master.std_id AND exam_master.class_id = std_master.add_std  where exam_master.class_id=" & cmbclsno.Text & " ORDER BY exam_master.class_id", d.con)
                'btnprint.Tag = "cls"
                XtraMessageBox.Show("Please Select Semester", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbsem.Focus()
            End If
        Else



        End If
        If btnpprev.Tag = "prv" Then
            rempinfo("prv")
        ElseIf btnpprev.Tag = "prn" Then
            rempinfo("prn")
        End If
    End Sub
    Private Sub rempinfo(ByVal rpttype As String)

        Try
            ds.Clear()

            da.Fill(ds, "abc")


            Dim report2 As New rptresult
            report2.DataSource = ds.Tables("abc")
            report2.DataMember = "abc"
            report2.xrfname.DataBindings.Add("Text", ds.Tables("abc"), "abc.f_name")
            report2.xrmname.DataBindings.Add("Text", ds.Tables("abc"), "abc.m_name")
            report2.xrlname.DataBindings.Add("Text", ds.Tables("abc"), "abc.l_name")
            report2.xrstd.DataBindings.Add("Text", ds.Tables("abc"), "abc.std_id")
            report2.xrstdid.DataBindings.Add("Text", ds.Tables("abc"), "abc.class_id")

            report2.xrgrno.DataBindings.Add("Text", ds.Tables("abc"), "abc.gr_no")
            report2.xrsem.DataBindings.Add("Text", ds.Tables("abc"), "abc.sem")
            Try

                report2.xrphoto.DataBindings.Add("ImageUrl", ds.Tables("abc"), "abc.photo")

            Catch ex As Exception

            End Try
            Try
                Dim yr As Integer = Strings.Format(Now, "yyyy") + 1

                report2.xryear.Text = Strings.Format(Now, "yyyy") + "-" + yr.ToString

            Catch ex As Exception

            End Try
            report2.xrsrno.DataBindings.Add("Text", ds.Tables("abc"), "abc.row_no")
            report2.xrsubcode.DataBindings.Add("Text", ds.Tables("abc"), "abc.sub_id")

            report2.xrsub.DataBindings.Add("Text", ds.Tables("abc"), "abc.s_name")
            report2.xrfa1.DataBindings.Add("Text", ds.Tables("abc"), "abc.fa1")

            report2.xrfa2.DataBindings.Add("Text", ds.Tables("abc"), "abc.fa2")
            report2.xrsa1.DataBindings.Add("Text", ds.Tables("abc"), "abc.sa1")

            report2.xrsiddhi.DataBindings.Add("Text", ds.Tables("abc"), "abc.siddhi")
            report2.xrkrupa.DataBindings.Add("Text", ds.Tables("abc"), "abc.krupa")
            report2.xrtotal.DataBindings.Add("Text", ds.Tables("abc"), "abc.total")
            
            report2.xrstatus.DataBindings.Add("Text", ds.Tables("abc"), "abc.status")
            Try
                If btnprint.Tag = "all" Then
                    da = New SqlDataAdapter("select sum(fa1) as tfa1,sum(fa2) as tfa2,sum(sa1) as tsa1,sum(total) as ttotal from exam_master where [class_id]=" & cmbclsno.Text & " and [std_id]=" & cmbstdid.Text & " and [sem]=" & cmbsem.Text & "", d.con)
                    'ElseIf btnprint.Tag = "semcls" Then
                    '    da = New SqlDataAdapter("select sum(fa1) as tfa1,sum(fa2) as tfa2,sum(sa1) as tsa1,sum(total) as ttotal from exam_master where [class_id]=" & cmbclsno.Text & "  and [sem]=" & cmbsem.Text & "", d.con)

                    'ElseIf btnprint.Tag = "cls" Then
                    '    da = New SqlDataAdapter("select sum(fa1) as tfa1,sum(fa2) as tfa2,sum(sa1) as tsa1,sum(total) as ttotal from exam_master where [class_id]=" & cmbclsno.Text & "", d.con)

                End If
            Catch ex As Exception

            End Try
            Try
                Dim ds1 As New DataSet
                da.Fill(ds1, "total")

                report2.xrtfa1.Text = ds1.Tables("total").Rows(0).Item("tfa1")
                report2.xrtfa2.Text = ds1.Tables("total").Rows(0).Item("tfa2")
                report2.xrtsa1.Text = ds1.Tables("total").Rows(0).Item("tsa1")
                report2.xrttotal.Text = ds1.Tables("total").Rows(0).Item("ttotal")
                


            Catch ex As Exception

            End Try
            Try
                If btnprint.Tag = "all" Then
                    da = New SqlDataAdapter("select status from exam_master where [class_id]=" & cmbclsno.Text & " and [std_id]=" & cmbstdid.Text & " and [sem]=" & cmbsem.Text & "", d.con)
                ElseIf btnprint.Tag = "semcls" Then
                    da = New SqlDataAdapter("select status from exam_master where [class_id]=" & cmbclsno.Text & "  and [sem]=" & cmbsem.Text & "", d.con)

                ElseIf btnprint.Tag = "cls" Then
                    da = New SqlDataAdapter("select status from exam_master where [class_id]=" & cmbclsno.Text & "", d.con)

                End If
                Dim ds3 As New DataSet
                da.Fill(ds3, "stats")
                Dim max As Integer = ds3.Tables("stats").Rows.Count
                For i = 0 To max - 1
                    If ds3.Tables("stats").Rows(i).Item("status") = "Fail" Then
                        report2.xrtstatus.Text = "Fail"
                    Else


                    End If
                Next
                If (report2.xrtstatus.Text = "") Then
                    report2.xrtstatus.Text = "Pass"
                End If
            Catch ex As Exception

            End Try

            Try
                cmd = New SqlCommand("select u_name from log_regi where log_id=(select max(log_id) from log_regi)", d.con)
                report2.xruser.Text = cmd.ExecuteScalar

            Catch ex As Exception

            End Try


            If rpttype = "prv" Then
                report2.ShowPreview()
            ElseIf rpttype = "prn" Then
                report2.Print()

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
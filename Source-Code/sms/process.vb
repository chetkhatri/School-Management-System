Public Class process 

    Private Sub process_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Start()




    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        processbar.EditValue = processbar.EditValue + 15
        If processbar.EditValue > 98 Then
            frmstartscreen.Show()
            frmstartscreen.Enabled = True
            frmstartscreen.Opacity = 100%
            Timer1.Stop()
            Me.Close()


        End If
    End Sub

   
End Class
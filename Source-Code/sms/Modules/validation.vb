Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.CompilerServices


Public Class validation
    Public Sub GridPropery(ByRef GView As DevExpress.XtraGrid.Views.Grid.GridView)
        GView.OptionsCustomization.AllowColumnMoving = False
        GView.OptionsCustomization.AllowFilter = False
        GView.OptionsCustomization.AllowGroup = False
        GView.OptionsCustomization.AllowSort = True
        GView.OptionsSelection.EnableAppearanceFocusedCell = False
        GView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        GView.OptionsView.ShowGroupPanel = False
        GView.OptionsView.ShowIndicator = False
        GView.OptionsBehavior.Editable = False
        GView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    End Sub
    Public Function txtstring(ByRef txts As DevExpress.XtraEditors.TextEdit, ByRef lbl As System.Windows.Forms.Label) As Boolean
        If txts.Text = "" Then
            lbl.Text = "*"
            lbl.ForeColor = Color.Brown
            txts.Focus()

            txtstring = True
        Else
            lbl.Text = ""
            txtstring = False
        End If
    End Function
    Public Function attend(ByRef txts As DevExpress.XtraEditors.TextEdit, ByRef lbl As System.Windows.Forms.Label) As Boolean
        If Val(txts.Text) > 30 Then
            lbl.Text = "*"
            lbl.ForeColor = Color.Brown
            txts.Focus()
            txts.SelectAll()

            attend = True

        Else
            attend = False
        End If

    End Function

    Public Function txtstring(ByRef txts As DevExpress.XtraEditors.MemoEdit, ByRef lbl As System.Windows.Forms.Label) As Boolean
        If txts.Text = "" Then
            lbl.Text = "*"
            lbl.ForeColor = Color.Brown
            txts.Focus()

            txtstring = True
        Else
            lbl.Text = ""
            txtstring = False
        End If
    End Function
    Public Function txtstring(ByRef txts As DevExpress.XtraEditors.ComboBoxEdit, ByRef lbl As System.Windows.Forms.Label) As Boolean
        If txts.Text = "" Then
            lbl.Text = "*"
            lbl.ForeColor = Color.Brown
            txts.Focus()

            txtstring = True
        Else
            lbl.Text = ""
            txtstring = False
        End If
    End Function
    Public Function rdvalid(ByRef rd1 As System.Windows.Forms.RadioButton, ByVal rd2 As System.Windows.Forms.RadioButton, ByRef lbl As System.Windows.Forms.Label) As Boolean
        If rd1.Checked = False And rd2.Checked = False Then
            lbl.Text = "*"
            lbl.ForeColor = Color.Brown
            rdvalid = True
        Else
            lbl.Text = ""
            rdvalid = False
        End If
    End Function
    Public Function rdvalid(ByRef rd1 As System.Windows.Forms.RadioButton, ByVal rd2 As System.Windows.Forms.RadioButton, ByVal rd3 As System.Windows.Forms.RadioButton, ByRef lbl As System.Windows.Forms.Label) As Boolean
        If rd1.Checked = False And rd2.Checked = False And rd3.Checked = False Then
            lbl.Text = "*"
            lbl.ForeColor = Color.Brown
            rdvalid = True
        Else
            lbl.Text = ""
            rdvalid = False
        End If
    End Function
    Public Function mobvalid(ByRef txts As DevExpress.XtraEditors.TextEdit, ByRef lbl As System.Windows.Forms.Label) As Boolean
        If Not (txts.Text.ToString.Length() = 13 Or txts.Text.ToString.Length() = 10 Or txts.Text.ToString.Length() = 11) Then
            lbl.Text = "*"
            lbl.ForeColor = Color.Brown
            txts.Focus()
            mobvalid = True
        Else
            mobvalid = False

        End If
    End Function
    Public Function phvalid(ByRef txts As DevExpress.XtraEditors.TextEdit, ByRef lbl As System.Windows.Forms.Label) As Boolean
        If Not (txts.Text.ToString.Length() = 13 Or txts.Text.ToString.Length() = 11) Then
            lbl.Text = "*"
            lbl.ForeColor = Color.Brown
            txts.Focus()
            phvalid = True
        Else
            phvalid = False

        End If
    End Function
    Function EmailAddressCheck(ByRef email As DevExpress.XtraEditors.TextEdit, ByRef lbl As System.Windows.Forms.Label) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(email.Text, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True
            lbl.Text = ""
        Else
            EmailAddressCheck = False
            email.Focus()
            lbl.Text = "*"


        End If
    End Function
    Public Function dtevalid(ByRef dte As DevExpress.XtraEditors.DateEdit) As Boolean
        If Operators.ConditionalCompareObjectGreater(Today.Date, dte.EditValue, True) Then

            dtevalid = True
        Else
            dtevalid = False


        End If

    End Function
    Public Function validrate(ByRef txts As DevExpress.XtraEditors.TextEdit, ByRef lbl As System.Windows.Forms.Label) As Boolean
        If txts.Text = "." Then
            lbl.Text = "*"
            lbl.ForeColor = Color.Brown
            txts.Focus()
            txts.SelectAll()

            validrate = True
        ElseIf Not (txts.Text = "") Then
            If Convert.ToDouble(txts.Text) > 100 Then
                lbl.Text = "*"
                lbl.ForeColor = Color.Brown
                txts.Focus()
                txts.SelectAll()

                validrate = True

            Else

                validrate = False

            End If
        End If


       
    End Function
    Public Function checkdte(ByRef dte As DevExpress.XtraEditors.DateEdit, ByRef olddte As String) As Boolean
        If Operators.ConditionalCompareObjectGreater(olddte, dte.Text, True) Then

            checkdte = True
        Else
            checkdte = False


        End If

    End Function
End Class

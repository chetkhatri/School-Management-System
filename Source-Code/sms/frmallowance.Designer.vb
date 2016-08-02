<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmallowance
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmallowance))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnreset = New DevExpress.XtraEditors.SimpleButton
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnupdate = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.lbldte = New System.Windows.Forms.Label
        Me.dtpdte = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lblwasall = New System.Windows.Forms.Label
        Me.lblcashall = New System.Windows.Forms.Label
        Me.lblfpi = New System.Windows.Forms.Label
        Me.lblmedall = New System.Windows.Forms.Label
        Me.lblhra = New System.Windows.Forms.Label
        Me.lblda = New System.Windows.Forms.Label
        Me.lblgpay = New System.Windows.Forms.Label
        Me.txtwasall = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.txtcashall = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txtfpi = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txtmedall = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txthra = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtda = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtgpay = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.dtpdte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpdte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtwasall.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcashall.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfpi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmedall.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txthra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgpay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnreset)
        Me.GroupControl1.Controls.Add(Me.btncancel)
        Me.GroupControl1.Controls.Add(Me.btnupdate)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(317, 395)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'btnreset
        '
        Me.btnreset.Image = Global.sms.My.Resources.Resources.reset1
        Me.btnreset.Location = New System.Drawing.Point(121, 345)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(73, 31)
        Me.btnreset.TabIndex = 18
        Me.btnreset.Text = "Reset"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete
        Me.btncancel.Location = New System.Drawing.Point(210, 345)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(73, 31)
        Me.btncancel.TabIndex = 17
        Me.btncancel.Text = "Cancel"
        '
        'btnupdate
        '
        Me.btnupdate.Image = Global.sms.My.Resources.Resources.system_software_update
        Me.btnupdate.Location = New System.Drawing.Point(32, 345)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(73, 31)
        Me.btnupdate.TabIndex = 16
        Me.btnupdate.Text = "Update"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.lbldte)
        Me.GroupControl3.Controls.Add(Me.dtpdte)
        Me.GroupControl3.Controls.Add(Me.LabelControl1)
        Me.GroupControl3.Controls.Add(Me.lblwasall)
        Me.GroupControl3.Controls.Add(Me.lblcashall)
        Me.GroupControl3.Controls.Add(Me.lblfpi)
        Me.GroupControl3.Controls.Add(Me.lblmedall)
        Me.GroupControl3.Controls.Add(Me.lblhra)
        Me.GroupControl3.Controls.Add(Me.lblda)
        Me.GroupControl3.Controls.Add(Me.lblgpay)
        Me.GroupControl3.Controls.Add(Me.txtwasall)
        Me.GroupControl3.Controls.Add(Me.LabelControl13)
        Me.GroupControl3.Controls.Add(Me.txtcashall)
        Me.GroupControl3.Controls.Add(Me.LabelControl12)
        Me.GroupControl3.Controls.Add(Me.txtfpi)
        Me.GroupControl3.Controls.Add(Me.LabelControl11)
        Me.GroupControl3.Controls.Add(Me.txtmedall)
        Me.GroupControl3.Controls.Add(Me.LabelControl10)
        Me.GroupControl3.Controls.Add(Me.txthra)
        Me.GroupControl3.Controls.Add(Me.LabelControl9)
        Me.GroupControl3.Controls.Add(Me.txtda)
        Me.GroupControl3.Controls.Add(Me.LabelControl8)
        Me.GroupControl3.Controls.Add(Me.txtgpay)
        Me.GroupControl3.Controls.Add(Me.LabelControl7)
        Me.GroupControl3.Location = New System.Drawing.Point(1, 1)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(314, 324)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Updation of Employee Allowances"
        '
        'lbldte
        '
        Me.lbldte.AutoSize = True
        Me.lbldte.Location = New System.Drawing.Point(260, 36)
        Me.lbldte.Name = "lbldte"
        Me.lbldte.Size = New System.Drawing.Size(0, 13)
        Me.lbldte.TabIndex = 23
        '
        'dtpdte
        '
        Me.dtpdte.EditValue = Nothing
        Me.dtpdte.Location = New System.Drawing.Point(121, 33)
        Me.dtpdte.Name = "dtpdte"
        Me.dtpdte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpdte.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtpdte.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpdte.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dtpdte.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpdte.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtpdte.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpdte.Size = New System.Drawing.Size(132, 20)
        Me.dtpdte.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl1.TabIndex = 21
        Me.LabelControl1.Text = "Date"
        '
        'lblwasall
        '
        Me.lblwasall.AutoSize = True
        Me.lblwasall.Location = New System.Drawing.Point(260, 289)
        Me.lblwasall.Name = "lblwasall"
        Me.lblwasall.Size = New System.Drawing.Size(0, 13)
        Me.lblwasall.TabIndex = 20
        '
        'lblcashall
        '
        Me.lblcashall.AutoSize = True
        Me.lblcashall.Location = New System.Drawing.Point(260, 253)
        Me.lblcashall.Name = "lblcashall"
        Me.lblcashall.Size = New System.Drawing.Size(0, 13)
        Me.lblcashall.TabIndex = 19
        '
        'lblfpi
        '
        Me.lblfpi.AutoSize = True
        Me.lblfpi.Location = New System.Drawing.Point(260, 218)
        Me.lblfpi.Name = "lblfpi"
        Me.lblfpi.Size = New System.Drawing.Size(0, 13)
        Me.lblfpi.TabIndex = 18
        '
        'lblmedall
        '
        Me.lblmedall.AutoSize = True
        Me.lblmedall.Location = New System.Drawing.Point(260, 182)
        Me.lblmedall.Name = "lblmedall"
        Me.lblmedall.Size = New System.Drawing.Size(0, 13)
        Me.lblmedall.TabIndex = 17
        '
        'lblhra
        '
        Me.lblhra.AutoSize = True
        Me.lblhra.Location = New System.Drawing.Point(260, 146)
        Me.lblhra.Name = "lblhra"
        Me.lblhra.Size = New System.Drawing.Size(0, 13)
        Me.lblhra.TabIndex = 16
        '
        'lblda
        '
        Me.lblda.AutoSize = True
        Me.lblda.Location = New System.Drawing.Point(260, 111)
        Me.lblda.Name = "lblda"
        Me.lblda.Size = New System.Drawing.Size(0, 13)
        Me.lblda.TabIndex = 15
        '
        'lblgpay
        '
        Me.lblgpay.AutoSize = True
        Me.lblgpay.Location = New System.Drawing.Point(260, 73)
        Me.lblgpay.Name = "lblgpay"
        Me.lblgpay.Size = New System.Drawing.Size(0, 13)
        Me.lblgpay.TabIndex = 14
        '
        'txtwasall
        '
        Me.txtwasall.Location = New System.Drawing.Point(121, 286)
        Me.txtwasall.Name = "txtwasall"
        Me.txtwasall.Properties.MaxLength = 4
        Me.txtwasall.Size = New System.Drawing.Size(132, 20)
        Me.txtwasall.TabIndex = 13
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(14, 289)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl13.TabIndex = 12
        Me.LabelControl13.Text = "Was. Allowance"
        '
        'txtcashall
        '
        Me.txtcashall.Location = New System.Drawing.Point(121, 250)
        Me.txtcashall.Name = "txtcashall"
        Me.txtcashall.Properties.MaxLength = 4
        Me.txtcashall.Size = New System.Drawing.Size(132, 20)
        Me.txtcashall.TabIndex = 11
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(13, 257)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl12.TabIndex = 10
        Me.LabelControl12.Text = "Cash.Allowance"
        '
        'txtfpi
        '
        Me.txtfpi.Location = New System.Drawing.Point(121, 215)
        Me.txtfpi.Name = "txtfpi"
        Me.txtfpi.Properties.MaxLength = 4
        Me.txtfpi.Size = New System.Drawing.Size(132, 20)
        Me.txtfpi.TabIndex = 9
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(13, 217)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl11.TabIndex = 8
        Me.LabelControl11.Text = "F.P.I"
        '
        'txtmedall
        '
        Me.txtmedall.Location = New System.Drawing.Point(121, 179)
        Me.txtmedall.Name = "txtmedall"
        Me.txtmedall.Properties.MaxLength = 4
        Me.txtmedall.Size = New System.Drawing.Size(132, 20)
        Me.txtmedall.TabIndex = 7
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(13, 181)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl10.TabIndex = 6
        Me.LabelControl10.Text = "Med.Allowance"
        '
        'txthra
        '
        Me.txthra.Location = New System.Drawing.Point(121, 142)
        Me.txthra.Name = "txthra"
        Me.txthra.Properties.MaxLength = 4
        Me.txthra.Size = New System.Drawing.Size(132, 20)
        Me.txthra.TabIndex = 5
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(13, 146)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl9.TabIndex = 4
        Me.LabelControl9.Text = "H.R.A"
        '
        'txtda
        '
        Me.txtda.Location = New System.Drawing.Point(121, 106)
        Me.txtda.Name = "txtda"
        Me.txtda.Properties.MaxLength = 4
        Me.txtda.Size = New System.Drawing.Size(132, 20)
        Me.txtda.TabIndex = 3
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(14, 111)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl8.TabIndex = 2
        Me.LabelControl8.Text = "D.A"
        '
        'txtgpay
        '
        Me.txtgpay.Location = New System.Drawing.Point(121, 70)
        Me.txtgpay.Name = "txtgpay"
        Me.txtgpay.Properties.MaxLength = 4
        Me.txtgpay.Size = New System.Drawing.Size(132, 20)
        Me.txtgpay.TabIndex = 2
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(14, 74)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl7.TabIndex = 0
        Me.LabelControl7.Text = "G.Pay"
        '
        'frmallowance
        '
        Me.AcceptButton = Me.btnupdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 394)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmallowance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allowance Updation"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.dtpdte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpdte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtwasall.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcashall.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfpi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmedall.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txthra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgpay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtwasall As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcashall As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtfpi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtmedall As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txthra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtgpay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnupdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblwasall As System.Windows.Forms.Label
    Friend WithEvents lblcashall As System.Windows.Forms.Label
    Friend WithEvents lblfpi As System.Windows.Forms.Label
    Friend WithEvents lblmedall As System.Windows.Forms.Label
    Friend WithEvents lblhra As System.Windows.Forms.Label
    Friend WithEvents lblda As System.Windows.Forms.Label
    Friend WithEvents lblgpay As System.Windows.Forms.Label
    Friend WithEvents btnreset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbldte As System.Windows.Forms.Label
    Friend WithEvents dtpdte As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class

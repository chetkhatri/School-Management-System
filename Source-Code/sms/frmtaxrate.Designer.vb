<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtaxrate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtaxrate))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnreset = New DevExpress.XtraEditors.SimpleButton
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnupdate = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.lbldte = New System.Windows.Forms.Label
        Me.dtpdte = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.lblgi = New System.Windows.Forms.Label
        Me.lblit = New System.Windows.Forms.Label
        Me.lblpf = New System.Windows.Forms.Label
        Me.lblcpf = New System.Windows.Forms.Label
        Me.lblgpf = New System.Windows.Forms.Label
        Me.txtgi = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtit = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtpf = New DevExpress.XtraEditors.TextEdit
        Me.txtcpf = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.txtgpf = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.dtpdte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpdte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcpf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgpf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnreset)
        Me.GroupControl1.Controls.Add(Me.btncancel)
        Me.GroupControl1.Controls.Add(Me.btnupdate)
        Me.GroupControl1.Controls.Add(Me.GroupControl4)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(265, 314)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'btnreset
        '
        Me.btnreset.Image = Global.sms.My.Resources.Resources.reset1
        Me.btnreset.Location = New System.Drawing.Point(96, 266)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(73, 31)
        Me.btnreset.TabIndex = 3
        Me.btnreset.Text = "Reset"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete
        Me.btncancel.Location = New System.Drawing.Point(185, 266)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(73, 31)
        Me.btncancel.TabIndex = 4
        Me.btncancel.Text = "Cancel"
        '
        'btnupdate
        '
        Me.btnupdate.Image = Global.sms.My.Resources.Resources.system_software_update
        Me.btnupdate.Location = New System.Drawing.Point(7, 266)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(73, 31)
        Me.btnupdate.TabIndex = 2
        Me.btnupdate.Text = "Update"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.lbldte)
        Me.GroupControl4.Controls.Add(Me.dtpdte)
        Me.GroupControl4.Controls.Add(Me.LabelControl3)
        Me.GroupControl4.Controls.Add(Me.lblgi)
        Me.GroupControl4.Controls.Add(Me.lblit)
        Me.GroupControl4.Controls.Add(Me.lblpf)
        Me.GroupControl4.Controls.Add(Me.lblcpf)
        Me.GroupControl4.Controls.Add(Me.lblgpf)
        Me.GroupControl4.Controls.Add(Me.txtgi)
        Me.GroupControl4.Controls.Add(Me.LabelControl2)
        Me.GroupControl4.Controls.Add(Me.txtit)
        Me.GroupControl4.Controls.Add(Me.LabelControl1)
        Me.GroupControl4.Controls.Add(Me.txtpf)
        Me.GroupControl4.Controls.Add(Me.txtcpf)
        Me.GroupControl4.Controls.Add(Me.LabelControl16)
        Me.GroupControl4.Controls.Add(Me.LabelControl15)
        Me.GroupControl4.Controls.Add(Me.txtgpf)
        Me.GroupControl4.Controls.Add(Me.LabelControl14)
        Me.GroupControl4.Location = New System.Drawing.Point(2, 1)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(263, 250)
        Me.GroupControl4.TabIndex = 1
        Me.GroupControl4.Text = "Updation of Employee Tax Deductions"
        '
        'lbldte
        '
        Me.lbldte.AutoSize = True
        Me.lbldte.Location = New System.Drawing.Point(204, 37)
        Me.lbldte.Name = "lbldte"
        Me.lbldte.Size = New System.Drawing.Size(0, 13)
        Me.lbldte.TabIndex = 30
        '
        'dtpdte
        '
        Me.dtpdte.EditValue = Nothing
        Me.dtpdte.Location = New System.Drawing.Point(65, 34)
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
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(22, 37)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl3.TabIndex = 29
        Me.LabelControl3.Text = "Date"
        '
        'lblgi
        '
        Me.lblgi.AutoSize = True
        Me.lblgi.Location = New System.Drawing.Point(204, 216)
        Me.lblgi.Name = "lblgi"
        Me.lblgi.Size = New System.Drawing.Size(0, 13)
        Me.lblgi.TabIndex = 27
        '
        'lblit
        '
        Me.lblit.AutoSize = True
        Me.lblit.Location = New System.Drawing.Point(204, 180)
        Me.lblit.Name = "lblit"
        Me.lblit.Size = New System.Drawing.Size(0, 13)
        Me.lblit.TabIndex = 26
        '
        'lblpf
        '
        Me.lblpf.AutoSize = True
        Me.lblpf.Location = New System.Drawing.Point(204, 145)
        Me.lblpf.Name = "lblpf"
        Me.lblpf.Size = New System.Drawing.Size(0, 13)
        Me.lblpf.TabIndex = 25
        '
        'lblcpf
        '
        Me.lblcpf.AutoSize = True
        Me.lblcpf.Location = New System.Drawing.Point(204, 109)
        Me.lblcpf.Name = "lblcpf"
        Me.lblcpf.Size = New System.Drawing.Size(0, 13)
        Me.lblcpf.TabIndex = 24
        '
        'lblgpf
        '
        Me.lblgpf.AutoSize = True
        Me.lblgpf.Location = New System.Drawing.Point(204, 73)
        Me.lblgpf.Name = "lblgpf"
        Me.lblgpf.Size = New System.Drawing.Size(0, 13)
        Me.lblgpf.TabIndex = 23
        '
        'txtgi
        '
        Me.txtgi.Location = New System.Drawing.Point(65, 213)
        Me.txtgi.Name = "txtgi"
        Me.txtgi.Properties.MaxLength = 4
        Me.txtgi.Size = New System.Drawing.Size(132, 20)
        Me.txtgi.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(22, 216)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "G.I"
        '
        'txtit
        '
        Me.txtit.Location = New System.Drawing.Point(65, 177)
        Me.txtit.Name = "txtit"
        Me.txtit.Properties.MaxLength = 4
        Me.txtit.Size = New System.Drawing.Size(132, 20)
        Me.txtit.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(23, 180)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(14, 13)
        Me.LabelControl1.TabIndex = 19
        Me.LabelControl1.Text = "I.T"
        '
        'txtpf
        '
        Me.txtpf.Location = New System.Drawing.Point(65, 142)
        Me.txtpf.Name = "txtpf"
        Me.txtpf.Properties.MaxLength = 4
        Me.txtpf.Size = New System.Drawing.Size(132, 20)
        Me.txtpf.TabIndex = 4
        '
        'txtcpf
        '
        Me.txtcpf.Location = New System.Drawing.Point(65, 106)
        Me.txtcpf.Name = "txtcpf"
        Me.txtcpf.Properties.MaxLength = 4
        Me.txtcpf.Size = New System.Drawing.Size(132, 20)
        Me.txtcpf.TabIndex = 3
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(23, 109)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl16.TabIndex = 16
        Me.LabelControl16.Text = "C.P.F"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(23, 145)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl15.TabIndex = 15
        Me.LabelControl15.Text = "P.F"
        '
        'txtgpf
        '
        Me.txtgpf.Location = New System.Drawing.Point(65, 70)
        Me.txtgpf.Name = "txtgpf"
        Me.txtgpf.Properties.MaxLength = 4
        Me.txtgpf.Size = New System.Drawing.Size(132, 20)
        Me.txtgpf.TabIndex = 2
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(23, 75)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl14.TabIndex = 0
        Me.LabelControl14.Text = "G.P.F"
        '
        'frmtaxrate
        '
        Me.AcceptButton = Me.btnupdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 315)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmtaxrate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Tax Updation"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.dtpdte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpdte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcpf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgpf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtpf As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcpf As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtgpf As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtgi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnreset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnupdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblgi As System.Windows.Forms.Label
    Friend WithEvents lblit As System.Windows.Forms.Label
    Friend WithEvents lblpf As System.Windows.Forms.Label
    Friend WithEvents lblcpf As System.Windows.Forms.Label
    Friend WithEvents lblgpf As System.Windows.Forms.Label
    Friend WithEvents lbldte As System.Windows.Forms.Label
    Friend WithEvents dtpdte As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class

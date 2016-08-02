<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnewac
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmnewac))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lblempid = New System.Windows.Forms.Label
        Me.txtempid = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.cmbutype = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblrepw = New System.Windows.Forms.Label
        Me.lblpw = New System.Windows.Forms.Label
        Me.lbluname = New System.Windows.Forms.Label
        Me.lblutype = New System.Windows.Forms.Label
        Me.txtrepw = New DevExpress.XtraEditors.TextEdit
        Me.txtpw = New DevExpress.XtraEditors.TextEdit
        Me.txtuname = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.btnreset = New DevExpress.XtraEditors.SimpleButton
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtempid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbutype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrepw.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpw.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtuname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lblempid)
        Me.GroupControl1.Controls.Add(Me.txtempid)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.cmbutype)
        Me.GroupControl1.Controls.Add(Me.lblrepw)
        Me.GroupControl1.Controls.Add(Me.lblpw)
        Me.GroupControl1.Controls.Add(Me.lbluname)
        Me.GroupControl1.Controls.Add(Me.lblutype)
        Me.GroupControl1.Controls.Add(Me.txtrepw)
        Me.GroupControl1.Controls.Add(Me.txtpw)
        Me.GroupControl1.Controls.Add(Me.txtuname)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(344, 222)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Create New User"
        '
        'lblempid
        '
        Me.lblempid.AutoSize = True
        Me.lblempid.Location = New System.Drawing.Point(301, 39)
        Me.lblempid.Name = "lblempid"
        Me.lblempid.Size = New System.Drawing.Size(0, 13)
        Me.lblempid.TabIndex = 20
        '
        'txtempid
        '
        Me.txtempid.Location = New System.Drawing.Point(143, 35)
        Me.txtempid.Name = "txtempid"
        Me.txtempid.Properties.MaxLength = 4
        Me.txtempid.Size = New System.Drawing.Size(150, 20)
        Me.txtempid.TabIndex = 1
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(26, 40)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl7.TabIndex = 18
        Me.LabelControl7.Text = "Employee ID"
        '
        'cmbutype
        '
        Me.cmbutype.Location = New System.Drawing.Point(143, 71)
        Me.cmbutype.Name = "cmbutype"
        Me.cmbutype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbutype.Properties.Items.AddRange(New Object() {"Admin", "Employee"})
        Me.cmbutype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbutype.Size = New System.Drawing.Size(151, 20)
        Me.cmbutype.TabIndex = 2
        '
        'lblrepw
        '
        Me.lblrepw.AutoSize = True
        Me.lblrepw.Location = New System.Drawing.Point(301, 186)
        Me.lblrepw.Name = "lblrepw"
        Me.lblrepw.Size = New System.Drawing.Size(0, 13)
        Me.lblrepw.TabIndex = 17
        '
        'lblpw
        '
        Me.lblpw.AutoSize = True
        Me.lblpw.Location = New System.Drawing.Point(301, 149)
        Me.lblpw.Name = "lblpw"
        Me.lblpw.Size = New System.Drawing.Size(0, 13)
        Me.lblpw.TabIndex = 16
        '
        'lbluname
        '
        Me.lbluname.AutoSize = True
        Me.lbluname.Location = New System.Drawing.Point(302, 113)
        Me.lbluname.Name = "lbluname"
        Me.lbluname.Size = New System.Drawing.Size(0, 13)
        Me.lbluname.TabIndex = 15
        '
        'lblutype
        '
        Me.lblutype.AutoSize = True
        Me.lblutype.Location = New System.Drawing.Point(302, 77)
        Me.lblutype.Name = "lblutype"
        Me.lblutype.Size = New System.Drawing.Size(0, 13)
        Me.lblutype.TabIndex = 14
        '
        'txtrepw
        '
        Me.txtrepw.Location = New System.Drawing.Point(143, 181)
        Me.txtrepw.Name = "txtrepw"
        Me.txtrepw.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtrepw.Size = New System.Drawing.Size(150, 20)
        Me.txtrepw.TabIndex = 5
        '
        'txtpw
        '
        Me.txtpw.Location = New System.Drawing.Point(143, 144)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.Properties.MaxLength = 16
        Me.txtpw.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpw.Size = New System.Drawing.Size(150, 20)
        Me.txtpw.TabIndex = 4
        '
        'txtuname
        '
        Me.txtuname.Location = New System.Drawing.Point(143, 108)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Properties.MaxLength = 16
        Me.txtuname.Size = New System.Drawing.Size(150, 20)
        Me.txtuname.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(27, 185)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Re - Enter Password"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(27, 150)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Enter Password"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(27, 111)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "User Name"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(27, 75)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "User Type"
        '
        'btnreset
        '
        Me.btnreset.Image = Global.sms.My.Resources.Resources.reset1
        Me.btnreset.Location = New System.Drawing.Point(136, 236)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(73, 31)
        Me.btnreset.TabIndex = 7
        Me.btnreset.Text = "Reset"
        '
        'btncancel
        '
        Me.btncancel.Image = Global.sms.My.Resources.Resources.Delete1
        Me.btncancel.Location = New System.Drawing.Point(232, 236)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(73, 31)
        Me.btncancel.TabIndex = 8
        Me.btncancel.Text = "Cancel"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.sms.My.Resources.Resources.Icon_Disk01_Blue1
        Me.btnsave.Location = New System.Drawing.Point(38, 236)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(73, 31)
        Me.btnsave.TabIndex = 6
        Me.btnsave.Text = "Save"
        '
        'frmnewac
        '
        Me.AcceptButton = Me.btnsave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 282)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmnewac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New User Registration"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtempid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbutype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrepw.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpw.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtuname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtrepw As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtpw As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtuname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblrepw As System.Windows.Forms.Label
    Friend WithEvents lblpw As System.Windows.Forms.Label
    Friend WithEvents lbluname As System.Windows.Forms.Label
    Friend WithEvents lblutype As System.Windows.Forms.Label
    Friend WithEvents cmbutype As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnreset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblempid As System.Windows.Forms.Label
    Friend WithEvents txtempid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class

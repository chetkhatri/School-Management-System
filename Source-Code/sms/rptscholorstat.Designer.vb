<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptscholorstat
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptscholorstat))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xruser = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrtotal = New DevExpress.XtraReports.UI.XRLabel
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.xrclassid = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrstdid = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrdte = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrschotype = New DevExpress.XtraReports.UI.XRTableCell
        Me.xramt = New DevExpress.XtraReports.UI.XRTableCell
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.Height = 25
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeader.Height = 25
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrLabel2, Me.xruser, Me.XrPageInfo2})
        Me.PageFooter.Height = 41
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLabel5, Me.XrLabel9, Me.XrPictureBox1})
        Me.ReportHeader.Height = 161
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.ImageUrl = "D:\SMS\sms\sms\Resources\sms.png"
        Me.XrPictureBox1.Location = New System.Drawing.Point(0, 8)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.Size = New System.Drawing.Size(167, 135)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.ForeColor = System.Drawing.Color.Maroon
        Me.XrLabel9.Location = New System.Drawing.Point(192, 17)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(400, 33)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "School Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.ForeColor = System.Drawing.Color.Maroon
        Me.XrLabel5.Location = New System.Drawing.Point(192, 83)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(400, 33)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Student Scholorship Statement"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLine1
        '
        Me.XrLine1.Location = New System.Drawing.Point(0, 150)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(708, 2)
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.XrPageInfo2.Format = "Page {0} of {1}"
        Me.XrPageInfo2.Location = New System.Drawing.Point(608, 8)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.Size = New System.Drawing.Size(100, 25)
        Me.XrPageInfo2.StylePriority.UseFont = False
        '
        'xruser
        '
        Me.xruser.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.xruser.Location = New System.Drawing.Point(383, 8)
        Me.xruser.Name = "xruser"
        Me.xruser.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xruser.Size = New System.Drawing.Size(100, 25)
        Me.xruser.StylePriority.UseFont = False
        Me.xruser.StylePriority.UseTextAlignment = False
        Me.xruser.Text = "xruser"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.XrLabel2.Location = New System.Drawing.Point(200, 8)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(175, 25)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Report Generated By :-"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.XrPageInfo1.Location = New System.Drawing.Point(8, 8)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.Size = New System.Drawing.Size(100, 25)
        Me.XrPageInfo1.StylePriority.UseFont = False
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrtotal, Me.XrLabel4})
        Me.GroupFooter1.Height = 25
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.Location = New System.Drawing.Point(442, 0)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(125, 25)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Total Amount :-"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrtotal
        '
        Me.xrtotal.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.xrtotal.Location = New System.Drawing.Point(567, 0)
        Me.xrtotal.Name = "xrtotal"
        Me.xrtotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrtotal.Size = New System.Drawing.Size(100, 25)
        Me.xrtotal.StylePriority.UseFont = False
        Me.xrtotal.StylePriority.UseTextAlignment = False
        Me.xrtotal.Text = "xrtotal"
        Me.xrtotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable1.Location = New System.Drawing.Point(50, 0)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(617, 25)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(617, 25)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Size = New System.Drawing.Size(81, 25)
        Me.XrTableCell1.Text = "Class ID"
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(81, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Size = New System.Drawing.Size(103, 25)
        Me.XrTableCell2.Text = "Student ID"
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(184, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Size = New System.Drawing.Size(150, 25)
        Me.XrTableCell4.Text = "Date"
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Location = New System.Drawing.Point(334, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Size = New System.Drawing.Size(185, 25)
        Me.XrTableCell5.Text = "Scholorship Type"
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Location = New System.Drawing.Point(519, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Size = New System.Drawing.Size(98, 25)
        Me.XrTableCell3.Text = "Amount"
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.XrTable2.Location = New System.Drawing.Point(50, 0)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.Size = New System.Drawing.Size(617, 25)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrclassid, Me.xrstdid, Me.xrdte, Me.xrschotype, Me.xramt})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(617, 25)
        '
        'xrclassid
        '
        Me.xrclassid.Location = New System.Drawing.Point(0, 0)
        Me.xrclassid.Name = "xrclassid"
        Me.xrclassid.Size = New System.Drawing.Size(81, 25)
        Me.xrclassid.Text = "xrclassid"
        '
        'xrstdid
        '
        Me.xrstdid.Location = New System.Drawing.Point(81, 0)
        Me.xrstdid.Name = "xrstdid"
        Me.xrstdid.Size = New System.Drawing.Size(103, 25)
        Me.xrstdid.Text = "xrstdid"
        '
        'xrdte
        '
        Me.xrdte.Location = New System.Drawing.Point(184, 0)
        Me.xrdte.Name = "xrdte"
        Me.xrdte.Size = New System.Drawing.Size(150, 25)
        Me.xrdte.Text = "xrdte"
        '
        'xrschotype
        '
        Me.xrschotype.Location = New System.Drawing.Point(334, 0)
        Me.xrschotype.Name = "xrschotype"
        Me.xrschotype.Size = New System.Drawing.Size(185, 25)
        Me.xrschotype.Text = "xrschotype"
        '
        'xramt
        '
        Me.xramt.Location = New System.Drawing.Point(519, 0)
        Me.xramt.Name = "xramt"
        Me.xramt.Size = New System.Drawing.Size(98, 25)
        Me.xramt.Text = "xramt"
        '
        'rptscholorstat
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportHeader, Me.GroupFooter1})
        Me.Margins = New System.Drawing.Printing.Margins(100, 40, 100, 100)
        Me.Version = "8.3"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xruser As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents xrtotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrclassid As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrstdid As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrdte As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrschotype As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xramt As DevExpress.XtraReports.UI.XRTableCell
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReadPDF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.frmReadData = New System.Windows.Forms.Button()
        Me.OFDPdfRead = New System.Windows.Forms.OpenFileDialog()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butnTestCode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'frmReadData
        '
        Me.frmReadData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmReadData.Location = New System.Drawing.Point(624, 337)
        Me.frmReadData.Name = "frmReadData"
        Me.frmReadData.Size = New System.Drawing.Size(155, 55)
        Me.frmReadData.TabIndex = 0
        Me.frmReadData.Text = "Path of File"
        Me.frmReadData.UseVisualStyleBackColor = True
        '
        'OFDPdfRead
        '
        Me.OFDPdfRead.FileName = "ReadPDF"
        '
        'lblPath
        '
        Me.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPath.Location = New System.Drawing.Point(65, 104)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(674, 34)
        Me.lblPath.TabIndex = 1
        Me.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'butnTestCode
        '
        Me.butnTestCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butnTestCode.Location = New System.Drawing.Point(420, 337)
        Me.butnTestCode.Name = "butnTestCode"
        Me.butnTestCode.Size = New System.Drawing.Size(155, 55)
        Me.butnTestCode.TabIndex = 3
        Me.butnTestCode.Text = "Test Code"
        Me.butnTestCode.UseVisualStyleBackColor = True
        '
        'FrmReadPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 513)
        Me.Controls.Add(Me.butnTestCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.frmReadData)
        Me.Name = "FrmReadPDF"
        Me.Text = "Read Data from PDF File"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents frmReadData As Button
    Friend WithEvents OFDPdfRead As OpenFileDialog
    Friend WithEvents lblPath As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents butnTestCode As Button
End Class

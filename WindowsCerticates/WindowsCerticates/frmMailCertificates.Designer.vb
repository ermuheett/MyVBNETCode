<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMailCertificates
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
        Me.ButnEmailCertificates = New System.Windows.Forms.Button()
        Me.butnPDF = New System.Windows.Forms.Button()
        Me.butnPDFText = New System.Windows.Forms.Button()
        Me.ButnAdditional = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButnEmailCertificates
        '
        Me.ButnEmailCertificates.Location = New System.Drawing.Point(683, 567)
        Me.ButnEmailCertificates.Name = "ButnEmailCertificates"
        Me.ButnEmailCertificates.Size = New System.Drawing.Size(171, 67)
        Me.ButnEmailCertificates.TabIndex = 0
        Me.ButnEmailCertificates.Text = "Email Certificates"
        Me.ButnEmailCertificates.UseVisualStyleBackColor = True
        '
        'butnPDF
        '
        Me.butnPDF.Location = New System.Drawing.Point(489, 567)
        Me.butnPDF.Name = "butnPDF"
        Me.butnPDF.Size = New System.Drawing.Size(171, 67)
        Me.butnPDF.TabIndex = 1
        Me.butnPDF.Text = "PDF DOCUMENTS"
        Me.butnPDF.UseVisualStyleBackColor = True
        '
        'butnPDFText
        '
        Me.butnPDFText.Location = New System.Drawing.Point(289, 567)
        Me.butnPDFText.Name = "butnPDFText"
        Me.butnPDFText.Size = New System.Drawing.Size(171, 67)
        Me.butnPDFText.TabIndex = 2
        Me.butnPDFText.Text = "PDF TExt"
        Me.butnPDFText.UseVisualStyleBackColor = True
        '
        'ButnAdditional
        '
        Me.ButnAdditional.Location = New System.Drawing.Point(60, 567)
        Me.ButnAdditional.Name = "ButnAdditional"
        Me.ButnAdditional.Size = New System.Drawing.Size(171, 67)
        Me.ButnAdditional.TabIndex = 3
        Me.ButnAdditional.Text = "Additoinal Method"
        Me.ButnAdditional.UseVisualStyleBackColor = True
        '
        'frmMailCertificates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 709)
        Me.Controls.Add(Me.ButnAdditional)
        Me.Controls.Add(Me.butnPDFText)
        Me.Controls.Add(Me.butnPDF)
        Me.Controls.Add(Me.ButnEmailCertificates)
        Me.Name = "frmMailCertificates"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButnEmailCertificates As Button
    Friend WithEvents butnPDF As Button
    Friend WithEvents butnPDFText As Button
    Friend WithEvents ButnAdditional As Button
End Class

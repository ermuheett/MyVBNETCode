<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProgrammeList
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
        Me.LstEvents = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButnCancel = New System.Windows.Forms.Button()
        Me.butnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstEvents
        '
        Me.LstEvents.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstEvents.FormattingEnabled = True
        Me.LstEvents.ItemHeight = 25
        Me.LstEvents.Location = New System.Drawing.Point(12, 56)
        Me.LstEvents.Name = "LstEvents"
        Me.LstEvents.ScrollAlwaysVisible = True
        Me.LstEvents.Size = New System.Drawing.Size(831, 529)
        Me.LstEvents.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Event ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButnCancel
        '
        Me.ButnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButnCancel.Location = New System.Drawing.Point(575, 622)
        Me.ButnCancel.Name = "ButnCancel"
        Me.ButnCancel.Size = New System.Drawing.Size(131, 46)
        Me.ButnCancel.TabIndex = 12
        Me.ButnCancel.Text = "Cancel"
        Me.ButnCancel.UseVisualStyleBackColor = True
        '
        'butnOK
        '
        Me.butnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butnOK.Location = New System.Drawing.Point(712, 622)
        Me.butnOK.Name = "butnOK"
        Me.butnOK.Size = New System.Drawing.Size(131, 46)
        Me.butnOK.TabIndex = 11
        Me.butnOK.Text = "OK"
        Me.butnOK.UseVisualStyleBackColor = True
        '
        'FrmProgrammeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 691)
        Me.Controls.Add(Me.ButnCancel)
        Me.Controls.Add(Me.butnOK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LstEvents)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmProgrammeList"
        Me.Text = "Programme List"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LstEvents As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButnCancel As Button
    Friend WithEvents butnOK As Button
End Class

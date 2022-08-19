<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStatus
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
        Me.ButnAssignAttendance = New System.Windows.Forms.Button()
        Me.butnAccessment = New System.Windows.Forms.Button()
        Me.butnInit = New System.Windows.Forms.Button()
        Me.ButnCheckRemaining = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButnAssignAttendance
        '
        Me.ButnAssignAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButnAssignAttendance.Location = New System.Drawing.Point(186, 130)
        Me.ButnAssignAttendance.Name = "ButnAssignAttendance"
        Me.ButnAssignAttendance.Size = New System.Drawing.Size(495, 73)
        Me.ButnAssignAttendance.TabIndex = 0
        Me.ButnAssignAttendance.Text = "Assign Attendance as per Email"
        Me.ButnAssignAttendance.UseVisualStyleBackColor = True
        '
        'butnAccessment
        '
        Me.butnAccessment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butnAccessment.Location = New System.Drawing.Point(186, 231)
        Me.butnAccessment.Name = "butnAccessment"
        Me.butnAccessment.Size = New System.Drawing.Size(495, 73)
        Me.butnAccessment.TabIndex = 1
        Me.butnAccessment.Text = "Assign Assessment"
        Me.butnAccessment.UseVisualStyleBackColor = True
        '
        'butnInit
        '
        Me.butnInit.Enabled = False
        Me.butnInit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butnInit.Location = New System.Drawing.Point(186, 34)
        Me.butnInit.Name = "butnInit"
        Me.butnInit.Size = New System.Drawing.Size(495, 73)
        Me.butnInit.TabIndex = 2
        Me.butnInit.Text = "Intialization"
        Me.butnInit.UseVisualStyleBackColor = True
        '
        'ButnCheckRemaining
        '
        Me.ButnCheckRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButnCheckRemaining.Location = New System.Drawing.Point(186, 339)
        Me.ButnCheckRemaining.Name = "ButnCheckRemaining"
        Me.ButnCheckRemaining.Size = New System.Drawing.Size(495, 73)
        Me.ButnCheckRemaining.TabIndex = 3
        Me.ButnCheckRemaining.Text = "Compare Certificate with Registration"
        Me.ButnCheckRemaining.UseVisualStyleBackColor = True
        '
        'FrmStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 656)
        Me.Controls.Add(Me.ButnCheckRemaining)
        Me.Controls.Add(Me.butnInit)
        Me.Controls.Add(Me.butnAccessment)
        Me.Controls.Add(Me.ButnAssignAttendance)
        Me.Name = "FrmStatus"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButnAssignAttendance As Button
    Friend WithEvents butnAccessment As Button
    Friend WithEvents butnInit As Button
    Friend WithEvents ButnCheckRemaining As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.butEvaluate = New System.Windows.Forms.Button
        Me.txtEvaluate = New System.Windows.Forms.TextBox
        Me.cboSelection = New System.Windows.Forms.ComboBox
        Me.lblKeyWord = New System.Windows.Forms.Label
        Me.bttnClose = New System.Windows.Forms.Button
        Me.bttnTxtAllign = New System.Windows.Forms.Button
        Me.bttnOutput = New System.Windows.Forms.Button
        Me.bttnCodeSnipets = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'butEvaluate
        '
        Me.butEvaluate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butEvaluate.ForeColor = System.Drawing.Color.Black
        Me.butEvaluate.Location = New System.Drawing.Point(226, 333)
        Me.butEvaluate.Name = "butEvaluate"
        Me.butEvaluate.Size = New System.Drawing.Size(248, 33)
        Me.butEvaluate.TabIndex = 0
        Me.butEvaluate.Text = "Evaluate Form Element"
        Me.butEvaluate.UseVisualStyleBackColor = True
        '
        'txtEvaluate
        '
        Me.txtEvaluate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvaluate.Location = New System.Drawing.Point(226, 65)
        Me.txtEvaluate.Name = "txtEvaluate"
        Me.txtEvaluate.Size = New System.Drawing.Size(210, 26)
        Me.txtEvaluate.TabIndex = 1
        '
        'cboSelection
        '
        Me.cboSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelection.FormattingEnabled = True
        Me.cboSelection.Items.AddRange(New Object() {"Java", "C", "C++", "SQL", "PLSQL", "Visual Basic"})
        Me.cboSelection.Location = New System.Drawing.Point(226, 97)
        Me.cboSelection.Name = "cboSelection"
        Me.cboSelection.Size = New System.Drawing.Size(210, 28)
        Me.cboSelection.TabIndex = 3
        '
        'lblKeyWord
        '
        Me.lblKeyWord.AutoSize = True
        Me.lblKeyWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeyWord.Location = New System.Drawing.Point(44, 65)
        Me.lblKeyWord.Name = "lblKeyWord"
        Me.lblKeyWord.Size = New System.Drawing.Size(165, 20)
        Me.lblKeyWord.TabIndex = 4
        Me.lblKeyWord.Text = "Enter the Key Word"
        '
        'bttnClose
        '
        Me.bttnClose.Location = New System.Drawing.Point(378, 0)
        Me.bttnClose.Name = "bttnClose"
        Me.bttnClose.Size = New System.Drawing.Size(106, 23)
        Me.bttnClose.TabIndex = 5
        Me.bttnClose.Text = "Close Application"
        Me.bttnClose.UseVisualStyleBackColor = True
        '
        'bttnTxtAllign
        '
        Me.bttnTxtAllign.Location = New System.Drawing.Point(12, 340)
        Me.bttnTxtAllign.Name = "bttnTxtAllign"
        Me.bttnTxtAllign.Size = New System.Drawing.Size(106, 23)
        Me.bttnTxtAllign.TabIndex = 6
        Me.bttnTxtAllign.Text = "Allign Button"
        Me.bttnTxtAllign.UseVisualStyleBackColor = True
        '
        'bttnOutput
        '
        Me.bttnOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnOutput.Location = New System.Drawing.Point(226, 293)
        Me.bttnOutput.Name = "bttnOutput"
        Me.bttnOutput.Size = New System.Drawing.Size(124, 23)
        Me.bttnOutput.TabIndex = 7
        Me.bttnOutput.Text = "Output Window"
        Me.bttnOutput.UseVisualStyleBackColor = True
        '
        'bttnCodeSnipets
        '
        Me.bttnCodeSnipets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCodeSnipets.Location = New System.Drawing.Point(12, 293)
        Me.bttnCodeSnipets.Name = "bttnCodeSnipets"
        Me.bttnCodeSnipets.Size = New System.Drawing.Size(124, 23)
        Me.bttnCodeSnipets.TabIndex = 8
        Me.bttnCodeSnipets.Text = "Code Snippets"
        Me.bttnCodeSnipets.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 378)
        Me.Controls.Add(Me.bttnCodeSnipets)
        Me.Controls.Add(Me.bttnOutput)
        Me.Controls.Add(Me.bttnTxtAllign)
        Me.Controls.Add(Me.bttnClose)
        Me.Controls.Add(Me.lblKeyWord)
        Me.Controls.Add(Me.cboSelection)
        Me.Controls.Add(Me.txtEvaluate)
        Me.Controls.Add(Me.butEvaluate)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "My Test Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butEvaluate As System.Windows.Forms.Button
    Friend WithEvents txtEvaluate As System.Windows.Forms.TextBox
    Friend WithEvents cboSelection As System.Windows.Forms.ComboBox
    Friend WithEvents lblKeyWord As System.Windows.Forms.Label
    Friend WithEvents bttnClose As System.Windows.Forms.Button
    Friend WithEvents bttnTxtAllign As System.Windows.Forms.Button
    Friend WithEvents bttnOutput As System.Windows.Forms.Button
    Friend WithEvents bttnCodeSnipets As System.Windows.Forms.Button

End Class

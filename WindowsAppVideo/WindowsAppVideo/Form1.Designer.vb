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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picCapture = New System.Windows.Forms.PictureBox
        Me.btnStart = New System.Windows.Forms.Button
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.lstDevices = New System.Windows.Forms.ListBox
        Me.lblActiveDevics = New System.Windows.Forms.Label
        Me.sfdImage = New System.Windows.Forms.SaveFileDialog
        Me.picClothes = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.picLabel = New System.Windows.Forms.PictureBox
        Me.picDog = New System.Windows.Forms.PictureBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.lblPic = New System.Windows.Forms.Label
        CType(Me.picCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClothes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCapture
        '
        Me.picCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCapture.Location = New System.Drawing.Point(213, 152)
        Me.picCapture.Name = "picCapture"
        Me.picCapture.Size = New System.Drawing.Size(499, 452)
        Me.picCapture.TabIndex = 0
        Me.picCapture.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(49, 623)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(99, 44)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(194, 623)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(99, 44)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(345, 623)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 44)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lstDevices
        '
        Me.lstDevices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDevices.FormattingEnabled = True
        Me.lstDevices.ItemHeight = 20
        Me.lstDevices.Location = New System.Drawing.Point(31, 54)
        Me.lstDevices.Name = "lstDevices"
        Me.lstDevices.Size = New System.Drawing.Size(437, 44)
        Me.lstDevices.TabIndex = 4
        '
        'lblActiveDevics
        '
        Me.lblActiveDevics.AutoSize = True
        Me.lblActiveDevics.Location = New System.Drawing.Point(274, 20)
        Me.lblActiveDevics.Name = "lblActiveDevics"
        Me.lblActiveDevics.Size = New System.Drawing.Size(39, 13)
        Me.lblActiveDevics.TabIndex = 5
        Me.lblActiveDevics.Text = "Label1"
        '
        'picClothes
        '
        Me.picClothes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picClothes.Image = CType(resources.GetObject("picClothes.Image"), System.Drawing.Image)
        Me.picClothes.Location = New System.Drawing.Point(303, 243)
        Me.picClothes.Name = "picClothes"
        Me.picClothes.Size = New System.Drawing.Size(332, 276)
        Me.picClothes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClothes.TabIndex = 6
        Me.picClothes.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(808, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 64)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'picLabel
        '
        Me.picLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picLabel.Location = New System.Drawing.Point(785, 207)
        Me.picLabel.Name = "picLabel"
        Me.picLabel.Size = New System.Drawing.Size(221, 234)
        Me.picLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLabel.TabIndex = 8
        Me.picLabel.TabStop = False
        '
        'picDog
        '
        Me.picDog.Location = New System.Drawing.Point(686, 31)
        Me.picDog.Name = "picDog"
        Me.picDog.Size = New System.Drawing.Size(54, 52)
        Me.picDog.TabIndex = 9
        Me.picDog.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(0, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'lblPic
        '
        Me.lblPic.AutoSize = True
        Me.lblPic.Location = New System.Drawing.Point(859, 606)
        Me.lblPic.Name = "lblPic"
        Me.lblPic.Size = New System.Drawing.Size(39, 13)
        Me.lblPic.TabIndex = 11
        Me.lblPic.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 738)
        Me.Controls.Add(Me.picClothes)
        Me.Controls.Add(Me.lblPic)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.picDog)
        Me.Controls.Add(Me.picLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.picCapture)
        Me.Controls.Add(Me.lblActiveDevics)
        Me.Controls.Add(Me.lstDevices)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picCapture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClothes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCapture As System.Windows.Forms.PictureBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lstDevices As System.Windows.Forms.ListBox
    Friend WithEvents lblActiveDevics As System.Windows.Forms.Label
    Friend WithEvents sfdImage As System.Windows.Forms.SaveFileDialog
    Friend WithEvents picClothes As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents picLabel As System.Windows.Forms.PictureBox
    Friend WithEvents picDog As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblPic As System.Windows.Forms.Label

End Class

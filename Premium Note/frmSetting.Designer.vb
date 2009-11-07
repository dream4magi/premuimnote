<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Me.chkStartWSys = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.grbVisualSetting = New System.Windows.Forms.GroupBox
        Me.lblOpacity = New System.Windows.Forms.Label
        Me.TrackBarOpacity = New System.Windows.Forms.TrackBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblFont = New System.Windows.Forms.Label
        Me.chkAnimation = New System.Windows.Forms.CheckBox
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.btnClose = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grbVisualSetting.SuspendLayout()
        CType(Me.TrackBarOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkStartWSys
        '
        Me.chkStartWSys.AutoSize = True
        Me.chkStartWSys.BackColor = System.Drawing.Color.Transparent
        Me.chkStartWSys.Location = New System.Drawing.Point(12, 12)
        Me.chkStartWSys.Name = "chkStartWSys"
        Me.chkStartWSys.Size = New System.Drawing.Size(135, 20)
        Me.chkStartWSys.TabIndex = 0
        Me.chkStartWSys.Text = "Start With System"
        Me.chkStartWSys.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Premium_Note.My.Resources.Resources.etc
        Me.Button1.Location = New System.Drawing.Point(65, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 18)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grbVisualSetting
        '
        Me.grbVisualSetting.BackColor = System.Drawing.Color.Transparent
        Me.grbVisualSetting.Controls.Add(Me.Panel1)
        Me.grbVisualSetting.Controls.Add(Me.lblOpacity)
        Me.grbVisualSetting.Controls.Add(Me.Label2)
        Me.grbVisualSetting.Controls.Add(Me.Label1)
        Me.grbVisualSetting.Controls.Add(Me.Button1)
        Me.grbVisualSetting.Controls.Add(Me.lblFont)
        Me.grbVisualSetting.Controls.Add(Me.chkAnimation)
        Me.grbVisualSetting.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbVisualSetting.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.grbVisualSetting.Location = New System.Drawing.Point(12, 60)
        Me.grbVisualSetting.Name = "grbVisualSetting"
        Me.grbVisualSetting.Size = New System.Drawing.Size(273, 176)
        Me.grbVisualSetting.TabIndex = 2
        Me.grbVisualSetting.TabStop = False
        Me.grbVisualSetting.Text = "Visual Setting"
        '
        'lblOpacity
        '
        Me.lblOpacity.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOpacity.Location = New System.Drawing.Point(141, 68)
        Me.lblOpacity.Name = "lblOpacity"
        Me.lblOpacity.Size = New System.Drawing.Size(50, 13)
        Me.lblOpacity.TabIndex = 6
        Me.lblOpacity.Text = "Opacity"
        Me.lblOpacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TrackBarOpacity
        '
        Me.TrackBarOpacity.AutoSize = False
        Me.TrackBarOpacity.BackColor = System.Drawing.SystemColors.Control
        Me.TrackBarOpacity.Location = New System.Drawing.Point(1, 1)
        Me.TrackBarOpacity.Maximum = 100
        Me.TrackBarOpacity.Minimum = 10
        Me.TrackBarOpacity.Name = "TrackBarOpacity"
        Me.TrackBarOpacity.Size = New System.Drawing.Size(191, 31)
        Me.TrackBarOpacity.TabIndex = 5
        Me.TrackBarOpacity.TickFrequency = 10
        Me.TrackBarOpacity.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.TrackBarOpacity.Value = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Note Paper Opacity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(5, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Note Font"
        '
        'lblFont
        '
        Me.lblFont.AutoEllipsis = True
        Me.lblFont.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblFont.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFont.Location = New System.Drawing.Point(5, 41)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(262, 20)
        Me.lblFont.TabIndex = 2
        Me.lblFont.Text = "Note Font"
        '
        'chkAnimation
        '
        Me.chkAnimation.AutoSize = True
        Me.chkAnimation.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.chkAnimation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAnimation.Location = New System.Drawing.Point(9, 124)
        Me.chkAnimation.Name = "chkAnimation"
        Me.chkAnimation.Size = New System.Drawing.Size(85, 20)
        Me.chkAnimation.TabIndex = 0
        Me.chkAnimation.Text = "Animation"
        Me.chkAnimation.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.Premium_Note.My.Resources.Resources.OK
        Me.btnClose.Location = New System.Drawing.Point(245, 242)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.TabIndex = 9
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(70, 283)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.TrackBarOpacity)
        Me.Panel1.Location = New System.Drawing.Point(9, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(193, 33)
        Me.Panel1.TabIndex = 7
        '
        'frmSetting
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Premium_Note.My.Resources.Resources.form_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(403, 294)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grbVisualSetting)
        Me.Controls.Add(Me.chkStartWSys)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSetting"
        Me.Text = "frmSetting"
        Me.grbVisualSetting.ResumeLayout(False)
        Me.grbVisualSetting.PerformLayout()
        CType(Me.TrackBarOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkStartWSys As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grbVisualSetting As System.Windows.Forms.GroupBox
    Friend WithEvents lblFont As System.Windows.Forms.Label
    Friend WithEvents chkAnimation As System.Windows.Forms.CheckBox
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TrackBarOpacity As System.Windows.Forms.TrackBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblOpacity As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class

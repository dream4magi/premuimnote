﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreference
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
        Me.chkTabOnTop = New System.Windows.Forms.CheckBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TrackBarTabOpacity = New System.Windows.Forms.TrackBar
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TrackBarOpacity = New System.Windows.Forms.TrackBar
        Me.chkAnimation = New System.Windows.Forms.CheckBox
        Me.lblTabOpacity = New System.Windows.Forms.Label
        Me.lblOpacity = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblFont = New System.Windows.Forms.Label
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblSort = New System.Windows.Forms.Label
        Me.cboSort = New System.Windows.Forms.ComboBox
        Me.grbVisualSetting.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TrackBarTabOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TrackBarOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Button1.Location = New System.Drawing.Point(65, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 18)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grbVisualSetting
        '
        Me.grbVisualSetting.BackColor = System.Drawing.Color.Transparent
        Me.grbVisualSetting.Controls.Add(Me.chkTabOnTop)
        Me.grbVisualSetting.Controls.Add(Me.Panel2)
        Me.grbVisualSetting.Controls.Add(Me.Panel1)
        Me.grbVisualSetting.Controls.Add(Me.chkAnimation)
        Me.grbVisualSetting.Controls.Add(Me.lblTabOpacity)
        Me.grbVisualSetting.Controls.Add(Me.lblOpacity)
        Me.grbVisualSetting.Controls.Add(Me.Label3)
        Me.grbVisualSetting.Controls.Add(Me.Label2)
        Me.grbVisualSetting.Controls.Add(Me.Label1)
        Me.grbVisualSetting.Controls.Add(Me.Button1)
        Me.grbVisualSetting.Controls.Add(Me.lblFont)
        Me.grbVisualSetting.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbVisualSetting.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.grbVisualSetting.Location = New System.Drawing.Point(12, 39)
        Me.grbVisualSetting.Name = "grbVisualSetting"
        Me.grbVisualSetting.Size = New System.Drawing.Size(338, 242)
        Me.grbVisualSetting.TabIndex = 1
        Me.grbVisualSetting.TabStop = False
        Me.grbVisualSetting.Text = "Visual Setting"
        '
        'chkTabOnTop
        '
        Me.chkTabOnTop.AutoSize = True
        Me.chkTabOnTop.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.chkTabOnTop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTabOnTop.Location = New System.Drawing.Point(10, 207)
        Me.chkTabOnTop.Name = "chkTabOnTop"
        Me.chkTabOnTop.Size = New System.Drawing.Size(169, 20)
        Me.chkTabOnTop.TabIndex = 10
        Me.chkTabOnTop.Text = "Tabs Always in the Front"
        Me.chkTabOnTop.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.TrackBarTabOpacity)
        Me.Panel2.Location = New System.Drawing.Point(9, 168)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(322, 33)
        Me.Panel2.TabIndex = 9
        '
        'TrackBarTabOpacity
        '
        Me.TrackBarTabOpacity.AutoSize = False
        Me.TrackBarTabOpacity.BackColor = System.Drawing.SystemColors.Control
        Me.TrackBarTabOpacity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TrackBarTabOpacity.Location = New System.Drawing.Point(1, 1)
        Me.TrackBarTabOpacity.Maximum = 100
        Me.TrackBarTabOpacity.Minimum = 50
        Me.TrackBarTabOpacity.Name = "TrackBarTabOpacity"
        Me.TrackBarTabOpacity.Size = New System.Drawing.Size(320, 31)
        Me.TrackBarTabOpacity.TabIndex = 0
        Me.TrackBarTabOpacity.TickFrequency = 5
        Me.TrackBarTabOpacity.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.TrackBarTabOpacity.Value = 100
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.TrackBarOpacity)
        Me.Panel1.Location = New System.Drawing.Point(9, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(323, 33)
        Me.Panel1.TabIndex = 6
        '
        'TrackBarOpacity
        '
        Me.TrackBarOpacity.AutoSize = False
        Me.TrackBarOpacity.BackColor = System.Drawing.SystemColors.Control
        Me.TrackBarOpacity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TrackBarOpacity.Location = New System.Drawing.Point(1, 1)
        Me.TrackBarOpacity.Maximum = 100
        Me.TrackBarOpacity.Minimum = 50
        Me.TrackBarOpacity.Name = "TrackBarOpacity"
        Me.TrackBarOpacity.Size = New System.Drawing.Size(321, 31)
        Me.TrackBarOpacity.TabIndex = 0
        Me.TrackBarOpacity.TickFrequency = 5
        Me.TrackBarOpacity.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.TrackBarOpacity.Value = 100
        '
        'chkAnimation
        '
        Me.chkAnimation.AutoSize = True
        Me.chkAnimation.BackColor = System.Drawing.Color.Transparent
        Me.chkAnimation.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.chkAnimation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAnimation.Location = New System.Drawing.Point(10, 19)
        Me.chkAnimation.Name = "chkAnimation"
        Me.chkAnimation.Size = New System.Drawing.Size(111, 20)
        Me.chkAnimation.TabIndex = 0
        Me.chkAnimation.Text = "Use Animation"
        Me.chkAnimation.UseVisualStyleBackColor = False
        '
        'lblTabOpacity
        '
        Me.lblTabOpacity.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTabOpacity.Location = New System.Drawing.Point(279, 152)
        Me.lblTabOpacity.Name = "lblTabOpacity"
        Me.lblTabOpacity.Size = New System.Drawing.Size(50, 13)
        Me.lblTabOpacity.TabIndex = 8
        Me.lblTabOpacity.Text = "Opacity"
        Me.lblTabOpacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOpacity
        '
        Me.lblOpacity.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOpacity.Location = New System.Drawing.Point(280, 92)
        Me.lblOpacity.Name = "lblOpacity"
        Me.lblOpacity.Size = New System.Drawing.Size(50, 13)
        Me.lblOpacity.TabIndex = 5
        Me.lblOpacity.Text = "Opacity"
        Me.lblOpacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(9, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Note Tab Opacity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(10, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Note Paper Opacity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(9, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Note Font"
        '
        'lblFont
        '
        Me.lblFont.AutoEllipsis = True
        Me.lblFont.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblFont.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFont.Location = New System.Drawing.Point(9, 65)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(236, 20)
        Me.lblFont.TabIndex = 3
        Me.lblFont.Text = "Note Font"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.Premium_Note.My.Resources.Resources.OK
        Me.btnClose.Location = New System.Drawing.Point(357, 260)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(64, 60)
        Me.btnClose.TabIndex = 2
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblSort
        '
        Me.lblSort.AutoSize = True
        Me.lblSort.BackColor = System.Drawing.Color.Transparent
        Me.lblSort.Location = New System.Drawing.Point(9, 297)
        Me.lblSort.Name = "lblSort"
        Me.lblSort.Size = New System.Drawing.Size(221, 16)
        Me.lblSort.TabIndex = 3
        Me.lblSort.Text = "After converting all to Tabs, Use sort:"
        '
        'cboSort
        '
        Me.cboSort.FormattingEnabled = True
        Me.cboSort.Items.AddRange(New Object() {"by Position", "by Color", "by AutoHide", "Do Nothing"})
        Me.cboSort.Location = New System.Drawing.Point(229, 293)
        Me.cboSort.Name = "cboSort"
        Me.cboSort.Size = New System.Drawing.Size(121, 24)
        Me.cboSort.TabIndex = 4
        '
        'frmPreference
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Premium_Note.My.Resources.Resources.form_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(430, 330)
        Me.Controls.Add(Me.cboSort)
        Me.Controls.Add(Me.lblSort)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grbVisualSetting)
        Me.Controls.Add(Me.chkStartWSys)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPreference"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preference"
        Me.grbVisualSetting.ResumeLayout(False)
        Me.grbVisualSetting.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.TrackBarTabOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TrackBarOpacity, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TrackBarTabOpacity As System.Windows.Forms.TrackBar
    Friend WithEvents lblTabOpacity As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkTabOnTop As System.Windows.Forms.CheckBox
    Friend WithEvents lblSort As System.Windows.Forms.Label
    Friend WithEvents cboSort As System.Windows.Forms.ComboBox
End Class

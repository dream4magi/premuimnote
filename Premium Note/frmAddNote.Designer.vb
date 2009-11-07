<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNote
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
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.txtContent = New System.Windows.Forms.TextBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblContent = New System.Windows.Forms.Label
        Me.chkAlerm = New System.Windows.Forms.CheckBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.picAlerm = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.cboPiority = New System.Windows.Forms.ComboBox
        Me.lblPiority = New System.Windows.Forms.Label
        Me.color = New System.Windows.Forms.ColumnHeader
        Me.picColor0 = New System.Windows.Forms.PictureBox
        Me.panColor0 = New System.Windows.Forms.Panel
        Me.panColor1 = New System.Windows.Forms.Panel
        Me.picColor1 = New System.Windows.Forms.PictureBox
        Me.panColor2 = New System.Windows.Forms.Panel
        Me.picColor2 = New System.Windows.Forms.PictureBox
        Me.panColor3 = New System.Windows.Forms.Panel
        Me.picColor3 = New System.Windows.Forms.PictureBox
        Me.panColor4 = New System.Windows.Forms.Panel
        Me.picColor4 = New System.Windows.Forms.PictureBox
        Me.panColorMain = New System.Windows.Forms.Panel
        Me.lblColor = New System.Windows.Forms.Label
        CType(Me.picAlerm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColor0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panColor0.SuspendLayout()
        Me.panColor1.SuspendLayout()
        CType(Me.picColor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panColor2.SuspendLayout()
        CType(Me.picColor2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panColor3.SuspendLayout()
        CType(Me.picColor3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panColor4.SuspendLayout()
        CType(Me.picColor4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panColorMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(75, 15)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(243, 26)
        Me.txtTitle.TabIndex = 0
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(75, 108)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(243, 143)
        Me.txtContent.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblTitle.Location = New System.Drawing.Point(34, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(31, 15)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Title"
        '
        'lblContent
        '
        Me.lblContent.AutoSize = True
        Me.lblContent.BackColor = System.Drawing.Color.Transparent
        Me.lblContent.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContent.ForeColor = System.Drawing.Color.Gray
        Me.lblContent.Location = New System.Drawing.Point(15, 111)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(50, 15)
        Me.lblContent.TabIndex = 2
        Me.lblContent.Text = "Content"
        '
        'chkAlerm
        '
        Me.chkAlerm.AutoSize = True
        Me.chkAlerm.Location = New System.Drawing.Point(75, 260)
        Me.chkAlerm.Name = "chkAlerm"
        Me.chkAlerm.Size = New System.Drawing.Size(65, 23)
        Me.chkAlerm.TabIndex = 3
        Me.chkAlerm.Text = "Alerm"
        Me.chkAlerm.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(144, 259)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(0)
        Me.DateTimePicker1.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2009, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(174, 26)
        Me.DateTimePicker1.TabIndex = 6
        '
        'picAlerm
        '
        Me.picAlerm.Image = Global.Premium_Note.My.Resources.Resources.Alerm
        Me.picAlerm.Location = New System.Drawing.Point(5, 309)
        Me.picAlerm.Name = "picAlerm"
        Me.picAlerm.Size = New System.Drawing.Size(30, 32)
        Me.picAlerm.TabIndex = 7
        Me.picAlerm.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Premium_Note.My.Resources.Resources.OK
        Me.Button1.Location = New System.Drawing.Point(190, 291)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 60)
        Me.Button1.TabIndex = 8
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Premium_Note.My.Resources.Resources.NG
        Me.Button2.Location = New System.Drawing.Point(255, 291)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 60)
        Me.Button2.TabIndex = 8
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cboPiority
        '
        Me.cboPiority.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboPiority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPiority.FormattingEnabled = True
        Me.cboPiority.ItemHeight = 19
        Me.cboPiority.Items.AddRange(New Object() {"Highest", "High", "Normal", "Low", "Lowest"})
        Me.cboPiority.Location = New System.Drawing.Point(75, 46)
        Me.cboPiority.Name = "cboPiority"
        Me.cboPiority.Size = New System.Drawing.Size(89, 27)
        Me.cboPiority.TabIndex = 9
        '
        'lblPiority
        '
        Me.lblPiority.AutoSize = True
        Me.lblPiority.BackColor = System.Drawing.Color.Transparent
        Me.lblPiority.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPiority.ForeColor = System.Drawing.Color.Gray
        Me.lblPiority.Location = New System.Drawing.Point(23, 51)
        Me.lblPiority.Name = "lblPiority"
        Me.lblPiority.Size = New System.Drawing.Size(42, 15)
        Me.lblPiority.TabIndex = 10
        Me.lblPiority.Text = "Piority"
        '
        'color
        '
        Me.color.Width = 20
        '
        'picColor0
        '
        Me.picColor0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picColor0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picColor0.Image = Global.Premium_Note.My.Resources.Resources._00yelllow
        Me.picColor0.Location = New System.Drawing.Point(2, 2)
        Me.picColor0.Name = "picColor0"
        Me.picColor0.Size = New System.Drawing.Size(16, 16)
        Me.picColor0.TabIndex = 12
        Me.picColor0.TabStop = False
        '
        'panColor0
        '
        Me.panColor0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panColor0.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panColor0.Controls.Add(Me.picColor0)
        Me.panColor0.Location = New System.Drawing.Point(0, 0)
        Me.panColor0.Margin = New System.Windows.Forms.Padding(0)
        Me.panColor0.Name = "panColor0"
        Me.panColor0.Padding = New System.Windows.Forms.Padding(2)
        Me.panColor0.Size = New System.Drawing.Size(20, 20)
        Me.panColor0.TabIndex = 13
        '
        'panColor1
        '
        Me.panColor1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panColor1.BackColor = System.Drawing.SystemColors.Control
        Me.panColor1.Controls.Add(Me.picColor1)
        Me.panColor1.Location = New System.Drawing.Point(27, 0)
        Me.panColor1.Margin = New System.Windows.Forms.Padding(0)
        Me.panColor1.Name = "panColor1"
        Me.panColor1.Padding = New System.Windows.Forms.Padding(2)
        Me.panColor1.Size = New System.Drawing.Size(20, 20)
        Me.panColor1.TabIndex = 14
        '
        'picColor1
        '
        Me.picColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picColor1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picColor1.Image = Global.Premium_Note.My.Resources.Resources._01green
        Me.picColor1.Location = New System.Drawing.Point(2, 2)
        Me.picColor1.Name = "picColor1"
        Me.picColor1.Size = New System.Drawing.Size(16, 16)
        Me.picColor1.TabIndex = 12
        Me.picColor1.TabStop = False
        '
        'panColor2
        '
        Me.panColor2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panColor2.BackColor = System.Drawing.SystemColors.Control
        Me.panColor2.Controls.Add(Me.picColor2)
        Me.panColor2.Location = New System.Drawing.Point(54, 0)
        Me.panColor2.Margin = New System.Windows.Forms.Padding(0)
        Me.panColor2.Name = "panColor2"
        Me.panColor2.Padding = New System.Windows.Forms.Padding(2)
        Me.panColor2.Size = New System.Drawing.Size(20, 20)
        Me.panColor2.TabIndex = 14
        '
        'picColor2
        '
        Me.picColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picColor2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picColor2.Image = Global.Premium_Note.My.Resources.Resources._02red
        Me.picColor2.Location = New System.Drawing.Point(2, 2)
        Me.picColor2.Name = "picColor2"
        Me.picColor2.Size = New System.Drawing.Size(16, 16)
        Me.picColor2.TabIndex = 12
        Me.picColor2.TabStop = False
        '
        'panColor3
        '
        Me.panColor3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panColor3.BackColor = System.Drawing.SystemColors.Control
        Me.panColor3.Controls.Add(Me.picColor3)
        Me.panColor3.Location = New System.Drawing.Point(81, 0)
        Me.panColor3.Margin = New System.Windows.Forms.Padding(0)
        Me.panColor3.Name = "panColor3"
        Me.panColor3.Padding = New System.Windows.Forms.Padding(2)
        Me.panColor3.Size = New System.Drawing.Size(20, 20)
        Me.panColor3.TabIndex = 14
        '
        'picColor3
        '
        Me.picColor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picColor3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picColor3.Image = Global.Premium_Note.My.Resources.Resources._03blue
        Me.picColor3.Location = New System.Drawing.Point(2, 2)
        Me.picColor3.Name = "picColor3"
        Me.picColor3.Size = New System.Drawing.Size(16, 16)
        Me.picColor3.TabIndex = 12
        Me.picColor3.TabStop = False
        '
        'panColor4
        '
        Me.panColor4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panColor4.BackColor = System.Drawing.SystemColors.Control
        Me.panColor4.Controls.Add(Me.picColor4)
        Me.panColor4.Location = New System.Drawing.Point(108, 0)
        Me.panColor4.Margin = New System.Windows.Forms.Padding(0)
        Me.panColor4.Name = "panColor4"
        Me.panColor4.Padding = New System.Windows.Forms.Padding(2)
        Me.panColor4.Size = New System.Drawing.Size(20, 20)
        Me.panColor4.TabIndex = 14
        '
        'picColor4
        '
        Me.picColor4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picColor4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picColor4.Image = Global.Premium_Note.My.Resources.Resources._04purple
        Me.picColor4.Location = New System.Drawing.Point(2, 2)
        Me.picColor4.Name = "picColor4"
        Me.picColor4.Size = New System.Drawing.Size(16, 16)
        Me.picColor4.TabIndex = 12
        Me.picColor4.TabStop = False
        '
        'panColorMain
        '
        Me.panColorMain.AutoSize = True
        Me.panColorMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panColorMain.Controls.Add(Me.panColor4)
        Me.panColorMain.Controls.Add(Me.panColor0)
        Me.panColorMain.Controls.Add(Me.panColor3)
        Me.panColorMain.Controls.Add(Me.panColor1)
        Me.panColorMain.Controls.Add(Me.panColor2)
        Me.panColorMain.Location = New System.Drawing.Point(75, 80)
        Me.panColorMain.Name = "panColorMain"
        Me.panColorMain.Size = New System.Drawing.Size(128, 20)
        Me.panColorMain.TabIndex = 15
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.BackColor = System.Drawing.Color.Transparent
        Me.lblColor.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.ForeColor = System.Drawing.Color.Gray
        Me.lblColor.Location = New System.Drawing.Point(29, 82)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(36, 15)
        Me.lblColor.TabIndex = 16
        Me.lblColor.Text = "Color"
        '
        'frmAddNote
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(322, 353)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.panColorMain)
        Me.Controls.Add(Me.lblPiority)
        Me.Controls.Add(Me.cboPiority)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.picAlerm)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.chkAlerm)
        Me.Controls.Add(Me.lblContent)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.txtTitle)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAddNote"
        Me.Text = "frmAddNote"
        CType(Me.picAlerm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColor0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panColor0.ResumeLayout(False)
        Me.panColor1.ResumeLayout(False)
        CType(Me.picColor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panColor2.ResumeLayout(False)
        CType(Me.picColor2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panColor3.ResumeLayout(False)
        CType(Me.picColor3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panColor4.ResumeLayout(False)
        CType(Me.picColor4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panColorMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblContent As System.Windows.Forms.Label
    Friend WithEvents chkAlerm As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents picAlerm As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cboPiority As System.Windows.Forms.ComboBox
    Friend WithEvents lblPiority As System.Windows.Forms.Label
    Friend WithEvents color As System.Windows.Forms.ColumnHeader
    Friend WithEvents picColor0 As System.Windows.Forms.PictureBox
    Friend WithEvents panColor0 As System.Windows.Forms.Panel
    Friend WithEvents panColor1 As System.Windows.Forms.Panel
    Friend WithEvents picColor1 As System.Windows.Forms.PictureBox
    Friend WithEvents panColor2 As System.Windows.Forms.Panel
    Friend WithEvents picColor2 As System.Windows.Forms.PictureBox
    Friend WithEvents panColor3 As System.Windows.Forms.Panel
    Friend WithEvents picColor3 As System.Windows.Forms.PictureBox
    Friend WithEvents panColor4 As System.Windows.Forms.Panel
    Friend WithEvents picColor4 As System.Windows.Forms.PictureBox
    Friend WithEvents panColorMain As System.Windows.Forms.Panel
    Friend WithEvents lblColor As System.Windows.Forms.Label
End Class

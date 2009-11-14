<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscImageButton
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Me.picBtn = New System.Windows.Forms.PictureBox
        Me.ToolTip0 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBtn
        '
        Me.picBtn.Location = New System.Drawing.Point(0, 0)
        Me.picBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.picBtn.Name = "picBtn"
        Me.picBtn.Size = New System.Drawing.Size(100, 50)
        Me.picBtn.TabIndex = 0
        Me.picBtn.TabStop = False
        '
        'uscImageButton
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.picBtn)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "uscImageButton"
        CType(Me.picBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picBtn As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip0 As System.Windows.Forms.ToolTip

End Class

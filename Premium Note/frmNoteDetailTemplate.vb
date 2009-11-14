Option Strict On
Option Explicit On
Public Class frmNoteDetailTemplate
    Implements INotePaper

    Private WithEvents txtTitle As TextBox
    Private WithEvents txtContent As TextBox

    Dim noteData As clsAllNotes.clsNoteData
    Private WithEvents tmr As New Timer
    'Public note_title As String
    'Public note_content As String

    'Public note_create_time As String
    'Public note_done_time As String


    'Public note_alerm_enable As String
    'Public note_alerm_time As String

    'Public note_piority As String
    'Public blnNoteDetailmode As String
    Public Sub New(ByVal noteClass As clsAllNotes.clsNoteData)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        noteData = noteClass
        ' Add any initialization after the InitializeComponent() call.
        Me.Opacity = My.Settings.NOTE_OPACITY
    End Sub
    Public Sub New(ByVal noteClass As clsAllNotes.clsNoteData, ByVal Opacity As Double)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        noteData = noteClass
        ' Add any initialization after the InitializeComponent() call.
        Me.Opacity = Opacity
    End Sub
    Private Sub frmNoteTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmr.Interval = 50
        tmr.Stop()
        Me.Opacity = My.Settings.NOTE_OPACITY


        loadNoteDataToNote(Me.noteData)
        Me.Location = New Point(CInt(noteData.X), CInt(noteData.Y))
        Me.Font = My.Settings.NOTE_FONT
    End Sub

    Sub loadNoteDataToNote(ByVal noteClass As clsAllNotes.clsNoteData) Implements INotePaper.loadNoteDataToNote
        lblTitle.Text = Me.noteData.note_title
        lblContent.Text = Me.noteData.note_content
        Me.panNote.BackgroundImage = getNoteDetailBackgroundImage(Me.noteData.note_color)
    End Sub

    Property readNoteData() As clsAllNotes.clsNoteData Implements INotePaper.readNoteData
        Get
            Return noteData
        End Get
        Set(ByVal value As clsAllNotes.clsNoteData)
            Me.noteData = value
            loadNoteDataToNote(Me.noteData)
        End Set
    End Property



    Private Sub changeNoteMode(ByVal blnDetailMode As Boolean)
        If blnDetailMode Then 'change to detail mode

        Else

        End If
    End Sub








#Region "Move"


    Private shiftX As Integer
    Private shiftY As Integer
    Private Sub frmNoteTemplate_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        shiftX = e.X
        shiftY = e.Y
        If My.Settings.Animation Then
            fageIn = False
            tmr.Start()
        End If
    End Sub
    Private Sub frmNoteTemplate_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Top = Me.Top + e.Y - shiftY
            Me.Left = Me.Left + e.X - shiftX
        End If
    End Sub
    Private Sub frmNoteTemplate_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If My.Settings.Animation Then
            fageIn = True
            tmr.Start()
        End If
    End Sub


    Private Sub Layout_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblContent.MouseDown, panNote.MouseDown, lblTitle.MouseDown
        If txtTitle IsNot Nothing AndAlso Not txtTitle.Text.Equals("") Then
            doneTitleEdit()
        End If
        If txtContent IsNot Nothing AndAlso Not txtContent.Text.Equals("") Then
            doneContentEdit()
        End If

        Call frmNoteTemplate_MouseDown(sender, e)
    End Sub
    Private Sub Layout_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblContent.MouseMove, panNote.MouseMove, lblTitle.MouseMove
        Call frmNoteTemplate_MouseMove(sender, e)
    End Sub

    Private Sub Layout_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblContent.MouseUp, panNote.MouseUp, lblTitle.MouseUp
        Call frmNoteTemplate_MouseUp(sender, e)

    End Sub


#End Region



    Dim fageIn As Boolean
    Private Sub tmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmr.Tick
        If fageIn Then
            Me.Opacity += 0.1
            If Me.Opacity >= My.Settings.NOTE_OPACITY Then tmr.Stop()
        Else
            Me.Opacity -= 0.1
            If Me.Opacity <= 0.5 Then tmr.Stop()
        End If
    End Sub










    Private Sub btnMin_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMin.MouseClick
        T.changeNoteMode(noteData, False)
    End Sub

    Private Sub chkTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTop.CheckedChanged
        Me.TopMost = chkTop.Checked
    End Sub

    Private Sub frmNoteDetailTemplate_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        noteData.X = Me.Left.ToString
        noteData.Y = Me.Top.ToString

    End Sub





    Private Sub btnDone_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnDone.MouseClick
        If MsgBox("Note Done ?", MsgBoxStyle.YesNo, "Please Confirm.") = MsgBoxResult.Yes Then
            T.doneNote(Me.noteData.note_no)
            T.noteDataChanged()
        End If
    End Sub
    Private Sub btnDelete_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnDelete.MouseClick
        If MsgBox("This will delete the Note forever," & vbCrLf & "Continue ?", MsgBoxStyle.YesNo, "Please Confirm.") = MsgBoxResult.Yes Then
            T.deleteNote(Me.noteData.note_no)
            T.noteDataChanged()
        End If
    End Sub

 

#Region "Edit title"
    Private Sub lblTitle_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDoubleClick
        txtTitle = New TextBox
        txtTitle.Multiline = False
        txtTitle.Font = lblTitle.Font
        txtTitle.Size = lblTitle.Size
        txtTitle.Location = lblTitle.Location
        txtTitle.BorderStyle = BorderStyle.FixedSingle
        txtTitle.Text = lblTitle.Text
        panNote.Controls.Add(txtTitle)
        txtTitle.BringToFront()
        txtTitle.Focus()
    End Sub

    Private Sub doneTitleEdit()
        lblTitle.Text = txtTitle.Text
        noteData.note_title = lblTitle.Text
        T.noteDataChanged()
        txtTitle.Dispose()
    End Sub

    Private Sub txtTitle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTitle.KeyDown
        If e.KeyCode = Keys.Escape Then
            txtTitle.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            doneTitleEdit()
        End If
    End Sub
#End Region
#Region "Edit content"
    Private Sub lblContent_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblContent.MouseDoubleClick
        txtContent = New TextBox
        txtContent.Multiline = True
        txtContent.Font = lblContent.Font
        txtContent.Size = lblContent.Size
        txtContent.Location = lblContent.Location
        txtContent.BorderStyle = BorderStyle.FixedSingle
        txtContent.Text = lblContent.Text
        panNote.Controls.Add(txtContent)
        txtContent.BringToFront()
        txtContent.Focus()
    End Sub
 
    Private Sub doneContentEdit()
        lblContent.Text = txtContent.Text
        noteData.note_content = lblContent.Text
        T.noteDataChanged()
        txtContent.Dispose()
    End Sub

    Private Sub txtContent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContent.KeyDown
        If e.KeyCode = Keys.Escape Then
            txtContent.Dispose()
        End If
    End Sub
#End Region

#Region "Tool Tip"
    Private Sub lblContent_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblContent.TextChanged
        Me.ToolTip1.SetToolTip(Me.lblContent, lblContent.Text & vbCrLf & "DoubleClick to edit.")
    End Sub

    Private Sub lblTitle_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTitle.TextChanged
        Me.ToolTip1.SetToolTip(Me.lblTitle, lblTitle.Text & vbCrLf & "DoubleClick to edit.")
    End Sub

#End Region



End Class
Option Strict On
Option Explicit On
Public Class frmNoteTemplate
    Implements INotePaper



    Dim title As String
    Dim content As String
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

    Private Sub changeNoteMode(ByVal blnDetailMode As Boolean)
        If blnDetailMode Then 'change to detail mode

        Else

        End If
    End Sub





    'Public note_title As String
    'Public note_content As String

    'Public note_create_time As String
    'Public note_done_time As String


    'Public note_alerm_enable As String
    'Public note_alerm_time As String

    'Public note_piority As String
    'Public blnNoteDetailmode As String
    Public Sub New(ByVal noteClass As clsAllNotes.clsNoteData, Optional ByVal Opacity As Double = 1)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        noteData = noteClass
        Me.Opacity = Opacity
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmNoteTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmr.Interval = 50
        tmr.Stop()
        Me.Opacity = My.Settings.NOTE_OPACITY


        loadNoteDataToNote(Me.noteData)
        Me.Location = New Point(CInt(noteData.tabX), CInt(noteData.tabY))
    End Sub

    Sub loadNoteDataToNote(ByVal noteClass As clsAllNotes.clsNoteData) Implements INotePaper.loadNoteDataToNote
        title = Me.noteData.note_title
        content = Me.noteData.note_content
        Me.panNote.BackgroundImage = getNoteBackgroundImage(Me.noteData.note_color)
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






#Region "Move"
    Private shiftX As Integer
    Private shiftY As Integer
    Private Sub frmNoteTemplate_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        shiftX = e.X
        shiftY = e.Y
        fageIn = False
        tmr.Start()
    End Sub
    Private Sub frmNoteTemplate_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Top = Me.Top + e.Y - shiftY
            Me.Left = Me.Left + e.X - shiftX
        End If
    End Sub
    Private Sub frmNoteTemplate_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        fageIn = True
        tmr.Start()
    End Sub

    Dim fageIn As Boolean
    Private Sub tmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmr.Tick
        If fageIn Then
            Me.Opacity += 0.1
            If Me.Opacity >= 1 Then tmr.Stop()
        Else
            Me.Opacity -= 0.1
            If Me.Opacity <= 0.5 Then tmr.Stop()
        End If
    End Sub


    Private Sub Layout_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panNote.MouseDown
        Call frmNoteTemplate_MouseDown(sender, e)
    End Sub
    Private Sub Layout_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panNote.MouseMove
        Call frmNoteTemplate_MouseMove(sender, e)
    End Sub

    Private Sub Layout_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panNote.MouseUp
        Call frmNoteTemplate_MouseUp(sender, e)
    End Sub


#End Region


    Private Sub btnChangeMode_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnChangeMode.MouseClick
        T.changeNoteMode(noteData, True, True)
    End Sub


    Private Sub frmNoteTemplate_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        noteData.tabX = Me.Left.ToString
        noteData.tabY = Me.Top.ToString
    End Sub



    Private Sub btnNoteDone_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnNoteDone.MouseClick
        If MsgBox("Note Done ?", MsgBoxStyle.YesNo, "Please Confirm.") = MsgBoxResult.Yes Then
            T.doneNote(Me.noteData.note_no)
        End If
    End Sub

    Private Sub UscImageButton5_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub
End Class
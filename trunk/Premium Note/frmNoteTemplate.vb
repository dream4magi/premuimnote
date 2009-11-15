Option Strict On
Option Explicit On
Public Class frmNoteTemplate
    Implements INotePaper

    Private Const CALLAPSED_Y As Integer = -32


    Dim title As String
    Dim content As String
    Dim noteData As clsAllNotes.clsNoteData
    Private WithEvents tmr As New Timer

    Private WithEvents tmrMove As New Timer
    Private blnOpen As Boolean = False

    Private WithEvents tmrChkMouseHover As New Timer
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
        tmrMove.Interval = 40
        tmrMove.Stop()
        tmrChkMouseHover.Interval = 4000
        tmrChkMouseHover.Stop()
        Me.Opacity = My.Settings.NOTE_TAB_OPACITY
        Me.TopMost = My.Settings.NOTE_TAB_ON_TOP

        loadNoteDataToNote(Me.noteData)
        Me.Location = New Point(CInt(noteData.X), 0)

        blnOpen = True
        tmrMove.Start()
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
    'Private shiftY As Integer
    Private Sub frmNoteTemplate_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        shiftX = e.X
        'shiftY = e.Y

        If My.Settings.ANIMATION Then
            fageIn = False
            tmr.Start()
        End If

    End Sub

    Private Sub panNote_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panNote.MouseDoubleClick
        T.changeNoteMode(noteData, True)
    End Sub

    Private Sub frmNoteTemplate_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter, panNote.MouseEnter

    End Sub

    Private Sub frmNoteTemplate_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover, panNote.MouseHover, btnAutoHide.MouseHover, btnNoteDone.MouseHover
        If noteData.note_TabAutoHide.ToUpper.Equals("Y") Then
            If Me.MousePosition.X > Me.Left AndAlso Me.MousePosition.X < Me.Left + Me.Width AndAlso _
                  Me.MousePosition.Y > Me.Top AndAlso Me.MousePosition.Y < Me.Top + Me.Height Then

                'If Not tmrMove.Enabled Then
                blnOpen = True
                tmrMove.Start()
                ' End If
            End If
        End If
        Me.ToolTip1.SetToolTip(Me.panNote, String.Format("{0}{1}{2}{3}{4}", noteData.note_title, vbCrLf, noteData.note_piority, vbCrLf, noteData.note_content))
    End Sub

    Private Sub frmNoteTemplate_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave, panNote.MouseLeave, btnAutoHide.MouseLeave, btnNoteDone.MouseLeave
        If noteData.note_TabAutoHide.ToUpper.Equals("Y") Then
            If Not (Me.MousePosition.X > Me.Left AndAlso Me.MousePosition.X < Me.Left + Me.Width AndAlso _
               Me.MousePosition.Y > Me.Top AndAlso Me.MousePosition.Y < Me.Top + Me.Height) Then

                ' If Not tmrMove.Enabled Then
                blnOpen = False
                tmrMove.Start()
                'End If
            End If
        End If
    End Sub


    Private Sub frmNoteTemplate_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            'Me.Top = Me.Top + e.Y - shiftY
            Me.Top = 0
            Me.Left = Me.Left + e.X - shiftX
        End If
    End Sub
    Private Sub frmNoteTemplate_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If My.Settings.ANIMATION Then
            fageIn = True
            tmr.Start()
        End If
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


    Private Sub btnChangeMode_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAutoHide.MouseClick
        If noteData.note_TabAutoHide.ToUpper.Equals("Y") Then
            noteData.note_TabAutoHide = "N"
        Else
            noteData.note_TabAutoHide = "Y"
        End If
    End Sub


    Private Sub frmNoteTemplate_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        noteData.X = Me.Left.ToString
        ' noteData.Y = Me.Top.ToString
    End Sub



    Private Sub btnNoteDone_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnNoteDone.MouseClick
        If MsgBox("Note Done ?", MsgBoxStyle.YesNo, "Please Confirm.") = MsgBoxResult.Yes Then
            T.doneNote(Me.noteData.note_no)
            T.noteDataChanged()
        End If
    End Sub

 
    Private Sub tmrMove_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrMove.Tick


        If blnOpen Then
            If My.Settings.ANIMATION Then
                If Me.Top < 0 Then
                    Me.Top += 8
                Else
                    tmrMove.Stop()
                    tmrChkMouseHover.Start()
                End If
            Else
                Me.Top = 0
                tmrChkMouseHover.Start()
            End If
        Else
            If My.Settings.ANIMATION Then
                If Me.Top > CALLAPSED_Y Then
                    Me.Top -= 8
                Else
                    tmrMove.Stop()
                End If
            Else
                Me.Top = CALLAPSED_Y
            End If


        End If
    End Sub

    Private Sub tmrChkMouseHover_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrChkMouseHover.Tick

        If noteData.note_TabAutoHide.ToUpper.Equals("Y") Then
            If Not (Me.MousePosition.X > Me.Left AndAlso Me.MousePosition.X < Me.Left + Me.Width AndAlso _
                Me.MousePosition.Y > Me.Top AndAlso Me.MousePosition.Y < Me.Top + Me.Height) Then

                blnOpen = False
                tmrMove.Start()
            End If
        End If


    End Sub

    Private Sub panNote_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panNote.Paint

    End Sub
End Class
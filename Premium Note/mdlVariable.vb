Option Strict On
Option Explicit On
Module mdlVariable

    Public NoteColor(4) As Color
    Public aryALL_NOTES As New List(Of clsAllNotes.clsNoteData)
    Public aryALL_NOTES_paper As New List(Of INotePaper)

    Public aryDONE_NOTES As New List(Of clsAllNotes.clsNoteData)
    Sub initialNoteColor()
        NoteColor(0) = System.Drawing.Color.FromArgb(255, 230, 62)
        NoteColor(1) = System.Drawing.Color.FromArgb(181, 228, 97)
        NoteColor(2) = System.Drawing.Color.FromArgb(251, 188, 188)
        NoteColor(3) = System.Drawing.Color.FromArgb(183, 234, 253)
        NoteColor(4) = System.Drawing.Color.FromArgb(233, 183, 253)
    End Sub
End Module

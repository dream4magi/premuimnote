Module T






#Region "Utility"
    Function getLvwColnumByName(ByVal LvwColname() As String, ByVal keyword As String) As Integer
        For i As Integer = 0 To LvwColname.Length - 1
            If LvwColname(i).ToLower.Equals(keyword.ToLower) Then
                Return i
            End If
        Next
        Return -1
    End Function
    Function getNoteColorNum(ByVal noteClass As clsNoteData) As Integer
        Select Case noteClass.note_color
            Case "0"
                Return 0
            Case "1"
                Return 1
            Case "2"
                Return 2
            Case "3"
                Return 3
            Case "4"
                Return 4
            Case Else
                Return 0
        End Select
    End Function
    Function getNoteDetailBackgroundImage(ByVal strNoteColor As String) As Bitmap
        Select Case strNoteColor
            Case "0"
                Return My.Resources.noteColor0
            Case "1"
                Return My.Resources.noteColor1
            Case "2"
                Return My.Resources.noteColor2
            Case "3"
                Return My.Resources.noteColor3
            Case "4"
                Return My.Resources.noteColor4
            Case Else
                Return My.Resources.noteColor0
        End Select
    End Function
    Function getNoteBackgroundImage(ByVal strNoteColor As String) As Bitmap
        Select Case strNoteColor
            Case "0"
                Return My.Resources.tabColor0
            Case "1"
                Return My.Resources.tabColor1
            Case "2"
                Return My.Resources.tabColor2
            Case "3"
                Return My.Resources.tabColor3
            Case "4"
                Return My.Resources.tabColor4
            Case Else
                Return My.Resources.tabColor0
        End Select
    End Function
    Sub noteDataChanged()
        If frmNoteList IsNot Nothing Then
            frmNoteList.loadLvw()
        End If


    End Sub
    Sub arrangeTabs()
        Dim start_X As Integer = 100
        Dim end_X As Integer = My.Computer.Screen.PrimaryScreen.Bounds.Width - 120

        Dim aryTabs As New List(Of frmNoteTemplate)
        For Each obj As INotePaper In aryALL_NOTES_paper
            If obj.GetType.Equals(GetType(frmNoteTemplate)) Then

                aryTabs.Add(CType(obj, frmNoteTemplate))
            End If
        Next

        If aryTabs.Count * 23 + (aryTabs.Count - 1) * 2 > end_X - start_X Then
            For i As Integer = 0 To aryTabs.Count - 1
                aryTabs.Item(i).Left = CInt(start_X + i * (end_X - start_X) / aryTabs.Count)
                aryTabs.Item(i).SendToBack()
            Next
        Else

            For i As Integer = 0 To aryTabs.Count - 1
                aryTabs.Item(i).Left = start_X + i * (23 + 2)
                aryTabs.Item(i).SendToBack()
            Next

        End If

    End Sub

    Sub arrangeTabsByColor()
        Dim start_X As Integer = 100
        Dim end_X As Integer = My.Computer.Screen.PrimaryScreen.Bounds.Width - 120

        Dim aryTabs As New List(Of frmNoteTemplate)
        For Each obj As INotePaper In aryALL_NOTES_paper
            If obj.GetType.Equals(GetType(frmNoteTemplate)) Then

                aryTabs.Add(CType(obj, frmNoteTemplate))
            End If
        Next

        If aryTabs.Count * 23 + (aryTabs.Count - 1) * 2 > end_X - start_X Then
            Dim iCount As Integer = 0
            For j As Integer = 0 To NoteColor.Length - 1
                For i As Integer = 0 To aryTabs.Count - 1
                    If aryTabs.Item(i).readNoteData.note_color.Equals(j.ToString) Then
                        aryTabs.Item(i).Left = CInt(start_X + iCount * (end_X - start_X) / aryTabs.Count)
                        aryTabs.Item(i).SendToBack()
                        iCount += 1
                    End If
                Next
            Next

        Else
            Dim iCount As Integer = 0
            For j As Integer = 0 To NoteColor.Length - 1
                For i As Integer = 0 To aryTabs.Count - 1
                    If aryTabs.Item(i).readNoteData.note_color.Equals(j.ToString) Then
                        aryTabs.Item(i).Left = start_X + iCount * (23 + 2)
                        aryTabs.Item(i).SendToBack()
                        iCount += 1
                    End If
                Next
            Next
        End If

    End Sub

    Sub arrangeTabsByAutoHide()
        Dim start_X As Integer = 100
        Dim end_X As Integer = My.Computer.Screen.PrimaryScreen.Bounds.Width - 120

        Dim aryTabs As New List(Of frmNoteTemplate)
        For Each obj As INotePaper In aryALL_NOTES_paper
            If obj.GetType.Equals(GetType(frmNoteTemplate)) Then

                aryTabs.Add(CType(obj, frmNoteTemplate))
            End If
        Next

        If aryTabs.Count * 23 + (aryTabs.Count - 1) * 2 > end_X - start_X Then
            Dim iCount As Integer = 0

            For i As Integer = 0 To aryTabs.Count - 1
                If aryTabs.Item(i).readNoteData.note_TabAutoHide.ToUpper.Equals("N") Then
                    aryTabs.Item(i).Left = CInt(start_X + iCount * (end_X - start_X) / aryTabs.Count)
                    aryTabs.Item(i).SendToBack()
                    iCount += 1
                End If
            Next
            For i As Integer = 0 To aryTabs.Count - 1
                If aryTabs.Item(i).readNoteData.note_TabAutoHide.ToUpper.Equals("Y") Then
                    aryTabs.Item(i).Left = CInt(start_X + iCount * (end_X - start_X) / aryTabs.Count)
                    aryTabs.Item(i).SendToBack()
                    iCount += 1
                End If
            Next


        Else
            Dim iCount As Integer = 0



            For i As Integer = 0 To aryTabs.Count - 1
                If aryTabs.Item(i).readNoteData.note_TabAutoHide.ToUpper.Equals("N") Then
                    aryTabs.Item(i).Left = start_X + iCount * (23 + 2)
                    aryTabs.Item(i).SendToBack()
                    iCount += 1
                End If
            Next
            For i As Integer = 0 To aryTabs.Count - 1
                If aryTabs.Item(i).readNoteData.note_TabAutoHide.ToUpper.Equals("Y") Then
                    aryTabs.Item(i).Left = start_X + iCount * (23 + 2)
                    aryTabs.Item(i).SendToBack()
                    iCount += 1
                End If
            Next

        End If

    End Sub
#End Region

#Region "File Handle"
    Function readDataFile() As clsAllNotes
        Dim ALL_NOTES As clsAllNotes = Nothing
        Try


            Dim fileContents As String
            fileContents = My.Computer.FileSystem.ReadAllText("data.xml")

            Dim Xmsg As New Xstream.Core.XStream
            Xmsg.Alias("AllNotes", GetType(clsAllNotes))
            Xmsg.Alias("Note", GetType(clsNoteData))
            ALL_NOTES = CType(Xmsg.FromXml(fileContents), clsAllNotes)
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally

        End Try
        If ALL_NOTES Is Nothing Then
            ALL_NOTES = New clsAllNotes
        End If
        Return ALL_NOTES
    End Function
    Sub saveDataFile()

        Dim ALL_NOTES = New clsAllNotes
        ReDim ALL_NOTES.Notes(aryALL_NOTES.Count - 1)

        For i As Integer = 0 To aryALL_NOTES.Count - 1
            ALL_NOTES.Notes(i) = aryALL_NOTES.Item(i)
        Next

        Try
            Dim Xmsg As New Xstream.Core.XStream
            Xmsg.Alias("AllNotes", GetType(clsAllNotes))
            Xmsg.Alias("Note", GetType(clsNoteData))


            My.Computer.FileSystem.WriteAllText("data.xml", Xmsg.ToXml(ALL_NOTES), False)

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub
    Function readDoneDataFile() As clsAllNotes
        Dim DONE_NOTES As clsAllNotes = Nothing
        Try


            Dim fileContents As String
            fileContents = My.Computer.FileSystem.ReadAllText("done_data.xml")

            Dim Xmsg As New Xstream.Core.XStream
            Xmsg.Alias("AllNotes", GetType(clsAllNotes))
            Xmsg.Alias("Note", GetType(clsNoteData))
            DONE_NOTES = CType(Xmsg.FromXml(fileContents), clsAllNotes)
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally

        End Try
        If DONE_NOTES Is Nothing Then
            DONE_NOTES = New clsAllNotes
        End If
        Return DONE_NOTES
    End Function
    Sub saveDoneDataFile()

        Dim DONE_NOTES = New clsAllNotes
        ReDim DONE_NOTES.Notes(aryDONE_NOTES.Count - 1)

        For i As Integer = 0 To aryDONE_NOTES.Count - 1
            DONE_NOTES.Notes(i) = aryDONE_NOTES.Item(i)
        Next

        Try
            Dim Xmsg As New Xstream.Core.XStream
            Xmsg.Alias("AllNotes", GetType(clsAllNotes))
            Xmsg.Alias("Note", GetType(clsNoteData))


            My.Computer.FileSystem.WriteAllText("done_data.xml", Xmsg.ToXml(DONE_NOTES), False)

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub
#End Region

#Region "Note Handle"
    Sub loadAllNotePaper()
        For Each obj As clsNoteData In aryALL_NOTES
            If obj.blnNoteDetailmode.ToUpper.Equals("Y") Then
                T.createNewNoteDetailPaper(obj).Owner = frmMain
            Else
                T.createNewNotePaper(obj).Owner = frmMain
            End If
        Next
    End Sub
    Sub setNoteColor(ByVal noteClass As clsNoteData, ByVal colorNo As Integer)
        noteClass.note_color = colorNo.ToString
    End Sub
    Function getNewNoteNo() As Double
        Dim NextNoteNo As Double = -1
        For Each obj As clsNoteData In aryALL_NOTES
            If CType(obj.note_no, Double) > NextNoteNo Then
                NextNoteNo = CType(obj.note_no, Double)
            End If
        Next
        Return NextNoteNo + 1
    End Function
    Sub changeNoteMode(ByVal noteClass As clsNoteData, ByVal DetailMode As Boolean)
        T.removeNotePaper(noteClass)
        If DetailMode Then
            noteClass.blnNoteDetailmode = "Y"
            T.createNewNoteDetailPaper(noteClass)
        Else
            noteClass.blnNoteDetailmode = "N"
            T.createNewNotePaper(noteClass)
        End If

    End Sub
    Function getTotalNoteCount() As Double
        Return aryALL_NOTES.Count
    End Function
    Function getNoteClass(ByVal note_no As String) As clsNoteData
        For Each obj As clsNoteData In aryALL_NOTES
            If obj.note_no = note_no Then
                Return obj
            End If
        Next
        Return Nothing
    End Function
    Sub showNote(ByVal note_no As String)
        Try
            If T.getNotePaper(T.getNoteClass(note_no)).GetType.Equals(GetType(frmNoteTemplate)) Then

                T.changeNoteMode(T.getNoteClass(note_no), True)
            End If
            CType(T.getNotePaper(T.getNoteClass(note_no)), Form).BringToFront()
        Catch ex As Exception
            MsgBox(ex.Message, , "Error")
        End Try
    End Sub
    Function getNotePaper(ByVal noteClass As clsNoteData) As INotePaper
        For Each obj As INotePaper In aryALL_NOTES_paper
            If obj.readNoteData.Equals(noteClass) Then
                Return obj
            End If
        Next
        Return Nothing
    End Function
#Region "NotePaper"
    Sub removeNotePaper(ByVal noteClass As clsNoteData)
        For Each obj As INotePaper In aryALL_NOTES_paper
            If obj.readNoteData.Equals(noteClass) Then
                aryALL_NOTES_paper.Remove(obj)

                CType(obj, Form).Dispose()
                Return
            End If
        Next
    End Sub
    Public Function createNewNoteDetailPaper(ByVal noteClass As clsNoteData) As frmNoteDetailTemplate
        Dim newNoteFormDetail As New frmNoteDetailTemplate(noteClass)
        newNoteFormDetail.Show()
        newNoteFormDetail.Owner = frmMain
        aryALL_NOTES_paper.Add(newNoteFormDetail)
        Return newNoteFormDetail
    End Function
    Public Function createNewNotePaper(ByVal noteClass As clsNoteData) As frmNoteTemplate
        Dim newNoteForm As New frmNoteTemplate(noteClass)
        newNoteForm.Show()
        newNoteForm.Owner = frmMain
        aryALL_NOTES_paper.Add(newNoteForm)
        Return newNoteForm
    End Function
#End Region


#Region "NoteClass"
    Sub doneNote(ByVal note_no As String)
        aryDONE_NOTES.Clear()

        Dim DONE_NOTES As clsAllNotes = readDoneDataFile()
        If DONE_NOTES.Notes IsNot Nothing Then
            For i As Integer = 0 To DONE_NOTES.Notes.Length - 1
                aryDONE_NOTES.Add(DONE_NOTES.Notes(i))
            Next
        End If

        getNoteClass(note_no).note_done_time = Now().ToString("yyyy-MM-dd HH:mm")
        aryDONE_NOTES.Add(getNoteClass(note_no))



        saveDoneDataFile()
        DONE_NOTES = Nothing
        aryDONE_NOTES.Clear()

        deleteNote(note_no)

    End Sub
    Sub deleteNote(ByVal note_no As String)
        For Each obj As clsNoteData In aryALL_NOTES
            If obj.note_no.Equals(note_no) Then

                removeNotePaper(obj)


                aryALL_NOTES.Remove(obj)
                frmMain.refreshNote_no()
                Return
            End If
        Next
    End Sub
    Function addNote() As clsNoteData
        Dim newNote As New clsNoteData(getNewNoteNo.ToString)

        aryALL_NOTES.Add(newNote)
        frmMain.refreshNote_no()
        Return newNote
    End Function
    Function addNote(ByVal varNoteTitle As String, ByVal varNoteContent As String, _
                     ByVal alerm As String, ByVal alerm_time As String, ByVal piority As String, _
                     ByVal noteColor As String) As clsNoteData

        Dim newNote As New clsNoteData(getNewNoteNo.ToString)
        newNote.note_title = varNoteTitle

        newNote.note_content = varNoteContent

        newNote.note_alerm_enable = alerm
        newNote.note_alerm_time = alerm_time
        newNote.note_piority = piority
        newNote.note_color = noteColor
        newNote.note_TabAutoHide = "Y"
        aryALL_NOTES.Add(newNote)
        frmMain.refreshNote_no()
        Return newNote
    End Function
#End Region



#End Region
End Module

Public Class AddBooksForm
    Private Sub CloseButton1_Click(sender As Object, e As EventArgs) Handles CloseButton1.Click
        AddBooksForm.ActiveForm.Close()
    End Sub

    Private Sub AddButton1_Click(sender As Object, e As EventArgs) Handles AddButton1.Click

        If Not IsFormValid() Then
            Return
        End If
        Dim books = LibraryFrom1.books
        Dim addedBook = New Book()
        addedBook.Id = Guid.NewGuid().ToString("N")
        addedBook.Title = TitleTextBox1.Text
        addedBook.Genre = GenreTextBox1.Text
        addedBook.Author = AuthorTextBox1.Text
        addedBook.Isbn = IsbnTextBox1.Text
        addedBook.State = "Dostępna"

        books.Add(addedBook)
        XMLWrite.WriteBooksListToXML()

        LibraryFrom1.GenreListBox1.Items.Clear()
        LibraryFrom1.AuthorListBox1.Items.Clear()
        LibraryFrom1.TitleListBox.Items.Clear()
        LibraryFrom1.IsbnListBox.Items.Clear()

        Dim subset = From book In books
                     Select book.Genre
                     Order By Genre

        For Each genre As String In subset.Distinct
            LibraryFrom1.GenreListBox1.Items.Add(genre)
        Next
    End Sub

    Private Function IsFormValid() As Boolean
        Dim isValid = True
        If IsEmpty(GenreTextBox1, GenreWarningLabel1) Or
           IsEmpty(AuthorTextBox1, AuthorWarningLabel1) Or
           IsEmpty(TitleTextBox1, TitleWarningLabel1) Or
           IsEmpty(IsbnTextBox1, IsbnWarningLabel1) Then
            isValid = False
        End If
        Return isValid
    End Function

    Private Function IsEmpty(textbox As TextBox, warningLabel As Label) As Boolean
        If textbox.Text.Length = 0 Then
            warningLabel.Visible = True
            Return True
        Else
            warningLabel.Visible = False
            Return False
        End If
    End Function

End Class
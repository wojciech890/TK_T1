
Imports System.IO
Public Class LibraryFrom1
    Public Property books As New List(Of Book)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists("booksList.xml") = False Then
            Console.Write("File Not Found, initialising empty book list")
        Else
            books = ReadBookListFromXML()
        End If


        Dim subset = From book In books
                     Select book.Genre
                     Order By Genre

        For Each genre As String In subset.Distinct
            GenreListBox1.Items.Add(genre)
        Next
    End Sub

    Private Sub GenreListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GenreListBox1.SelectedIndexChanged
        Dim genre = GenreListBox1.SelectedItem
        If IsNothing(genre) Then
            Return
        End If
        Dim authors = From book In books
                      Where book.Genre = genre
                      Select book.Author
                      Order By Author

        AuthorListBox1.Items.Clear()
        TitleListBox.Items.Clear()
        IsbnListBox.Items.Clear()

        For Each author As String In authors.Distinct
            AuthorListBox1.Items.Add(author)
        Next
    End Sub

    Private Sub AuthorListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AuthorListBox1.SelectedIndexChanged
        Dim author = AuthorListBox1.SelectedItem
        If IsNothing(author) Then
            Return
        End If
        Dim titles = From book In books
                     Where book.Author = author
                     Select book.Title
                     Order By Title

        TitleListBox.Items.Clear()
        IsbnListBox.Items.Clear()

        For Each title As String In titles.Distinct
            TitleListBox.Items.Add(title)
        Next
    End Sub

    Private Sub TitleListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TitleListBox.SelectedIndexChanged
        Dim title = TitleListBox.SelectedItem
        If IsNothing(title) Then
            Return
        End If
        Dim isbns = From book In books
                    Where book.Title = title
                    Select book.Isbn
                    Order By Isbn

        IsbnListBox.Items.Clear()

        For Each isbn As String In isbns
            IsbnListBox.Items.Add(isbn)
        Next
    End Sub

    Private Sub IsbnListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IsbnListBox.SelectedIndexChanged
        Dim isbn = IsbnListBox.SelectedItem
        If IsNothing(isbn) Then
            Return
        End If

        CoverPictureBox1.Image = My.Resources.ResourceManager.GetObject(isbn)

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim editForm = New AddBooksForm()
        editForm.Show()
    End Sub

    Private Function ReadBookListFromXML()
        Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(List(Of Book)))
        Dim file As New System.IO.StreamReader(
            "booksList.xml")
        Dim booksList As New List(Of Book)
        booksList = CType(reader.Deserialize(file), List(Of Book))
        file.Close()
        Return booksList
    End Function
End Class

Public Class Book
    Public Property Id As String
    Public Property Title As String
    Public Property Genre As String
    Public Property Author As String
    Public Property Isbn As String
    Public Property State As String
End Class

Public Module XMLWrite

    Sub Main()
        WriteBooksListToXML()
    End Sub

    Public Sub WriteBooksListToXML()
        Dim books As New List(Of Book)
        books = LibraryFrom1.books
        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(List(Of Book)))
        Dim file As New System.IO.StreamWriter(
            "booksList.xml")
        writer.Serialize(file, LibraryFrom1.books)
        file.Close()
    End Sub
End Module


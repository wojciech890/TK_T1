<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LibraryFrom1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Genre = New System.Windows.Forms.Label()
        Me.GenreListBox1 = New System.Windows.Forms.ListBox()
        Me.AuthorListBox1 = New System.Windows.Forms.ListBox()
        Me.AuthorLabel1 = New System.Windows.Forms.Label()
        Me.IsbnListBox = New System.Windows.Forms.ListBox()
        Me.IsbnLabel1 = New System.Windows.Forms.Label()
        Me.TitleListBox = New System.Windows.Forms.ListBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.CoverPictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.CoverPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Genre
        '
        Me.Genre.AutoSize = True
        Me.Genre.Location = New System.Drawing.Point(57, 84)
        Me.Genre.Name = "Genre"
        Me.Genre.Size = New System.Drawing.Size(51, 13)
        Me.Genre.TabIndex = 0
        Me.Genre.Text = "Gatunek:"
        '
        'GenreListBox1
        '
        Me.GenreListBox1.FormattingEnabled = True
        Me.GenreListBox1.Location = New System.Drawing.Point(60, 109)
        Me.GenreListBox1.Name = "GenreListBox1"
        Me.GenreListBox1.Size = New System.Drawing.Size(120, 95)
        Me.GenreListBox1.TabIndex = 1
        '
        'AuthorListBox1
        '
        Me.AuthorListBox1.FormattingEnabled = True
        Me.AuthorListBox1.Location = New System.Drawing.Point(230, 109)
        Me.AuthorListBox1.Name = "AuthorListBox1"
        Me.AuthorListBox1.Size = New System.Drawing.Size(120, 95)
        Me.AuthorListBox1.TabIndex = 3
        '
        'AuthorLabel1
        '
        Me.AuthorLabel1.AutoSize = True
        Me.AuthorLabel1.Location = New System.Drawing.Point(227, 84)
        Me.AuthorLabel1.Name = "AuthorLabel1"
        Me.AuthorLabel1.Size = New System.Drawing.Size(35, 13)
        Me.AuthorLabel1.TabIndex = 2
        Me.AuthorLabel1.Text = "Autor:"
        Me.AuthorLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IsbnListBox
        '
        Me.IsbnListBox.FormattingEnabled = True
        Me.IsbnListBox.Location = New System.Drawing.Point(554, 109)
        Me.IsbnListBox.Name = "IsbnListBox"
        Me.IsbnListBox.Size = New System.Drawing.Size(120, 95)
        Me.IsbnListBox.TabIndex = 7
        '
        'IsbnLabel1
        '
        Me.IsbnLabel1.AutoSize = True
        Me.IsbnLabel1.Location = New System.Drawing.Point(551, 84)
        Me.IsbnLabel1.Name = "IsbnLabel1"
        Me.IsbnLabel1.Size = New System.Drawing.Size(83, 13)
        Me.IsbnLabel1.TabIndex = 6
        Me.IsbnLabel1.Text = "Numer wydania:"
        Me.IsbnLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TitleListBox
        '
        Me.TitleListBox.FormattingEnabled = True
        Me.TitleListBox.Location = New System.Drawing.Point(384, 109)
        Me.TitleListBox.Name = "TitleListBox"
        Me.TitleListBox.Size = New System.Drawing.Size(120, 95)
        Me.TitleListBox.TabIndex = 5
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(381, 84)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(30, 13)
        Me.TitleLabel.TabIndex = 4
        Me.TitleLabel.Text = "Title:"
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(698, 109)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 8
        Me.EditButton.Text = "&Edytuj"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'CoverPictureBox1
        '
        Me.CoverPictureBox1.Location = New System.Drawing.Point(60, 277)
        Me.CoverPictureBox1.Name = "CoverPictureBox1"
        Me.CoverPictureBox1.Size = New System.Drawing.Size(182, 255)
        Me.CoverPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CoverPictureBox1.TabIndex = 9
        Me.CoverPictureBox1.TabStop = False
        '
        'LibraryFrom1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 931)
        Me.Controls.Add(Me.CoverPictureBox1)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.IsbnListBox)
        Me.Controls.Add(Me.IsbnLabel1)
        Me.Controls.Add(Me.TitleListBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.AuthorListBox1)
        Me.Controls.Add(Me.AuthorLabel1)
        Me.Controls.Add(Me.GenreListBox1)
        Me.Controls.Add(Me.Genre)
        Me.Name = "LibraryFrom1"
        Me.Text = "Wypożyczalnia"
        CType(Me.CoverPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Genre As Label
    Friend WithEvents GenreListBox1 As ListBox
    Friend WithEvents AuthorListBox1 As ListBox
    Friend WithEvents AuthorLabel1 As Label
    Friend WithEvents IsbnListBox As ListBox
    Friend WithEvents IsbnLabel1 As Label
    Friend WithEvents TitleListBox As ListBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents EditButton As Button
    Friend WithEvents CoverPictureBox1 As PictureBox
End Class

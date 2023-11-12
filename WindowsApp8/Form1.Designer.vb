<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibraryFrom1
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
        Me.Genre = New System.Windows.Forms.Label()
        Me.GenreListBox1 = New System.Windows.Forms.ListBox()
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
        'LibraryFrom1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 931)
        Me.Controls.Add(Me.GenreListBox1)
        Me.Controls.Add(Me.Genre)
        Me.Name = "LibraryFrom1"
        Me.Text = "Wypożyczalnia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Genre As Label
    Friend WithEvents GenreListBox1 As ListBox
End Class

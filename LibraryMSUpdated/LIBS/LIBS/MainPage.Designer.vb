<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoorrowedBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersT = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppliersRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TechnicalSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblAvtar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BooksToolStripMenuItem, Me.UsersT, Me.MembersToolStripMenuItem, Me.LoansToolStripMenuItem, Me.SuppliersToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1352, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BooksToolStripMenuItem
        '
        Me.BooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBookToolStripMenuItem, Me.ViewsToolStripMenuItem, Me.IssueBookToolStripMenuItem, Me.BoorrowedBooksToolStripMenuItem})
        Me.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        Me.BooksToolStripMenuItem.Size = New System.Drawing.Size(68, 25)
        Me.BooksToolStripMenuItem.Text = "Books"
        '
        'AddBookToolStripMenuItem
        '
        Me.AddBookToolStripMenuItem.Name = "AddBookToolStripMenuItem"
        Me.AddBookToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.AddBookToolStripMenuItem.Text = "Add Book"
        '
        'ViewsToolStripMenuItem
        '
        Me.ViewsToolStripMenuItem.Name = "ViewsToolStripMenuItem"
        Me.ViewsToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.ViewsToolStripMenuItem.Text = "Views Books"
        '
        'IssueBookToolStripMenuItem
        '
        Me.IssueBookToolStripMenuItem.Name = "IssueBookToolStripMenuItem"
        Me.IssueBookToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.IssueBookToolStripMenuItem.Text = "Issue Book"
        '
        'BoorrowedBooksToolStripMenuItem
        '
        Me.BoorrowedBooksToolStripMenuItem.Name = "BoorrowedBooksToolStripMenuItem"
        Me.BoorrowedBooksToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.BoorrowedBooksToolStripMenuItem.Text = "Boorrowed Books"
        '
        'UsersT
        '
        Me.UsersT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.ViewUsersToolStripMenuItem})
        Me.UsersT.Name = "UsersT"
        Me.UsersT.Size = New System.Drawing.Size(63, 25)
        Me.UsersT.Text = "Users"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'ViewUsersToolStripMenuItem
        '
        Me.ViewUsersToolStripMenuItem.Name = "ViewUsersToolStripMenuItem"
        Me.ViewUsersToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.ViewUsersToolStripMenuItem.Text = "View Users"
        '
        'MembersToolStripMenuItem
        '
        Me.MembersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStudentToolStripMenuItem, Me.ViewStudentsToolStripMenuItem})
        Me.MembersToolStripMenuItem.Name = "MembersToolStripMenuItem"
        Me.MembersToolStripMenuItem.Size = New System.Drawing.Size(93, 25)
        Me.MembersToolStripMenuItem.Text = "Members"
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.AddStudentToolStripMenuItem.Text = "Add Student"
        '
        'ViewStudentsToolStripMenuItem
        '
        Me.ViewStudentsToolStripMenuItem.Name = "ViewStudentsToolStripMenuItem"
        Me.ViewStudentsToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.ViewStudentsToolStripMenuItem.Text = "View Students"
        '
        'LoansToolStripMenuItem
        '
        Me.LoansToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnBooksToolStripMenuItem})
        Me.LoansToolStripMenuItem.Name = "LoansToolStripMenuItem"
        Me.LoansToolStripMenuItem.Size = New System.Drawing.Size(76, 25)
        Me.LoansToolStripMenuItem.Text = "Arrears"
        '
        'ReturnBooksToolStripMenuItem
        '
        Me.ReturnBooksToolStripMenuItem.Name = "ReturnBooksToolStripMenuItem"
        Me.ReturnBooksToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.ReturnBooksToolStripMenuItem.Text = "Fine Paid"
        '
        'SuppliersToolStripMenuItem
        '
        Me.SuppliersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuppliersRegistrationToolStripMenuItem})
        Me.SuppliersToolStripMenuItem.Name = "SuppliersToolStripMenuItem"
        Me.SuppliersToolStripMenuItem.Size = New System.Drawing.Size(93, 25)
        Me.SuppliersToolStripMenuItem.Text = "Suppliers"
        '
        'SuppliersRegistrationToolStripMenuItem
        '
        Me.SuppliersRegistrationToolStripMenuItem.Name = "SuppliersRegistrationToolStripMenuItem"
        Me.SuppliersRegistrationToolStripMenuItem.Size = New System.Drawing.Size(248, 26)
        Me.SuppliersRegistrationToolStripMenuItem.Text = "Suppliers Registration"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TechnicalSupportToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(117, 25)
        Me.HelpToolStripMenuItem.Text = "Transactions"
        '
        'TechnicalSupportToolStripMenuItem
        '
        Me.TechnicalSupportToolStripMenuItem.Name = "TechnicalSupportToolStripMenuItem"
        Me.TechnicalSupportToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.TechnicalSupportToolStripMenuItem.Text = "View Transaction"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(1131, 3)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(172, 23)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "User"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblAvtar
        '
        Me.lblAvtar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAvtar.Location = New System.Drawing.Point(1132, 32)
        Me.lblAvtar.Name = "lblAvtar"
        Me.lblAvtar.Size = New System.Drawing.Size(172, 27)
        Me.lblAvtar.TabIndex = 2
        Me.lblAvtar.Text = "User"
        Me.lblAvtar.UseVisualStyleBackColor = True
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.LIBS.My.Resources.Resources.back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1352, 741)
        Me.Controls.Add(Me.lblAvtar)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersT As ToolStripMenuItem
    Friend WithEvents MembersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewStudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoansToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TechnicalSupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblAvtar As Button
    Friend WithEvents SuppliersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuppliersRegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IssueBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoorrowedBooksToolStripMenuItem As ToolStripMenuItem
End Class

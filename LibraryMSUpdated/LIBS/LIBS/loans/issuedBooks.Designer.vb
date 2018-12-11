<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class issuedBooks
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
        Me.grdBorrw = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtBookNumber = New System.Windows.Forms.TextBox()
        Me.dtpReturned = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpBorrwed = New System.Windows.Forms.DateTimePicker()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAuth = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txISNB = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBnow = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.cbClass = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbGender = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNam = New System.Windows.Forms.TextBox()
        Me.txtReg = New System.Windows.Forms.TextBox()
        Me.Penalty = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTot = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIsbn = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtRg = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtReceipt = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpaid = New System.Windows.Forms.DateTimePicker()
        Me.dtpRegistered = New System.Windows.Forms.DateTimePicker()
        CType(Me.grdBorrw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Penalty.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdBorrw
        '
        Me.grdBorrw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBorrw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.bISBN, Me.studentId, Me.b_title, Me.Column9, Me.Column10, Me.Column12})
        Me.grdBorrw.Location = New System.Drawing.Point(22, 381)
        Me.grdBorrw.Name = "grdBorrw"
        Me.grdBorrw.Size = New System.Drawing.Size(1046, 234)
        Me.grdBorrw.TabIndex = 0
        '
        'Column2
        '
        Me.Column2.HeaderText = "Book Number"
        Me.Column2.Name = "Column2"
        '
        'bISBN
        '
        Me.bISBN.HeaderText = "Book ISBN"
        Me.bISBN.Name = "bISBN"
        '
        'studentId
        '
        Me.studentId.HeaderText = "studentID"
        Me.studentId.Name = "studentId"
        '
        'b_title
        '
        Me.b_title.HeaderText = "Title"
        Me.b_title.Name = "b_title"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Author"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 156
        '
        'Column10
        '
        Me.Column10.HeaderText = "Publisher"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 214
        '
        'Column12
        '
        Me.Column12.HeaderText = "Date Borrowed"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 234
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 62)
        Me.Panel1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 32)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Borrowed Book List"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1256, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(888, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(362, 26)
        Me.txtSearch.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtBookNumber)
        Me.GroupBox1.Controls.Add(Me.dtpReturned)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpBorrwed)
        Me.GroupBox1.Controls.Add(Me.txtPublisher)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAuth)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.txISNB)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 298)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Information"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(15, 31)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(117, 20)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "Book Number"
        '
        'txtBookNumber
        '
        Me.txtBookNumber.Enabled = False
        Me.txtBookNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookNumber.Location = New System.Drawing.Point(201, 31)
        Me.txtBookNumber.Name = "txtBookNumber"
        Me.txtBookNumber.Size = New System.Drawing.Size(288, 26)
        Me.txtBookNumber.TabIndex = 48
        Me.txtBookNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpReturned
        '
        Me.dtpReturned.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReturned.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReturned.Location = New System.Drawing.Point(201, 226)
        Me.dtpReturned.Name = "dtpReturned"
        Me.dtpReturned.Size = New System.Drawing.Size(288, 26)
        Me.dtpReturned.TabIndex = 47
        Me.dtpReturned.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Publisher"
        '
        'dtpBorrwed
        '
        Me.dtpBorrwed.Enabled = False
        Me.dtpBorrwed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBorrwed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBorrwed.Location = New System.Drawing.Point(201, 193)
        Me.dtpBorrwed.Name = "dtpBorrwed"
        Me.dtpBorrwed.Size = New System.Drawing.Size(288, 26)
        Me.dtpBorrwed.TabIndex = 46
        '
        'txtPublisher
        '
        Me.txtPublisher.Enabled = False
        Me.txtPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublisher.Location = New System.Drawing.Point(201, 162)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(288, 26)
        Me.txtPublisher.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 227)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 20)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Date Returned"
        Me.Label13.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Date Borrowed"
        '
        'txtAuth
        '
        Me.txtAuth.Enabled = False
        Me.txtAuth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuth.Location = New System.Drawing.Point(201, 130)
        Me.txtAuth.Name = "txtAuth"
        Me.txtAuth.Size = New System.Drawing.Size(288, 26)
        Me.txtAuth.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Tittle "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Book ISBN"
        '
        'txtTitle
        '
        Me.txtTitle.Enabled = False
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(201, 97)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(288, 26)
        Me.txtTitle.TabIndex = 25
        '
        'txISNB
        '
        Me.txISNB.Enabled = False
        Me.txISNB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txISNB.Location = New System.Drawing.Point(201, 63)
        Me.txISNB.Name = "txISNB"
        Me.txISNB.Size = New System.Drawing.Size(288, 26)
        Me.txISNB.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBnow)
        Me.GroupBox2.Controls.Add(Me.btnReturn)
        Me.GroupBox2.Controls.Add(Me.cbClass)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cbGender)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtSurname)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtNam)
        Me.GroupBox2.Controls.Add(Me.txtReg)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(588, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 271)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Information"
        '
        'btnBnow
        '
        Me.btnBnow.BackColor = System.Drawing.Color.Green
        Me.btnBnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBnow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBnow.ForeColor = System.Drawing.Color.White
        Me.btnBnow.Location = New System.Drawing.Point(6, 215)
        Me.btnBnow.Name = "btnBnow"
        Me.btnBnow.Size = New System.Drawing.Size(200, 45)
        Me.btnBnow.TabIndex = 37
        Me.btnBnow.Text = "Return Book Now"
        Me.btnBnow.UseVisualStyleBackColor = False
        Me.btnBnow.Visible = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Green
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(230, 215)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(157, 45)
        Me.btnReturn.TabIndex = 36
        Me.btnReturn.Text = "Return Book"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'cbClass
        '
        Me.cbClass.Enabled = False
        Me.cbClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClass.Location = New System.Drawing.Point(149, 177)
        Me.cbClass.Name = "cbClass"
        Me.cbClass.Size = New System.Drawing.Size(238, 26)
        Me.cbClass.TabIndex = 33
        Me.cbClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 20)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Class"
        '
        'cbGender
        '
        Me.cbGender.Enabled = False
        Me.cbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.Location = New System.Drawing.Point(149, 136)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(238, 26)
        Me.cbGender.TabIndex = 31
        Me.cbGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Gender"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 20)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Surname"
        '
        'txtSurname
        '
        Me.txtSurname.Enabled = False
        Me.txtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(149, 95)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(238, 26)
        Me.txtSurname.TabIndex = 28
        Me.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 20)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Student ID"
        '
        'txtNam
        '
        Me.txtNam.Enabled = False
        Me.txtNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNam.Location = New System.Drawing.Point(149, 60)
        Me.txtNam.Name = "txtNam"
        Me.txtNam.Size = New System.Drawing.Size(238, 26)
        Me.txtNam.TabIndex = 25
        Me.txtNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtReg
        '
        Me.txtReg.Enabled = False
        Me.txtReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReg.Location = New System.Drawing.Point(149, 24)
        Me.txtReg.Name = "txtReg"
        Me.txtReg.Size = New System.Drawing.Size(238, 26)
        Me.txtReg.TabIndex = 24
        Me.txtReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Penalty
        '
        Me.Penalty.Controls.Add(Me.Label20)
        Me.Penalty.Controls.Add(Me.txtAmt)
        Me.Penalty.Controls.Add(Me.Label18)
        Me.Penalty.Controls.Add(Me.txtTotal)
        Me.Penalty.Controls.Add(Me.Label17)
        Me.Penalty.Controls.Add(Me.txtTot)
        Me.Penalty.Controls.Add(Me.Label16)
        Me.Penalty.Controls.Add(Me.txtNum)
        Me.Penalty.Controls.Add(Me.Label15)
        Me.Penalty.Controls.Add(Me.txtIsbn)
        Me.Penalty.Controls.Add(Me.Label14)
        Me.Penalty.Controls.Add(Me.txtRg)
        Me.Penalty.Controls.Add(Me.Label12)
        Me.Penalty.Controls.Add(Me.txtReceipt)
        Me.Penalty.Controls.Add(Me.Button2)
        Me.Penalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Penalty.Location = New System.Drawing.Point(1029, 68)
        Me.Penalty.Name = "Penalty"
        Me.Penalty.Size = New System.Drawing.Size(309, 307)
        Me.Penalty.TabIndex = 36
        Me.Penalty.TabStop = False
        Me.Penalty.Text = "Fine Payment"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(9, 191)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(111, 20)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "Amount Paid"
        '
        'txtAmt
        '
        Me.txtAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt.Location = New System.Drawing.Point(147, 188)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(143, 26)
        Me.txtAmt.TabIndex = 49
        Me.txtAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 224)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 20)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "Total Paid"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(147, 221)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(143, 26)
        Me.txtTotal.TabIndex = 47
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(7, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 20)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Amount Per day"
        '
        'txtTot
        '
        Me.txtTot.Enabled = False
        Me.txtTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTot.Location = New System.Drawing.Point(148, 156)
        Me.txtTot.Name = "txtTot"
        Me.txtTot.Size = New System.Drawing.Size(143, 26)
        Me.txtTot.TabIndex = 45
        Me.txtTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 126)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(137, 20)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Number of Days"
        '
        'txtNum
        '
        Me.txtNum.Enabled = False
        Me.txtNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.Location = New System.Drawing.Point(148, 123)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(143, 26)
        Me.txtNum.TabIndex = 43
        Me.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 20)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Book ISBN"
        '
        'txtIsbn
        '
        Me.txtIsbn.Enabled = False
        Me.txtIsbn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIsbn.Location = New System.Drawing.Point(147, 91)
        Me.txtIsbn.Name = "txtIsbn"
        Me.txtIsbn.Size = New System.Drawing.Size(143, 26)
        Me.txtIsbn.TabIndex = 41
        Me.txtIsbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 20)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Student ID"
        '
        'txtRg
        '
        Me.txtRg.Enabled = False
        Me.txtRg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRg.Location = New System.Drawing.Point(147, 58)
        Me.txtRg.Name = "txtRg"
        Me.txtRg.Size = New System.Drawing.Size(143, 26)
        Me.txtRg.TabIndex = 39
        Me.txtRg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 20)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Receipt No"
        '
        'txtReceipt
        '
        Me.txtReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceipt.Location = New System.Drawing.Point(147, 26)
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.Size = New System.Drawing.Size(143, 26)
        Me.txtReceipt.TabIndex = 37
        Me.txtReceipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(29, 264)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 34)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Fine"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(1152, 397)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 20)
        Me.Label19.TabIndex = 49
        Me.Label19.Text = "Change"
        Me.Label19.Visible = False
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(1276, 397)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(44, 20)
        Me.lblChange.TabIndex = 50
        Me.lblChange.Text = "0.00"
        Me.lblChange.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(1260, 397)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(19, 20)
        Me.Label21.TabIndex = 51
        Me.Label21.Text = "$"
        Me.Label21.Visible = False
        '
        'dtpaid
        '
        Me.dtpaid.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpaid.Location = New System.Drawing.Point(1152, 442)
        Me.dtpaid.Name = "dtpaid"
        Me.dtpaid.Size = New System.Drawing.Size(200, 20)
        Me.dtpaid.TabIndex = 52
        Me.dtpaid.Value = New Date(2018, 12, 11, 0, 0, 0, 0)
        Me.dtpaid.Visible = False
        '
        'dtpRegistered
        '
        Me.dtpRegistered.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegistered.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegistered.Location = New System.Drawing.Point(1156, 478)
        Me.dtpRegistered.Name = "dtpRegistered"
        Me.dtpRegistered.Size = New System.Drawing.Size(189, 26)
        Me.dtpRegistered.TabIndex = 53
        Me.dtpRegistered.Value = New Date(2018, 12, 11, 0, 0, 0, 0)
        Me.dtpRegistered.Visible = False
        '
        'issuedBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 638)
        Me.Controls.Add(Me.dtpRegistered)
        Me.Controls.Add(Me.dtpaid)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Penalty)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grdBorrw)
        Me.Name = "issuedBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "issuedBooks"
        CType(Me.grdBorrw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Penalty.ResumeLayout(False)
        Me.Penalty.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdBorrw As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAuth As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txISNB As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbClass As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbGender As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNam As TextBox
    Friend WithEvents txtReg As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents dtpReturned As DateTimePicker
    Friend WithEvents dtpBorrwed As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Penalty As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtTot As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtIsbn As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtRg As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtReceipt As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtAmt As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents dtpaid As DateTimePicker
    Friend WithEvents btnBnow As Button
    Friend WithEvents dtpRegistered As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents txtBookNumber As TextBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents bISBN As DataGridViewTextBoxColumn
    Friend WithEvents studentId As DataGridViewTextBoxColumn
    Friend WithEvents b_title As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
End Class

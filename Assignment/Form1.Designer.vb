<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.grBoxBookManagement = New System.Windows.Forms.GroupBox()
        Me.cbmaloaihang = New System.Windows.Forms.ComboBox()
        Me.cbdonvitinh = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.txttenhang = New System.Windows.Forms.TextBox()
        Me.lblAuthorName = New System.Windows.Forms.Label()
        Me.txtmahang = New System.Windows.Forms.TextBox()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.lstnv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cotmahang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cottenhang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cotdonvi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cotmaloai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grBoxBookManagement.SuspendLayout()
        Me.SuspendLayout()
        '
        'grBoxBookManagement
        '
        Me.grBoxBookManagement.BackColor = System.Drawing.Color.Transparent
        Me.grBoxBookManagement.Controls.Add(Me.cbmaloaihang)
        Me.grBoxBookManagement.Controls.Add(Me.cbdonvitinh)
        Me.grBoxBookManagement.Controls.Add(Me.Label2)
        Me.grBoxBookManagement.Controls.Add(Me.btnSearch)
        Me.grBoxBookManagement.Controls.Add(Me.btnAddNew)
        Me.grBoxBookManagement.Controls.Add(Me.lblPublisher)
        Me.grBoxBookManagement.Controls.Add(Me.txttenhang)
        Me.grBoxBookManagement.Controls.Add(Me.lblAuthorName)
        Me.grBoxBookManagement.Controls.Add(Me.txtmahang)
        Me.grBoxBookManagement.Controls.Add(Me.lblBookName)
        Me.grBoxBookManagement.Location = New System.Drawing.Point(11, 11)
        Me.grBoxBookManagement.Margin = New System.Windows.Forms.Padding(2)
        Me.grBoxBookManagement.Name = "grBoxBookManagement"
        Me.grBoxBookManagement.Padding = New System.Windows.Forms.Padding(2)
        Me.grBoxBookManagement.Size = New System.Drawing.Size(582, 152)
        Me.grBoxBookManagement.TabIndex = 18
        Me.grBoxBookManagement.TabStop = False
        Me.grBoxBookManagement.Text = "Quản lý hàng hóa"
        '
        'cbmaloaihang
        '
        Me.cbmaloaihang.FormattingEnabled = True
        Me.cbmaloaihang.Items.AddRange(New Object() {"MSP01", "MSP02", "MSP03"})
        Me.cbmaloaihang.Location = New System.Drawing.Point(420, 22)
        Me.cbmaloaihang.Margin = New System.Windows.Forms.Padding(2)
        Me.cbmaloaihang.Name = "cbmaloaihang"
        Me.cbmaloaihang.Size = New System.Drawing.Size(146, 21)
        Me.cbmaloaihang.TabIndex = 15
        '
        'cbdonvitinh
        '
        Me.cbdonvitinh.FormattingEnabled = True
        Me.cbdonvitinh.Items.AddRange(New Object() {"Cái", "Kg", "Tấn"})
        Me.cbdonvitinh.Location = New System.Drawing.Point(95, 67)
        Me.cbdonvitinh.Margin = New System.Windows.Forms.Padding(2)
        Me.cbdonvitinh.Name = "cbdonvitinh"
        Me.cbdonvitinh.Size = New System.Drawing.Size(221, 21)
        Me.cbdonvitinh.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(346, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Mã loại hàng "
        '
        'btnSearch
        '
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.Location = New System.Drawing.Point(346, 51)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 32)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNew.Location = New System.Drawing.Point(468, 51)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(98, 32)
        Me.btnAddNew.TabIndex = 12
        Me.btnAddNew.Text = "Thêm mới"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Location = New System.Drawing.Point(4, 69)
        Me.lblPublisher.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(60, 13)
        Me.lblPublisher.TabIndex = 4
        Me.lblPublisher.Text = "Đơn vị tính"
        '
        'txttenhang
        '
        Me.txttenhang.Location = New System.Drawing.Point(95, 44)
        Me.txttenhang.Margin = New System.Windows.Forms.Padding(2)
        Me.txttenhang.Name = "txttenhang"
        Me.txttenhang.Size = New System.Drawing.Size(221, 20)
        Me.txttenhang.TabIndex = 3
        '
        'lblAuthorName
        '
        Me.lblAuthorName.AutoSize = True
        Me.lblAuthorName.Location = New System.Drawing.Point(4, 46)
        Me.lblAuthorName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAuthorName.Name = "lblAuthorName"
        Me.lblAuthorName.Size = New System.Drawing.Size(55, 13)
        Me.lblAuthorName.TabIndex = 2
        Me.lblAuthorName.Text = "Tên Hàng"
        '
        'txtmahang
        '
        Me.txtmahang.Location = New System.Drawing.Point(95, 21)
        Me.txtmahang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmahang.Name = "txtmahang"
        Me.txtmahang.Size = New System.Drawing.Size(221, 20)
        Me.txtmahang.TabIndex = 1
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Location = New System.Drawing.Point(4, 24)
        Me.lblBookName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(51, 13)
        Me.lblBookName.TabIndex = 0
        Me.lblBookName.Text = "Mã Hàng"
        '
        'lstnv
        '
        Me.lstnv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.cotmahang, Me.cottenhang, Me.cotdonvi, Me.cotmaloai})
        Me.lstnv.FullRowSelect = True
        Me.lstnv.GridLines = True
        Me.lstnv.Location = New System.Drawing.Point(11, 182)
        Me.lstnv.Margin = New System.Windows.Forms.Padding(2)
        Me.lstnv.Name = "lstnv"
        Me.lstnv.Size = New System.Drawing.Size(582, 271)
        Me.lstnv.TabIndex = 20
        Me.lstnv.UseCompatibleStateImageBehavior = False
        Me.lstnv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STT"
        Me.ColumnHeader1.Width = 40
        '
        'cotmahang
        '
        Me.cotmahang.Text = "Mã Hàng"
        Me.cotmahang.Width = 100
        '
        'cottenhang
        '
        Me.cottenhang.Text = "Tên Hàng"
        Me.cottenhang.Width = 350
        '
        'cotdonvi
        '
        Me.cotdonvi.Text = "Đơn vị tính"
        Me.cotdonvi.Width = 140
        '
        'cotmaloai
        '
        Me.cotmaloai.Text = "Mã loại hàng"
        Me.cotmaloai.Width = 120
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.Location = New System.Drawing.Point(300, 473)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(99, 37)
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.Text = "Sửa"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.Location = New System.Drawing.Point(431, 473)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 37)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Xóa"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.Location = New System.Drawing.Point(561, 473)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(99, 37)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Đóng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 521)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lstnv)
        Me.Controls.Add(Me.grBoxBookManagement)
        Me.Name = "Form1"
        Me.Text = "Quản lý hàng hóa"
        Me.grBoxBookManagement.ResumeLayout(False)
        Me.grBoxBookManagement.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grBoxBookManagement As System.Windows.Forms.GroupBox
    Friend WithEvents cbmaloaihang As System.Windows.Forms.ComboBox
    Friend WithEvents cbdonvitinh As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents lblPublisher As System.Windows.Forms.Label
    Friend WithEvents txttenhang As System.Windows.Forms.TextBox
    Friend WithEvents lblAuthorName As System.Windows.Forms.Label
    Friend WithEvents txtmahang As System.Windows.Forms.TextBox
    Friend WithEvents lblBookName As System.Windows.Forms.Label
    Public WithEvents lstnv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cotmahang As System.Windows.Forms.ColumnHeader
    Friend WithEvents cottenhang As System.Windows.Forms.ColumnHeader
    Friend WithEvents cotdonvi As System.Windows.Forms.ColumnHeader
    Friend WithEvents cotmaloai As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class

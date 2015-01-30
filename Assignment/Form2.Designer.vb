<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.cbnguoilh = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblPublishYear = New System.Windows.Forms.Label()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.lblAuthorName = New System.Windows.Forms.Label()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.lstkh = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cotmanv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cottennhanvien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cotdc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cotnguoilh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cotphone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cotemail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grBoxBookManagement.SuspendLayout()
        Me.SuspendLayout()
        '
        'grBoxBookManagement
        '
        Me.grBoxBookManagement.BackColor = System.Drawing.Color.Transparent
        Me.grBoxBookManagement.Controls.Add(Me.cbnguoilh)
        Me.grBoxBookManagement.Controls.Add(Me.Label2)
        Me.grBoxBookManagement.Controls.Add(Me.btnSearch)
        Me.grBoxBookManagement.Controls.Add(Me.btnAddNew)
        Me.grBoxBookManagement.Controls.Add(Me.txtsdt)
        Me.grBoxBookManagement.Controls.Add(Me.txtemail)
        Me.grBoxBookManagement.Controls.Add(Me.lblNumber)
        Me.grBoxBookManagement.Controls.Add(Me.lblPublishYear)
        Me.grBoxBookManagement.Controls.Add(Me.txtdiachi)
        Me.grBoxBookManagement.Controls.Add(Me.lblPublisher)
        Me.grBoxBookManagement.Controls.Add(Me.txttenkh)
        Me.grBoxBookManagement.Controls.Add(Me.lblAuthorName)
        Me.grBoxBookManagement.Controls.Add(Me.txtmakh)
        Me.grBoxBookManagement.Controls.Add(Me.lblBookName)
        Me.grBoxBookManagement.Location = New System.Drawing.Point(11, 11)
        Me.grBoxBookManagement.Margin = New System.Windows.Forms.Padding(2)
        Me.grBoxBookManagement.Name = "grBoxBookManagement"
        Me.grBoxBookManagement.Padding = New System.Windows.Forms.Padding(2)
        Me.grBoxBookManagement.Size = New System.Drawing.Size(582, 152)
        Me.grBoxBookManagement.TabIndex = 18
        Me.grBoxBookManagement.TabStop = False
        Me.grBoxBookManagement.Text = "Quản lý khách hàng"
        '
        'cbnguoilh
        '
        Me.cbnguoilh.FormattingEnabled = True
        Me.cbnguoilh.Items.AddRange(New Object() {"NV01", "NV02", "NV03", "NV04", "NV05"})
        Me.cbnguoilh.Location = New System.Drawing.Point(425, 21)
        Me.cbnguoilh.Margin = New System.Windows.Forms.Padding(2)
        Me.cbnguoilh.Name = "cbnguoilh"
        Me.cbnguoilh.Size = New System.Drawing.Size(142, 21)
        Me.cbnguoilh.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(346, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "NV liên hệ"
        '
        'btnSearch
        '
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.Location = New System.Drawing.Point(328, 115)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(118, 32)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Enabled = False
        Me.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNew.Location = New System.Drawing.Point(451, 115)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(118, 32)
        Me.btnAddNew.TabIndex = 12
        Me.btnAddNew.Text = "Thêm mới"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(426, 44)
        Me.txtsdt.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(142, 20)
        Me.txtsdt.TabIndex = 9
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(425, 67)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(142, 20)
        Me.txtemail.TabIndex = 9
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(346, 70)
        Me.lblNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(32, 13)
        Me.lblNumber.TabIndex = 8
        Me.lblNumber.Text = "Email"
        '
        'lblPublishYear
        '
        Me.lblPublishYear.AutoSize = True
        Me.lblPublishYear.Location = New System.Drawing.Point(346, 48)
        Me.lblPublishYear.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublishYear.Name = "lblPublishYear"
        Me.lblPublishYear.Size = New System.Drawing.Size(70, 13)
        Me.lblPublishYear.TabIndex = 6
        Me.lblPublishYear.Text = "Số điện thoại"
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(95, 67)
        Me.txtdiachi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(221, 20)
        Me.txtdiachi.TabIndex = 5
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Location = New System.Drawing.Point(4, 69)
        Me.lblPublisher.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(40, 13)
        Me.lblPublisher.TabIndex = 4
        Me.lblPublisher.Text = "Địa chỉ"
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(95, 44)
        Me.txttenkh.Margin = New System.Windows.Forms.Padding(2)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(221, 20)
        Me.txttenkh.TabIndex = 3
        '
        'lblAuthorName
        '
        Me.lblAuthorName.AutoSize = True
        Me.lblAuthorName.Location = New System.Drawing.Point(4, 46)
        Me.lblAuthorName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAuthorName.Name = "lblAuthorName"
        Me.lblAuthorName.Size = New System.Drawing.Size(86, 13)
        Me.lblAuthorName.TabIndex = 2
        Me.lblAuthorName.Text = "Tên khách hàng"
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(95, 21)
        Me.txtmakh.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(221, 20)
        Me.txtmakh.TabIndex = 1
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Location = New System.Drawing.Point(4, 24)
        Me.lblBookName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(40, 13)
        Me.lblBookName.TabIndex = 0
        Me.lblBookName.Text = "Mã KH"
        '
        'lstkh
        '
        Me.lstkh.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.cotmanv, Me.cottennhanvien, Me.cotdc, Me.cotnguoilh, Me.cotphone, Me.cotemail})
        Me.lstkh.FullRowSelect = True
        Me.lstkh.GridLines = True
        Me.lstkh.Location = New System.Drawing.Point(11, 182)
        Me.lstkh.Margin = New System.Windows.Forms.Padding(2)
        Me.lstkh.Name = "lstkh"
        Me.lstkh.Size = New System.Drawing.Size(583, 258)
        Me.lstkh.TabIndex = 20
        Me.lstkh.UseCompatibleStateImageBehavior = False
        Me.lstkh.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STT"
        Me.ColumnHeader1.Width = 40
        '
        'cotmanv
        '
        Me.cotmanv.Text = "Mã KH"
        Me.cotmanv.Width = 70
        '
        'cottennhanvien
        '
        Me.cottennhanvien.Text = "Tên khách hàng"
        Me.cottennhanvien.Width = 175
        '
        'cotdc
        '
        Me.cotdc.Text = "Địa Chỉ"
        Me.cotdc.Width = 140
        '
        'cotnguoilh
        '
        Me.cotnguoilh.Text = "NV liên hệ"
        Me.cotnguoilh.Width = 120
        '
        'cotphone
        '
        Me.cotphone.Text = "Số điện thoại"
        Me.cotphone.Width = 100
        '
        'cotemail
        '
        Me.cotemail.Text = "Email"
        Me.cotemail.Width = 120
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.Location = New System.Drawing.Point(339, 453)
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
        Me.btnDelete.Location = New System.Drawing.Point(462, 453)
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
        Me.btnClose.Location = New System.Drawing.Point(583, 453)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(99, 37)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Đóng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 501)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lstkh)
        Me.Controls.Add(Me.grBoxBookManagement)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.grBoxBookManagement.ResumeLayout(False)
        Me.grBoxBookManagement.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grBoxBookManagement As System.Windows.Forms.GroupBox
    Friend WithEvents cbnguoilh As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents lblPublishYear As System.Windows.Forms.Label
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents lblPublisher As System.Windows.Forms.Label
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents lblAuthorName As System.Windows.Forms.Label
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents lblBookName As System.Windows.Forms.Label
    Public WithEvents lstkh As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cotmanv As System.Windows.Forms.ColumnHeader
    Friend WithEvents cottennhanvien As System.Windows.Forms.ColumnHeader
    Friend WithEvents cotdc As System.Windows.Forms.ColumnHeader
    Friend WithEvents cotnguoilh As System.Windows.Forms.ColumnHeader
    Friend WithEvents cotphone As System.Windows.Forms.ColumnHeader
    Friend WithEvents cotemail As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class

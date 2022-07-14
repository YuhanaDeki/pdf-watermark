<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb_fileName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_angle = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_title_x = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_title_y = New System.Windows.Forms.TextBox()
        Me.cb_opacity = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_fontSize = New System.Windows.Forms.ComboBox()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_itemNumber = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_from = New System.Windows.Forms.TextBox()
        Me.txt_item_y = New System.Windows.Forms.TextBox()
        Me.txt_item_x = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_bookNumber = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Prompt", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(355, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "สร้างลายน้ำ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ยังไม่ได้เลือก"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Prompt", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(6, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "เลือก"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb_fileName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Prompt", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 102)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เลือกไฟล์"
        '
        'lb_fileName
        '
        Me.lb_fileName.AutoSize = True
        Me.lb_fileName.ForeColor = System.Drawing.Color.Black
        Me.lb_fileName.Location = New System.Drawing.Point(65, 71)
        Me.lb_fileName.Name = "lb_fileName"
        Me.lb_fileName.Size = New System.Drawing.Size(68, 17)
        Me.lb_fileName.TabIndex = 4
        Me.lb_fileName.Text = "ยังไม่ได้เลือก"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ชื่อไฟล์ : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_angle)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt_title_x)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_title_y)
        Me.GroupBox2.Controls.Add(Me.cb_opacity)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cb_fontSize)
        Me.GroupBox2.Controls.Add(Me.txt_title)
        Me.GroupBox2.Font = New System.Drawing.Font("Prompt", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 196)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ข้อความ"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(138, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "แกน Y :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_angle
        '
        Me.txt_angle.BackColor = System.Drawing.Color.White
        Me.txt_angle.Location = New System.Drawing.Point(97, 65)
        Me.txt_angle.Multiline = True
        Me.txt_angle.Name = "txt_angle"
        Me.txt_angle.Size = New System.Drawing.Size(42, 25)
        Me.txt_angle.TabIndex = 16
        Me.txt_angle.Text = "-45"
        Me.txt_angle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(6, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 25)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "มุม :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.ForeColor = System.Drawing.Color.Crimson
        Me.Label13.Location = New System.Drawing.Point(233, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 25)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "- ยิ่งติดลบจะเลื่อนขึ้น"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.ForeColor = System.Drawing.Color.Crimson
        Me.Label12.Location = New System.Drawing.Point(233, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 25)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "- ยิ่งติดลบจะออกซ้าย "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_title_x
        '
        Me.txt_title_x.BackColor = System.Drawing.Color.White
        Me.txt_title_x.Location = New System.Drawing.Point(188, 17)
        Me.txt_title_x.Multiline = True
        Me.txt_title_x.Name = "txt_title_x"
        Me.txt_title_x.Size = New System.Drawing.Size(46, 25)
        Me.txt_title_x.TabIndex = 11
        Me.txt_title_x.Text = "-150"
        Me.txt_title_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(138, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "แกน X :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_title_y
        '
        Me.txt_title_y.BackColor = System.Drawing.Color.White
        Me.txt_title_y.Location = New System.Drawing.Point(188, 41)
        Me.txt_title_y.Multiline = True
        Me.txt_title_y.Name = "txt_title_y"
        Me.txt_title_y.Size = New System.Drawing.Size(46, 25)
        Me.txt_title_y.TabIndex = 12
        Me.txt_title_y.Text = "500"
        Me.txt_title_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cb_opacity
        '
        Me.cb_opacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_opacity.FormattingEnabled = True
        Me.cb_opacity.Items.AddRange(New Object() {"0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1"})
        Me.cb_opacity.Location = New System.Drawing.Point(97, 41)
        Me.cb_opacity.Name = "cb_opacity"
        Me.cb_opacity.Size = New System.Drawing.Size(42, 25)
        Me.cb_opacity.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(6, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ความเข้ม : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(6, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ขนาดตัวอักษร : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cb_fontSize
        '
        Me.cb_fontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_fontSize.FormattingEnabled = True
        Me.cb_fontSize.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99"})
        Me.cb_fontSize.Location = New System.Drawing.Point(97, 17)
        Me.cb_fontSize.Name = "cb_fontSize"
        Me.cb_fontSize.Size = New System.Drawing.Size(42, 25)
        Me.cb_fontSize.TabIndex = 1
        '
        'txt_title
        '
        Me.txt_title.BackColor = System.Drawing.Color.White
        Me.txt_title.Location = New System.Drawing.Point(6, 102)
        Me.txt_title.Multiline = True
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(343, 86)
        Me.txt_title.TabIndex = 0
        Me.txt_title.Text = "เนื้อหา"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cb_itemNumber)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txt_from)
        Me.GroupBox3.Font = New System.Drawing.Font("Prompt", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 322)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(355, 59)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ข้อความจำนวนเล่ม (เช่น 1 ของ 3 เล่ม)"
        '
        'cb_itemNumber
        '
        Me.cb_itemNumber.BackColor = System.Drawing.Color.Crimson
        Me.cb_itemNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cb_itemNumber.Font = New System.Drawing.Font("Prompt", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_itemNumber.ForeColor = System.Drawing.Color.Yellow
        Me.cb_itemNumber.Location = New System.Drawing.Point(82, 23)
        Me.cb_itemNumber.Multiline = True
        Me.cb_itemNumber.Name = "cb_itemNumber"
        Me.cb_itemNumber.Size = New System.Drawing.Size(37, 25)
        Me.cb_itemNumber.TabIndex = 11
        Me.cb_itemNumber.Text = "1"
        Me.cb_itemNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(118, 23)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(61, 25)
        Me.TextBox5.TabIndex = 10
        Me.TextBox5.Text = "เล่ม"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(6, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "xx"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_from
        '
        Me.txt_from.BackColor = System.Drawing.Color.White
        Me.txt_from.Location = New System.Drawing.Point(37, 23)
        Me.txt_from.Multiline = True
        Me.txt_from.Name = "txt_from"
        Me.txt_from.Size = New System.Drawing.Size(46, 25)
        Me.txt_from.TabIndex = 8
        Me.txt_from.Text = "ของ"
        Me.txt_from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_item_y
        '
        Me.txt_item_y.BackColor = System.Drawing.Color.White
        Me.txt_item_y.Enabled = False
        Me.txt_item_y.Location = New System.Drawing.Point(691, 322)
        Me.txt_item_y.Multiline = True
        Me.txt_item_y.Name = "txt_item_y"
        Me.txt_item_y.Size = New System.Drawing.Size(94, 25)
        Me.txt_item_y.TabIndex = 16
        Me.txt_item_y.Text = "550"
        Me.txt_item_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_item_y.Visible = False
        '
        'txt_item_x
        '
        Me.txt_item_x.BackColor = System.Drawing.Color.White
        Me.txt_item_x.Enabled = False
        Me.txt_item_x.Location = New System.Drawing.Point(547, 322)
        Me.txt_item_x.Multiline = True
        Me.txt_item_x.Name = "txt_item_x"
        Me.txt_item_x.Size = New System.Drawing.Size(85, 25)
        Me.txt_item_x.TabIndex = 15
        Me.txt_item_x.Text = "-50"
        Me.txt_item_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_item_x.Visible = False
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Enabled = False
        Me.Label9.Location = New System.Drawing.Point(487, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 25)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "แกน X :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Visible = False
        '
        'txt_bookNumber
        '
        Me.txt_bookNumber.BackColor = System.Drawing.Color.White
        Me.txt_bookNumber.Enabled = False
        Me.txt_bookNumber.Location = New System.Drawing.Point(564, 273)
        Me.txt_bookNumber.Multiline = True
        Me.txt_bookNumber.Name = "txt_bookNumber"
        Me.txt_bookNumber.Size = New System.Drawing.Size(171, 25)
        Me.txt_bookNumber.TabIndex = 7
        Me.txt_bookNumber.Visible = False
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Enabled = False
        Me.Label11.Location = New System.Drawing.Point(631, 322)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 25)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "แกน Y :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 431)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txt_item_y)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_item_x)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_bookNumber)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เพิ่มลายน้ำ PDF"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub



    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_title As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_fontSize As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_bookNumber As TextBox
    Friend WithEvents txt_from As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lb_fileName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_opacity As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_title_y As TextBox
    Friend WithEvents txt_title_x As TextBox
    Friend WithEvents txt_item_y As TextBox
    Friend WithEvents txt_item_x As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cb_itemNumber As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_angle As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
End Class

